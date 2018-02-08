namespace AspServerAngularTest.Models
{
    public class Donger
    {
        public int DongerId { get; set; }
        public string Location { get; set; }
        public string Locale { get; set; }
        public string Gender { get; set; }
        public string IdentityId { get; set; } // ForeginKey id

        // Navigation prop
        public ApplicationUser  Identity { get; set; } 
    }
}