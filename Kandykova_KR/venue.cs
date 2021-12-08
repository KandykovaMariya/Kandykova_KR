using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Kandykova_KR
{
    [Table(Name = "venue")]
    class venue
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_venue")]
        public int id_venue { get; set; }

        [Column(Name = "name_place")]
        public string name_place { get; set; }

        [Column(Name = "country")]
        public string country { get; set; }

        [Column(Name = "city")]
        public string city { get; set; }

        [Column(Name = "date_open")]
        public DateTime date_open { get; set; }
    }
}
