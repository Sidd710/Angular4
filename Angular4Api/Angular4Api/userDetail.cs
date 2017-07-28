namespace Angular4Api
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class userDetail
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Fname { get; set; }

        [StringLength(100)]
        public string Lname { get; set; }

        public int? Age { get; set; }
    }
}
