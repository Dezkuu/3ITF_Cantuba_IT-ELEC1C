using CantubaITELEC1C.Models;
using CantubaITELEC1C.Services;

namespace CantubaITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }

        public MyFakeDataService()//constructor
        {
            StudentList = new List<Student>
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

            InstructorList = new List<Instructor>
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
        }
    }
}