using System.Security.Cryptography;

namespace ZohaSite
{
    public static class Paswordd
    {
        public static bool IsUserPassValid(string Pass, string Passfromuser)
        {

            return BCrypt.Net.BCrypt.Verify(Pass, Passfromuser);

        }

        public static string MakeHash(string Pass)
        {

            return BCrypt.Net.BCrypt.HashPassword(Pass, BCrypt.Net.BCrypt.GenerateSalt());

        }

    }
}
