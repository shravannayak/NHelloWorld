using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InstaDetail1 : ContentPage
	{
		public InstaDetail1(Contact contact)
		{
            if (contact == null)
                throw new ArgumentNullException();
            BindingContext = contact;
            InitializeComponent ();
		}
	}
}