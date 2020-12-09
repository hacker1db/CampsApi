using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfiles : Profile
    {
        public CampProfiles()
        {
            this.CreateMap<Camp, CampModel>();
        }

    }
}