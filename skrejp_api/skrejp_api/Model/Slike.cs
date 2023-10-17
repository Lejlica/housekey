
﻿using System.ComponentModel.DataAnnotations.Schema;

﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace skrejp_api.Model
{
    public class Slike
    {
        public int ID { get; set; }
        public string url { get; set; }
        [ForeignKey("nekretninaID")]
        public Nekretnina nekretnina { get; set; }
        public int nekretninaID { get; set; }

    }
}
