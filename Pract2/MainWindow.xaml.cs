using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pract2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mas = [0,0];
        LibMas libMas=new LibMas();
        Lib lib = new Lib();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Тимофеева Виктория \n Группа: ИСП-31 \n Вариант№8 \n Задание:Ввести n целых чисел. Вычислить косинус (cos) суммы чисел < 3. Результат \r\nвывести на экран.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Input(object sender, RoutedEventArgs e)
        {
            string result = "";
            int get_number;
            int n;
            try
            {

                if (int.TryParse(input_num.Text, out get_number) && (int.TryParse(lenght.Text, out n)))
                {
                    mas = libMas.Create(get_number, in n);
                    for (int i = 0; i < mas.Length; i++)
                    {
                        result = result + mas[i].ToString() + " ";
                    }
                    outputMas.Text = result;
                    double s = lib.Cos(mas);
                    outputcos.Text = s.ToString();
                }
                else
                {
                    MessageBox.Show("Введено неправильное значение");
                }
            }
            catch (Exception ex) { MessageBox.Show($"Произошла ошибка:\nВозможно вы ввели отрицаиельное число.\nКод ошибки:\n{ex}"); }
        }

        private void OpenClik(object sender, RoutedEventArgs e)
        {
            string result = "";
            libMas.Open(out mas);
            for (int i = 0; i < mas.Length; i++)
            {
                result = result + mas[i].ToString() + " ";
            }
            outputMas.Text = result;
        }

        private void SaveClik(object sender, RoutedEventArgs e)
        {
            if(mas != null)
            {
                libMas.Save(mas);
            }
            else MessageBox.Show("Mas is null");
        }

        private void ClearClik(object sender, RoutedEventArgs e)
        {
            mas = null;
            outputMas.Text = "";
            outputcos.Text = "";
            input_num.Text = "";
            lenght.Text = "";

        }

       
    }
}