using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыРабочихГрафиков", Comment = "(Общ)", Synonym = "Виды рабочих графиков")]
    public class ВидыРабочихГрафиков:EnumItem
    {
        public static readonly ВидыРабочихГрафиков Пятидневка = new ВидыРабочихГрафиков{Name= "Пятидневка",Synonim="Пятидневка",Comment="(Общ)"};
        public static readonly ВидыРабочихГрафиков Шестидневка = new ВидыРабочихГрафиков{Name= "Шестидневка",Synonim="Шестидневка",Comment="(Общ)"};
        public static readonly ВидыРабочихГрафиков Сменный = new ВидыРабочихГрафиков{Name= "Сменный",Synonim="Сменный",Comment="(Общ)"};
    }
}
