using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;

namespace ClassLibrary1
{
    public class Class1
    {
	    public Class1()
	    {
		    UIElement button = new Button();
		    var elementVisual = ElementCompositionPreview.GetElementVisual(button);

		    button.Events().DragEnter.Subscribe();
	    }
    }
}
