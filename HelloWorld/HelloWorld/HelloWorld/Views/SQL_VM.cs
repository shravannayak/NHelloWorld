using HelloWorld.CustomRenderer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloWorld.Views
{
    public class SQL_VM : INotifyPropertyChanged
    {
        public int TFlag;
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                OnPropertyChanged();
            }
        }
        private string _Desc;
        public string Desc
        {
            get { return _Desc; }
            set
            {
                _Desc = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    TFlag = 1;
                    //DependencyService.Get<ITostCustom>().ShowToast("Added");
                });
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
