var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerGen(options =>
{
    foreach (System.Reflection.FieldInfo fileld in typeof(test.Controllers.ApiVersionInfo).GetFields())
    {
        options.SwaggerDoc(fileld.Name, new Microsoft.OpenApi.Models.OpenApiInfo
        {
            Version = fileld.Name,
            Title = "API±êÌâ",
            Description = $"APIÃèÊö,{fileld.Name}°æ±¾"
        });
    }
    var xmlFilename = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        foreach (System.Reflection.FieldInfo field in typeof(test.Controllers.ApiVersionInfo).GetFields())
        {
            c.SwaggerEndpoint($"/swagger/{field.Name}/swagger.json", $"{field.Name}");
        }
    });
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();