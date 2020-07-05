using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace sample_csharp_desktopapp_unittest
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

        void TraceOut(string msg)
        {
            Trace.WriteLine(msg);
        }

        private void OnBtnStaticCallBefore(object sender, RoutedEventArgs e)
        {
            var target = new StaticCallBefore();
            var ret = target.func1();
            TraceOut($"{ret}");

        }

        private void OnBtnStaticCallAfter(object sender, RoutedEventArgs e)
        {
            var target = new StaticCallAfter(new Logic1());
            var ret = target.func1();
            TraceOut($"{ret}");
        }
    }
}
