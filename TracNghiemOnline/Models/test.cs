
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
    
public partial class test
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public test()
    {

        this.quests_of_test = new HashSet<quests_of_test>();

        this.scores = new HashSet<score>();

    }


    public string test_name { get; set; }

    public int test_code { get; set; }

    public string password { get; set; }

    public int id_subject { get; set; }

    public int total_questions { get; set; }

    public int time_to_do { get; set; }

    public string note { get; set; }

    public int id_status { get; set; }

    public Nullable<System.DateTime> timestamps { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<quests_of_test> quests_of_test { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<score> scores { get; set; }

    public virtual status status { get; set; }

    public virtual subject subject { get; set; }

}

}
