using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Kandykova_KR
{
    [Table(Name = "student")]
    class student
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_student")]
        public int id_student { get; set; }

        [Column(Name = "first_name")] 
        public string first_name { get; set; }

        [Column(Name = "last_name")] 
        public string last_name { get; set; }

        [Column(Name = "patronymic")] 
        public string patronymic { get; set; }

        [Column(Name = "date_of_birth")]  
        public DateTime date_of_birth { get; set; }

        [Column(Name = "specialnost")] 
        public int specialnost { get; set; }

        [Column(Name = "phone")]  
        public string phone { get; set; }

        [Column(Name ="email")] 
        public string email { get; set; }
    }
}
