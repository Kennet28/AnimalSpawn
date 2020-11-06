using AnimalSpawn.Domain.DTOs;
using AnimalSpawn.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

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


            CreateMap<AnimalRequestDto, RfidTag>()
                .ForMember(destination => destination.Tag, act => act.MapFrom(source =>
                    source.RfidTag));
            CreateMap<AnimalRequestDto, Animal>()
                 .ForMember(destination => destination.RfidTag, act => act.MapFrom(source => source))
                 .AfterMap(
                 ((source, destination) => {
                     destination.CreateAt = DateTime.Now;
                     destination.CreatedBy = 3;
                     destination.Status = true;
                 }));

        }
    }    
}