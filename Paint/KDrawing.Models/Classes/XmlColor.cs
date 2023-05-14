using System;
using System.Drawing;
using System.Xml.Serialization;

namespace KDrawing.Models
{
    public class XmlColor
    {
        #region Properties
       
        public Color ToColor() { return color; }

        #endregion

        #region Fields
        private Color color = Color.Black;
        #endregion

        #region Constructor
        public XmlColor() { }
        public XmlColor(Color color) { this.color = color; }
        #endregion

        #region Methods
        
        public static implicit operator Color(XmlColor xmlColor) { return xmlColor.ToColor(); }

        public static implicit operator XmlColor(Color color) { return new XmlColor(color); }
        #endregion
    }
}
