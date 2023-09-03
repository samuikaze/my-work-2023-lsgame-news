using AutoMapper;
using LSGames.News.Api.Models.ServiceModels;
using LSGames.News.Api.Models.ViewModels;
using LSGames.News.Repository.Models;

namespace LSGames.News.Api.AutoMapperProfiles
{
    public class NewsProfile : Profile
    {
        public NewsProfile()
        {
            CreateMap<GetNewsRequestViewModel, GetNewsRequestServiceModel>();
            CreateMap<GetNewsResponseServiceModel, GetNewsResponseViewModel>();
            CreateMap<NewsType, NewsTypeServiceModel>().ReverseMap();
            CreateMap<NewsTypeServiceModel, NewsTypeViewModel>().ReverseMap();
            CreateMap<NewsViewModel, NewsServiceModel>().ReverseMap();
            CreateMap<NewsServiceModel, Repository.Models.News>().ReverseMap();
        }
    }
}
