using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configuration
{
    public class MissionAppUserConfiguration:BaseConfiguration<MissionAppUser>
    {
        public override void Configure(EntityTypeBuilder<MissionAppUser> builder)
        {
            base.Configure(builder);

            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.AppUserID,
                x.MissionID
            });
        }
    }
}
