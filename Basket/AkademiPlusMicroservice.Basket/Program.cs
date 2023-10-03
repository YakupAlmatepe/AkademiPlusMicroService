using AkademiPlusMicroservice.Basket.Services;
using AkademiPlusMicroservice.Basket.Settings;
using AkademiPlusMicroService.Shared.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;

namespace AkademiPlusMicroservice.Basket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Remove("sub");

            // Add services to the container.

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.Authority = builder.Configuration["IdentityServerURL"];
                opt.Audience = "resource_basket";
                opt.RequireHttpsMetadata = false;
            });
            builder.Services.AddControllers(opt =>
            {
                opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
            });



            // redis i.in
            builder.Services.AddScoped<ISharedIdentityService,SharedIdentityService>();
            builder.Services.AddScoped<IBasketService,BasketService>();
            builder.Services.AddHttpContextAccessor();
            builder.Services.Configure<RedisSettings>(builder.Configuration.GetSection("RedisSettings"));
            builder.Services.AddSingleton<RedisService>(sp =>
            {
                var redisSettings = sp.GetRequiredService<IOptions<RedisSettings >> ().Value;
            //    var redis = new RedisService(redisSettings.Host, redisSettings.Port);
                redis.Connect();
                return redis;
            });
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}