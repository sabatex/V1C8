using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийНалоговаяНакладная", Comment = "(Общ)", Synonym = "Виды операций документа 'Налоговая накладная'")]
    public class ВидыОперацийНалоговаяНакладная:EnumItem
    {
        public static readonly ВидыОперацийНалоговаяНакладная ОблагаемыеОперации = new ВидыОперацийНалоговаяНакладная{Name= "ОблагаемыеОперации",Synonim="Операции, облагаемые НДС",Comment=""};
        public static readonly ВидыОперацийНалоговаяНакладная ОсвобожденныеОперации = new ВидыОперацийНалоговаяНакладная{Name= "ОсвобожденныеОперации",Synonim="Операции, освобожденные от  НДС",Comment="Операции, освобожденные от НДС (п.5)"};
        public static readonly ВидыОперацийНалоговаяНакладная НеНДСОперации = new ВидыОперацийНалоговаяНакладная{Name= "НеНДСОперации",Synonim="Операции, не являющиеся объектом налогообложения",Comment="Операции, не объекты налогообложения по НДС (п. 3.2)"};
        public static readonly ВидыОперацийНалоговаяНакладная ИтоговаяРозницаОблагаемыеОперации = new ВидыОперацийНалоговаяНакладная{Name= "ИтоговаяРозницаОблагаемыеОперации",Synonim="Итоговая в рознице по облагаемому НДС",Comment=""};
        public static readonly ВидыОперацийНалоговаяНакладная ИтоговаяРозницаОсвобожденныеОперации = new ВидыОперацийНалоговаяНакладная{Name= "ИтоговаяРозницаОсвобожденныеОперации",Synonim="Итоговая в рознице по освобожденному НДС",Comment=""};
        public static readonly ВидыОперацийНалоговаяНакладная РозницаКонрагентуОблагаемыеОперации = new ВидыОперацийНалоговаяНакладная{Name= "РозницаКонрагентуОблагаемыеОперации",Synonim="Реализация в розницу плательщику НДС по облагаемому НДС",Comment=""};
        public static readonly ВидыОперацийНалоговаяНакладная РозницаКонрагентуОсвобожденныеОперации = new ВидыОперацийНалоговаяНакладная{Name= "РозницаКонрагентуОсвобожденныеОперации",Synonim="Реализация в розницу плательщику НДС по освобожденному НДС",Comment=""};
        public static readonly ВидыОперацийНалоговаяНакладная УсловнаяПродажа = new ВидыОперацийНалоговаяНакладная{Name= "УсловнаяПродажа",Synonim="Условная продажа",Comment=""};
        public static readonly ВидыОперацийНалоговаяНакладная УсловнаяПродажаСписаниеОС = new ВидыОперацийНалоговаяНакладная{Name= "УсловнаяПродажаСписаниеОС",Synonim="Условная продажа при списании ОС",Comment=""};
        public static readonly ВидыОперацийНалоговаяНакладная РаботыОтНерезидента = new ВидыОперацийНалоговаяНакладная{Name= "РаботыОтНерезидента",Synonim="Работы от нерезидента",Comment="Работы, полученные от нерезидента"};
        public static readonly ВидыОперацийНалоговаяНакладная СводнаяНаПревышениеБазыНадЦенойПоставки = new ВидыОперацийНалоговаяНакладная{Name= "СводнаяНаПревышениеБазыНадЦенойПоставки",Synonim="Сводная на превышение базы над ценой поставки",Comment=""};
    }
}
