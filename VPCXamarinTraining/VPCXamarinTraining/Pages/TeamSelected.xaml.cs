using VPCXamarinTraining.DTO;
using VPCXamarinTraining.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VPCXamarinTraining.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeamSelected : ContentPage
    {
        public TeamSelected(SoccerTeamDTO TeamSelected)
        {
            InitializeComponent();
            BindingContext = new TeamSelectedViewModel(TeamSelected);
        }
    }
}