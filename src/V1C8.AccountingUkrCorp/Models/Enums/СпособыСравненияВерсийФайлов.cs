using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыСравненияВерсийФайлов", Comment = "", Synonym = "Способы сравнения версий файлов")]
    public class СпособыСравненияВерсийФайлов:EnumItem
    {
        public static readonly СпособыСравненияВерсийФайлов MicrosoftOfficeWord = new СпособыСравненияВерсийФайлов{Name= "MicrosoftOfficeWord",Synonim="Microsoft Office Word",Comment=""};
        public static readonly СпособыСравненияВерсийФайлов OpenOfficeOrgWriter = new СпособыСравненияВерсийФайлов{Name= "OpenOfficeOrgWriter",Synonim="OpenOffice.org Writer",Comment=""};
    }
}
