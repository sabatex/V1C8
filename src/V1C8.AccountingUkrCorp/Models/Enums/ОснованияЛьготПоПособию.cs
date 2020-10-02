using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОснованияЛьготПоПособию", Comment = "", Synonym = "Основания льгот по пособию")]
    public class ОснованияЛьготПоПособию:EnumItem
    {
        public static readonly ОснованияЛьготПоПособию Чернобыль = new ОснованияЛьготПоПособию{Name= "Чернобыль",Synonim="Чернобыльская АЭС",Comment=""};
        public static readonly ОснованияЛьготПоПособию ВетераныВойны = new ОснованияЛьготПоПособию{Name= "ВетераныВойны",Synonim="Ветераны войны",Comment="Согл. Закону Украины 'О статусе ветеранов войны, гарантии их социальной защиты' "};
        public static readonly ОснованияЛьготПоПособию ЖертвыНацистскихПреследований = new ОснованияЛьготПоПособию{Name= "ЖертвыНацистскихПреследований",Synonim="Жертвы нацистских преследований",Comment="Согл. Закону Украины 'О жертвах нацистских преследований'"};
        public static readonly ОснованияЛьготПоПособию РодительРебенкаЧернобыльца = new ОснованияЛьготПоПособию{Name= "РодительРебенкаЧернобыльца",Synonim="Родитель больного ребенка, пострадавшего от аварии на ЧАЭС",Comment="Родитель или лицо, заменяющее родителя больного ребенка до 14 лет, пострадавшего от аварии на ЧАЭС"};
        public static readonly ОснованияЛьготПоПособию Донор = new ОснованияЛьготПоПособию{Name= "Донор",Synonim="Донор, имеющий право на льготу",Comment="Донор, имеющий право на льготу согл. Закону Украины 'О донорстве крови и ее компонентов'"};
        public static readonly ОснованияЛьготПоПособию УчастникРеволюцииДостоинства = new ОснованияЛьготПоПособию{Name= "УчастникРеволюцииДостоинства",Synonim="Пострадавший участник революции достоинства",Comment="Согласно Закону Украины от 22.05.2018 №2443-VIII  лицо со статусом пострадавшего участника Революции Достоинства"};
    }
}
