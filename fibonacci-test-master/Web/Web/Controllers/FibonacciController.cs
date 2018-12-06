using System.Web.Mvc;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class FibonacciController : Controller
    {
        private readonly IFibonacciService _service;

        public FibonacciController(IFibonacciService service)
        {
            _service = service;
        }

        public FibonacciController()
        {
            _service = new FibonacciService();
        }

        public ActionResult Index(int number = 10)
        {
            var viewModel = new FibonacciViewModel
            {
                Results = _service.GenerateFibonacciSequence(number),
                NumberRequested = number
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult GenerateFibonacciSequence(FibonacciViewModel model)
        {
            var viewModel = new FibonacciViewModel
            {
                Results = _service.GenerateFibonacciSequence(model.NumberRequested),
                NumberRequested = model.NumberRequested
            };
            return View("Index", viewModel);
        }
    }
}