using System;
using System.Collections.Generic;

namespace ITI_DAL.Models
{
    public partial class Applicate
    {
        public double? Rank1 { get; set; }
        public double? RegNumber { get; set; }
        public string? ApplicantName { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? Gender { get; set; }
        public string? Category { get; set; }
        public string? LocalStatus { get; set; }
        public string? IsPh { get; set; }
        public string? Isexg { get; set; }
        public string? Isorphan { get; set; }
        public string? Religion { get; set; }
        public string? Qualification { get; set; }
        public string? QualificationBoard { get; set; }
        public double? FinalGp { get; set; }
        public double? Maths { get; set; }
        public double? Science { get; set; }
        public double? Social { get; set; }
        public double? ThiLang { get; set; }
        public double? FirLang { get; set; }
        public double? SecLang { get; set; }
        public DateTime? Dob { get; set; }
        public string? ApprovedByVoname { get; set; }
        public string? ApprovedByVocode { get; set; }
        public double? VomobileNo { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public int? QulificationNo { get; set; }
        public string? AllocatedIticode { get; set; }
        public string? AllocatedTrade { get; set; }
        public string? AllocatedCategory { get; set; }
        public int? OptionSlNo { get; set; }
        public string? IsEws { get; set; }
    }
}
