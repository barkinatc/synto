using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configuration
{
    public class ProjectAConfiguration:BaseConfiguration<ProjectA>
    {
        public override void Configure(EntityTypeBuilder<ProjectA> builder)
        {
            base.Configure(builder);
            
            
        }
    }
}
