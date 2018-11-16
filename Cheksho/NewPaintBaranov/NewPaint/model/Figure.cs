using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NewPaint.model
{
    public abstract class Figure
    {
        public List<Point> Coordinates { get; set; }

        public abstract void SetCoordinate(Point aPoint);

        public abstract void Draw(Panel aCanvas);

        public void InitProperties()
        {
            Coordinates = new List<Point>();
        }
    }
}
