using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemo.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string gender { get; set; }
        public int deptid { get; set; }
        

    }
}