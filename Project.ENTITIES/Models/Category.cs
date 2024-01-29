using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Category:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string? EditorContent { get; set; }
        public int? ParentID { get; set; }

        public int? ProjectAID { get; set; }
        public string? UserName { get; set; }
        public string? AllTimeUsers { get; set; }

        //Relational Properties 
        public virtual List<SubCategory>? SubCategories { get; set; }

        public virtual ProjectA? ProjectA { get; set; }
       

        public virtual List<Mission>? Missions { get; set; }

        public virtual List<Content>? Contents { get; set; }
        public virtual List<Image>? Images { get; set; }
        public virtual List<Data>? Datas { get; set; }
        public virtual List<CategoryRevizyon>? CategoryRevizyons { get; set; }
    }

}
