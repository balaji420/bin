using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CurApi.Models
{
     [Table("profacurconvconfig")]
    public class curconvconfig
    {
        public decimal CrvLocFk { get; set; }
        public decimal CrvBasCurFk { get; set; }
        public decimal CrvConCurFk { get; set; }
        public decimal CrvByRt { get; set; }
        public decimal CrvSelRt { get; set; }
        public System.DateTime CrvEffFrm { get; set; }
        public Nullable<System.DateTime> CrvEffTo { get; set; }
        public decimal CrvConvVal { get; set; }
        public string CrvCutOffTm { get; set; }
        public Nullable<decimal> CrvFcr1 { get; set; }
        public Nullable<decimal> CrvFcr2 { get; set; }
        public Nullable<decimal> CrvFcr3 { get; set; }
         [Key]
        public int CrvPk { get; set; }
        public System.Guid CrvRowid { get; set; }
        public string CrvCreatedBy { get; set; }
        public System.DateTime CrvCreatedDt { get; set; }
        public string CrvModifiedBy { get; set; }
        public System.DateTime CrvModifiedDt { get; set; }
        public string CrvDelFlg { get; set; }
        public Nullable<byte> CrvDelId { get; set; }
    }

    public class ProFaCurdef
    {
        public string CurCd { get; set; }
        public string CurDesc { get; set; }
        public string CurDispNm { get; set; }
        public string CurSecCur { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CurPK { get; set; }
        public System.Guid CurRowid { get; set; }
        public string CurCreatedBy { get; set; }
        public System.DateTime CurCreatedDt { get; set; }
        public string CurModifiedBy { get; set; }
        public System.DateTime CurModifiedDt { get; set; }
        public string CurDelFlg { get; set; }
        public Nullable<byte> CurDelId { get; set; }

    }
}



