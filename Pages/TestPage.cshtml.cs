using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class TestPageModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public TestPageModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string Message { get; private set; } = "PageModel in C#";

    public void OnGet()
    {
        Message += $" Server time is { DateTime.Now }";
    }
}
