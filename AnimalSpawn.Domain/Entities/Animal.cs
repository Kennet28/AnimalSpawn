using System;

namespace AnimalSpawn.Domain.Entities
{
    public class Animal
 {
 public string Name { get; set; }
 public bool Gender { get; set; }
 public DateTime CaptureDate { get; set; }
 public string CaptureCondition { get; set; }
 public double Weight { get; set; }
 public double Height { get; set; }
 public int EstimatedAge { get; set; }
 public string Description { get; set; }
 }
}