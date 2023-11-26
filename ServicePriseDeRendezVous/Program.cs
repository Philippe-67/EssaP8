using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configuration des services ici
        builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        string authority = builder.Configuration.GetSection("Authentication:Authority").Value;
        string audience = builder.Configuration.GetSection("Authentication:Audience").Value;

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = authority;
                options.RequireHttpsMetadata = true;
                options.Audience = audience;
            });

        builder.Services.AddAuthorization(options =>
        {
            options.AddPolicy("RequireAdminRole", policy =>
                policy.RequireRole("Admin"));

            // Ajoutez d'autres politiques ici
        });

        builder.Services.AddControllers();

        // Configuration Swagger
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "ServicePriseDeRendezVous API", Version = "v1" });
        });

        var app = builder.Build();

        // Utilisez le pipeline d'application
        app.UseAuthentication();
        app.UseAuthorization();

        // Configuration Swagger
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ServicePriseDeRendezVous API V1");
            });
        }

        app.UseHttpsRedirection();

        app.MapControllers();

        app.Run();
    }
}
