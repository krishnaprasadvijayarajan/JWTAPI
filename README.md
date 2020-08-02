# JWTAPI
Code based on below:

https://www.yogihosting.com/jwt-api-aspnet-core/#api-project  

From nuget, Add "Microsoft.AspNetCore.Authentication.JwtBearer"

File: Startup.cs
ConfigureServices() :
services.AddControllers();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options => 
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = true;
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience=true,
                    ValidAudience= "https://github.com/krishnaprasadvijayarajan",
                    ValidIssuer= "https://github.com/krishnaprasadvijayarajan",
                    IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MyFirstJWTAuthentication20200802"))
                };
            });
            

Configure():
app.useAuthentication()
app.useAuthorization()

File: Controller
Add [Authorize] attribute
