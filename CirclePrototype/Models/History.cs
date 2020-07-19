using System.ComponentModel.DataAnnotations;

namespace CirclePrototype.Models
{
    public class History
    {
        [Key]
        public int Id {get; set;}

        public string UserName {get; set;}
    }
}