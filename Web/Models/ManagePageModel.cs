using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Web.Models;

public class ManagePageModel : PageModel
{
    public IConfiguration Configuration;
    public ManagePageModel(IConfiguration config)
    {
        Configuration = config;
    }
    [BindProperty]
    public int PageDataID { get; set; }
    [BindProperty]
    public string Title { get; set; } 
    public async Task<IActionResult> OnGetAsync(int id)
    {
        // using (var conn = new SqlConnection(Configuration.GetConnectionString("contentdb")))
        // {
        //     await conn.OpenAsync();
        //     var pages = await conn.QueryAsync("select * FROM PageData Where PageDataID = @p1", new { p1 = id });
        //     var page = pages.FirstOrDefault();
        //     this.Title = page.Title;
        //     this.PageDataID = page.PageDataID;
        // }
        return Page();
    }
    public async Task<IActionResult> OnPostAsync(int id)
    {
        if (ModelState.IsValid)
        {
            // try
            // {
            //     //Save to the database
            //     using (var conn = new SqlConnection(Configuration.GetConnectionString("contentdb")))
            //     {
            //         await conn.OpenAsync();
            //         await conn.ExecuteAsync("UPDATE PageData SET Title = @Title WHERE PageDataID = @PageDataID", new { PageDataID, Title });
            //     }
            // }
            // catch (Exception)
            // {
            //     //log it
            // }
            return RedirectToPage("/");
        }
        return Page();
    }
}