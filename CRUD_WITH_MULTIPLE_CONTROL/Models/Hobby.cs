//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_WITH_MULTIPLE_CONTROL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hobby
    {
        public Hobby()
        {
            this.SelectedHobbyOfEmployeeWises = new HashSet<SelectedHobbyOfEmployeeWise>();
        }
    
        public int HobbyId { get; set; }
        public string HobbyName { get; set; }
    
        public virtual ICollection<SelectedHobbyOfEmployeeWise> SelectedHobbyOfEmployeeWises { get; set; }
    }
}
