using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийСписаниеБезналичныхДенежныхСредств", Comment = "(Общ)", Synonym = "Виды операций списания безналичных денежных средств")]
    public class ВидыОперацийСписаниеБезналичныхДенежныхСредств:EnumItem
    {
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств ОплатаПоставщику = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "ОплатаПоставщику",Synonim="Оплата поставщику",Comment="(Общ)"};
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств ВозвратДенежныхСредствПокупателю = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "ВозвратДенежныхСредствПокупателю",Synonim="Возврат денежных средств покупателю",Comment="(Общ)"};
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств ПеречислениеНалога = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "ПеречислениеНалога",Synonim="Перечисление налогов/взносов по заработной плате",Comment="(Общ)"};
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств РасчетыПоКредитамИЗаймам = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "РасчетыПоКредитамИЗаймам",Synonim="Расчеты по кредитам и займам с контрагентами",Comment=""};
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств ПрочиеРасчетыСКонтрагентами = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "ПрочиеРасчетыСКонтрагентами",Synonim="Прочие расчеты с контрагентами",Comment=""};
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств ПереводНаДругойСчет = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "ПереводНаДругойСчет",Synonim="Перевод на другой счет организации",Comment=""};
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств ПеречислениеДенежныхСредствПодотчетнику = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "ПеречислениеДенежныхСредствПодотчетнику",Synonim="Перечисление денежных средств подотчетнику",Comment="(Общ)"};
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств ПокупкаПродажаВалюты = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "ПокупкаПродажаВалюты",Synonim="Покупка/продажа валюты",Comment=""};
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств ПеречислениеЗП = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "ПеречислениеЗП",Synonim="Перечисление заработной платы",Comment="(Общ)"};
        public static readonly ВидыОперацийСписаниеБезналичныхДенежныхСредств ПрочееСписаниеБезналичныхДенежныхСредств = new ВидыОперацийСписаниеБезналичныхДенежныхСредств{Name= "ПрочееСписаниеБезналичныхДенежныхСредств",Synonim="Прочее списание безналичных денежных средств",Comment=""};
    }
}
