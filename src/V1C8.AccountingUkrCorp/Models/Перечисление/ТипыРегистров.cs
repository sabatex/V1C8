using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыРегистров", Comment = "", Synonym = "Типы регистров")]
    public enum ТипыРегистров
    {
        [Description1C8(Name = "РегистрНакопления", Comment = "", Synonym = "Регистр накопления")]
        РегистрНакопления,
        [Description1C8(Name = "РегистрСведений", Comment = "", Synonym = "Регистр сведений")]
        РегистрСведений
    }
}
