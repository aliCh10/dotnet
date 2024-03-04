using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace firstApp.Models
{
    public class Movie
    {
        public Movie() { }
      public  int id  { get; set; }
        [Required(ErrorMessage ="name failed is required")]

        public string name { get;set; }
        
        public DateTime date { get;set; }
        public bool withsubtitles { get;set; }
        public Movie(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
    }
  
   
}
