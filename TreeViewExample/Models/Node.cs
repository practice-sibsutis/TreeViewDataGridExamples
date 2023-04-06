using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewExample.Models
{
    public class Node : AbstractNotifyPropertyChanged
    {
        private ObservableCollection<Node> nodes;
        private int data;

        public ObservableCollection<Node> Nodes
        {
            get => nodes;
            set
            {
                SetAndRaise(ref nodes, value);
            }
        }
        public int Data
        {
            get => data;
            set
            {
                SetAndRaise(ref data, value);
            }
        }
    }
}
