using System.Text.RegularExpressions;

namespace Domain.Helpers
{
    public class PasswordHandler
    {
        public static bool IsStrong(string password)
        {
            Regex regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

            return regex.IsMatch(password);
        }
    }
}
