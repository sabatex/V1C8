using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРасчетаКосвенныхРасходов", Comment = "", Synonym = "Виды операций расчета косвенных расходов")]
    public class ВидыОперацийРасчетаКосвенныхРасходов:EnumItem
    {
        public static readonly ВидыОперацийРасчетаКосвенныхРасходов РаспределениеОбщепроизводственныхРасходов = new ВидыОперацийРасчетаКосвенныхРасходов{Name= "РаспределениеОбщепроизводственныхРасходов",Synonim="Распределение общепроизводственных расходов",Comment=""};
        public static readonly ВидыОперацийРасчетаКосвенныхРасходов РаспределениеОбщехозяйственныхРасходов = new ВидыОперацийРасчетаКосвенныхРасходов{Name= "РаспределениеОбщехозяйственныхРасходов",Synonim="Распределение общехозяйственных расходов",Comment=""};
        public static readonly ВидыОперацийРасчетаКосвенныхРасходов УслугиБезИспользованияПлановыхЦен = new ВидыОперацийРасчетаКосвенныхРасходов{Name= "УслугиБезИспользованияПлановыхЦен",Synonim="Услуги без использования плановых цен",Comment=""};
        public static readonly ВидыОперацийРасчетаКосвенныхРасходов ВыпускПродукцииИУслуг = new ВидыОперацийРасчетаКосвенныхРасходов{Name= "ВыпускПродукцииИУслуг",Synonim="Выпуск продукции и услуг",Comment=""};
    }
}
