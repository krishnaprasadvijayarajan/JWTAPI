# JWTAPI
Code based on below:

https://www.yogihosting.com/jwt-api-aspnet-core/#api-project  

From nuget, Add "Microsoft.AspNetCore.Authentication.JwtBearer"

File: Startup.cs
ConfigureServices() :
Add AddAuthentication()
Use the secret key for AddJwtBearer()

Configure():
app.useAuthentication()
app.useAuthorization()

File: Controller
Add [Authorize] attribute
