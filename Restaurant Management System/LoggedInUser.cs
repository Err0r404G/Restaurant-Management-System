namespace Restaurant_Management_System
{
    internal static class LoggedInUser
    {
        private static int userID;

        public static int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private static string username = "";

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        private static string fullName = "";

        public static string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private static string role = "";

        public static string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
