using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Task_10.UI
{
    class TemplateSelectorcs :DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var data = item as string;
            if(data.StartsWith("a"))
            {
                return new DataTemplate(typeof(BigTemplate));
            }
            else
            {
                return new DataTemplate(typeof(SmallTemplate));
            }
        }
    }
}
