using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Linq;
using ychebnay_practica.ychebnayDataSetTableAdapters;

namespace ychebnay_practica
{
    /// <summary>
    /// Логика взаимодействия для element.xaml
    /// </summary>
    public partial class element : Window
    {
        elementTableAdapter el = new elementTableAdapter();
        public element()
        {
            InitializeComponent();
            ycheb.ItemsSource = el.GetData();
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            el.InsertQuery(tx.Text);
            ycheb.ItemsSource = el.GetData();

        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (ycheb.SelectedItem as DataRowView).Row[0];
            el.DeleteQuery(Convert.ToInt32(id));
            ycheb.ItemsSource = el.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            object id = (ycheb.SelectedItem as DataRowView).Row[0];
            object id1 = (ycheb.SelectedItem as DataRowView).Row[1];
            el.UpdateQuery(tx.Text, Convert.ToInt32(id), Convert.ToString(id1));
            ycheb.ItemsSource = el.GetData();
        }
    }
}
