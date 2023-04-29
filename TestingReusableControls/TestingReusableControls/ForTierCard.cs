using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using TestingReusableControls.Components;

namespace TestingReusableControls
{
    public class ForTierCard
    {
        
        public TierCard newTier = new TierCard();

        public ForTierCard(int column, int row, string subType, Brush color, string description)
        {
            Grid.SetColumn(newTier, column);
            Grid.SetRow(newTier, row);
            newTier.Header = subType;
            newTier.Color = color;
            newTier.Description = description;
           
        }


    }
}
