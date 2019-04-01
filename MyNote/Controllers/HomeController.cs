using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyNote.Models;
using MyNote.Services;

namespace MyNote.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoteServices _noteService;

        public HomeController(INoteServices noteService)
        {
            _noteService = noteService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNote(Note note)
        {
            if (ModelState.IsValid)
            {
                _noteService.AddNote(note);
                return RedirectToAction(nameof(List));
            }
            return View();
        }

        public IActionResult DeleteNote(int? id)
        {
            if (ModelState.IsValid)
            {
                _noteService.DeleteNote(id);
                return RedirectToAction(nameof(List));
            }
            return View();
        }

        public IActionResult List()
        {
            return View(_noteService.Notes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
