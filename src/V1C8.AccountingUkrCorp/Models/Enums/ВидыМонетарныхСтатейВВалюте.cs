using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыМонетарныхСтатейВВалюте", Comment = "", Synonym = "Виды монетарных статей (в иностранной валюте)")]
    public class ВидыМонетарныхСтатейВВалюте:EnumItem
    {
        public static readonly ВидыМонетарныхСтатейВВалюте НеоперационнаяДеятельность = new ВидыМонетарныхСтатейВВалюте{Name= "НеоперационнаяДеятельность",Synonim="Неоперационная (финансовая, инвестиционная) деятельность",Comment=""};
        public static readonly ВидыМонетарныхСтатейВВалюте ОбязательстваУчредителей = new ВидыМонетарныхСтатейВВалюте{Name= "ОбязательстваУчредителей",Synonim="Обязательства учредителей при формировании уставного капитала",Comment=""};
    }
}
