using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники", Comment = "", Synonym = "Варианты правил формирования представления элементов справочника сотрудники")]
    public enum ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники
    {
        [Description1C8(Name = "ФамилияИОДополнение", Comment = "", Synonym = "Фамилия И. О. [дополнение]")]
        ФамилияИОДополнение,
        [Description1C8(Name = "ФамилияИмяОтчествоДополнение", Comment = "", Synonym = "Фамилия Имя Отчество [дополнение]")]
        ФамилияИмяОтчествоДополнение,
        [Description1C8(Name = "ФамилияИОВидЗанятостиДополнение", Comment = "", Synonym = "Фамилия И. О. (вид занятости) [дополнение]")]
        ФамилияИОВидЗанятостиДополнение,
        [Description1C8(Name = "ФамилияИмяОтчествоВидЗанятостиДополнение", Comment = "", Synonym = "Фамилия Имя Отчество (вид занятости) [дополнение]")]
        ФамилияИмяОтчествоВидЗанятостиДополнение,
        [Description1C8(Name = "ФамилияИОВидЗанятостиУволенДополнение", Comment = "", Synonym = "Фамилия И. О. (вид занятости, ув.) [дополнение]")]
        ФамилияИОВидЗанятостиУволенДополнение,
        [Description1C8(Name = "ФамилияИмяОтчествоВидЗанятостиУволенДополнение", Comment = "", Synonym = "Фамилия Имя Отчество (вид занятости, ув.) [дополнение]")]
        ФамилияИмяОтчествоВидЗанятостиУволенДополнение,
        [Description1C8(Name = "ФамилияИОУволенДополнение", Comment = "", Synonym = "Фамилия И. О. (ув.) [дополнение]")]
        ФамилияИОУволенДополнение,
        [Description1C8(Name = "ФамилияИмяОтчествоУволенДополнение", Comment = "", Synonym = "Фамилия Имя Отчество (ув.) [дополнение]")]
        ФамилияИмяОтчествоУволенДополнение
    }
}
