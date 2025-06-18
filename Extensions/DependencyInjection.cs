using ExpenseTracker.Repository.Generic;
using ExpenseTracker.Repository.UnitOfWork;

namespace ExpenseTracker.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
