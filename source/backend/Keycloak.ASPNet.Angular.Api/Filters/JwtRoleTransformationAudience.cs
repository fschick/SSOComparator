﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Keycloak.ASPNet.Angular.Api.Filters;

/// <summary>
/// Transforms provider specific roles from audience to default role claims.
/// </summary>
/// <seealso cref="IClaimsTransformation" />
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global", Justification = "Instantiated via DI.")]
public class JwtRoleTransformationAudience : IClaimsTransformation
{
    private readonly string _audience;

    /// <summary>
    /// Initializes a new instance of the <see cref="JwtRoleTransformation"/> class.
    /// </summary>
    /// <param name="configuration">The configuration.</param>
    /// <autogeneratedoc />
    public JwtRoleTransformationAudience(IConfiguration configuration)
        => _audience = configuration.GetSection("JwtBearer").Get<JwtBearerOptions>().Audience;

    /// <summary>
    /// Provides a central transformation point to change the specified principal.
    /// Note: this will be run on each AuthenticateAsync call, so its safer to
    /// return a new ClaimsPrincipal if your transformation is not idempotent.
    /// </summary>
    /// <param name="principal">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> to transform.</param>
    /// <returns>
    /// The transformed principal.
    /// </returns>
    public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    {
        var result = principal.Clone();

        // TODO: Implement provider specific transformation here.

        return Task.FromResult(result);
    }
}