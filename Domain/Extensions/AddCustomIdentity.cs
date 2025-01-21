using eticaret.Domain.Database.Context;
using eticaret.Domain.Entities.Users;
using eticaret.Domain.ErrorTr;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace eticaret.Domain.Extensions
{
    public static class AddCustomIdentity
    {
        public static void IdentityAdd(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>()
            .AddDefaultTokenProviders()
            .AddUserValidator<CustomUserValidator>()
            .AddErrorDescriber<CustomIdentityErrorDescriber>()
            .AddRoleValidator<CustomRoleValidator>()
            .AddPasswordValidator<CustomPasswordValidator>()
            .AddDefaultTokenProviders()
            .AddEntityFrameworkStores<CommerceContext>();

            services.Configure<SecurityStampValidatorOptions>(opt =>
            {
                opt.ValidationInterval = TimeSpan.FromMinutes(10);
            });

            services.Configure<IdentityOptions>(opt =>
            {
                opt.SignIn.RequireConfirmedEmail = false;
                opt.SignIn.RequireConfirmedPhoneNumber = false;
                opt.SignIn.RequireConfirmedAccount = false;

                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredLength = 6;
                opt.Password.RequiredUniqueChars = 1;

                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                opt.Lockout.MaxFailedAccessAttempts = 3;
                opt.Lockout.AllowedForNewUsers = true;

                opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";
                opt.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(cookie =>
            {
                cookie.LoginPath = new PathString("/login");
                cookie.LogoutPath = new PathString("/outsign");
                cookie.AccessDeniedPath = new PathString("/erisim");
                cookie.Cookie = new CookieBuilder
                {
                    Name = "serkantoy",
                    HttpOnly = true
                };
                cookie.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                cookie.SlidingExpiration = true;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();//.AddBearerToken();
        }
    }
}
