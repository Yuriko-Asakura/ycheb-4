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
    /// Логика взаимодействия для classs.xaml
    /// </summary>
    public partial class classs : Window
    {
        classTableAdapter cl = new classTableAdapter();
        public classs()
        {
            InitializeComponent();
            ycheb.ItemsSource = cl.GetData();
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            cl.InsertQuery(tx.Text,tx2.Text);
            ycheb.ItemsSource = cl.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (ycheb.SelectedItem as DataRowView).Row[0];
            cl.DeleteQuery(Convert.ToInt32(id));
            ycheb.ItemsSource = cl.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            object id = (ycheb.SelectedItem as DataRowView).Row[0];
            object id1 = (ycheb.SelectedItem as DataRowView).Row[1];
            object id2 = (ycheb.SelectedItem as DataRowView).Row[2];
            cl.UpdateQuery(tx.Text,tx2.Text, Convert.ToInt32(id), Convert.ToString(id1),Convert.ToString(id2));
            ycheb.ItemsSource = cl.GetData();
        }
    }
}
