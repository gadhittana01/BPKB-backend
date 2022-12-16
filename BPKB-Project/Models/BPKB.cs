using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPKB_Project.Models
{
	public class BPKB
	{
        [Key]
        [Required(ErrorMessage = "Agreement Number mustn't be empty")]
        [Column("agreement_number")]
        public string AgreementNumber { get; set; }

        [Required(ErrorMessage = "BPKB no mustn't be empty")]
        [Column("bpkb_no")]
        public string BPKBNo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Branch ID musn't be empty")]
        [Column("branch_id")]
        public string BranchID { get; set; } = string.Empty;

        [Required(ErrorMessage = "BPKB Date musn't be empty")]
        [Column("bpkb_date")]
        public DateTime BPKBDate { get; set; }

        [Required(ErrorMessage = "Faktur No musn't be empty")]
        [Column("faktur_no")]
        public string FakturNo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Faktur Date musn't be empty")]
        [Column("faktur_date")]
        public DateTime FakturDate { get; set; }

        [ForeignKey("LocationFK")]
        public Location? Location { get; set; }

        [Required(ErrorMessage = "Location musn't be empty")]
        [Column("location_id")]
        public string LocationFK { get; set; } = string.Empty;

        [Required(ErrorMessage = "Police No musn't be empty")]
        [Column("police_no")]
        public string PoliceNo { get; set; } = string.Empty;

        [Required(ErrorMessage = "BPKB Date In No musn't be empty")]
        [Column("bpkb_date_in")]
        public DateTime BPKBDateIn { get; set; }
    }
}

