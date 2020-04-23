using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The items of the order 
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// Gets and sets the search terms
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Gets and sets the minimium price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Gets and sets the maximum price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// Gets and sets the minimium Calories
        /// </summary>
        [BindProperty]
        public double? CaloriesMin { get; set; }

        /// <summary>
        /// Gets and sets the maximum Calories
        /// </summary>
        [BindProperty]
        public double? CaloriesMax { get; set; }

        /// <summary>
        /// Gets and sets the type of item
        /// </summary>
        [BindProperty]
        public string[] Types { get; set; }

        public void OnGet(double? PriceMin, double? PriceMax, double? CaloriesMin, double? CaloriesMax)
        {
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            this.CaloriesMax = CaloriesMax;
            this.CaloriesMin = CaloriesMin;
            SearchTerms = Request.Query["SearchTerms"];
            Types = Request.Query["Types"];
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByType(Items, Types);
        }
    }
}
