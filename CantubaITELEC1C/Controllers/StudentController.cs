﻿using Microsoft.AspNetCore.Mvc;
using CantubaITELEC1C.Models;


namespace CantubaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Dusk",LastName = "Cantuba", IsRegular = IsRegular.Conditional, Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), Email = "duskdenilson.cantuba.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 2,FirstName = "Dawn",LastName = "Cantuba", IsRegular = IsRegular.Irregular, Course = Course.OTHER, AdmissionDate = DateTime.Parse("2022-08-07"), Email = "dawnverosh.cantuba.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 3,FirstName = "Richelle",LastName = "Cantuba", IsRegular = IsRegular.Regular, Course = Course.OTHER, AdmissionDate = DateTime.Parse("2020-01-25"), Email = "richelle.cantuba.cics@ust.edu.ph"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }
    }
}