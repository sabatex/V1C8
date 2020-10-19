using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыПубликацииДополнительныхОтчетовИОбработок:EnumBase
    {
        public ВариантыПубликацииДополнительныхОтчетовИОбработок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Используется => GetProperty<EnumItem>("Используется");
        public EnumItem РежимОтладки => GetProperty<EnumItem>("РежимОтладки");
        public EnumItem Отключена => GetProperty<EnumItem>("Отключена");
    }
}
