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

namespace YourWallet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            YourWallet.dbDataSet dbDataSet = ((YourWallet.dbDataSet)(this.FindResource("dbDataSet")));
            // Load data into the table Table. You can modify this code as needed.
            YourWallet.dbDataSetTableAdapters.TableTableAdapter dbDataSetTableTableAdapter = new YourWallet.dbDataSetTableAdapters.TableTableAdapter();
            dbDataSetTableTableAdapter.Fill(dbDataSet.Table);
            System.Windows.Data.CollectionViewSource tableViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tableViewSource")));
            tableViewSource.View.MoveCurrentToFirst();
        }
    }
}
