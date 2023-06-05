using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        class EmployeeMetadata
        {
            public int Id { get; set; }
            [Required(ErrorMessage = "Name is Required")]
            public string Name { get; set; }
        }
    }
}
