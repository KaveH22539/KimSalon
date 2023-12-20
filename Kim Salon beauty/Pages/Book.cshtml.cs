using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kim_Salon_beauty.Pages
{
    public class BookModel : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPost()
        {

        }

        public class BookingModel
        {
            public string Date { get; set; } = DateTime.UtcNow.ToString("yyyy-MM-dd");
            public string Time { get; set; } = "10:00AM";
            public string ServiceType { get; set; } = "Haircut";
            public CustomerModel Customer { get; set; } = new CustomerModel();
            public string Status { get; set; } = "pending";
        }

        public class CustomerModel
        {
            public string Name { get; set; } = "";
            public string Contact { get; set; } = "";
        }

        public BookingModel Booking { get; set; } = new BookingModel();

        public List<ModelItem> ModelsList { get; set; } = new List<ModelItem>();

        public class ModelItem
        {
            public string ModelName { get; set; } = "";
            public decimal Price { get; set; } = new decimal();
        }
    }
}