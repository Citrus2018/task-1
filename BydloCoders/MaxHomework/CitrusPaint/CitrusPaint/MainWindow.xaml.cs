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

namespace CitrusPaint {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {


        List<Brush.AbstractPen> figures = new List<Brush.AbstractPen>();

        public MainWindow() {
            InitializeComponent();
            ReleaseMouseCapture();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) {

            if (e.MouseDevice.LeftButton == MouseButtonState.Pressed) {
                figures.Last().Draw(canvas, e.GetPosition(canvas));
            }

        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e) {
            figures.Add(new Brush.Pen());

        }

    }
}
