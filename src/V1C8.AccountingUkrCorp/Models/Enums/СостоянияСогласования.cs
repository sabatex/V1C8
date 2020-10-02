using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияСогласования", Comment = "", Synonym = "Состояния согласования")]
    public class СостоянияСогласования:EnumItem
    {
        public static readonly СостоянияСогласования Отклонено = new СостоянияСогласования{Name= "Отклонено",Synonim="Отклонено",Comment=""};
        public static readonly СостоянияСогласования Рассматривается = new СостоянияСогласования{Name= "Рассматривается",Synonim="Рассматривается",Comment=""};
        public static readonly СостоянияСогласования Согласовано = new СостоянияСогласования{Name= "Согласовано",Synonim="Согласовано",Comment=""};
    }
}
