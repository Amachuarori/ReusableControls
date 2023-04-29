using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace TestingReusableControls
{
    public class Columns
    {
        public ColumnDefinition column = new ColumnDefinition();


        public Columns(int width)
        {
            column.Width = new GridLength(width);
        }
    }
}
