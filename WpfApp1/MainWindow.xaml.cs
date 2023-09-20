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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            repeatCheck.Checked += (_,_) =>
            {
                repeatField.IsEnabled = true;
                repeatUnit.IsEnabled = true;
            };
            repeatCheck.Unchecked += (_,_) =>
            {
                repeatField.IsEnabled = false;
                repeatUnit.IsEnabled = false;
            };
        }
    }
}
