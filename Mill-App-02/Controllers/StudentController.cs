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
using Mill_App_02.Models;

namespace Mill_App_02.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _studentRepository;
        private readonly IConfiguration _config;
        private readonly StudentContext _studentContext;
        public StudentController(IConfiguration config, IStudent studentRepository, StudentContext studentContext)
        {
            _studentRepository = studentRepository;
            _config = config;
            _studentContext = studentContext;
        }

        public IActionResult Index()
        {
            var result = _studentRepository.GetAllStudent();


            return View("Index", result);
        }
        public IActionResult StudentByEF()
        {
            // FromSqlRaw   OR FromSqlInterpolated  
            var result = _studentContext.StudentEntities
                                         .FromSqlRaw<StudentEntity>("GetStudentByID {0}", 1);
            List<StudentVM> listOfStudents = new List<StudentVM>();
            foreach (var item in result)
            {
                listOfStudents.Add(
                    new StudentVM()
                    {
                        Id = item.Id,
                        Age = item.Age,
                        Class = item.Class,
                        Name = item.Name

                    });
            }

            StudentVM studentVm = new StudentVM();
            
            ViewBag.DropDownList = listOfStudents;

            // Set your Employee dropdown
            ViewBag.DropdownForEmployee = populateStudentDropDownValue();

            var studentVM = new StudentVM();
            studentVM.StudentList = listOfStudents;
            return View("Index", studentVM);

        }

        private List<StudentVM> populateStudentDropDownValue()
        {
            List<StudentVM> listofStudent= new  List<StudentVM>();

            listofStudent.Add(new StudentVM()
            {
                 Id = 1,
                 Name = "Somesh"


            });
            listofStudent.Add(new StudentVM()
            {
                Id = 2,
                Name = "Shane"


            });
            return listofStudent;

        }

    }
}
