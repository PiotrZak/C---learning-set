using System;
using AutoMapper;
using supermarket.Models;
using supermarket.Resources;

namespace supermarket.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }

    }
}
