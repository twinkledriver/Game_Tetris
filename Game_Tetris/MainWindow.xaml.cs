using System;
using System.Collections.Generic;
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

namespace Game_Tetris
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            win.Title = "子窗体1";
            win.Content = "单击超链接所引发的事件1";
            win.ShowDialog();
        }

        private void Hyperlink_Click2(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            win.Title = "子窗体2";
            win.Content = "单击超链接所引发的事件2";
            win.ShowDialog();
        }
    }
}
