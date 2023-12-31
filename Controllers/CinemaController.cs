﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticketwebapp.Data;

namespace Ticketwebapp.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _context;

        //constructor
        public CinemaController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allCinema = await _context.Cinemas.ToListAsync();
            return View(allCinema);
        }
    }
}
