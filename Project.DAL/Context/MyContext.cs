using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.MAP.Configuration;

namespace Project.DAL.Context
{
    public  class MyContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new InstitutionConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new SubCategoryConfiguration());
            builder.ApplyConfiguration(new ProjectAConfiguration());
            builder.ApplyConfiguration(new PageConfiguration());
            builder.ApplyConfiguration(new DataConfiguration());
            builder.ApplyConfiguration(new ImageConfiguration());
            builder.ApplyConfiguration(new ContentConfiguration());
            builder.ApplyConfiguration(new MissionConfiguration());

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Institution> Institutions { get; set; }    

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ProjectA> ProjectAs { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Data> Datas { get; set; }
        public DbSet<Mission> Missions { get; set; }


    }
}
