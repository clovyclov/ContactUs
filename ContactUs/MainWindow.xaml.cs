using ContactUs.Classes;
using SQLite;
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

namespace ContactUs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ReadDatebase();
        }

        private void addContactButton_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContactWindow = new NewContactWindow();
            newContactWindow.ShowDialog();
            ReadDatebase();
        }

        void ReadDatebase()
        {
            List<Contact> contacts;
            using(SQLiteConnection conn = new SQLiteConnection(App.db_path))
            {
                conn.CreateTable<Contact>();
                contacts = conn.Table<Contact>().ToList();
            }

            if( contacts != null)
            {
                contactsListView.ItemsSource = contacts;   
            }
        }
    }
}
