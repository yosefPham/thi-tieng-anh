
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
    
public partial class teacher
{

    public int id_teacher { get; set; }

    public string username { get; set; }

    public string password { get; set; }

    public string email { get; set; }

    public string avatar { get; set; }

    public string name { get; set; }

    public string gender { get; set; }

    public System.DateTime birthday { get; set; }

    public string phone { get; set; }

    public int id_permission { get; set; }

    public int id_speciality { get; set; }

    public Nullable<System.DateTime> last_login { get; set; }

    public string last_seen { get; set; }

    public string last_seen_url { get; set; }

    public Nullable<System.DateTime> timestamps { get; set; }



    public virtual permission permission { get; set; }

    public virtual speciality speciality { get; set; }

}

}
