using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыТарифныхСтавок", Comment = "", Synonym = "Виды тарифных ставок")]
    public class ВидыТарифныхСтавок:EnumItem
    {
        public static readonly ВидыТарифныхСтавок МесячнаяТарифнаяСтавка = new ВидыТарифныхСтавок{Name= "МесячнаяТарифнаяСтавка",Synonim="Месячная тарифная ставка",Comment=""};
        public static readonly ВидыТарифныхСтавок ЧасоваяТарифнаяСтавка = new ВидыТарифныхСтавок{Name= "ЧасоваяТарифнаяСтавка",Synonim="Часовая тарифная ставка",Comment=""};
        public static readonly ВидыТарифныхСтавок ДневнаяТарифнаяСтавка = new ВидыТарифныхСтавок{Name= "ДневнаяТарифнаяСтавка",Synonim="Дневная тарифная ставка",Comment=""};
    }
}
