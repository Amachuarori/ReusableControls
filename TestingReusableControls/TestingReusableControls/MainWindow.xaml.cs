using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Diagnostics;
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
using TestingReusableControls.Components;

namespace TestingReusableControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<TierCard> tiers = new ObservableCollection<TierCard>();
        Grid myGrid = new Grid();
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void GenerateClick(object sender, RoutedEventArgs e)
        {

            if(tiers.Count > 0)
            {
                tiers.Clear();
                myGrid.Children.Clear();
                myPanel.Children.Clear();
                
            }
            
            string[] arr = new string[] { "basic", "pro", "enterprise" , "super basic" , "super Pro", "super Enterprise"};
            var colors = new Brush[] { Brushes.Bisque, Brushes.Black, Brushes.Green, Brushes.BlueViolet, Brushes.DeepPink, Brushes.Crimson };
            var words = new string[] { "bbbbbasic", "pro", "advanced", "super basic", "super Pro", "super Enterprise" };
            
            int num = rnd.Next(0, 10);

            List<int> rowsList = new List<int>();
            List<int> columnsList = new List<int>();
            for(int i = 0; i< num; i++)
            {
                rowsList.Add(i);
                columnsList.Add(i);
            }

            while(rowsList.Count > 0)
            {
                int randomNum = rnd.Next(0, arr.Length);
                int a = rnd.Next(0, columnsList.Count - 1);
                int b = rnd.Next(0, rowsList.Count - 1);
                ForTierCard forTier = new ForTierCard(columnsList[a], rowsList[b], arr[randomNum], colors[randomNum], words[randomNum]);
                columnsList.RemoveAt(a);
                rowsList.RemoveAt(b);
                tiers.Add(forTier.newTier);
            }


            for(int i =0; i<num; i++)
            {
                ColumnDefinition column = new ColumnDefinition();
                column.Width = new GridLength(300);
                myGrid.ColumnDefinitions.Add(column);
                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(400);
                myGrid.RowDefinitions.Add(row);
            }







            for (int i = 0; i<tiers.Count; i++ )
            {
                myGrid.Children.Add(tiers[i]);
            }
            
            myPanel.Children.Add(myGrid);

            GeneratingButton.IsEnabled = false;
            ClearButton.IsEnabled = true;

            
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            tiers.Clear();
            myGrid.Children.Clear();
            myPanel.Children.Clear();
            GeneratingButton.IsEnabled = true;
            ClearButton.IsEnabled = false;

        }
    }

}








//for(int i = 0; i<3; i++)
//        {
//            ColumnDefinition column = new ColumnDefinition();
//            RowDefinition row = new RowDefinition();
//            column.Width = new GridLength(200);
//            row.Height = new GridLength(500);
//            myGrid.ColumnDefinitions.Add(column);
//            myGrid.RowDefinitions.Add(row);

//        }
//        myPanel.Children.Add(myGrid);

//for (int i = 0; i < 3; i++)
//{
//    TierCard tierCard = new TierCard();
//    tierCard.Color = colors[i];
//    tierCard.Description = words[i];
//    tierCard.Header = arr[i];
//    Grid.SetColumn(tierCard, i);
//    Grid.SetRow(tierCard, i);
//    controlUser.Add(tierCard);
//    Debug.Print("je");
//}

//myItems.ItemsSource = controlUser;


//var a = tiers[i];
//ColumnDefinition column = new ColumnDefinition();
//column.Width = new GridLength(300);
//RowDefinition row = new RowDefinition();
//row.Height = new GridLength(400);
//myGrid.RowDefinitions.Add(row);
//myGrid.ColumnDefinitions.Add(column);
//myGrid.Children.Add(a);