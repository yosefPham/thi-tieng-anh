
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace TracNghiemOnline.Models
{

using System;
    using System.Collections.Generic;
    
public partial class status
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public status()
    {

        this.tests = new HashSet<test>();

    }


    public int id_status { get; set; }

    public string status_name { get; set; }

    public Nullable<System.DateTime> timestamps { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<test> tests { get; set; }

}

}
