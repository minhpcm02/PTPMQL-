using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMOMPMVC.Models
{
    
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set;}
        public string FullName { get; set;}
    
    }
}







