using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЕдиницыВремениУчетаСпецстажа", Comment = "", Synonym = "Единицы времени учета спецстажа")]
    public class ЕдиницыВремениУчетаСпецстажа:EnumItem
    {
        public static readonly ЕдиницыВремениУчетаСпецстажа КалендарныеДни = new ЕдиницыВремениУчетаСпецстажа{Name= "КалендарныеДни",Synonim="Календарные дни",Comment=""};
        public static readonly ЕдиницыВремениУчетаСпецстажа Смены = new ЕдиницыВремениУчетаСпецстажа{Name= "Смены",Synonim="Смены",Comment=""};
        public static readonly ЕдиницыВремениУчетаСпецстажа Часы = new ЕдиницыВремениУчетаСпецстажа{Name= "Часы",Synonim="Часы",Comment=""};
    }
}
