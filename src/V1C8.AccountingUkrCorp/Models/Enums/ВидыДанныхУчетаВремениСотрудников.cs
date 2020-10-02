using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДанныхУчетаВремениСотрудников", Comment = "", Synonym = "Виды данных учета времени сотрудников")]
    public class ВидыДанныхУчетаВремениСотрудников:EnumItem
    {
        public static readonly ВидыДанныхУчетаВремениСотрудников ДанныеОбщихГрафиков = new ВидыДанныхУчетаВремениСотрудников{Name= "ДанныеОбщихГрафиков",Synonim="Данные общих графиков",Comment=""};
        public static readonly ВидыДанныхУчетаВремениСотрудников ДанныеИндивидуальныхГрафиков = new ВидыДанныхУчетаВремениСотрудников{Name= "ДанныеИндивидуальныхГрафиков",Synonim="Данные индивидуальных графиков",Comment=""};
        public static readonly ВидыДанныхУчетаВремениСотрудников ДанныеТабельногоУчета = new ВидыДанныхУчетаВремениСотрудников{Name= "ДанныеТабельногоУчета",Synonim="Данные табельного учета",Comment=""};
        public static readonly ВидыДанныхУчетаВремениСотрудников ДанныеОперативногоУчета = new ВидыДанныхУчетаВремениСотрудников{Name= "ДанныеОперативногоУчета",Synonim="Данные оперативного учета",Comment=""};
        public static readonly ВидыДанныхУчетаВремениСотрудников ДанныеВнутрисменныхНеявок = new ВидыДанныхУчетаВремениСотрудников{Name= "ДанныеВнутрисменныхНеявок",Synonim="Данные внутрисменных неявок",Comment=""};
        public static readonly ВидыДанныхУчетаВремениСотрудников ВытесняемоеПлановоеВремя = new ВидыДанныхУчетаВремениСотрудников{Name= "ВытесняемоеПлановоеВремя",Synonim="Вытесняемое плановое время",Comment=""};
        public static readonly ВидыДанныхУчетаВремениСотрудников ДополнительноеВнутрисменноеВремя = new ВидыДанныхУчетаВремениСотрудников{Name= "ДополнительноеВнутрисменноеВремя",Synonim="Дополнительное внутрисменное время",Comment=""};
        public static readonly ВидыДанныхУчетаВремениСотрудников СводныеДанные = new ВидыДанныхУчетаВремениСотрудников{Name= "СводныеДанные",Synonim="Сводные данные",Comment=""};
    }
}
