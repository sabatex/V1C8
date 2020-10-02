using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыРасчетовПоДоговорам", Comment = "", Synonym = "Виды расчетов по договорам")]
    public class ВидыРасчетовПоДоговорам:EnumItem
    {
        public static readonly ВидыРасчетовПоДоговорам РасчетыВВалютеРегламентированногоУчета = new ВидыРасчетовПоДоговорам{Name= "РасчетыВВалютеРегламентированногоУчета",Synonim="Расчеты в валюте регламентированного учета",Comment=""};
        public static readonly ВидыРасчетовПоДоговорам РасчетыВИностраннойВалюте = new ВидыРасчетовПоДоговорам{Name= "РасчетыВИностраннойВалюте",Synonim="Расчеты в иностранной валюте",Comment=""};
    }
}
