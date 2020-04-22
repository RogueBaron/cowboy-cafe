using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {

        /// <summary>
        /// The movies to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> items { get; protected set; } = Menu.CompleteMenu();

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The filtered type of food
        /// </summary>
        [BindProperty]
        public string[] FoodType { get; set; }

        /// <summary>
        /// The minimum price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// The minimum calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet(double? PriceMin, double? PriceMax, int? CaloriesMin, int? CaloriesMax)
        {
            // Nullable conversion workaround
            SearchTerms = Request.Query["SearchTerms"];
            FoodType = Request.Query["FoodType"];
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            items = Menu.Search(items, SearchTerms);
            items = Menu.FilterByCategory(items, FoodType);
            items = Menu.FilterByCalories(items, CaloriesMin, CaloriesMax);
            items = Menu.FilterByPrice(items, PriceMin, PriceMax);
        }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
    }
}
