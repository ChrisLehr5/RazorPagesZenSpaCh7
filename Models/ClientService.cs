using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models
{
    public class ClientService
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ClientID")]
        public int ClientID { get; set; }
        [ForeignKey("ServicesID")]
        public int ServicesID { get; set; }
        public Services Services { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Contact email")]
        public DateTime Date { get; set; }
    }
}
