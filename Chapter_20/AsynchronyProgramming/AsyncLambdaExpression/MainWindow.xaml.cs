using System.Threading.Tasks;
using System.Windows;

namespace AsyncLambdaExpression
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 使用异步Lambda表达式为点击事件添加相关执行代码片段
            // 注意async关键字在此处的使用
            startWorkButton.Click += async (sender, e) => 
            {
                SetWindowValues(false, "Processing...");
                await DoSomeWork();
                SetWindowValues(true, "Work Finished");
            };
        }

        private void SetWindowValues(bool btnEnabled, string status)
        {
            startWorkButton.IsEnabled = btnEnabled;
            workStartedTextBlock.Text = status;
        }

        private Task DoSomeWork()
        {
            return Task.Delay(5000);
        }
    }
}
