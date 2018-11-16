using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CitrusPaint.Brush {
    public class Pen : AbstractPen {
        Point? oldPoint = null;


        override public void Draw(Canvas canvas, Point point) {

            if(oldPoint == null) {
                oldPoint = point;
                return;
            }
            var line = new Line {
                    X1 = oldPoint.Value.X,
                    Y1 = oldPoint.Value.Y,
                    X2 = point.X,
                    Y2 = point.Y,
                    StrokeStartLineCap = PenLineCap.Round,
                    StrokeEndLineCap = PenLineCap.Round,
                    Stroke = Brushes.Black
            };
            canvas.Children.Add(line);
            oldPoint = point;
        }
    }
}
