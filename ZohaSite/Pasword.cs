using System.Security.Cryptography;
namespace ZohaSite
{
    public static class Pasword
    {
        private static bool IsUserPassValid( string Pass, string Passfromuser)
        {
          
                return BCrypt.Net.BCrypt.Verify(Pass, Passfromuser);
 
        }

        private static string MakeHash(string Pass)
        {

            return BCrypt.Net.BCrypt.HashPassword(Pass, BCrypt.Net.BCrypt.GenerateSalt());

        }

    }
}
