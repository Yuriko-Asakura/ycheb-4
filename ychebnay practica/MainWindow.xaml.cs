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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using ychebnay_practica.ychebnayDataSetTableAdapters;
namespace ychebnay_practica
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CharactesTableAdapter charactes = new CharactesTableAdapter();
        NameeTableAdapter name = new NameeTableAdapter();
        elementTableAdapter el = new elementTableAdapter();
        classTableAdapter cl = new classTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ycheb.ItemsSource = charactes.GetData();
            t1.ItemsSource = name.GetData();
            t1.DisplayMemberPath = "namee";
            t2.ItemsSource = el.GetData();
            t2.DisplayMemberPath = "element";
            t3.ItemsSource = cl.GetData();
            t3.DisplayMemberPath = "orydie";
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            Charactes charactes = new Charactes();
            charactes.Show();
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            classs classs = new classs();
            classs.Show();
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            element element = new element();
            element.Show();
        }

        private void dov_Click(object sender, RoutedEventArgs e)
        {
            object sel1 = (t1.SelectedItem as DataRowView).Row[0];
            object sel2 = (t2.SelectedItem as DataRowView).Row[0];
            object sel3 = (t3.SelectedItem as DataRowView).Row[0];
            charactes.InsertQuery(Convert.ToInt32(sel1), Convert.ToInt32(sel2), Convert.ToInt32(sel3));
            ycheb.ItemsSource = charactes.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (ycheb.SelectedItem as DataRowView).Row[0];
            charactes.DeleteQuery(Convert.ToInt32(id));
            ycheb.ItemsSource = charactes.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            object sel = (ycheb.SelectedItem as DataRowView).Row[0];
            object se1 = (ycheb.SelectedItem as DataRowView).Row[1];
            object se2 = (ycheb.SelectedItem as DataRowView).Row[2];
            object se3 = (ycheb.SelectedItem as DataRowView).Row[3];
            object sel1 = (t1.SelectedItem as DataRowView).Row[0];
            object sel2 = (t2.SelectedItem as DataRowView).Row[0];
            object sel3 = (t3.SelectedItem as DataRowView).Row[0];
            charactes.UpdateQuery(Convert.ToInt32(sel1), Convert.ToInt32(sel2), Convert.ToInt32(sel3),Convert.ToInt32(sel),
                Convert.ToInt32(se1),Convert.ToInt32(se2),Convert.ToInt32(se3));
            ycheb.ItemsSource = charactes.GetData();
        }
    }
}
