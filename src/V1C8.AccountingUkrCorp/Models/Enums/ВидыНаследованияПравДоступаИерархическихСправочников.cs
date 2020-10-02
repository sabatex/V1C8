using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыНаследованияПравДоступаИерархическихСправочников", Comment = "", Synonym = "Виды наследования прав доступа иерархических справочников")]
    public class ВидыНаследованияПравДоступаИерархическихСправочников:EnumItem
    {
        public static readonly ВидыНаследованияПравДоступаИерархическихСправочников НаследуетсяОтРодителя = new ВидыНаследованияПравДоступаИерархическихСправочников{Name= "НаследуетсяОтРодителя",Synonim="Наследуется от родителя",Comment=""};
        public static readonly ВидыНаследованияПравДоступаИерархическихСправочников РаспространитьНаПодчиненных = new ВидыНаследованияПравДоступаИерархическихСправочников{Name= "РаспространитьНаПодчиненных",Synonim="Распространить на подчиненных",Comment=""};
        public static readonly ВидыНаследованияПравДоступаИерархическихСправочников ТолькоДляТекущегоПрава = new ВидыНаследованияПравДоступаИерархическихСправочников{Name= "ТолькоДляТекущегоПрава",Synonim="Только для текущего права",Comment=""};
    }
}
