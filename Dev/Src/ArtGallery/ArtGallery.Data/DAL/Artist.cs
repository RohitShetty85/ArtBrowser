//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtGallery.Data.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artist
    {
        public int Artist_ID { get; set; }
        public string User_ID { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Profile_Pic { get; set; }
        public string Cover_Pic { get; set; }
        public string Location { get; set; }
        public string Statement { get; set; }
        public string Price_Range { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Expertise { get; set; }
        public string Education { get; set; }
        public string Work { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}