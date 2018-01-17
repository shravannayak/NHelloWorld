using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grid1 : ContentPage
    {
        private double First = 0;
        private double Second = 0;
        private double Result = 0;
        private double abc;
        private bool op = false;
        private string oper;
        private string temp;
        private string equation;
        private int len;
        private int Nlen;
        private int tmp;

        public Grid1()
        {
            InitializeComponent();

        }
        public void NumClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if ((LblDisp.Text == "0") && (op == false))
            {
                LblDisp.Text = btn.Text;
                equation += btn.Text;
                First = Convert.ToDouble(LblDisp.Text);
                //await DisplayAlert("first value", First.ToString(), "ok");
            }
            else if ((LblDisp.Text != "0" )&& (op == true))
            {
                LblDisp.Text += btn.Text;
                Nlen = LblDisp.Text.Length;
                tmp = Nlen - len;
                equation += btn.Text;
                //await DisplayAlert("len value", len.ToString(), "ok");
                //await DisplayAlert("Nlen value", Nlen.ToString(), "ok");
                temp = equation.Substring(len,tmp);
                //await DisplayAlert("substr value", temp, "ok");
                Second = Convert.ToDouble(temp);
                //await DisplayAlert("second value", Second.ToString(), "ok");
            }
            else if ((LblDisp.Text != "0" )&&( op == false))
            {
                LblDisp.Text += btn.Text;
                equation += btn.Text;
                First = Convert.ToDouble(LblDisp.Text);
                //await DisplayAlert("first value", First.ToString(), "ok");
            }
            /*else if ((LblDisp.Text != "0") && (op == true))
            {
                LblDisp.Text += btn.Text;
                Nlen = LblDisp.Text.Length;
                tmp = Nlen - len;
                temp = LblDisp.Text.Substring(len, tmp);
                Second = Convert.ToDouble(tmp);
                await DisplayAlert("second value", Second.ToString(), "ok");
            }*/

        }
        public void OpClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            op = true;
            LblDisp.Text += btn.Text;
            equation += btn.Text;
            len = LblDisp.Text.Length;
            oper = btn.Text;

        }
        public void CalcClicked(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "+": Result = First + Second;
                    LblDisp.Text = Result.ToString();
                    Reset();
                    break;
                case "-": Result = First - Second;
                    LblDisp.Text = Result.ToString();
                    Reset();
                    break;
                case "*": Result = First * Second;
                    LblDisp.Text = Result.ToString();
                    Reset();
                    break;
                case "/": Result = First / Second;
                    LblDisp.Text = Result.ToString();
                    Reset();
                    break;
            }

        }
        public void ClearClicked(object sender, EventArgs e)
        {
            LblDisp.Text = "0";
            Reset();
        }
        public void Reset()
        {
            First = 0;Second = 0;Result = 0;op = false; equation = null;
        }
        public void DelClicked(object sender,EventArgs e)
        {
            len = LblDisp.Text.Length;
            LblDisp.Text = LblDisp.Text.Substring(0, len - 1);
            equation = LblDisp.Text.Substring(0, len - 1);
            SetNums();
        }
        public async void SetNums()
        {
            if(equation.Contains(oper))
            {
                Nlen = equation.LastIndexOf(oper);
                await DisplayAlert("LastIndexOf(oper)", Nlen.ToString(), "ok");
                tmp = equation.Length - Nlen;
                await DisplayAlert("Characters count", tmp.ToString(), "ok");
                Second = Convert.ToDouble(equation.Substring(Nlen, tmp));
            }
            else
            {
                op = false;
                First = Convert.ToDouble(equation);
            }
        }
        
    }
}