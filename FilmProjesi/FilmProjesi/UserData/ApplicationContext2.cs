

using Entities.Models;

namespace FilmProjesi.UserData
{
    public class ApplicationContext2
    {
        public static List<User>Users { get; set; }

        static ApplicationContext2()
        {
            Users = new List<User>()
            {
                new User() { UserId=1,UserName="alidegirmenci",Password="123",Email="alideg41",Phone="5553108585"},
                new User() { UserId=2,UserName="emirturanali",Password="456",Email="turanali41",Phone="5553108586"},
                new User() { UserId=3,UserName="velidasn",Password="789",Email="velidasan43",Phone="5553108587"}
            };
        }
    }
}
