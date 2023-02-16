using Application.Common.Interfaces;
using CalmSalesSouce.Services;
using CleanArchitecture.WebUI.Filters;
using FluentValidation.AspNetCore;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace CalmSalesSouce
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddCalmConfigureServices(this IServiceCollection services)
        {
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddSingleton<ICurrentUserService, CurrentUserService>();
            services.AddHttpContextAccessor();

            services.AddHealthChecks()
                .AddDbContextCheck<ApplicationDbContext>();

            services.AddRazorPages();

            // Customise default API behaviour
            services.Configure<ApiBehaviorOptions>(options =>
                options.SuppressModelStateInvalidFilter = true);


            return services;
        }
    }

}