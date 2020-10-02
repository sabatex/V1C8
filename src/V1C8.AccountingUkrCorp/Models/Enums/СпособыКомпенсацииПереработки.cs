using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыКомпенсацииПереработки", Comment = "", Synonym = "Способы компенсации переработки")]
    public class СпособыКомпенсацииПереработки:EnumItem
    {
        public static readonly СпособыКомпенсацииПереработки ПовышеннаяОплата = new СпособыКомпенсацииПереработки{Name= "ПовышеннаяОплата",Synonim="Повышенная оплата",Comment=""};
        public static readonly СпособыКомпенсацииПереработки Отгул = new СпособыКомпенсацииПереработки{Name= "Отгул",Synonim="Отгул",Comment=""};
    }
}
