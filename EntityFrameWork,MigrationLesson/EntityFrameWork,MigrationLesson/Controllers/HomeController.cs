﻿using EntityFrameWork_MigrationLesson.Data;
using EntityFrameWork_MigrationLesson.Models;
using EntityFrameWork_MigrationLesson.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork_MigrationLesson.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderDetail detail = await _context.SliderDetails.FirstOrDefaultAsync();

            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Detail = detail
            };
            return View(homeVM);
        }
    }
}
