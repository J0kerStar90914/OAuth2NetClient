using System.Collections.Generic;

namespace oauth2_test_epal.Models
{
    public class DSUserInfo
    {
        public string Sub { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Account> Accounts { get; set; }
    }
}