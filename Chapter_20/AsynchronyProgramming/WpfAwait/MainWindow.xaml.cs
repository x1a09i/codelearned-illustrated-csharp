using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfAwait
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        // 定义用来取消异步操作的令牌(Token)
        CancellationTokenSource _cancellationTokenSource;
        CancellationToken _cancellationToken;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            btnProcess.IsEnabled = false;

            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;

            int completedPercent = 0;

            for(int i = 0; i < 10; i++)
            {
                if (_cancellationTokenSource.IsCancellationRequested) break;
                // 注意，此处用tryCatch来实现中断操作
                try
                {
                    await Task.Delay(500, _cancellationToken);
                    // 每半秒进度条增长10%
                    completedPercent = (i + 1) * 10;
                }
                catch(TaskCanceledException)
                {
                    completedPercent = i * 10;
                }
                progressBar.Value = completedPercent;
            }

            string message = _cancellationTokenSource.IsCancellationRequested
                ? string.Format("Process was cancelled at {0}%", completedPercent)
                : "Process completed normally.";

            MessageBox.Show(message, "Completion Status");

            progressBar.Value = 0;
            btnProcess.IsEnabled = true;
            btnCancel.IsEnabled = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (!btnProcess.IsEnabled)
            {
                btnCancel.IsEnabled = false;
                _cancellationTokenSource.Cancel();
            }
        }
    }
}
