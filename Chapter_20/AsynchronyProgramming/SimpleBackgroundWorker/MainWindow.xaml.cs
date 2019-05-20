using System.ComponentModel;
using System.Windows;
using System.Threading;

namespace SimpleBackgroundWorker
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker bgWorker = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();
            // (属性)WorkerReportsProgress：是否允许后台线程向主线程进行汇报（数据交流）
            bgWorker.WorkerReportsProgress = true;
            // (属性)WorkerSupportsCancellation：是否接收来自主线程的中断请求
            bgWorker.WorkerSupportsCancellation = true;

            // (事件)DoWork：于后台线程开始时被触发
            bgWorker.DoWork += DoWork_Handler;
            // (事件)ProgressChanged：于后台线程“汇报工作”时被触发
            bgWorker.ProgressChanged += ProgressChanged_Handler;
            // (事件)RunWorkerCompleted：于后台线程退出时被触发
            bgWorker.RunWorkerCompleted +=RunWorkerCompleted_Handler;
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            // (属性)IsBusy：检查后台线程是否在运行
            if (!bgWorker.IsBusy)
                // RunWorkerAsync()：获取后台线程，并执行与DoWork事件相关联的事件程序代码
                bgWorker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // (方法)CancelAsync()：将CancellationPending属性设为true
            bgWorker.CancelAsync();
        }

        /// <summary>
        /// DoWork（调用RunWorkerAsync方法时被触发）的相关事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args">包括3个只读属性：Argument、Result、Cancel</param>
        private void DoWork_Handler(object sender, DoWorkEventArgs args)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for(int i=0; i <= 10; i++)
            {
                // (属性)CancellationPending：检测后台处理是否接收到取消请求
                if (worker.CancellationPending)
                {
                    args.Cancel = true;
                    break;
                }
                else
                {
                    // (方法)ReportProgress：向主线程汇报工作进度，唯一一个须要在worker内调用的方法
                    worker.ReportProgress(i * 10);
                    Thread.Sleep(500);
                }
            }
        }

        /// <summary>
        /// ProgressChanged事件（调用ReportProgress方法时被触发）的相关事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args">包括2个只读属性：ProgressPercentage、UserState</param>
        private void ProgressChanged_Handler(object sender, ProgressChangedEventArgs args)
        {
            // ProgressPercentage：用来获取后台线程的当前进度
            progressBar.Value = args.ProgressPercentage;
        }

        /// <summary>
        ///  RunWorkerCompleted事件（在DoWork时间相关处理程序执行完毕后被触发）的相关事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args">包括4个只读属性：Cancelled、Error、Result、UserState</param>
        private void RunWorkerCompleted_Handler(object sender, RunWorkerCompletedEventArgs args)
        {
            progressBar.Value = 0;
            if (args.Cancelled)
                MessageBox.Show("Process was cancelled.", "Process Cancelled");
            else
                MessageBox.Show("Process completed normally.", "Process Completed");
        }
    }
}
