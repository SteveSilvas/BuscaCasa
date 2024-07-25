using System.Text.RegularExpressions;

namespace Domain.Helpers
{
    public class EmailHandler
    {
        public static bool IsValid(string email)
        {
            if (string.IsNullOrEmpty(email)) 
                return false;

            string regex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, regex);
        }
    }
}
