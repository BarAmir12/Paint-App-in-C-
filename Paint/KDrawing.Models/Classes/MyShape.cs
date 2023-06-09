﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;

namespace KDrawing.Models
{
    public abstract class MyShape
    {
        [XmlElement(Type = typeof(XmlColor))]
        public Color Color { get; set; }
        
        public abstract PointF Begin { get; set; }
        
        public abstract PointF End { get; set; }
        
        public float LineWeight { get; set; }
        
        public bool IsSelected { get; set; } = false;
        
        public bool IsHidden { get; set; } = false;
        
        public string Name { get; set; }
        
        public DashStyle DashStyle { get; set; } = DashStyle.Solid;
        protected abstract GraphicsPath GraphicsPath { get; }
        
        public abstract bool IsHit(PointF point);
        
        public abstract void Draw(Graphics graphics);
        
        public abstract void Move(PointF distance);
        
        public abstract void Move(KDrawing.Enums.Direction direction, int movingOffset);
        public abstract object Clone();
        
        public abstract void Scale(float percent);
        
        public abstract void Rotate(int degree);
    }
}