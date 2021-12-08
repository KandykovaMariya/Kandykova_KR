using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Kandykova_KR
{
    [Table (Name = "tournament")]
    class tournament
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_tournament")]
        public int id_tournament { get; set; }

        [Column(Name = "number_of_student")]
        public string number_of_student { get; set; }

        [Column(Name = "name_place")]
        public int name_place { get; set; }

        [Column(Name = "date_of_start")]
        public DateTime date_of_start { get; set; }

        [Column(Name = "date_of_finish")]
        public DateTime date_of_finish { get; set; }
    }
}
