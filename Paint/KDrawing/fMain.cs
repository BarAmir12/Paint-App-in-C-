using KDrawing.Enums;
using KDrawing.KControls;
using KDrawing.Models;
using KDrawing.Models.Enums;
using KDrawing.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace KDrawing
{
    public partial class fMain : Form
    {
        #region Fields
        public static int untitledIndex = 0;

        ShapeType shapeType = ShapeType.NoDrawing;
        DrawingMode drawingMode = DrawingMode.NoFill;
        DrawingStage drawingStage = DrawingStage.Orther;
        private string filePath;

        private List<Button> listButton;
        private List<MyShape> listShapes = new List<MyShape>();
        private PointF previousPoint;

        private Brush brush = new SolidBrush(Color.FromArgb(0, 30, 81));
        private Brush brushShadow = new SolidBrush(Color.White);
        private Pen framePen = new Pen(Color.FromArgb(0, 30, 81), 1.5f)
        {
            DashPattern = new float[] { 3, 3, 3, 3 },
            DashStyle = DashStyle.Custom
        };

        private Pen framePenShadow = new Pen(Color.White, 2f)
        {
            DashPattern = new float[] { 3.25f, 3.25f, 3.25f, 3.25f },
            DashStyle = DashStyle.Custom
        };

        private MyShape selectedShape;
        private PointF selectedPoint1;
        private PointF selectedPoint2;
        private RectangleF selectedRegion;

        private bool isMouseDown;
        private bool isControlKeyPress;
        private bool isShiftKeyPress;
        private int movingOffset;
        #endregion

        #region Properties
        public List<MyShape> ListShapes { get => listShapes; set => listShapes = value; }
        public RectangleF SelectedRegion
        {
            get
            {
                if (selectedPoint1 == new PointF() || selectedPoint2 == new PointF()) { return new RectangleF(); }

                float width = selectedPoint2.X - selectedPoint1.X;
                float height = selectedPoint2.Y - selectedPoint1.Y;

                if (width > 0 && height > 0)
                {
                    selectedRegion = new RectangleF(selectedPoint1, new SizeF(width, height));
                }
                else if (width < 0 && height > 0)
                {
                    selectedRegion = new RectangleF(selectedPoint2.X, selectedPoint1.Y, -width, height);
                }
                else if (width > 0 && height < 0)
                {
                    selectedRegion = new RectangleF(selectedPoint1.X, selectedPoint2.Y, width, -height);
                }
                else
                {
                    selectedRegion = new RectangleF(selectedPoint2, new SizeF(-width, -height));
                }

                return selectedRegion;
            }
            set => selectedRegion = value;
        }
        public ShapeType ShapeType
        {
            get => shapeType;
            set
            {
                shapeType = value;

            }
        }
        public DrawingMode DrawingMode
        {
            get => drawingMode;
            set
            {
                drawingMode = value;
            }
        }
        #endregion

        public fMain()
        {
            InitializeComponent();
        }

        #region Events
        #region fMain event
        private void fMain_Load(object sender, EventArgs e)
        {
            mnu.Renderer = new MenuStripRenderer(Color.FromArgb(28, 151, 234));

            DrawingMode = DrawingMode.NoFill;
            ShapeType = ShapeType.NoDrawing;
            listButton = new List<Button> { btnCurve, btnEllipse, btnRectangle, btnSelect, btnPencil };
            cboDashStyle.SelectedIndex = 0;

            if (System.IO.File.Exists(this.filePath))
            {
                titleBar.TitleText = System.IO.Path.GetFileName(filePath) + " - KDrawing";

                var shapeData = ShapeData.Deserialize(filePath);
                psfMain.BackColor = shapeData.BackColor;
                shapeData.ListShapes.ForEach(shape =>
                {
                    ListShapes.Add(shape);
                    shapeLayers.Add(shape);
                });
                ReDraw();
            }
            else { titleBar.TitleText = "Untitled " + (++untitledIndex).ToString() + " - KDrawing"; }
        }

        private void fMain_KeyDown(object sender, KeyEventArgs e)
        {
            psfMain.Focus();
            isControlKeyPress = e.Control;
            isShiftKeyPress = e.Shift;

            if (e.Control) { movingOffset = 1; }
            else { movingOffset = 5; }

            switch (e.KeyCode)
            {
               
                case Keys.Oemplus:          
                    ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Scale(1.1f); });
                    ReDraw();
                    break;
                case Keys.OemMinus:         
                    ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Scale(0.9f); });
                    ReDraw();
                    break;
            }
        }

        private void fMain_KeyUp(object sender, KeyEventArgs e)
        {
            isControlKeyPress = e.Control;
            isShiftKeyPress = e.Shift;
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ListShapes.Count > 0)
            {
                string mess = "Save changes to drawing project \"" + titleBar.TitleText.TrimEnd(" - KDrawing".ToCharArray()) + "\" before quitting ?"; ;
                DialogResult dialogResult = MessageBox.Show(mess, "KDrawing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    mnuFile_Save.PerformClick();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        private void btnEnableFill_Click(object sender, EventArgs e)
        {
            if (btnEnableFill.ToggleStage)
            {
                DrawingMode = DrawingMode.Fill;
                btnFillColor.Enabled = true;
                ListShapes.FindAll(shape => (shape is IFillableShape && shape.IsSelected)).ForEach(shape => (shape as IFillableShape).IsFill = true);

                if (btnEllipse.Tag.ToString() == "Ellipse") { btnEllipse.BackgroundImage = Properties.Resources.shape_ellipse_white; }
                else { btnEllipse.BackgroundImage = Properties.Resources.shape_circle_white; }
                if (btnRectangle.Tag.ToString() == "Rectangle") { btnRectangle.BackgroundImage = Properties.Resources.shape_rectangle_white; }
                else { btnRectangle.BackgroundImage = Properties.Resources.shape_square_white; }
            }
            else
            {
                DrawingMode = DrawingMode.NoFill;
                btnFillColor.Enabled = false;
                ListShapes.FindAll(shape => (shape is IFillableShape && shape.IsSelected)).ForEach(shape => (shape as IFillableShape).IsFill = false);


                if (btnEllipse.Tag.ToString() == "Ellipse") { btnEllipse.BackgroundImage = Properties.Resources.shape_ellipse_outline_white; }
                else { btnEllipse.BackgroundImage = Properties.Resources.shape_circle_outline_white; }
                if (btnRectangle.Tag.ToString() == "Rectangle") { btnRectangle.BackgroundImage = Properties.Resources.shape_rectangle_outline_white; }
                else { btnRectangle.BackgroundImage = Properties.Resources.shape_square_outline_white; }
            }
            ReDraw();
        }

        private void nudLineWeight_ValueChanged(object sender, EventArgs e)
        {

            this.ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape =>
            {

                { shape.LineWeight = (float)nudLineWeight.Value; }
            });

            ReDraw();
        }

        private void cboDashStyle_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            e.DrawBackground();
            if (e.Index != -1)
            {
                e.Graphics.DrawImage(imgCboDashStyle.Images[e.Index], e.Bounds.Left, e.Bounds.Top);
            }
            e.DrawFocusRectangle();
        }

        private void cboDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape =>
            {
                shape.DashStyle = (DashStyle)cboDashStyle.SelectedIndex;
            });

            this.ReDraw();
        }

        #region select Color button event
       

        private void btnFillColor_BackColorChanged(object sender, EventArgs e)
        {
            var btn = sender as Button;
            ListShapes.FindAll(shape => shape.IsSelected && shape is IFillableShape).ForEach(shape =>
            {
                (shape as IFillableShape).FillColor = btn.BackColor;
            });
            ReDraw();
        }

        private void btnForeColor_BackColorChanged(object sender, EventArgs e)
        {
            var btn = sender as Button;
            ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Color = btn.BackColor; });
            ReDraw();
        }

        private void btnBackColor_BackColorChanged(object sender, EventArgs e)
        {
            var btn = sender as Button;
            psfMain.BackColor = btn.BackColor;
        }
        #endregion

        #region psfMain's event
        private void psfMain_DoubleClick(object sender, EventArgs e)
        {

            if (drawingStage == DrawingStage.IsDrawCurve)
            {
                drawingStage = DrawingStage.Orther;
                MyCurve curve = ListShapes[ListShapes.Count - 1] as MyCurve;
                if (curve.Points.Count <= 3) { ListShapes.Remove(curve); }
                curve.Points.RemoveAt(curve.Points.Count - 1);
                curve.Points.RemoveAt(curve.Points.Count - 1);

                psfMain.Invalidate();
                curve.FindRegion();
            }
        }

        private void psfMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                return;
                
            }

            if (ShapeType != ShapeType.NoDrawing)
            {
                isMouseDown = true;
                ListShapes.ForEach(shape => shape.IsSelected = false);
            }

            switch (this.ShapeType)
            {
                case ShapeType.NoDrawing:
                    if (isControlKeyPress)
                    {
                        for (int i = 0; i < ListShapes.Count; i++)
                        {
                            if (ListShapes[i].IsHit(e.Location))
                            {
                                ListShapes[i].IsSelected = !ListShapes[i].IsSelected;
                                ReDraw();
                                break;
                            }
                        }
                    }
                    else
                    {
                        var isHitSelectedShape = false;
                        var listShapeSelected = ListShapes.FindAll(shape => shape.IsSelected);

                        for (int i = 0; i < listShapeSelected.Count; i++)
                        {
                            if (listShapeSelected[i].IsHit(e.Location))
                            {
                                isHitSelectedShape = true;
                                break;
                            }
                        }

                        if (!isHitSelectedShape)
                        {
                            UnselectAllShapes();
                        }

                        for (int i = 0; i < ListShapes.Count; i++)
                        {
                            if (ListShapes[i].IsHit(e.Location))
                            {
                                selectedShape = ListShapes[i];
                                ListShapes[i].IsSelected = true;



                                ReDraw();
                                break;
                            }
                        }

                        if (selectedShape != null)
                        {
                            drawingStage = DrawingStage.IsMovingShape;
                            previousPoint = e.Location;
                        }
                        else
                        {
                            drawingStage = DrawingStage.IsMouseSelect;
                            selectedPoint1 = e.Location;
                            selectedPoint2 = new PointF();
                        }
                    }
                    break;



                case ShapeType.Freehand:
                    if (drawingStage != DrawingStage.IsFreehand)
                    {
                        MyFreehand freehand = new MyFreehand((float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                        freehand.Begin = e.Location;
                        freehand.Points.Add(e.Location);

                        ListShapes.Add(freehand);
                        drawingStage = DrawingStage.IsFreehand;
                    }
                    else
                    {
                        MyFreehand freehand = ListShapes[ListShapes.Count - 1] as MyFreehand;
                        freehand.Points[freehand.Points.Count - 1] = e.Location;
                        freehand.Points.Add(e.Location);
                    }
                    break;



                case ShapeType.Rectangle:
                    MyRectangle rectangle = new MyRectangle(e.Location, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                    if (DrawingMode == DrawingMode.Fill)
                    {
                        rectangle.IsFill = true;
                        rectangle.FillColor = btnFillColor.BackColor;
                    }
                    ListShapes.Add(rectangle);
                    break;

                case ShapeType.Square:
                    MySquare square = new MySquare(e.Location, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                    if (DrawingMode == DrawingMode.Fill)
                    {
                        square.IsFill = true;
                        square.FillColor = btnFillColor.BackColor;
                    }
                    ListShapes.Add(square);
                    break;

                case ShapeType.Ellipse:
                    MyEllipse ellipse = new MyEllipse(e.Location, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                    if (DrawingMode == DrawingMode.Fill)
                    {
                        ellipse.IsFill = true;
                        ellipse.FillColor = btnFillColor.BackColor;
                    }
                    ListShapes.Add(ellipse);
                    break;

                case ShapeType.Circle:
                    MyCircle circle = new MyCircle(e.Location, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                    if (DrawingMode == DrawingMode.Fill)
                    {
                        circle.IsFill = true;
                        circle.FillColor = btnFillColor.BackColor;
                    }
                    ListShapes.Add(circle);
                    break;

                case ShapeType.Curve:
                    if (drawingStage != DrawingStage.IsDrawCurve)
                    {
                        MyCurve curve = new MyCurve(false, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                        curve.Points.Add(e.Location);
                        curve.Points.Add(e.Location);

                        ListShapes.Add(curve);
                        drawingStage = DrawingStage.IsDrawCurve;
                    }
                    else
                    {
                        MyCurve curve = ListShapes[ListShapes.Count - 1] as MyCurve;
                        curve.Points[curve.Points.Count - 1] = e.Location;

                        curve.Points.Add(e.Location);
                    }
                    isMouseDown = false;
                    break;


                default:
                    break;

            }
        }

        private void psfMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingStage == DrawingStage.IsFreehand)
            {
                MyFreehand freehand = ListShapes[ListShapes.Count - 1] as MyFreehand;
                freehand.Points.Add(e.Location);
                ReDraw();
            }

            if (isMouseDown)
            {
                MyShape lastShape = ListShapes[ListShapes.Count - 1];
                if (isShiftKeyPress)
                {
                    if (lastShape is MyRectangle) { (lastShape as MyRectangle).IsSquare = true; }
                    else if (lastShape is MyEllipse) { (lastShape as MyEllipse).IsCircle = true; }
                }
                else
                {
                    if (lastShape is MyRectangle) { (lastShape as MyRectangle).IsSquare = false; }
                    else if (lastShape is MyEllipse) { (lastShape as MyEllipse).IsCircle = false; }
                }
                lastShape.End = e.Location;
                ReDraw();
            }
            else if (drawingStage == DrawingStage.IsMovingShape)
            {
                PointF d = new PointF(e.X - previousPoint.X, e.Y - previousPoint.Y);
                ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Move(d); });
                previousPoint = e.Location;
                ReDraw();
            }
            else if (ShapeType == ShapeType.NoDrawing)
            {
                if (drawingStage == DrawingStage.IsMouseSelect)
                {
                    selectedPoint2 = e.Location;
                    ReDraw();
                }
                else
                {
                    if (ListShapes.Exists(shape => shape.IsHit(e.Location)))
                    {
                        psfMain.Cursor = MyCursor.Instance.SizeAll;
                    }
                    else
                    {
                        psfMain.Cursor = Cursors.Default;
                    }
                }
            }


            else if (drawingStage == DrawingStage.IsDrawCurve)
            {
                MyCurve curve = ListShapes[ListShapes.Count - 1] as MyCurve;
                curve.Points[curve.Points.Count - 1] = e.Location;

                ReDraw();
            }

        }

        private void psfMain_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (drawingStage == DrawingStage.IsFreehand)
            {
                drawingStage = DrawingStage.Orther;
                MyFreehand freehand = ListShapes[ListShapes.Count - 1] as MyFreehand;
                freehand.End = freehand.Points[freehand.Points.Count - 1];
                psfMain.Invalidate();
            }
            else if (drawingStage == DrawingStage.IsMovingShape)
            {
                drawingStage = DrawingStage.Orther;
                selectedShape = null;
            }
            else if (drawingStage == DrawingStage.IsMouseSelect)
            {
                drawingStage = DrawingStage.Orther;
                for (int i = 0; i < ListShapes.Count; i++)
                {
                    ListShapes[i].IsSelected = false;

                    if (ListShapes[i].Begin.X >= SelectedRegion.X &&
                        ListShapes[i].End.X <= SelectedRegion.X + SelectedRegion.Width &&
                        ListShapes[i].Begin.Y >= SelectedRegion.Y &&
                        ListShapes[i].End.Y <= SelectedRegion.Y + SelectedRegion.Height)
                    {
                        ListShapes[i].IsSelected = true;
                    }
                }
                ReDraw();
            }

            try
            {
                MyShape shape = ListShapes[ListShapes.Count - 1];

                if (shape.Begin.X > shape.End.X || (shape.Begin.X == shape.End.X && shape.Begin.Y > shape.End.Y))
                {
                    PointF temp = shape.Begin;
                    shape.Begin = shape.End;
                    shape.End = temp;
                }

                if (shape is MyCircle circle)
                {
                    circle.End = new PointF(circle.Begin.X + circle.Diameter, circle.Begin.Y + circle.Diameter);
                }
                else if (shape is MySquare square)
                {
                    if (square.Begin.X < square.End.X && square.Begin.Y > square.End.Y)
                    {
                        square.Begin = new PointF(square.Begin.X, square.End.Y);
                        square.End = new PointF(square.Begin.X + square.Width, square.Begin.Y + square.Width);
                    }
                    else
                    {
                        square.End = new PointF(square.Begin.X + square.Width, square.Begin.Y + square.Width);
                    }
                }
                else if (shape is MyRectangle rect)
                {
                    if (rect.Begin.X < rect.End.X && rect.Begin.Y > rect.End.Y)
                    {
                        PointF begin = rect.Begin, end = rect.End;

                        rect.Begin = new PointF(begin.X, end.Y);
                        rect.End = new PointF(end.X, begin.Y);
                    }
                }

                if (ShapeType != ShapeType.NoDrawing)
                {
                    if (shape is MyCurve)
                    {
                        if ((ShapeType == ShapeType.Curve && drawingStage != DrawingStage.IsDrawCurve))
                        {
                            shapeLayers.Add(shape);
                        }
                    }
                    else
                    {
                        if (shape is MyFreehand freehand) { freehand.FindRegion(); }
                        shapeLayers.Add(shape);
                    }
                }
            }
            catch { }
        }

        private void psfMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            ListShapes.ForEach(shape =>
            {
                if (shape.IsSelected)
                {
                    shape.Draw(e.Graphics);



                    if (shape is MyEllipse || shape is MyRectangle || shape is MyFreehand)
                    {
                        GraphicsExtensions.DrawSelectPoints(e.Graphics, brush, brushShadow, shape.Begin, shape.End);
                        if (shape is MyEllipse elip)
                        {
                            GraphicsExtensions.DrawSelectPoints(e.Graphics, brush, brushShadow, elip.TopRight, elip.BottomLeft);
                        }
                        else if (shape is MyRectangle rec)
                        {
                            GraphicsExtensions.DrawSelectPoints(e.Graphics, brush, brushShadow, rec.TopRight, rec.BottomLeft);
                        }
                    }
                    else if (shape is MyCurve curve)
                    {
                        GraphicsExtensions.DrawSelectPoints(e.Graphics, brush, brushShadow, curve.Points);
                    }

                }
                else if (!shape.IsHidden)
                {
                    shape.Draw(e.Graphics);
                }
            });

            if (drawingStage == DrawingStage.IsMouseSelect)
            {
                GraphicsExtensions.DrawSelectFrame(e.Graphics, framePen, framePenShadow, SelectedRegion);
            }
        }
        #endregion

        private void btnShape_Click(object sender, EventArgs e)
        {
            UnselectAllShapes();
            Button btn = sender as Button;

            if (btn.BackColor == Color.FromArgb(0, 30, 81))
            {
                UncheckAll();
                this.ShapeType = ShapeType.NoDrawing;
                this.btnSelect.BackColor = Color.FromArgb(0, 30, 81);
                this.psfMain.Cursor = Cursors.Default;
            }
            else
            {
                UncheckAll();
                btn.BackColor = Color.FromArgb(0, 30, 81);
                btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                this.psfMain.Cursor = MyCursor.Instance.Cross;

                switch (btn.Tag)
                {
                    case "Freehand":
                        this.ShapeType = ShapeType.Freehand;
                        break;
                    case "Curve":
                        this.ShapeType = ShapeType.Curve;
                        break;
                    case "Ellipse":
                        this.ShapeType = ShapeType.Ellipse;
                        break;
                    case "Circle":
                        this.ShapeType = ShapeType.Circle;
                        break;
                    case "Rectangle":
                        this.ShapeType = ShapeType.Rectangle;
                        break;
                    case "Square":
                        this.ShapeType = ShapeType.Square;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnEllipse_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = sender as Button;
                if (btn.Tag.ToString() == "Ellipse")
                {
                    btn.Tag = "Circle";
                    if (DrawingMode == DrawingMode.NoFill) { btn.BackgroundImage = Properties.Resources.shape_circle_outline_white; }
                    else { btn.BackgroundImage = Properties.Resources.shape_circle_white; }
                }
                else
                {
                    btn.Tag = "Ellipse";
                    if (DrawingMode == DrawingMode.NoFill) { btn.BackgroundImage = Properties.Resources.shape_ellipse_outline_white; }
                    else { btn.BackgroundImage = Properties.Resources.shape_ellipse_white; }
                }
                btn.PerformClick();
                btn.PerformClick();
            }
        }

        private void btnRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = sender as Button;
                if (btn.Tag.ToString() == "Rectangle")
                {
                    btn.Tag = "Square";
                    if (DrawingMode == DrawingMode.NoFill) { btn.BackgroundImage = Properties.Resources.shape_square_outline_white; }
                    else { btn.BackgroundImage = Properties.Resources.shape_square_white; }
                }
                else
                {
                    btn.Tag = "Rectangle";
                    if (DrawingMode == DrawingMode.NoFill) { btn.BackgroundImage = Properties.Resources.shape_rectangle_outline_white; }
                    else { btn.BackgroundImage = Properties.Resources.shape_rectangle_white; }
                }
                btn.PerformClick();
                btn.PerformClick();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            UnselectAllShapes();
            this.ShapeType = ShapeType.NoDrawing;
            UncheckAll();
            (sender as Button).BackColor = Color.FromArgb(0, 30, 81);
            this.psfMain.Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e) { DeleteSelectedShape(); }

        #region Menustrip event

        #region Menu File
        private void mnuFile_Open_Click(object sender, EventArgs e)
        {
            string openFilePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BoazAndBar Project | *.bnb";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.ListShapes.Count == 0)
                {
                    this.filePath = openFileDialog.FileName;
                    this.OnLoad(null);
                }
                else
                {
                    openFilePath = openFileDialog.FileName;
                    fMain fMain = new fMain();
                    fMain.filePath = openFilePath;
                    fMain.Show();
                }
            }
        }

        private void mnuFile_New_Click(object sender, EventArgs e)
        {
            fMain fMain = new fMain();
            fMain.Show();
        }

        private void mnuFile_Save_Click(object sender, EventArgs e)
        {
            if (this.filePath == null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "BoazAndBar Project | *.bnb|" +
                                       "PNG Picture | *.png|" +
                                       "JPEG Picture | *.jpg;*.jpeg;*.jpe";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var extension = System.IO.Path.GetExtension(saveFileDialog.FileName);

                        if (extension.ToLower() == ".bnb")
                        {
                            this.filePath = saveFileDialog.FileName;
                        }
                        else
                        {
                            Bitmap myBitmap = Utilities.CreateBimap(psfMain.Width, psfMain.Height, psfMain.BackColor, ListShapes);

                            switch (extension.ToLower())
                            {
                                case ".png":
                                    myBitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                                    break;

                                case ".jpeg":
                                case ".jpg":
                                    myBitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                                    break;
                            }
                        }
                    }
                }
            }

            if (this.filePath != null)
            {
                ShapeData shapeData = new ShapeData()
                {
                    BackColor = psfMain.BackColor,
                    ListShapes = this.ListShapes
                };
                ShapeData.Serialize(shapeData, this.filePath);
            }
        }

        private void mnuFile_Quit_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        #endregion

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            int numShapeSelected = ListShapes.FindAll(shape => shape.IsSelected).Count;
            int numShapes = ListShapes.Count;
            shapeLayers.Update(numShapeSelected, numShapes);
        }
        #endregion

        #region Methods
        #region Public methods

        public void ReDraw() { psfMain.Invalidate(); }

        public void DeleteSelectedShape()
        {
            for (int i = ListShapes.Count - 1; i >= 0; i--)
            {
                if (ListShapes[i].IsSelected) { ListShapes.RemoveAt(i); }
            }
            ReDraw();
        }
        #endregion

        #region Private methods
        
        private void UnselectAllShapes()
        {
            ListShapes.ForEach(shape => shape.IsSelected = false);
            ReDraw();
        }

        private void UncheckAll()
        {
            listButton.ForEach(button => button.BackColor = Color.Transparent);
        }

        
        private void MoveShape(Enums.Direction direction)
        {
            ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => shape.Move(direction, movingOffset));
            ReDraw();
        }
        #endregion

        #endregion


    }
}