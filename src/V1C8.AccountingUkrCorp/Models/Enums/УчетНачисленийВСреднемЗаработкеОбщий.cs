using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УчетНачисленийВСреднемЗаработкеОбщий", Comment = "", Synonym = "Учет начислений в среднем заработке общий")]
    public class УчетНачисленийВСреднемЗаработкеОбщий:EnumItem
    {
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ОбщийЗаработок = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ОбщийЗаработок",Synonim="Общий заработок",Comment="Общий заработок"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ПремияФиксированнойСуммой = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ПремияФиксированнойСуммой",Synonim="Премия, учитываемая пропорционально",Comment="Премия, учитываемая пропорционально отработанному времени"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ПремияПроцентом = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ПремияПроцентом",Synonim="Премия, полностью учитываемая",Comment="Премия, полностью учитываемая"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ПремияГодоваяФиксированнойСуммой = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ПремияГодоваяФиксированнойСуммой",Synonim="Годовая премия, учитываемая пропорционально",Comment="Годовая премия, учитываемая пропорционально отработанному времени"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ПремияГодоваяПроцентом = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ПремияГодоваяПроцентом",Synonim="Годовая премия, полностью учитываемая",Comment="Годовая премия, полностью учитываемая"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий НеВключать = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "НеВключать",Synonim="Не включать",Comment="Не включать"};
    }
}
