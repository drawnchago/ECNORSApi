using ECNORSApi.Config;
using ECNORSApi.Factories;
using ECNORSAppData.Data.Config;
using ECNORSAppData.Services;

var builder = WebApplication.CreateBuilder(args);

// ================= SERVICES =================

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuración de estaciones desde appsettings.json
builder.Services.Configure<StationsOptions>(builder.Configuration);

// Factory para DbContext por estación
builder.Services.AddSingleton<IStationDbFactory, StationDbFactory>();
builder.Services.AddSingleton<IConnectionSelector, ConnectionSelector>();
builder.Services.AddScoped<SelectedConnectionState>();
builder.Services.AddScoped<ICloseLoadService, CloseLoadService>();
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(p =>
        p.AllowAnyOrigin()
         .AllowAnyHeader()
         .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors();
// ================= MIDDLEWARE =================

// Swagger SIEMPRE habilitado (útil para IIS y pruebas)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ECNORS API v1");
    c.RoutePrefix = "swagger"; // https://host/swagger
});

app.Use(async (ctx, next) =>
{
    var station = ctx.Request.Query["station"].ToString();
    if (string.IsNullOrWhiteSpace(station))
        station = ctx.Request.Headers["X-Station"].ToString();

    var state = ctx.RequestServices.GetRequiredService<SelectedConnectionState>();
    state.SetSelectedName(station);

    await next();
});


//app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
