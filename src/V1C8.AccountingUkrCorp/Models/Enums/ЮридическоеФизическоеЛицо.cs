using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЮридическоеФизическоеЛицо", Comment = "Определяет, является ли организация или контрагент юридическим лицом или нет.", Synonym = "Юридическое / физическое лицо")]
    public class ЮридическоеФизическоеЛицо:EnumItem
    {
        public static readonly ЮридическоеФизическоеЛицо ЮридическоеЛицо = new ЮридическоеФизическоеЛицо{Name= "ЮридическоеЛицо",Synonim="Юридическое лицо",Comment=""};
        public static readonly ЮридическоеФизическоеЛицо ФизическоеЛицо = new ЮридическоеФизическоеЛицо{Name= "ФизическоеЛицо",Synonim="Физическое лицо",Comment=""};
    }
}
