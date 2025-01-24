using Keycloak.ASPNet.Angular.Api.Filters;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;

namespace Keycloak.ASPNet.Angular.Api.Startup;

/// <summary>
/// Startup code to register authorization related stuff.
/// </summary>
internal static class AuthorizationStartup
{
    /// <summary>
    /// Register authorization related services.
    /// </summary>
    /// <param name="services">The services to act on.</param>
    public static void AddAuthorization(this IServiceCollection services)
    {
        services.AddSingleton<JwtRoleTransformationTenant, JwtRoleTransformationTenant>();
        services.AddSingleton<JwtRoleTransformationAudience, JwtRoleTransformationAudience>();
        services.AddSingleton<IClaimsTransformation, JwtRoleTransformation>();
    }

    /// <summary>
    /// Adds authorization to OpenAPI UI.
    /// </summary>
    /// <param name="options">The options to act on.</param>
    /// <param name="configuration">The application configuration.</param>
    public static void AddAuthorization(this SwaggerUIOptions options, IConfiguration configuration)
    {
        var clientId = configuration
            .GetSection("Swagger")
            .GetValue<string>("ClientId");

        var audience = configuration
            .GetSection("JwtBearer")
            .GetValue<string>("Audience");

        var scopes = configuration
            .GetSection("Swagger")
            .GetValue<string>("Scopes")?
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            ?? [];

        options.OAuthClientId(clientId);
        options.OAuthScopes(scopes);
        options.OAuthUsePkce();
        options.OAuthAdditionalQueryStringParams(new Dictionary<string, string>() { ["audience"] = audience });
        options.EnablePersistAuthorization();
    }
}