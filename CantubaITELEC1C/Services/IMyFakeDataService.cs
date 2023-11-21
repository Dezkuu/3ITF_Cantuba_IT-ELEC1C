using CantubaITELEC1C.Models;
namespace CantubaITELEC1C.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}