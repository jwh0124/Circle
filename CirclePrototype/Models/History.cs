using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CirclePrototype.Models
{
    [Table("tbl_histories")]
    public class History
    {
        [Key]
        public int Id {get; set;}

        public string UserName {get; set;}
    }
}