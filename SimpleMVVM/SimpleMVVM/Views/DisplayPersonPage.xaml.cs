using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVVM.ModelViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPersonPage : ContentPage
    {
        public DisplayPersonPage()
        {
            var person = new DisplayPersonPageViewModel(DisplayPersonPageViewModel.FetchPerson());

            BindingContext = person;

            InitializeComponent();
        }
    }
}
