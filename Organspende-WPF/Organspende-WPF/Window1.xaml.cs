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
using System.Windows.Shapes;

namespace Organspende_WPF
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void OpenNewWindow_Click(object sender, RoutedEventArgs e)
        {
            Window2 newWindow = new Window2(); // Neues Window1 erstellen
            newWindow.Show(); // Fenster öffnen
            this.Close(); // Aktuelles Fenster schließen (optional)
        }
    }
}
