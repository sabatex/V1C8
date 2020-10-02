using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СобытияПриобретенияНалоговыйУчет", Comment = "(Регл)", Synonym = "События приобретения налоговый учет")]
    public class СобытияПриобретенияНалоговыйУчет:EnumItem
    {
        public static readonly СобытияПриобретенияНалоговыйУчет ОплатаПоставщику = new СобытияПриобретенияНалоговыйУчет{Name= "ОплатаПоставщику",Synonim="Оплата поставщику",Comment=""};
        public static readonly СобытияПриобретенияНалоговыйУчет ВозвратОплатыПоставщиком = new СобытияПриобретенияНалоговыйУчет{Name= "ВозвратОплатыПоставщиком",Synonim="Возврат оплаты поставщиком",Comment=""};
        public static readonly СобытияПриобретенияНалоговыйУчет ПоступлениеОтПоставщика = new СобытияПриобретенияНалоговыйУчет{Name= "ПоступлениеОтПоставщика",Synonim="Поступление от поставщика",Comment=""};
        public static readonly СобытияПриобретенияНалоговыйУчет ВозвратПоставщику = new СобытияПриобретенияНалоговыйУчет{Name= "ВозвратПоставщику",Synonim="Возврат поставщику",Comment=""};
    }
}
