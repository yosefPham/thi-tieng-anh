
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
    
public partial class grade
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public grade()
    {

        this.classes = new HashSet<@class>();

    }


    public int id_grade { get; set; }

    public string grade_name { get; set; }

    public Nullable<System.DateTime> timestamps { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<@class> classes { get; set; }

}

}
