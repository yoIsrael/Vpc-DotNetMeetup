using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPCXamarinTraining.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VPCXamarinTraining.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SoccerTeams : ContentPage
    {
        public SoccerTeams()
        {
            InitializeComponent();
            BindingContext = new SoccerTeamsViewModel();
        }
    }
}