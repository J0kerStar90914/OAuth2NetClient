using oauth2_test_epal.Models;
using System;
using System.Web;


namespace oauth2_test_epal
{
    public class DSUserService : IDSUserService
    {
        public bool CheckAccessToken(int bufferMin = 5)
        {
            return HttpContext.Current.User.Identity.IsAuthenticated
                && (DateTime.Now.Subtract(TimeSpan.FromMinutes(bufferMin)) < AppUser?.AccessExpireIn.Value);
        }

        public void Logout()
        {
            AppUser = null;
        }

        public DSAppUser AppUser { get; set; }
    }

}
