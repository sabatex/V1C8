using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПрочихСчетовУчета", Comment = "", Synonym = "Виды прочих счетов учета")]
    public class ВидыПрочихСчетовУчета:EnumItem
    {
        public static readonly ВидыПрочихСчетовУчета СчетДоходовВозвратПоставщику = new ВидыПрочихСчетовУчета{Name= "СчетДоходовВозвратПоставщику",Synonim="Счет доходов возврат поставщику",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетЗатратВозвратПоставщику = new ВидыПрочихСчетовУчета{Name= "СчетЗатратВозвратПоставщику",Synonim="Счет затрат возврат поставщику",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетЗатратОтчетКомиссионераОПродажах = new ВидыПрочихСчетовУчета{Name= "СчетЗатратОтчетКомиссионераОПродажах",Synonim="Счет расходов по вознагражению в отчете комиссионера о продажах",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты = new ВидыПрочихСчетовУчета{Name= "СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты",Synonim="Счет затрат по разнице курсов при продаже валюты",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты = new ВидыПрочихСчетовУчета{Name= "СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты",Synonim="Счет доходов по разнице курсов при продаже валюты",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетЗатратКомиссионныеПокупкаПродажаВалюты = new ВидыПрочихСчетовУчета{Name= "СчетЗатратКомиссионныеПокупкаПродажаВалюты",Synonim="Счет затрат по комиссионным банка при покупке/продаже валюты",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетЗатратПенсионныйПродажаВалюты = new ВидыПрочихСчетовУчета{Name= "СчетЗатратПенсионныйПродажаВалюты",Synonim="Счет затрат пенсионный при продаже валюты",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетЗатратСебестоимостьПродажаВалюты = new ВидыПрочихСчетовУчета{Name= "СчетЗатратСебестоимостьПродажаВалюты",Synonim="Счет затрат при покупке/продаже валюты",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетДоходовСебестоимостьПродажаВалюты = new ВидыПрочихСчетовУчета{Name= "СчетДоходовСебестоимостьПродажаВалюты",Synonim="Счет доходов при покупке/продаже валюты",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетДтСписаниеЗадолженностиКорректировкаДолга = new ВидыПрочихСчетовУчета{Name= "СчетДтСписаниеЗадолженностиКорректировкаДолга",Synonim="Счет списания безнадежной дебиторской задолженности",Comment=""};
        public static readonly ВидыПрочихСчетовУчета СчетКтСписаниеЗадолженностиКорректировкаДолга = new ВидыПрочихСчетовУчета{Name= "СчетКтСписаниеЗадолженностиКорректировкаДолга",Synonim="Счет списания безнадежной кредиторской  задолженности",Comment=""};
    }
}
