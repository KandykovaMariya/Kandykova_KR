using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Kandykova_KR
{
   [Table(Name = "result_sportsman")]
        class result_sportsman
        {
            [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_result_sportsman")]
            public int id_result_sportsman { get; set; }

            [Column(Name = "id_sportsman")]
            public int id_sportsman { get; set; }

            [Column(Name = "place_student")]
            public string place_student { get; set; }

            [Column(Name = "sport")]
            public int sport { get; set; }

        }
    }


