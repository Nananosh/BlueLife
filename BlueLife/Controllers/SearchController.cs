using AutoMapper;
using BlueLife.Business.Interfaces;
using BlueLife.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace BlueLife.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService searchService;
        private readonly IMapper mapper;

        public SearchController(ISearchService searchService, IMapper mapper)
        {
            this.searchService = searchService;
            this.mapper = mapper;
        }
        
        // GET
        public IActionResult Index(string query)
        {
            var medicines = searchService.SearchMedicineByQuery(query);
            return View(medicines);
        }
    }
}