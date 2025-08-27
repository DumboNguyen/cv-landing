using CV.BE;
using CV.BE.Infras;
using CV.BE.Repositories;
using CV.BE.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.Configure<IAppConfig>(builder.Configuration);
Func<IServiceProvider, AppConfig> appConfigFunc = x => x.GetRequiredService<IOptionsMonitor<AppConfig>>().CurrentValue;
builder.Services.AddScoped<IAppConfig>(appConfigFunc);

//var staticAppConfig = builder.Configuration.Get<AppConfig>();

builder.Services.AddScoped<IDatabaseContext>(x =>
{
    var appConfig = x.GetRequiredService<IAppConfig>();
    return new DatabaseContext(appConfig.DbConnectionString);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(staticAppConfig.DbConnectionString));

// repositories
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IPersonalRepository, PersonalRepository>();
builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<ISkillCategoryRepository, SkillCategoryRepository>();
builder.Services.AddScoped<IFeaturedProjectRepository, FeaturedProjectRepository>();
builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>();

// services
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IPersonalService, PersonalService>();
builder.Services.AddScoped<IEducationService, EducationService>();
builder.Services.AddScoped<IExperienceService, ExperienceService>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<ISkillCategoryService, SkillCategoryService>();
builder.Services.AddScoped<IFeaturedProjectService, FeaturedProjectService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
