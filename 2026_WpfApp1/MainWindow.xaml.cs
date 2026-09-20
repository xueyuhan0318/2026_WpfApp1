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

namespace _2026_WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            string name=textname.Text;
            string phone= textphone.Text;

            string message= "姓名：" + name + "\n" + "電話：" + phone;

            MessageBox.Show(message);
        }

        private void Computerbutton_click(object sender, RoutedEventArgs e)
        {
            int n =int.Parse(textnumber.Text);

            string result = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    result += $"{i}*{j}={i * j}\t\t";
                }
                result += "\n\n";
            }
            resulttestBlock.Text = result;
        }
    }
}