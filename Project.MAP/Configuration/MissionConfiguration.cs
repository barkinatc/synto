using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configuration
{
    public class MissionConfiguration:BaseConfiguration<Mission>
    {
        public override void Configure(EntityTypeBuilder<Mission> builder)
        {
            base.Configure(builder);

        }
    }
}
