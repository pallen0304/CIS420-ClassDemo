using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClassDemo.Models
{
    public class Student
    {
        public int Id
        {
            get; set;
        }
        [DisplayName("First Name")]
        public string FirstName
        {
            get; set;
        }
        [DisplayName("Last Name")]
        public string LastName
        {
            get; set;
        }
        [DisplayName("Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        public DateTime DateOfBirth
        {
            get; set;
        }
        [DisplayName("Total Credit Hours")]
        public int TotalCreditHours
        {
            get; set;
        }
    }
}