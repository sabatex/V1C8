using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЦветностиИзображения", Comment = "", Synonym = "Цветности изображения")]
    public class ЦветностиИзображения:EnumItem
    {
        public static readonly ЦветностиИзображения Монохромное = new ЦветностиИзображения{Name= "Монохромное",Synonim="Монохромное",Comment=""};
        public static readonly ЦветностиИзображения ГрадацииСерого = new ЦветностиИзображения{Name= "ГрадацииСерого",Synonim="Градации серого",Comment=""};
        public static readonly ЦветностиИзображения Цветное = new ЦветностиИзображения{Name= "Цветное",Synonim="Цветное",Comment=""};
    }
}
