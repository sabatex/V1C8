using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьВидыКалендарей", Comment = "", Synonym = "(не используется) Виды календарей")]
    public class УдалитьВидыКалендарей:EnumItem
    {
        public static readonly УдалитьВидыКалендарей Пятидневка = new УдалитьВидыКалендарей{Name= "Пятидневка",Synonim="Пятидневка",Comment=""};
        public static readonly УдалитьВидыКалендарей Шестидневка = new УдалитьВидыКалендарей{Name= "Шестидневка",Synonim="Шестидневка",Comment=""};
        public static readonly УдалитьВидыКалендарей Произвольный = new УдалитьВидыКалендарей{Name= "Произвольный",Synonim="Произвольный",Comment=""};
    }
}
