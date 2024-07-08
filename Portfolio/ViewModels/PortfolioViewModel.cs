using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class PortfolioViewModel
    {
        public List<AboutMeEntity> AboutMe { get; set; }
        public List<AboutMeTextEntity> AboutMeText { get; set; }
        public List<NameSurnameEntity> nameSurname { get; set; }
        public List<LgProsent>  lgProsents { get; set; }
        public List<YHP> yhp { get; set; }
        public List < ProfileImage> profileImage { get; set; }
    }
}
