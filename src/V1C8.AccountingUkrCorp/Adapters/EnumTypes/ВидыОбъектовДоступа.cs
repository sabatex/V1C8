using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОбъектовДоступа:EnumBase
    {
        public ВидыОбъектовДоступа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Организации => GetProperty<EnumItem>("Организации");
        public EnumItem ВнешниеОбработки => GetProperty<EnumItem>("ВнешниеОбработки");
    }
}
