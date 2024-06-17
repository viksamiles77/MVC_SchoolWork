using Class_05_DemoApp2.Models;

namespace Class_05_DemoApp2.Data
{
    public static class StaticDb
    {
        public static List<StudentViewModel> Students = new List<StudentViewModel>()
        {
            new StudentViewModel()
            {
                Id = 1,
                FirstName = "Viktor",
                LastName = "Mileski",
                Gender = 'M',
                Group = GroupEnum.G3
            }
        };
    }
}
