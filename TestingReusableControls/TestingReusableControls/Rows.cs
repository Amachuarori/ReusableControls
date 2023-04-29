using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace TestingReusableControls
{
    public class Rows
    {
        public RowDefinition row = new RowDefinition();


        public Rows(int height)
        {
            row.Height = new GridLength(height);
        }
    }
}
