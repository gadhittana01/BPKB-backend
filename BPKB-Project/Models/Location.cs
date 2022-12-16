using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPKB_Project.Models
{
	public class Location
	{
		[Key]
        [Required(ErrorMessage = "Location ID mustn't be empty")]
        [Column("location_id")]
        public string LocationID { get; set; } = string.Empty;

        [Required(ErrorMessage = "Location Name mustn't be empty")]
        [Column("location_name")]
        public string LocationName { get; set; } = string.Empty;

    }
}

