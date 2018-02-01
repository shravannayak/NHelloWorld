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
using HelloWorld.CustomRenderer;

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
            pdfView.LoadDocument(streamPdf);
           // if (Device.OS == TargetPlatform.Android)
              //  DependencyService.Get<ISave>().Save("example.pdf", "application/pdf", streamPdf);
            
            close.IsVisible = true;
         
            DependencyService.Get<ITostCustom>().ShowToast("Downloaded");
        }
        public async void CloseDoc(object sender,EventArgs e)
        {
            await close.ScaleTo(0.5, 50, Easing.SpringIn);
            await close.ScaleTo(1, 50, Easing.SpringOut);
            pdfView.Unload();
            close.IsVisible = false;
        }
        public MemoryStream GetPdf()
        {
            /*//Create a new PDF document.
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

            return stream;*/

            string text = "Hello world!!! Hello world!!!";
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.Pages.Add();
            PdfStringFormat drawFormat = new PdfStringFormat();
            drawFormat.WordWrap = PdfWordWrapType.Word;
            drawFormat.Alignment = PdfTextAlignment.Justify;
            drawFormat.LineAlignment = PdfVerticalAlignment.Top;
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 10f);
            PdfBrush brush = PdfBrushes.Red;
            RectangleF bounds = new RectangleF(new PointF(10, 10), new SizeF(page.Graphics.ClientSize.Width - 30, page.Graphics.ClientSize.Height - 20));
            PdfTextElement element = new PdfTextElement(text, font, brush);
            element.StringFormat = drawFormat;
            PdfLayoutResult result = element.Draw(page, bounds);
            result = element.Draw(result.Page, new RectangleF(result.Bounds.X, result.Bounds.Bottom + 10, result.Bounds.Width, result.Bounds.Height));
            PdfLightTable pdfLightTable = new PdfLightTable();
            pdfLightTable.Columns.Add(new PdfColumn("Name"));
            pdfLightTable.Columns.Add(new PdfColumn("Age"));
            pdfLightTable.Columns.Add(new PdfColumn("Sex"));
            pdfLightTable.Rows.Add(new string[] { "abc", "21", "Male" });
            pdfLightTable.Style.ShowHeader = true;
            result = pdfLightTable.Draw(page, new PointF(result.Bounds.Left, result.Bounds.Bottom + 20));
            result = element.Draw(result.Page, result.Bounds.X, result.Bounds.Bottom + 10);
            pdfLightTable = new PdfLightTable();
            pdfLightTable.Columns.Add(new PdfColumn("Name"));
            pdfLightTable.Columns.Add(new PdfColumn("Age"));
            pdfLightTable.Columns.Add(new PdfColumn("Sex"));
            pdfLightTable.Rows.Add(new string[] { "abc", "21", "Male" });
            pdfLightTable.Rows.Add(new string[] { "xyz", "23", "Female" });
            pdfLightTable.Style.ShowHeader = true;
            result = pdfLightTable.Draw(page, new PointF(result.Bounds.Left, result.Bounds.Bottom + 20));
            element.Draw(result.Page, result.Bounds.X, result.Bounds.Bottom + 10);
            MemoryStream stream = new MemoryStream();

            doc.Save(stream);

            doc.Close(true);
            
            return stream;
        }

    }
}