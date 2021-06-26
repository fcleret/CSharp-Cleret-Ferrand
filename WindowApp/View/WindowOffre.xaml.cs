using BiblioClass.Entity;
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
using System.Windows.Shapes;

namespace WindowApp
{
    /// <summary>
    /// Logique d'interaction pour WindowOffre.xaml
    /// </summary>
    public partial class WindowOffre : Window
    {
        public WindowOffre()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM();
        }
    }
}
