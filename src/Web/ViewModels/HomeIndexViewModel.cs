using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Web.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Brands { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public PaginationViewModel PaginationInfo { get; set; }
    }
}
