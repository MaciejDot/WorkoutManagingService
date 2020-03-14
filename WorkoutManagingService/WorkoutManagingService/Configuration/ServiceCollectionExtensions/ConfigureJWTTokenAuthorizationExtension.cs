using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace WorkoutManagingService.Configuration.ServiceCollectionExtensions
{
    public static class ConfigureJWTTokenAuthorizationExtension
    {
        public static IServiceCollection ConfigureJWTTokenAuthorization(this IServiceCollection services, string tokenServiceAddress) {
            var request = new RestRequest(tokenServiceAddress, Method.GET);
            var parameters = new RestClient().Execute<RSAPublicParameters>(request).Data;
            var rsa = RSA.Create(new RSAParameters
            {
                Exponent = Convert.FromBase64String(parameters.Exponent),
                Modulus = Convert.FromBase64String(parameters.Modulus)
            });
            services
                .AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new RsaSecurityKey(rsa),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            return services;
        }
    }
}
