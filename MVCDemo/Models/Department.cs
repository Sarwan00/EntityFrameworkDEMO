using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemo.Models
{
    [Table("Department")]
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Employee> employees { get; set; }
    }
}