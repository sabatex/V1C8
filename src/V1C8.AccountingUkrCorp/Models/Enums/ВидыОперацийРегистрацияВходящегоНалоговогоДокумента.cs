using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРегистрацияВходящегоНалоговогоДокумента", Comment = "Виды операций документа регистрация входящего налогового документа", Synonym = "Виды операций регистрация входящего налогового документа")]
    public class ВидыОперацийРегистрацияВходящегоНалоговогоДокумента:EnumItem
    {
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента НалоговаяНакладная = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "НалоговаяНакладная",Synonim="Налоговая накладная",Comment="Налоговая накладная входящая"};
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента РасчетКорректировкиВозврат = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "РасчетКорректировкиВозврат",Synonim="Расчет корректировки (возврат)",Comment="Расчет корректировки стоимости (входящий)"};
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента РасчетКорректировкиКорректировка = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "РасчетКорректировкиКорректировка",Synonim="Расчет корректировки (изменение суммы компенсации)",Comment="Расчет корректировки стоимости (входящий)"};
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента РаботыОтНерезидентаПрошлогоПериода = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "РаботыОтНерезидентаПрошлогоПериода",Synonim="Работы от нерезидента",Comment="Работы, полученнные от нерезидента в прошлом периоде"};
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента ПогашениеНалоговогоВекселя = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "ПогашениеНалоговогоВекселя",Synonim="Погашение налогового векселя",Comment="Погашение налогового векселя"};
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента BeксeльПpoшлoгoПepиoдa = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "BeксeльПpoшлoгoПepиoдa",Synonim="Вeксeль, погашенный  в пpoшлoм пepиoде или досрочно",Comment="Налоговый вексель, погашеный в прошлом периоде"};
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента ТаможенноеОформлениеТоваровКомитента = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "ТаможенноеОформлениеТоваровКомитента",Synonim="Таможенное оформление товаров комитента (право на кредит)",Comment="Регистрация ГТД оформленной при импорте комиссионных товаров. Право на кредит возникает при перечислении денег комитенту за реализованный товар"};
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента ИсправлениеОшибки = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "ИсправлениеОшибки",Synonim="Исправление ошибки",Comment=""};
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента ВосстановлениеНалоговогоКредита = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "ВосстановлениеНалоговогоКредита",Synonim="Восстановление налогового кредита",Comment=""};
        public static readonly ВидыОперацийРегистрацияВходящегоНалоговогоДокумента ТоварныйЧек = new ВидыОперацийРегистрацияВходящегоНалоговогоДокумента{Name= "ТоварныйЧек",Synonim="Прочее (товарный чек и т. п.)",Comment="Товарный чек или другой документ расчетов от резидента "};
    }
}
