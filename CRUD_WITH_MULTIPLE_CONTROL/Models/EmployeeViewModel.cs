using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CRUD_WITH_MULTIPLE_CONTROL.Models
{
    public class EmployeeViewModel
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string  StateName { get; set; }
        public string CityName { get; set; }
        public int GenderId { get; set; }
        public string Gender { get; set; }
       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]  
        public DateTime? DOB { get; set; }

        public int StateId { get; set; }
        public Dictionary<int, string> StateList { get; set; }

        public int CityId { get; set; }
        public Dictionary<int, string> CityList { get; set; }

        public string AddOrEdit { get; set; }
        public HttpPostedFileBase fileUpload { get; set; }
        public string fileName { get; set; }
    }
}