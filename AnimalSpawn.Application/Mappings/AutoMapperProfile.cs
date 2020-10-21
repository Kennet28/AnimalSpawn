using AnimalSpawn.Domain.DTOs;
using AnimalSpawn.Domain.Entities;
using System;
using AutoMapper;

namespace AnimalSpawn.Application.Mappings
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Animal, AnimalRequestDto>();
            CreateMap<Animal, AnimalResponseDto>();
            CreateMap<AnimalRequestDto, Animal>().AfterMap(
            ((source, destination) => {
                destination.CreateAt = DateTime.Now;
                destination.CreatedBy = 3;
                destination.Status = true;
            }));
            CreateMap<AnimalResponseDto, Animal>();
        }
    }
}
