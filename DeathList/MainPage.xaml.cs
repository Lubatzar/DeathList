using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DeathList
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

    }
    public class MainViewModel
    {
        public ObservableCollection<DeathNode> TasksList { get; } =
            new ObservableCollection<DeathNode>();

        public MainViewModel()
        {
            AddTask = new Command<string>((text) =>
            {
                DeathNode deathNode = new DeathNode();
                deathNode.Text = text;

                TasksList.Add(deathNode);
            });

            RemoveTask = new Command<DeathNode>((deathNode) =>
            {
                TasksList.Remove(deathNode);
            });
        }
        
        public Command<string> AddTask { get; set; }
        public Command<DeathNode> RemoveTask { get; set; }

    }
    public class DeathNode
    {
        public string Text { get; set; } = "666";
        public bool IsDead { get; set; } = false;
    }
}