
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
    
public partial class FeaturedPartner
{

    public int FeaturedPartnerId { get; set; }

    public Nullable<System.DateTime> Created { get; set; }

    public Nullable<System.DateTime> Modified { get; set; }

    public Nullable<bool> DisplayInHomePage { get; set; }

    public string PartnerId { get; set; }

    public Nullable<bool> IsExternal { get; set; }

    public string Name { get; set; }

    public string Image { get; set; }

    public string ExternalLink { get; set; }



    public virtual AspNetUser AspNetUser { get; set; }

}

}
