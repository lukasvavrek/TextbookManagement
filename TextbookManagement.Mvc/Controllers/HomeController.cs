using System.Diagnostics;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TextbookManagement.Core.Scenarios.Books.Queries;
using TextbookManagement.Core.Scenarios.Orders.Queries;
using TextbookManagement.Mvc.Models;

namespace TextbookManagement.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(
            ILogger<HomeController> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _mediator.Send(GetOrdersByUserIdQuery.Empty());
            var textbooks = await _mediator.Send(GetAllTextbooksQuery.Empty());
            var viewModel = IndexViewModel.Create(orders, textbooks);
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}