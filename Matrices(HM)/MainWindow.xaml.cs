using ArrayMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Matrices_HM_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double[,] matrix;
        private void CreateBTN_Click(object sender, RoutedEventArgs e)
        {
            CreateMatrix create = new();
            create.ShowDialog();

            matrix = ToTransferTheMatrix.matrix;
            MatrixDG.ItemsSource = ForMatrix.ToDataTable(matrix).DefaultView;
        }
        private void Matrix_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            int columnIndex = e.Column.DisplayIndex;
            int rowIndex = e.Row.GetIndex();
            matrix[rowIndex, columnIndex] = Convert.ToDouble(((TextBox)e.EditingElement).Text);
        }



        private void SevenBTN_Click(object sender, RoutedEventArgs e)
        {
       
        }

        private void FourBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
