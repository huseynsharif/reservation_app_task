using ReservationSystem.entitites;

namespace ReservationSystem.business
{
    internal class UserManager
    {

        public bool Login(User user)
        {
            return user.Username.Equals("admin") && user.Password.Equals("12345678");
        }

    }
}
