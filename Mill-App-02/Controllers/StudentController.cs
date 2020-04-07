using DataAccess;
using DataAccess.DbContexts;
using DataAccess.DBEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mill_App_02.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _studentRepository;
        private readonly IConfiguration _config;
        private readonly StudentContext _studentContext;
        public StudentController(IConfiguration config,IStudent studentRepository, StudentContext studentContext)
        {
            _studentRepository = studentRepository;
            _config = config;
            _studentContext = studentContext;
        }

        public IActionResult Index()
        {
            var result = _studentRepository.GetAllStudent();
            return View("Index",result);
        }
        public IActionResult StudentByEF()
        {
            // FromSqlRaw   OR FromSqlInterpolated  
            var result = _studentContext.StudentEntities
                                         .FromSqlRaw<StudentEntity>("GetStudentByID {0}", 1);
                                         
            return View("Index", result);
        }
    }
}
