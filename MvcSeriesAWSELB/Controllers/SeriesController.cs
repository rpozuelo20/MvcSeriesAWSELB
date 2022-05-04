using Microsoft.AspNetCore.Mvc;
using MvcSeriesAWSELB.Models;
using MvcSeriesAWSELB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSeriesAWSELB.Controllers
{
    public class SeriesController : Controller
    {
        private RepositorySeries repo;
        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Serie> series = this.repo.GetSeries();
            return View(series);
        }
        public IActionResult Serie(int id)
        {
            Serie serie = this.repo.FindSerie(id);
            return View(serie);
        }
    }
}
