using Microsoft.AspNetCore.Mvc;
using CantubaITELEC1C.Models;
using CantubaITELEC1C.Services;

namespace CantubaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _dummyData;

        public InstructorController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }


        public IActionResult Index()
        {

            return View(_dummyData.InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

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
            _dummyData.InstructorList.Add(newInstructor);
            return View("Index", _dummyData.InstructorList);
        }


        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == instructorChanges.Id);

            if (instructor != null)
            {
                instructor.FirstName = instructorChanges.FirstName;
                instructor.LastName = instructorChanges.LastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.Rank = instructorChanges.Rank;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.Email = instructorChanges.Email;
            }
            return View("Index", _dummyData.InstructorList);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Instructor newInstructor)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == newInstructor.Id);

            if (instructor != null)//was an instructor found?
                _dummyData.InstructorList.Remove(instructor);
            return View("Index", _dummyData.InstructorList);
        }
    }
}