using Microsoft.AspNetCore.Components;
using Radzen;

public partial class Home :  ComponentBase
{
    protected string? LoginMessage { get; set; }
    // protected void Login()
    
    protected async Task OnLogin(LoginArgs args)
    {
        if (args.Username == "admin" && args.Password == "password")
        {
            LoginMessage = "Login successful!";
        }
        else
        {
            LoginMessage = "Invalid username or password.";
        }

        await Task.CompletedTask;
    }
    
}