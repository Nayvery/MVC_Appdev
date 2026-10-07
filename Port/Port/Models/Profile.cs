namespace Port.Models
{
    public class Profile
    {
        public string LastName{ get; set; }
        public string FirstName{ get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string address { get; set; }


        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }

    }
}
