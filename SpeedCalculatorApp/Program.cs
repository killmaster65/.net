var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
// Map route for SpeedFunctionController
app.MapControllerRoute(
    name: "SpeedFunction",
    pattern: "speed/{function}/{*any}", // Use {*any} for remaining segments
    defaults: new { controller = "SpeedFunction", action = "calculateSpeed" }
);
app.MapControllerRoute(
    name: "Velocity",
    pattern: "Home/{function}/{*any}", // Use {*any} for remaining segments
    defaults: new { controller = "Home", action = "VelocityResults" }
);

app.Run();
