using PracticaDataSet1.VideoCardsDBDataSetTableAdapters;
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

namespace Practica
{
    public partial class MainWindow : Window
    {
        GraphicsCardsTableAdapter graphicsCardsAdapter = new GraphicsCardsTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            dg_BD_graphicsCards.ItemsSource = graphicsCardsAdapter.GetData();
            dg_BD_graphicsCards.DisplayMemberPath = "Model";
        }

        private void dg_BD_graphicsCards_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var graphicsCardModel = (dg_BD_graphicsCards.SelectedItem as DataRowView).Row["Model"];
            MessageBox.Show(graphicsCardModel.ToString());
        }

    }
}