using ApiXamarin.Services;
using ApiXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllergenPage : ContentPage
    {
        public AllergenPage()
        {
            InitializeComponent();
            BindingContext = new IIngredientAnalysisViewModel(new IngredientAnalysisApiService());
        }
    }
}