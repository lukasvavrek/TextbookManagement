﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TextbookManagement.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(
            this IServiceCollection services,
            IConfiguration configuration)
        {

            return services;
        }
    }
}