/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using static AspNet.Security.OAuth.Clever.CleverAuthenticationConstants;

namespace AspNet.Security.OAuth.Clever
{
    /// <summary>
    /// Defines a set of options used by <see cref="CleverAuthenticationHandler"/>.
    /// </summary>
    public class CleverAuthenticationOptions : OAuthOptions
    {
        public CleverAuthenticationOptions()
        {
            ClaimsIssuer = CleverAuthenticationDefaults.Issuer;
            CallbackPath = CleverAuthenticationDefaults.CallbackPath;

            AuthorizationEndpoint = CleverAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = CleverAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = CleverAuthenticationDefaults.UserInformationEndpoint;

            Scope.Add("profile");

            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "encodedId");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "displayName");
            ClaimActions.MapJsonKey(Claims.Avatar, "avatar");
            ClaimActions.MapJsonKey(Claims.Avatar150, "avatar150");
        }
    }
}
