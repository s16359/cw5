using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw5.DTO.Requests
{
    public class PromoteStudentRequest
    {
        [Required]
        public string Semester { get; set; }

        [Required]
        public string Studies { get; set; }
    }
}
