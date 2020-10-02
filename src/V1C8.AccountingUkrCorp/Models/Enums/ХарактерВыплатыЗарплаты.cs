using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ХарактерВыплатыЗарплаты", Comment = "Выплата конкретного начисления, аванса или окончательная выплата зарплаты 'под расчет'", Synonym = "Характер выплаты зарплаты")]
    public class ХарактерВыплатыЗарплаты:EnumItem
    {
        public static readonly ХарактерВыплатыЗарплаты Аванс = new ХарактерВыплатыЗарплаты{Name= "Аванс",Synonim="С авансом",Comment=""};
        public static readonly ХарактерВыплатыЗарплаты Межрасчет = new ХарактерВыплатыЗарплаты{Name= "Межрасчет",Synonim="В межрасчетный период",Comment=""};
        public static readonly ХарактерВыплатыЗарплаты Зарплата = new ХарактерВыплатыЗарплаты{Name= "Зарплата",Synonim="С зарплатой",Comment=""};
    }
}
