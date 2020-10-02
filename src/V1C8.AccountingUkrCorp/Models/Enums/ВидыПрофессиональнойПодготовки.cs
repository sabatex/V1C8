using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПрофессиональнойПодготовки", Comment = "", Synonym = "Виды профессиональной подготовки")]
    public class ВидыПрофессиональнойПодготовки:EnumItem
    {
        public static readonly ВидыПрофессиональнойПодготовки Переподготовка = new ВидыПрофессиональнойПодготовки{Name= "Переподготовка",Synonim="Переподготовка",Comment=""};
        public static readonly ВидыПрофессиональнойПодготовки ПовышениеКвалификации = new ВидыПрофессиональнойПодготовки{Name= "ПовышениеКвалификации",Synonim="Повышение квалификации",Comment=""};
    }
}
