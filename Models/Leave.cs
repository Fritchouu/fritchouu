using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Leave
    {
        public Leave() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CongeId { get; set; }
        public String EmployeeID { get; set; }
        public string StartingDate { get; set; }
        public string EndingDate { get; set; }
        public string Type { get; set; }
        public string Duration { get; set; }
        public string Cause { get; set; }

        public string Sold { get; set; }

        public string Statut { get; set; } = "Pending";



    }
}