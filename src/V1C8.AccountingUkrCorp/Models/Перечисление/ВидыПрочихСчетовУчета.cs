using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПрочихСчетовУчета", Comment = "", Synonym = "Виды прочих счетов учета")]
    public enum ВидыПрочихСчетовУчета
    {
        [Description1C8(Name = "СчетДоходовВозвратПоставщику", Comment = "", Synonym = "Счет доходов возврат поставщику")]
        СчетДоходовВозвратПоставщику,
        [Description1C8(Name = "СчетЗатратВозвратПоставщику", Comment = "", Synonym = "Счет затрат возврат поставщику")]
        СчетЗатратВозвратПоставщику,
        [Description1C8(Name = "СчетЗатратОтчетКомиссионераОПродажах", Comment = "", Synonym = "Счет расходов по вознагражению в отчете комиссионера о продажах")]
        СчетЗатратОтчетКомиссионераОПродажах,
        [Description1C8(Name = "СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты", Comment = "", Synonym = "Счет затрат по разнице курсов при продаже валюты")]
        СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты,
        [Description1C8(Name = "СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты", Comment = "", Synonym = "Счет доходов по разнице курсов при продаже валюты")]
        СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты,
        [Description1C8(Name = "СчетЗатратКомиссионныеПокупкаПродажаВалюты", Comment = "", Synonym = "Счет затрат по комиссионным банка при покупке/продаже валюты")]
        СчетЗатратКомиссионныеПокупкаПродажаВалюты,
        [Description1C8(Name = "СчетЗатратПенсионныйПродажаВалюты", Comment = "", Synonym = "Счет затрат пенсионный при продаже валюты")]
        СчетЗатратПенсионныйПродажаВалюты,
        [Description1C8(Name = "СчетЗатратСебестоимостьПродажаВалюты", Comment = "", Synonym = "Счет затрат при покупке/продаже валюты")]
        СчетЗатратСебестоимостьПродажаВалюты,
        [Description1C8(Name = "СчетДоходовСебестоимостьПродажаВалюты", Comment = "", Synonym = "Счет доходов при покупке/продаже валюты")]
        СчетДоходовСебестоимостьПродажаВалюты,
        [Description1C8(Name = "СчетДтСписаниеЗадолженностиКорректировкаДолга", Comment = "", Synonym = "Счет списания безнадежной дебиторской задолженности")]
        СчетДтСписаниеЗадолженностиКорректировкаДолга,
        [Description1C8(Name = "СчетКтСписаниеЗадолженностиКорректировкаДолга", Comment = "", Synonym = "Счет списания безнадежной кредиторской  задолженности")]
        СчетКтСписаниеЗадолженностиКорректировкаДолга
    }
}
