using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаПоШкале", Comment = "", Synonym = "Способы расчета по шкале")]
    public class СпособыРасчетаПоШкале:EnumItem
    {
        public static readonly СпособыРасчетаПоШкале ПоШкале = new СпособыРасчетаПоШкале{Name= "ПоШкале",Synonim="По шкале",Comment=""};
        public static readonly СпособыРасчетаПоШкале Прогрессивный = new СпособыРасчетаПоШкале{Name= "Прогрессивный",Synonim="Прогрессивный",Comment=""};
        public static readonly СпособыРасчетаПоШкале СДекретных = new СпособыРасчетаПоШкале{Name= "СДекретных",Synonim="С декретных",Comment=""};
    }
}
