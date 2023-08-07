using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticketwebapp.Data.Services;
using Ticketwebapp.Models;

namespace Ticketwebapp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
 
            return View();
        }

        [HttpPost]
        //we have id property as well in actor now we will bind
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult>Details(int id)
        {
            var actorDetails = _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("Empty");
            else
            {
                return View(actorDetails);
            }
        }

    }
}
