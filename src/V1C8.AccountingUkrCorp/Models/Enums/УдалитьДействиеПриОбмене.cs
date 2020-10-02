using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьДействиеПриОбмене", Comment = "", Synonym = "(не используется) Действие при обмене")]
    public class УдалитьДействиеПриОбмене:EnumItem
    {
        public static readonly УдалитьДействиеПриОбмене ЗагрузкаДанных = new УдалитьДействиеПриОбмене{Name= "ЗагрузкаДанных",Synonim="Загрузка данных",Comment=""};
        public static readonly УдалитьДействиеПриОбмене ОтложенныеДвижения = new УдалитьДействиеПриОбмене{Name= "ОтложенныеДвижения",Synonim="Отложенные движения",Comment=""};
        public static readonly УдалитьДействиеПриОбмене ВыгрузкаДанных = new УдалитьДействиеПриОбмене{Name= "ВыгрузкаДанных",Synonim="Выгрузка данных",Comment=""};
    }
}
