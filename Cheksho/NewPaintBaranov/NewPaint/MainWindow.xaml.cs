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

namespace NewPaint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<model.Figure> Figures;

        private bool IsMouseDown;

        public MainWindow()
        {
            InitializeComponent();

            Figures = new List<model.Figure>();

            IsMouseDown = false;
        }

        //public object DrawCanvas { get; private set; }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IsMouseDown = true;

            Figures.Add(new model.Pen(Mouse.GetPosition(this)));

            Paint();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Figures.Last().SetCoordinate(Mouse.GetPosition(this));
                Paint();
            }
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            IsMouseDown = false;
        }

        private void Paint()
        {
            DrawCanvas.Children.Clear();

            foreach (var f in Figures)
            {
                f.Draw(DrawCanvas);
            }
        }
    }
}
