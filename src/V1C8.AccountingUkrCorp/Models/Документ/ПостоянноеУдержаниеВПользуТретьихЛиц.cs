using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("PostoiannoeUderzhanyeVPolzuTretykhLyts")]
    [Description1C8(Name = "ПостоянноеУдержаниеВПользуТретьихЛиц", Comment = "", Synonym = "Постоянное удержание в пользу третьих лиц")]
    public class ПостоянноеУдержаниеВПользуТретьихЛиц:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Удержание", Comment = "", Synonym = "Удержание")]
        public ПланВидовРасчета.Удержания Удержание {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСУдержаниями Действие {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.ПостоянноеУдержаниеВПользуТретьихЛиц ДокументОснование {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "УдалитьДействие", Comment = "", Synonym = "Удалить действие")]
        public Enums.ДействияСНачислениямиИУдержаниями УдалитьДействие {get; set;}
        [Description1C8(Name = "УдалитьРазмер", Comment = "", Synonym = "Удалить размер")]
        // Format 15.2
        public decimal УдалитьРазмер {get; set;}
        [Description1C8(Name = "УдалитьФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица УдалитьФизическоеЛицо {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<ПостоянноеУдержаниеВПользуТретьихЛиц_Удержания> ПостоянноеУдержаниеВПользуТретьихЛицУдержания {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ПостоянноеУдержаниеВПользуТретьихЛиц_Показатели> ПостоянноеУдержаниеВПользуТретьихЛицПоказатели {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("PostoiannoeUderzhanyeVPolzuTretykhLyts_Uderzhanyia")]
    public class ПостоянноеУдержаниеВПользуТретьихЛиц_Удержания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("PostoiannoeUderzhanyeVPolzuTretykhLyts_Pokazately")]
    public class ПостоянноеУдержаниеВПользуТретьихЛиц_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
    }
}
