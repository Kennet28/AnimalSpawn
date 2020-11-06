using AnimalSpawn.Domain.DTOs;
using AnimalSpawn.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Validators
{
    public class AnimalValidator:AbstractValidator<AnimalRequestDto>
    {
        public AnimalValidator()
        {
            RuleFor(animal => animal.Name).NotNull().Length(3, 50);
            RuleFor(animal => animal.CaptureDate).LessThan(DateTime.Now);
            RuleFor(animal => animal.CaptureCondition).NotNull().Length(4, 200);
        }
    }
}
