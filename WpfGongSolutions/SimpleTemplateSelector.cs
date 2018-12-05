using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfGongSolutions
{
    class SimpleTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null && item is SampleModel)
            {
                var sampleModel = item as SampleModel;

                if (sampleModel.IsSmall)
                    return
                        element.FindResource("SmallTileTemplate") as DataTemplate;
                else
                    return
                        element.FindResource("MediumTileTemplate") as DataTemplate;
            }

            return null;
        }
    }
}
