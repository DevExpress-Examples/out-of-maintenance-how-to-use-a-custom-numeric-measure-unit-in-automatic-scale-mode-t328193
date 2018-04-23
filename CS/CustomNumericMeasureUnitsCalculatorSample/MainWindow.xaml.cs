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

namespace CustomNumericMeasureUnitsCalculatorSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GenerateData(10000);
        }

        List<DataPoint> GenerateData(int count) {
            List<DataPoint> points = new List<DataPoint>(count);
            Random generator = new Random();
            for (int i = 0; i < count; ++i)
                points.Add(new DataPoint { X = i, Y = generator.NextDouble() });
            return points;
        } 
    }

    public class DataPoint {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
