using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class Researcher
    {
        public Researcher()
        {
            Sighting = new HashSet<Sighting>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateBirth { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int? JobTitle { get; set; }
        public int ProtectedAreaId { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? Status { get; set; }

        public virtual ProtectedArea ProtectedArea { get; set; }
        // public virtual UserAccount UserAccount { get; set; }
        public virtual ICollection<Sighting> Sighting { get; set; }
    }
}
