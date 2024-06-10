using ViewModels;

namespace Demo_App_1
{
     public static class StaticDb
    {
        public static List<UserViewModel> Users = new List<UserViewModel>()
        {
            new UserViewModel
            {
                Id = 1,
                FirstName = "Risto",
                LastName = "Panchevski"
            },
            new UserViewModel
            {
                Id = 2,
                FirstName = "Slave",
                LastName = "Ivanovski"
            },
        };
    }
}
