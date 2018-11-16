using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CitrusPaint.Brush {
    abstract public class AbstractPen {

        public AbstractPen() {
        }


        abstract public void Draw(Canvas canvas, Point point);
        
    }
}
