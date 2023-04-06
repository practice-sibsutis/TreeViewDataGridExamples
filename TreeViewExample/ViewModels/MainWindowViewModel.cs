
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using TreeViewExample.Models;

namespace TreeViewExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Node> nodes;

        public MainWindowViewModel()
        {
            nodes = new ObservableCollection<Node>();
            nodes.Add(new Node
            {
                Data = 1,
                Nodes = GetChildren(),
            });
        }

        public ObservableCollection<Node> Nodes
        {
            get => nodes;
            set
            {
                this.RaiseAndSetIfChanged(ref nodes, value);
            }
        }

        public ObservableCollection<Node> GetChildren()
        {
            Random rnd = new Random();
            ObservableCollection<Node> children = new ObservableCollection<Node>();
            for(int i = 0; i < 5; ++i)
            {
                children.Add(new Node
                {
                    Data = rnd.Next(0, 100),
                });
                children[children.Count - 1].Nodes = new ObservableCollection<Node>(new Node[]
                {
                    new Node
                    {
                        Data = rnd.Next(0, 100),
                    },
                    new Node
                    {
                        Data = rnd.Next(0, 100),
                    },
                    new Node
                    {
                        Data = rnd.Next(0, 100),
                    },
                    new Node
                    {
                        Data = rnd.Next(0, 100),
                    },
                    new Node
                    {
                        Data = rnd.Next(0, 100),
                    }
                });
            }

            return children;
        }


    }
}