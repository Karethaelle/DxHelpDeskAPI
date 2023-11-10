using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DxHelpDeskAPI.Application/Mappings/MappingProfile.cs
using AutoMapper;
using DxHelpDeskAPI.Domain.Entities;
using DxHelpDeskAPI.Application.DTOs;
using System.Reflection;

namespace DxHelpDeskAPI.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Get all types within the specified namespaces
            var modelTypes = Assembly.GetExecutingAssembly().GetTypes()
                                     .Where(t => t.Namespace == "DxHelpDeskAPI.Domain.Entities.Models")
                                     .ToList();
            var dtoTypes = Assembly.GetExecutingAssembly().GetTypes()
                                   .Where(t => t.Namespace == "DxHelpDeskAPI.Application.DTOs")
                                   .ToList();

            // Create mappings for each found type
            foreach (var type in modelTypes)
            {
                var dtoType = dtoTypes.FirstOrDefault(t => t.Name == $"{type.Name}Dto");
                if (dtoType != null)
                {
                    CreateMap(type, dtoType);
                    CreateMap(dtoType, type);
                }
            }
        }
    }
}
