using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыДанныхКэшаПрограммныхИнтерфейсов", Comment = "", Synonym = "Типы данных кэша программных интерфейсов")]
    public class ТипыДанныхКэшаПрограммныхИнтерфейсов:EnumItem
    {
        public static readonly ТипыДанныхКэшаПрограммныхИнтерфейсов ОписаниеWebСервиса = new ТипыДанныхКэшаПрограммныхИнтерфейсов{Name= "ОписаниеWebСервиса",Synonim="Описание web-сервиса",Comment=""};
        public static readonly ТипыДанныхКэшаПрограммныхИнтерфейсов ВерсииИнтерфейса = new ТипыДанныхКэшаПрограммныхИнтерфейсов{Name= "ВерсииИнтерфейса",Synonim="Версии интерфейса",Comment=""};
    }
}
