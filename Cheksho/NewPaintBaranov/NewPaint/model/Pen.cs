using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NewPaint.model
{
    public class Pen : Line
    {
        public Pen(Point aPoint) : base(aPoint) { }

        public override void SetCoordinate(Point aPoint)
        {
            base.SetCoordinate(aPoint);
        }

        public override void Draw(Panel aCanvas)
        {
            base.Draw(aCanvas);
        }
    }
}
