namespace ChamThiSolution.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TC_KQ
    {
        public int Id { get; set; }

        public bool? IsTrue { get; set; }

        public virtual KetQua KetQua { get; set; }

        public virtual TestCase TestCase { get; set; }
    }
}
