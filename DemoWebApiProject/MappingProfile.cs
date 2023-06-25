using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace DemoWebApiProject
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerDto>();
        }
    }
}
