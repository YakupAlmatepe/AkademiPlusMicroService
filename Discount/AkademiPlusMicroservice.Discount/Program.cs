using AkademiPlusMicroservice.Discount.Context;
using AkademiPlusMicroservice.Discount.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Reflection;

namespace AkademiPlusMicroservice.Discount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DapperContext>();
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddScoped<IDiscountCouponService, DiscountCouponService>();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddControllers();


            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.Authority = builder.Configuration["IdentityServerUrl"];
                opt.Audience = "resource_discount";
                opt.RequireHttpsMetadata = false;
            });


            builder.Services.AddDbContext<DapperContext>();
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddScoped<IDiscountCouponService, DiscountCouponService>();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddControllers(opt =>
            {
                //opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
            });

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