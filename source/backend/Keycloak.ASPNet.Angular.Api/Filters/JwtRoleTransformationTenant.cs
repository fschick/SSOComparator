using Microsoft.AspNetCore.Authentication;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Keycloak.ASPNet.Angular.Api.Filters;

/// <summary>
/// Transforms provider specific roles from tenant to default role claims.
/// </summary>
/// <seealso cref="IClaimsTransformation" />
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global", Justification = "Instantiated via DI.")]
public class JwtRoleTransformationTenant : IClaimsTransformation
{
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