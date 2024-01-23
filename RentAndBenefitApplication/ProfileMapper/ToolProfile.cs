using AutoMapper;
using RentAndBenefitApplication.DAL.Model;
using RentAndBenefitApplication.PL.ViewModels;

namespace RentAndBenefitApplication.PL.ProfileMapper
{
    public class ToolProfile : Profile
    {
        public ToolProfile()
        {
            CreateMap<ToolVM, Tool>();
        }
    }
}
