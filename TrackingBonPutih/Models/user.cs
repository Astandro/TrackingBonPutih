//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackingBonPutih.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class user
    {
        [Required(ErrorMessage="Masukan NPK Anda!")]
        public int NPK { get; set; }
        public string nama { get; set; }
        public string bagian { get; set; }
        public string photo { get; set; }
        [Required(ErrorMessage = "Masukan Password Anda!")]
        public string PASS { get; set; }
        public string LEVEL { get; set; }
        public int ID_DEP { get; set; }
        public int FLAG_USER { get; set; }
        public string STATUS { get; set; }


    }
}
