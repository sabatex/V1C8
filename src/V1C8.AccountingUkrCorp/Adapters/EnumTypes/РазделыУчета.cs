using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыУчета:EnumBase
    {
        public РазделыУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОценкаМПЗ => GetProperty<EnumItem>("ОценкаМПЗ");
        public EnumItem РасчетыСКонтрагентами => GetProperty<EnumItem>("РасчетыСКонтрагентами");
    }
}
