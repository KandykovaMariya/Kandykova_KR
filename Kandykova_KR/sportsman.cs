using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Kandykova_KR
{
    [Table(Name = "sportsman")]
    class sportsman
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_sportsman")]
        public int id_sportsman { get; set; }

        [Column(Name = "id_student")] 
        public int id_student { get; set; }

        [Column(Name = "id_team")] 
        public int id_team { get; set; }

        [Column(Name = "gender")] 
        public int gender { get; set; }
    }
}
