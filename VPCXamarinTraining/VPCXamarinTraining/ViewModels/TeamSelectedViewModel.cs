using VPCXamarinTraining.DTO;
using VPCXamarinTraining.ViewModels.Base;

namespace VPCXamarinTraining.ViewModels
{
    public class TeamSelectedViewModel : ViewModelBase
    {
        #region Attributes

        private SoccerTeamDTO teamSelected;

        #endregion

        #region Properties

        public SoccerTeamDTO TeamSelected
        {
            get { return teamSelected; }
            set
            {
                if (teamSelected != value)
                {
                    teamSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Name => TeamSelected.Name;

        public string Description => TeamSelected.Description;

        public string ImageUrl => TeamSelected.ImageUrl;

        #endregion

        #region Constructor

        public TeamSelectedViewModel(SoccerTeamDTO teamSelected)
        {
            this.teamSelected = teamSelected;
        }

        #endregion
    }
}
