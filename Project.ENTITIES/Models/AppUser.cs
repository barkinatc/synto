using Microsoft.AspNetCore.Identity;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUser : IdentityUser<int>, IEntity
    {

        public int ID { get; set; }
        public string ?ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Gender { get; set; }

        public int? InstitutionID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public DataStatus Status { get; set; }
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Created;
        }
        //Relational Properties 
        public virtual Institution Institution { get; set; }
    }
}
