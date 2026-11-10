using Kerem.Flashcards.Domain.Interfaces;
using Kerem.Flashcards.Features;
using Kerem.Flashcards.Infrastructure.Persistence;
using Kerem.Flashcards.Infrastructure.Repositories;
using Kerem.Flashcards.UI;
using Microsoft.Extensions.DependencyInjection;

namespace Kerem.Flashcards;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, string connectionString)                                                                                                            
        {               
            services.AddSingleton(new DapperDbContext(connectionString));
            services.AddSingleton<IFlashcardRepository, FlashcardRepository>();
            services.AddSingleton<CreateFlashcard>();
            services.AddSingleton<FindAllFlashcards>();
            services.AddSingleton<ConsoleMenu>();
            return services;
        }   
    }