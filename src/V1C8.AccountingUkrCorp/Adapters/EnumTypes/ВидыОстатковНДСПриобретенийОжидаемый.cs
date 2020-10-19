using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОстатковНДСПриобретенийОжидаемый:EnumBase
    {
        public ВидыОстатковНДСПриобретенийОжидаемый(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПравильнаяРегистрация => GetProperty<EnumItem>("ПравильнаяРегистрация");
        public EnumItem ЕщеНеПолучены => GetProperty<EnumItem>("ЕщеНеПолучены");
        public EnumItem НеБудутПолучены => GetProperty<EnumItem>("НеБудутПолучены");
    }
}
