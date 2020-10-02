using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияСотрудника", Comment = "", Synonym = "Состояния сотрудника")]
    public class СостоянияСотрудника:EnumItem
    {
        public static readonly СостоянияСотрудника Работа = new СостоянияСотрудника{Name= "Работа",Synonim="Работа",Comment=""};
        public static readonly СостоянияСотрудника РаботаВОтпускеПоУходуЗаРебенком = new СостоянияСотрудника{Name= "РаботаВОтпускеПоУходуЗаРебенком",Synonim="Работа в отпуске по уходу за ребенком",Comment=""};
        public static readonly СостоянияСотрудника Прогул = new СостоянияСотрудника{Name= "Прогул",Synonim="Прогул",Comment=""};
        public static readonly СостоянияСотрудника ВынужденныйПрогул = new СостоянияСотрудника{Name= "ВынужденныйПрогул",Synonim="Вынужденный прогул",Comment=""};
        public static readonly СостоянияСотрудника ПростойПоВинеРаботника = new СостоянияСотрудника{Name= "ПростойПоВинеРаботника",Synonim="Простой по вине работника",Comment=""};
        public static readonly СостоянияСотрудника ПростойПоВинеРаботодателя = new СостоянияСотрудника{Name= "ПростойПоВинеРаботодателя",Synonim="Простой по вине работодателя",Comment=""};
        public static readonly СостоянияСотрудника ПростойНеЗависящийОтРаботодателяИРаботника = new СостоянияСотрудника{Name= "ПростойНеЗависящийОтРаботодателяИРаботника",Synonim="Простой, не зависящий от работодателя и работника",Comment=""};
        public static readonly СостоянияСотрудника ОтпускОсновной = new СостоянияСотрудника{Name= "ОтпускОсновной",Synonim="Отпуск основной",Comment=""};
        public static readonly СостоянияСотрудника ДополнительныйОтпуск = new СостоянияСотрудника{Name= "ДополнительныйОтпуск",Synonim="Дополнительный отпуск",Comment=""};
        public static readonly СостоянияСотрудника ДополнительныйОтпускНеоплачиваемый = new СостоянияСотрудника{Name= "ДополнительныйОтпускНеоплачиваемый",Synonim="Дополнительный отпуск (неоплачиваемый)",Comment=""};
        public static readonly СостоянияСотрудника ОтпускУчебныйОплачиваемый = new СостоянияСотрудника{Name= "ОтпускУчебныйОплачиваемый",Synonim="Отпуск учебный оплачиваемый",Comment=""};
        public static readonly СостоянияСотрудника ОтпускУчебныйНеоплачиваемый = new СостоянияСотрудника{Name= "ОтпускУчебныйНеоплачиваемый",Synonim="Отпуск учебный неоплачиваемый",Comment=""};
        public static readonly СостоянияСотрудника ОтпускНеоплачиваемыйПоРазрешениюРаботодателя = new СостоянияСотрудника{Name= "ОтпускНеоплачиваемыйПоРазрешениюРаботодателя",Synonim="Отпуск неоплачиваемый по разрешению работодателя",Comment=""};
        public static readonly СостоянияСотрудника ОтпускНеоплачиваемыйПоЗаконодательству = new СостоянияСотрудника{Name= "ОтпускНеоплачиваемыйПоЗаконодательству",Synonim="Отпуск неоплачиваемый по законодательству",Comment=""};
        public static readonly СостоянияСотрудника ОтпускПоУходуЗаРебенком = new СостоянияСотрудника{Name= "ОтпускПоУходуЗаРебенком",Synonim="Отпуск по уходу за ребенком до 3 лет",Comment=""};
        public static readonly СостоянияСотрудника Командировка = new СостоянияСотрудника{Name= "Командировка",Synonim="Командировка",Comment=""};
        public static readonly СостоянияСотрудника ОтсутствиеССохранениемОплаты = new СостоянияСотрудника{Name= "ОтсутствиеССохранениемОплаты",Synonim="Отсутствие с сохранением оплаты",Comment=""};
        public static readonly СостоянияСотрудника ВыполнениеГосударственныхОбязанностей = new СостоянияСотрудника{Name= "ВыполнениеГосударственныхОбязанностей",Synonim="Выполнение государственных обязанностей",Comment=""};
        public static readonly СостоянияСотрудника ДополнительныеВыходныеДниОплачиваемые = new СостоянияСотрудника{Name= "ДополнительныеВыходныеДниОплачиваемые",Synonim="Дополнительные выходные дни (оплачиваемые)",Comment=""};
        public static readonly СостоянияСотрудника ДополнительныеВыходныеДниНеОплачиваемые = new СостоянияСотрудника{Name= "ДополнительныеВыходныеДниНеОплачиваемые",Synonim="Дополнительные выходные дни не оплачиваемые",Comment=""};
        public static readonly СостоянияСотрудника ОтсутствиеПоНевыясненнымПричинам = new СостоянияСотрудника{Name= "ОтсутствиеПоНевыясненнымПричинам",Synonim="Отсутствие по невыясненным причинам",Comment=""};
        public static readonly СостоянияСотрудника ОтпускПоБеременностиИРодам = new СостоянияСотрудника{Name= "ОтпускПоБеременностиИРодам",Synonim="Отпуск по беременности и родам",Comment=""};
        public static readonly СостоянияСотрудника ОтпускНаСанаторноКурортноеЛечение = new СостоянияСотрудника{Name= "ОтпускНаСанаторноКурортноеЛечение",Synonim="Отпуск на санаторно-курортное лечение",Comment=""};
        public static readonly СостоянияСотрудника Болезнь = new СостоянияСотрудника{Name= "Болезнь",Synonim="Болезнь",Comment=""};
        public static readonly СостоянияСотрудника БолезньБезОплаты = new СостоянияСотрудника{Name= "БолезньБезОплаты",Synonim="Болезнь без оплаты",Comment=""};
        public static readonly СостоянияСотрудника Факт = new СостоянияСотрудника{Name= "Факт",Synonim="Факт",Comment=""};
        public static readonly СостоянияСотрудника Увольнение = new СостоянияСотрудника{Name= "Увольнение",Synonim="Увольнение",Comment=""};
        public static readonly СостоянияСотрудника ОтпускПоУходуЗаРебенком6лет = new СостоянияСотрудника{Name= "ОтпускПоУходуЗаРебенком6лет",Synonim="Отпуск по уходу за ребенком до 6 лет",Comment=""};
    }
}
