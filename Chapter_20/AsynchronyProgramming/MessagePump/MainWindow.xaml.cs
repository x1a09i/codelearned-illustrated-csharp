using System.Threading.Tasks;
using System.Windows;

namespace MessagePump
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnDoStuff_Click(object sender, RoutedEventArgs e)
        {
            btnDoStuff.IsEnabled = false;
            lblStatus.Content = "Doing Stuff";
            //System.Threading.Thread.Sleep(4000);
            await Task.Delay(4000); // 在遇上await表达式之后，此处理程序代码将交出处理器的使用权
            lblStatus.Content = "Not Doing Anything...";
            btnDoStuff.IsEnabled = true;
        }
    }
}
