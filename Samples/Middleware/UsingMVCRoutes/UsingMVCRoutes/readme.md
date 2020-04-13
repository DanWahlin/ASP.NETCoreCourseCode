## Instructions

1. Run the project in Visual Studio (using the Kestrel server - NOT IIS Express) or using `dotnet watch run`
2. Visit http://localhost:8000 and see that the view renders
3. Open the `Controllers/HomeController.cs` file and uncomment the `throw` line of code
4. Go back to the browser and refresh the page. You should see the custom exception handling code
from `Startup.cs` is run and a custom error is displayed.

Note: `Properties/launchSettings.json` is setting the runtime environment to `Production` for Kestrel