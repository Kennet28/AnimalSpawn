using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Domain.DTOs
{
    public class AnimalRequestDto
    {
        public int SpeciesId { get; set; }
        public int FamilyId { get; set; }
        public int GenusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Gender { get; set; }
        public DateTime CaptureDate { get; set; }
        public string CaptureCondition { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public int EstimatedAge { get; set; }
        public string RfidTag { get; set; }
        public DateTime DateEstablished { get; set; }
        public int ProtectedAreaId { get; set; }

    }
}
