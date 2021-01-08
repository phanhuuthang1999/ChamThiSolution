namespace ChamThiSolution.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestCase")]
    public partial class TestCase
    {
        public int Id { get; set; }

        public string Input { get; set; }

        public string Output { get; set; }

        public virtual CauHoi CauHoi { get; set; }

        public virtual TC_KQ TC_KQ { get; set; }
    }
}
