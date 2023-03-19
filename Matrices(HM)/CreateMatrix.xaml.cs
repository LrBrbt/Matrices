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
using System.Windows.Shapes;

namespace Matrices_HM_
{
    /// <summary>
    /// Логика взаимодействия для CreateMatrix.xaml
    /// </summary>
    public partial class CreateMatrix : Window
    {
        public CreateMatrix()
        {
            InitializeComponent();
        }

        private void CreateBTN_Click(object sender, RoutedEventArgs e)
        {
            double[,] matrix;
            try
            {
                Regex sizeMatrix = new Regex("[0-9][x][0-9]");
                Match match = sizeMatrix.Match(SizeMatrixTXT.Text);
                if (match.Success)
                {
                    int[] numbers = SizeMatrixTXT.Text.Split('x').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();
                    matrix = ForMatrix.Create(numbers[0], numbers[1]);

                    if (matrix.GetLength(0) != 0)
                    {
                        MessageBox.Show("Матрица создана! Теперь её можно заполнить.");
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так. Попробуйте снова.");
                    }
                    ToTransferTheMatrix.matrix = matrix;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите размер матрицы в формате <число>x<число>, х вводите на английской раскладке!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
