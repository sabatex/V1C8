using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыБазыУдержанияПоИсполнительномуДокументу:EnumBase
    {
        public ВидыБазыУдержанияПоИсполнительномуДокументу(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Заработок => GetProperty<EnumItem>("Заработок");
        public EnumItem ПрожиточныйМинимум => GetProperty<EnumItem>("ПрожиточныйМинимум");
    }
}
