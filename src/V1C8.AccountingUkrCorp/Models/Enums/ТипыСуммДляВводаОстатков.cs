using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыСуммДляВводаОстатков", Comment = "", Synonym = "Типы сумм для ввода остатков")]
    public class ТипыСуммДляВводаОстатков:EnumItem
    {
        public static readonly ТипыСуммДляВводаОстатков Оборот = new ТипыСуммДляВводаОстатков{Name= "Оборот",Synonim="Оборот",Comment=""};
        public static readonly ТипыСуммДляВводаОстатков ОстатокНаНачало = new ТипыСуммДляВводаОстатков{Name= "ОстатокНаНачало",Synonim="Остаток на начало",Comment=""};
    }
}
