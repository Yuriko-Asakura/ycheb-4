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
using ychebnay_practica.ychebnayDataSetTableAdapters;

namespace ychebnay_practica
{
    /// <summary>
    /// Логика взаимодействия для Charactes.xaml
    /// </summary>
    public partial class Charactes : Window
    {
        NameeTableAdapter na = new NameeTableAdapter();
        public Charactes()
        {
            InitializeComponent();
            ycheb.ItemsSource = na.GetData();
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            na.InsertQuery(tx.Text, tx2.Text, Convert.ToInt32(tx3.Text));
            ycheb.ItemsSource = na.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (ycheb.SelectedItem as DataRowView).Row[0];
            na.DeleteQuery(Convert.ToInt32(id));
            ycheb.ItemsSource = na.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        { 
            object id = (ycheb.SelectedItem as DataRowView).Row[0];
            object t1 = (ycheb.SelectedItem as DataRowView).Row[1];
            object t2 = (ycheb.SelectedItem as DataRowView).Row[2];
            object t3 = (ycheb.SelectedItem as DataRowView).Row[3];
            na.UpdateQuery(tx.Text,tx2.Text,Convert.ToInt32(tx3.Text),Convert.ToInt32(id),Convert.ToString(t1),Convert.ToString(t2),Convert.ToInt32(t3));
            ycheb.ItemsSource = na.GetData();
        }
    }
}
