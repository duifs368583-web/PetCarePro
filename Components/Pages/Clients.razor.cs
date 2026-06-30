using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace PetCarePro.Components.Pages;

public partial class Clients: ComponentBase
{
    public int Id { get; set; }
    private static string Name { get; set; } = "";
    private string Address { get; set; } = "";
    private string Zipcode { get; set; } = "";
    private string City { get; set; } = "";
}

{
private List<Clients>? clients;

protected override async Task OnInitializedAsync()
{       
    Clients = await DbContext.Clients.ToListAsync();
}
}
