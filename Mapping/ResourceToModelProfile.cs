using AutoMapper;
using Examen.Domain.Models;
using Examen.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Mapping
{
    public class ResourceToModelProfile : Profile
    {

        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }

    }
}
