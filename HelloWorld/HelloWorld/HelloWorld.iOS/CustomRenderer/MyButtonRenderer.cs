using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using HelloWorld.CustomRenderer;
using HelloWorld.iOS.CustomRenderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyButton), typeof(MyButtonRenderer))]
namespace HelloWorld.iOS.CustomRenderer
{
    public class MyButtonRenderer : ButtonRenderer
    {
    } 
}