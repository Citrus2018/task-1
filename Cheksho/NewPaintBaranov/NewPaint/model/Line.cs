using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace NewPaint.model
{
    public class Line : Figure
    {
        public Line(Point aPoint)
        {
            InitProperties();
            Coordinates.Add(aPoint);
        }

        public override void SetCoordinate(Point aPoint)
        {
            if (Coordinates.Count < 2)
            {
                Coordinates.Add(aPoint);
            }
            else
            {
                Coordinates[1] = aPoint;
            }
        }
        public override void Draw(Panel aCanvas)
        {
            var figure = new Polyline()
            {
                Stroke = Brushes.Black,
                StrokeThickness = 3,
            };

            foreach (var p in Coordinates)
            {
                figure.Points.Add(p);
            }

            aCanvas.Children.Add(figure);
        }
    }
}
