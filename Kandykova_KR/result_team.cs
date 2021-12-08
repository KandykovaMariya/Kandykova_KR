using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace Kandykova_KR
{  
    [Table(Name = "result_team")]
    class result_team
    {
            [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_result_team")]
            public int id_result_team { get; set; }

            [Column(Name = "id_team")]
            public int id_team { get; set; }
            [Column(Name = "id_tournament")]
            public int id_tournament { get; set; }

            [Column(Name = "result_team")]
            public string result_teams { get; set; }

            [Column(Name = "place_team")]
            public string place_team { get; set; }

            [Column(Name = "sport")]
            public int sport { get; set; }
        }
    }

