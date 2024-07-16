using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Screentop
{
    internal class TableVM
    {
        public ObservableCollection<UIElement> Elements { get; }

        public TableVM() 
        {
            Elements = new ObservableCollection<UIElement>();
            
            Button button = new Button();
            button.Content = "clickables";
            button.Width = 100;
            button.Height = 100;

            addElement(button, 50, 100);
        }

        private void addElement(UIElement element, int x, int y)
        {
            Canvas.SetTop(element, y);
            Canvas.SetLeft(element, x);
            Elements.Add(element);
        }



    }
}
