using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class PortfolioViewModel
    {
        public List<AboutMeEntity> AboutMe { get; set; }
        public List<AboutMeTextEntity> AboutMeText { get; set; }
        public List<NameSurnameEntity> nameSurname { get; set; }
        public List<LgProsent> lgProsents { get; set; }
        public List<YHP> yhp { get; set; }
        public List<ProfileImage> profileImage { get; set; }
        public List<PortfolioProject> portfolioProject { get; set; }
        public List<LatestsEntity> latestWorks { get; set; }
        public List<ServicesTxt> txts { get; set; }
        public List<BlogEntity> blog { get; set; }
        public List<BlogtxtEntity> blogtxtEntities { get; set; }
        public List<TestimonialEntity> testimonial { get; set; }
    
        public List<ServicesEntity> servicesEntity { get; set; }
        public List<ResumeTxtEntity> resumeTxtEntities { get; set; }
        public List<MyClientsLogosEntity> myClientsLogos { get; set; }
        public List<Experience> experiences { get; set; }
        public List<EducationEntity> educations { get; set; }
        public List<ConnectText> connectTexts { get; set; }
        public List<ConnectEntity> connectEntities { get; set; }


    }
}
