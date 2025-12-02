using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tailor.Business.Abstract;
using Tailor.Business.Concrete;
using Tailor.Business.Mapping;

using Tailor.DataAccess.Abstract;
using Tailor.DataAccess.Concrete;
using Tailor.DataAccess.Context; // ApplicationDbContext için namespace
using Tailor.Entity.Entities; // AppUser için namespace

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------------
// 1. AUTOMAPPER KAYDI
// ---------------------------------------------------------
// Business katmanýndaki MapProfile sýnýfýný tarayýp sisteme kaydeder.
builder.Services.AddAutoMapper(typeof(MapProfile));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// 2. Identity (Kullanýcý Yönetimi) Ayarlarýný Ekle
builder.Services.AddIdentity<AppUser, IdentityRole<int>>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

//Dependency Injection(DI) Container kayýtlarýnýn tanýmlanmasý ve eklenmesi
builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IOrderDal, EfOrderDal>();
builder.Services.AddScoped<IShipmentDal, EfShipmentDal>();
builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<IBlogDal, EfBlogDal>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ISupportTicketDal, EfSupportTicketDal>();
builder.Services.AddScoped<IAddressDal, EfAddressDal>();
builder.Services.AddScoped<IContactMessageDal, EfContactMessageDal>();


// B. Business Katmaný (YENÝ - Arkadaþlar buraya kendi managerlarýnýzý ekliyeceksiniz)
// Generic Service Kaydý (Önemli!):
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

// ÖZEL MANAGERLAR (Örnek: Ýleride ProductManager yazýlýnca buraya eklenecek)
// örnek olsun diye yorum satýrý olarak býraktým .
// builder.Services.AddScoped<IProductService, ProductManager>();
// builder.Services.AddScoped<ICategoryService, CategoryManager>();

// ---------------------------------------------------------
// 3. CORS AYARLARI (Frontend Eriþimi Ýçin)
// ---------------------------------------------------------
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowAnyOrigin(); // Güvenlik için canlýya alýrken buraya sadece frontend URL'i yazýlýr.
        });
});

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
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
