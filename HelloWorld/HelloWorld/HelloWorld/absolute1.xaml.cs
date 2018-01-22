using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using HelloWorld.Persistence;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class absolute1 : ContentPage
	{
		public absolute1 ()
		{
			InitializeComponent ();
		}
        async public void BtnClick(object sender,EventArgs e)
        {
            await btn.ScaleTo(0.5, 50, Easing.SpringIn);
            await btn.ScaleTo(1, 50, Easing.SpringOut);
        }
    }
}