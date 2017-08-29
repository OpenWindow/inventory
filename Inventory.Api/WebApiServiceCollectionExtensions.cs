using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Internal;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WebApiServiceCollectionExtensions
    {
        public static IMvcBuilder AddWebApi(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentException(nameof(services));

            var builder = services.AddMvcCore();
            builder.AddAuthorization();

            builder.AddFormatterMappings();

            builder.AddJsonFormatters();

            builder.AddCors();

            return new MvcBuilder(builder.Services, builder.PartManager);
        }

        public static IMvcBuilder AddWebApi(this IServiceCollection services, Action<MvcOptions> setupAction)
        {
            if (services == null) throw new ArgumentException(nameof(services));
            if (setupAction == null) throw new ArgumentException(nameof(setupAction));

            var builder = services.AddWebApi();
            builder.Services.Configure(setupAction);

            return builder;
        }
    }
}
