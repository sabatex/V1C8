using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийНалоговаяНакладная", Comment = "(Общ)", Synonym = "Виды операций документа 'Налоговая накладная'")]
    public enum ВидыОперацийНалоговаяНакладная
    {
        [Description1C8(Name = "ОблагаемыеОперации", Comment = "", Synonym = "Операции, облагаемые НДС")]
        ОблагаемыеОперации,
        [Description1C8(Name = "ОсвобожденныеОперации", Comment = "Операции, освобожденные от НДС (п.5)", Synonym = "Операции, освобожденные от  НДС")]
        ОсвобожденныеОперации,
        [Description1C8(Name = "НеНДСОперации", Comment = "Операции, не объекты налогообложения по НДС (п. 3.2)", Synonym = "Операции, не являющиеся объектом налогообложения")]
        НеНДСОперации,
        [Description1C8(Name = "ИтоговаяРозницаОблагаемыеОперации", Comment = "", Synonym = "Итоговая в рознице по облагаемому НДС")]
        ИтоговаяРозницаОблагаемыеОперации,
        [Description1C8(Name = "ИтоговаяРозницаОсвобожденныеОперации", Comment = "", Synonym = "Итоговая в рознице по освобожденному НДС")]
        ИтоговаяРозницаОсвобожденныеОперации,
        [Description1C8(Name = "РозницаКонрагентуОблагаемыеОперации", Comment = "", Synonym = "Реализация в розницу плательщику НДС по облагаемому НДС")]
        РозницаКонрагентуОблагаемыеОперации,
        [Description1C8(Name = "РозницаКонрагентуОсвобожденныеОперации", Comment = "", Synonym = "Реализация в розницу плательщику НДС по освобожденному НДС")]
        РозницаКонрагентуОсвобожденныеОперации,
        [Description1C8(Name = "УсловнаяПродажа", Comment = "", Synonym = "Условная продажа")]
        УсловнаяПродажа,
        [Description1C8(Name = "УсловнаяПродажаСписаниеОС", Comment = "", Synonym = "Условная продажа при списании ОС")]
        УсловнаяПродажаСписаниеОС,
        [Description1C8(Name = "РаботыОтНерезидента", Comment = "Работы, полученные от нерезидента", Synonym = "Работы от нерезидента")]
        РаботыОтНерезидента,
        [Description1C8(Name = "СводнаяНаПревышениеБазыНадЦенойПоставки", Comment = "", Synonym = "Сводная на превышение базы над ценой поставки")]
        СводнаяНаПревышениеБазыНадЦенойПоставки
    }
}
