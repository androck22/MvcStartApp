using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IUserRequestRepository _repo;

        public RequestsController(IUserRequestRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Logs()
        {
            var requests = await _repo.GetRequests();
            return View(requests);
        }
    }
}
