using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApi.Models
{
    public class Work
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string Duration { get; set; }

        public String EmployeeID { get; set; }

        public int point { get; set; } = 0;

        public string Description { get; set; }

        public String Statut { get; set; } = " not done";

    }


}
