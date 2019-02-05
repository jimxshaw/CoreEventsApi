using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {            
            this.CreateMap<Camp, CampModel>()
                .ForMember(cm => cm.Venue, o => o.MapFrom(c => c.Location.VenueName))
                .ForMember(cm => cm.Address1, o => o.MapFrom(c => c.Location.Address1))
                .ForMember(cm => cm.Address2, o => o.MapFrom(c => c.Location.Address2))
                .ForMember(cm => cm.Address3, o => o.MapFrom(c => c.Location.Address3))
                .ForMember(cm => cm.CityTown, o => o.MapFrom(c => c.Location.CityTown))
                .ForMember(cm => cm.StateProvince, o => o.MapFrom(c => c.Location.StateProvince))
                .ForMember(cm => cm.PostalCode, o => o.MapFrom(c => c.Location.PostalCode));
        }
    }
}