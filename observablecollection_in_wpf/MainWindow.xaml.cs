using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace observablecollection_in_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<Player> Players = new List<Player>();
        ObservableCollection<Player> Players = new ObservableCollection<Player>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this.GetPlayer();
        }
        //public List<Player> GetPlayer()
        public ObservableCollection<Player> GetPlayer()
        {
            Players.Add(new Player() { Id = 1, Name = "atmar" });
            return Players;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Players.Add(new Player() { Id = 4, Name = "ahmad" });
        }
    }
}
