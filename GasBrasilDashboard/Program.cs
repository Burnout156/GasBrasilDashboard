using GasBrasilDashboardBiblioteca.Data_Access_Layer;


var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

builder.Services.AddOptions();

// Add services to the container.
builder.Services.AddControllersWithViews();


/*builder.Services.AddDbContext<TB_FATURAMENTO_CONTEXT>
    (options => options.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=GasBrasilDashboardDB;Integrated Security=SSPI;"));

builder.Services.AddDbContext<TB_CADASTRO_BRUTO_CONTEXT>
    (options => options.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=GasBrasilDashboardDB;Integrated Security=SSPI;"));*/

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


app.Run();
