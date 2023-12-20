using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Kim_Salon_beauty.Pages.BookModel;

namespace Kim_Salon_beauty.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<ModelItem> ModelsList { get; set; } = new List<ModelItem>
        {
            new ModelItem{ModelName = "Dameklip", Price = 299},
            new ModelItem{ModelName = "Herreklip", Price = 299},
            new ModelItem{ModelName = "Børneklip", Price = 269}
        };
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
