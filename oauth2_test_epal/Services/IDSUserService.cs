using oauth2_test_epal.Models;

namespace oauth2_test_epal
{
    public interface IDSUserService
    {
        DSAppUser AppUser { get; set; }
        bool CheckAccessToken(int bufferMin);
        void Logout();
    }

}
