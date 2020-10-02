using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж", Comment = "", Synonym = "Коды операций регистра Ожидаемый и подтвержденный НДС продаж")]
    public class КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж:EnumItem
    {
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж ОжидаемыйНДС = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "ОжидаемыйНДС",Synonim="Ожидаемый НДС",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж ПодтвержденныйНДС = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "ПодтвержденныйНДС",Synonim="Подтвержденный НДС",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат",Synonim="Корректировка ожидаемого НДС по видам деятельности оплат",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж РегистрацияАвансов = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "РегистрацияАвансов",Synonim="Регистрация авансов",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж ОтменаРегистрацииАвансов = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "ОтменаРегистрацииАвансов",Synonim="Отмена регистрации авансов",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж КорректировкаНеправильноОформленныхНалоговыхДокументов = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "КорректировкаНеправильноОформленныхНалоговыхДокументов",Synonim="Корректировка неправильно оформленных налоговых документов",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж ПереводОФвСоставНепроизводственных = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "ПереводОФвСоставНепроизводственных",Synonim="Перевод основных фондов в состав непроизводственных",Comment=""};
    }
}
