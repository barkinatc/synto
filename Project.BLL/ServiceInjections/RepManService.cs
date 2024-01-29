using Microsoft.Extensions.DependencyInjection;
using Project.BLL.Abstract;
using Project.BLL.Concretes;
using Project.DAL.Abstract;
using Project.DAL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class RepManService
    {
        public static IServiceCollection AddRepManServices(this IServiceCollection services)
        {

            //AddScopedDAL

            services.AddScoped(typeof(IRepositoryDal<>), typeof(BaseRepositoryDal<>));

            services.AddScoped<ICategoryRepositoryDal, CategoryRepositoryDal>();
            services.AddScoped<IAppUserRepositoryDal, AppUserRepositoryDal>();
            services.AddScoped<IInstitutionRepositoryDal, InstitutionRepositoryDal>();
            services.AddScoped<ISubCategoryRepositoryDal, SubCategoryRepositoryDal>();
            services.AddScoped<IProjectARepositoryDal, ProjectARepositoryDal>();
            services.AddScoped<IPageRepositoryDal, PageRepositoryDal>();
            services.AddScoped<IImageRepositoryDal, ImageRepositoryDal>();
            services.AddScoped<IContentRepositoryDal, ContentRepositoryDal>();
            services.AddScoped<IDataRepositoryDal, DataRepositoryDal>();
            services.AddScoped<IMissionRepositoryDal, MissionRepositoryDal>();
            services.AddScoped<IDartRepositoryDal, DartRepositoryDal>();
            services.AddScoped<IPageAppUserRepositoryDal, PageAppUserRepositoryDal>();
            services.AddScoped<IPageInstitutionRepositoryDal, PageInstitutionRepositoryDal>();
            services.AddScoped<IIndicatorRepositoryDal, IndicatorRepositoryDal>();
            services.AddScoped<IDartIndicatorRepositoryDal, DartIndicatorRepositoryDal>();
            services.AddScoped<IMissionAppUserRepositoryDal, MissionAppUserRepositoryDal>();
            services.AddScoped<IMissionInstitutionRepositoryDal, MissionInstitutionRepositoryDal>();
            services.AddScoped<ICategoryRevizyonRepositoryDal, CategoryRevizyonRepositoryDal>();


            //Addscoped
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IInstitutionManager, InstitutionManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<ISubCategoryManager, SubCategoryManager>();
            services.AddScoped<IProjectAManager, ProjectAManager>();
            services.AddScoped<IPageManager, PageManager>();
            services.AddScoped<IContentManager, ContentManager>();
            services.AddScoped<IImageManager, ImageManager>();
            services.AddScoped<IDataManager, DataManager>();
            services.AddScoped<IMissionManager, MissionManager>();
            services.AddScoped<IDartManager, DartManager>();
            services.AddScoped<IPageAppUserManager, PageAppUserManager>();
            services.AddScoped<IPageInstitutionManager, PageInstitutionManager>();
            services.AddScoped<IIndicatorManager, IndicatorManager>();
            services.AddScoped<IDartIndicatorManager, DartIndicatorManager>();
            services.AddScoped<IMissionAppUserManager, MissionAppUserManager>();
            services.AddScoped<IMissionInstitutionManager, MissionInstitutionManager>();
            services.AddScoped<ICategoryRevizyonManager, CategoryRevizyonManager>();



            return services;


        }
    }
}
