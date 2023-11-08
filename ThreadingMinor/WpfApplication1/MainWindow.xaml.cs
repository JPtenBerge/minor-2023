using System.Threading;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            // Thread.Sleep(10000);
            var syncContext = SynchronizationContext.Current;
            new Thread(() =>
            {
                Thread.Sleep(2000);
                syncContext.Post((obj) =>
                {
                    this.LblTekst.Content = "nog een andere tekst";
                }, null);
                
                // this.LblTekst.Dispatcher.Invoke(() =>
                // {
                //     this.LblTekst.Content = "andere tekst";
                // });
            }).Start();
            
            
        }
    }
}