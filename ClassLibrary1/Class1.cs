using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ClassLibrary1
{
    public class Class1
    {
	    public Class1()
	    {
		    UIElement button = new Button();

		    button.Events().DragEnter.Subscribe();
        }
    }
}
