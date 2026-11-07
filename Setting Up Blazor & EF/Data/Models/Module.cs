using System.ComponentModel.DataAnnotations;

namespace Setting_Up_Blazor___EF.Data.Models
{
    public class Module
    {

        [Key]
      
        public int ID { get; set; } 

        public string Code { get; set; }

        public string Title { get; set; } 




    }
}
