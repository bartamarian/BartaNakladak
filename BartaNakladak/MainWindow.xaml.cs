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

namespace BartaNakladak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak man;
        Nakladak daf;

        public MainWindow()
        {
            InitializeComponent();

            man = new Nakladak();
            man.Jmeno = "MAN";
            Zobraz(man, TextBox1);

            daf = new Nakladak();
            daf.Jmeno = "DAF";
            Zobraz(daf, TextBox2);
        }

        public void Zobraz (Nakladak nakladak, TextBox textBox)
        {
            textBox.Text = nakladak.Jmeno + "\n";
            textBox.Text += "Nosnost: " + nakladak.Nosnost.ToString() + "\n";
            textBox.Text += "Objem nádrže: " + nakladak.ObjemNadrze() + "\n";
        }
    }
}
