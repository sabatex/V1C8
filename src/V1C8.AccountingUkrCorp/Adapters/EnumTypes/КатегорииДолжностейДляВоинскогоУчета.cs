using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииДолжностейДляВоинскогоУчета:EnumBase
    {
        public КатегорииДолжностейДляВоинскогоУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Руководители => GetProperty<EnumItem>("Руководители");
        public EnumItem Специалисты => GetProperty<EnumItem>("Специалисты");
        public EnumItem ДругиеСлужащие => GetProperty<EnumItem>("ДругиеСлужащие");
        public EnumItem Рабочие => GetProperty<EnumItem>("Рабочие");
    }
}
