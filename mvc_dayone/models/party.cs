namespace mvc_dayone.models
{
    public static class party
    {
        private static List<members> member = new List<members>();
        public static List<members> Member { get => member; }

        public static void addmembers(members members)
        {
            member.Add(members);
        }
    }
}
