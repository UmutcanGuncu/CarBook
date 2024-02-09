using System;
using CarBook.Application.CQRS.Handlers.AboutHandlers;
using CarBook.Application.CQRS.Handlers.BannerHandlers;
using CarBook.Application.CQRS.Handlers.BrandHandlers;
using CarBook.Application.CQRS.Handlers.CarHandlers;
using CarBook.Application.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.CQRS.Handlers.ContactHandlers;
using CarBook.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarBook.Applicationservices
{
    public static class ServiceRegistiration
    {
		public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(ServiceRegistiration).Assembly));
            
            services.AddScoped<GetCarWithBrandQueryHandler>();

            services.AddScoped<GetAboutQueryHandler>();
            services.AddScoped<GetAboutByIdQueryHandler>();
            services.AddScoped<RemoveAboutCommandHandler>();
            services.AddScoped<UpdateAboutCommandHandler>();
            services.AddScoped<CreateAboutCommandHandler>();

            services.AddScoped<GetBannerQueryHandler>();
            services.AddScoped<GetBannerByIdQueryHandler>();
            services.AddScoped<RemoveBannerCommandHandler>();
            services.AddScoped<UpdateBannerCommandHandler>();
            services.AddScoped<CreateBannerCommandHandler>();

            services.AddScoped<GetBrandQueryHandler>();
            services.AddScoped<GetBrandByIdQueryHandler>();
            services.AddScoped<RemoveBrandCommandHandler>();
            services.AddScoped<UpdateBrandCommandHandler>();
            services.AddScoped<CreateBrandCommandHandler>();

            services.AddScoped<GetCarQueryHandler>();
            services.AddScoped<GetCarByIdQueryHandler>();
            services.AddScoped<RemoveCarCommandHandler>();
            services.AddScoped<UpdateCarCommandHandler>();
            services.AddScoped<CreateCarCommandHandler>();

            services.AddScoped<GetCategoryQueryHandler>();
            services.AddScoped<GetCategoryByIdQueryHandler>();
            services.AddScoped<RemoveCategoryCommandHandler>();
            services.AddScoped<UpdateCategoryCommandHandler>();
            services.AddScoped<CreateCategoryCommandHandler>();

            services.AddScoped<GetContactQueryHandler>();
            services.AddScoped<GetContactByIdQueryHandler>();
            services.AddScoped<RemoveContactCommandHandler>();
            services.AddScoped<UpdateContactCommandHandler>();
            services.AddScoped<CreateContactCommandHandler>();

        }
    }
}

