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
        MemoryStream streamPdf = new MemoryStream();
        public absolute1 ()
		{
			InitializeComponent ();
            
        }
        async public void BtnClick(object sender,EventArgs e)
        {
            await btn.ScaleTo(0.5, 50, Easing.SpringIn);
            await btn.ScaleTo(1, 50, Easing.SpringOut);
            streamPdf = GetPdf();
            if (Device.OS == TargetPlatform.Android)
                DependencyService.Get<ISave>().Save("example.pdf", "application/pdf", streamPdf);
            pdfView.LoadDocument(streamPdf);
        }
        public static MemoryStream GetPdf()
        {
            //Create a new PDF document.
            PdfDocument document = new PdfDocument();
            //Add a page to the document.
            PdfPage page = document.Pages.Add();
            //Create PDF graphics for the page.
            PdfGraphics graphics = page.Graphics;
            //Set the standard font.
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
            //Draw the text.
            graphics.DrawString("Hello World!!!", font, PdfBrushes.Black, new PointF(0, 0));
            //Save the document.
            //document.Save("Output.pdf");
            //Close the document.

            MemoryStream stream = new MemoryStream();
            document.Save(stream);
            document.Close(true);

            return stream;
        }

    }
}