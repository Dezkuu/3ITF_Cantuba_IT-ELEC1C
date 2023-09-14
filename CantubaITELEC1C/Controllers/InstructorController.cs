using Microsoft.AspNetCore.Mvc;
using CantubaITELEC1C.Models;


namespace CantubaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Dusk",LastName = "Cantuba", IsTenured = IsTenured.Probationary, Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-26"), Email = "duskdenilson.cantuba.cics@ust.edu.ph"
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Dawn",LastName = "Cantuba", IsTenured = IsTenured.Permanent, Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2022-08-07"), Email = "dawnverosh.cantuba.cics@ust.edu.ph"
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Richelle",LastName = "Cantuba", IsTenured = IsTenured.Permanent, Rank = Rank.Professor, HiringDate = DateTime.Parse("2020-01-25"), Email = "richelle.cantuba.cics@ust.edu.ph"
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }
    }
}