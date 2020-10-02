using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияПроведенияВПоследовательности", Comment = "", Synonym = "Состояния проведения в последовательности")]
    public class СостоянияПроведенияВПоследовательности:EnumItem
    {
        public static readonly СостоянияПроведенияВПоследовательности ПроведенВПоследовательности = new СостоянияПроведенияВПоследовательности{Name= "ПроведенВПоследовательности",Synonim="Проведен в последовательности",Comment=""};
        public static readonly СостоянияПроведенияВПоследовательности ПроведенСНарушениемПоследовательности = new СостоянияПроведенияВПоследовательности{Name= "ПроведенСНарушениемПоследовательности",Synonim="Проведен с нарушением последовательности",Comment=""};
        public static readonly СостоянияПроведенияВПоследовательности ИсключенИзПоследовательности = new СостоянияПроведенияВПоследовательности{Name= "ИсключенИзПоследовательности",Synonim="Исключен из последовательности",Comment=""};
    }
}
