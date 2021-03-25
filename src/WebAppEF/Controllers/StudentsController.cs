using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WebAppEF.Repositories;

namespace WebAppEF.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository _studentRepository;

        public StudentsController(ILogger<HomeController> logger, IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            // get students

            return View();
        }

        public IActionResult Student(int id)
        {
            // hardcoded tenant id (school id)
            var tenantId = 1;

            // get student by id
            var data = _studentRepository.GetStudentByIdAsync(tenantId, id);

            return View();
        }
    }
}
