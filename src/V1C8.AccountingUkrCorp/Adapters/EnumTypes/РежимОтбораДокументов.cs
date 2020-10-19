using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимОтбораДокументов:EnumBase
    {
        public РежимОтбораДокументов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоРеквизитам => GetProperty<EnumItem>("ПоРеквизитам");
        public EnumItem ПоОборотам => GetProperty<EnumItem>("ПоОборотам");
        public EnumItem ПоОстаткам => GetProperty<EnumItem>("ПоОстаткам");
    }
}
