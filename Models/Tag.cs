using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSQL.Models
{
        [Table("[Tag]")]
        public class Tag
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Slug { get; set; }

        }    
}
