using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class UserAccount:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }

        public virtual Researcher IdNavigation { get; set; }
    }
}
