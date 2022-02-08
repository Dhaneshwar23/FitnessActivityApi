using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessActivityApi.Model
{
    public class UserDetails
    {
        [Key]
        public int employee_id { get; set; }

        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public int YearsofExperience { get; set; }

        public string ActivityName { get; set; }

        public string Comments { get; set; }
    }
}
