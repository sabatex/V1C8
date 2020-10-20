using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Catalogs
{
    [Table("HrafykyRabotySotrudnykov")]
    [Description1C8(Name = "ГрафикиРаботыСотрудников", Comment = "", Synonym = "Графики работы сотрудников")]
    public class ГрафикиРаботыСотрудников:EnumItem
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "ПроизводственныйКалендарь", Comment = "", Synonym = "Производственный календарь")]
    public DBNull ПроизводственныйКалендарь {get; set;}
    [Description1C8(Name = "СуммированныйУчетРабочегоВремени", Comment = "", Synonym = "Суммированный учет рабочего времени")]
    public bool СуммированныйУчетРабочегоВремени {get; set;}
    [Description1C8(Name = "ДатаОтсчета", Comment = "", Synonym = "Дата отсчета")]
    public DateTime ДатаОтсчета {get; set;}
    [Description1C8(Name = "ДлительностьРабочейНедели", Comment = "", Synonym = "Длительность рабочей недели")]
    // Format 7.2
    public decimal ДлительностьРабочейНедели {get; set;}
    [Description1C8(Name = "НеполноеРабочееВремя", Comment = "", Synonym = "Неполное рабочее время")]
    public bool НеполноеРабочееВремя {get; set;}
    [Description1C8(Name = "СокращеннаяРабочаяНеделя", Comment = "", Synonym = "Сокращенная рабочая неделя")]
    public bool СокращеннаяРабочаяНеделя {get; set;}
    [Description1C8(Name = "НеполныйРабочийДень", Comment = "", Synonym = "Неполный рабочий день")]
    public bool НеполныйРабочийДень {get; set;}
    [Description1C8(Name = "ГрафикПолногоРабочегоВремени", Comment = "", Synonym = "График полного рабочего времени")]
    public DBNull ГрафикПолногоРабочегоВремени {get; set;}
    [Description1C8(Name = "УчитыватьПраздники", Comment = "", Synonym = "Учитывать праздники")]
    public bool УчитыватьПраздники {get; set;}
    [Description1C8(Name = "СпособЗаполнения", Comment = "", Synonym = "Способ заполнения")]
    public DBNull СпособЗаполнения {get; set;}
    [Description1C8(Name = "РабочихДнейВНеделе", Comment = "", Synonym = "Рабочих дней в неделе")]
    // Format 1.0
    public long РабочихДнейВНеделе {get; set;}
    [Description1C8(Name = "СпособОпределенияНормыСуммированногоУчета", Comment = "", Synonym = "Способ определения нормы суммированного учета")]
    public DBNull СпособОпределенияНормыСуммированногоУчета {get; set;}
    [Description1C8(Name = "ГрафикНормыПриСуммированномУчете", Comment = "", Synonym = "График нормы при суммированном учете")]
    public DBNull ГрафикНормыПриСуммированномУчете {get; set;}
    [Description1C8(Name = "УчитыватьПредпраздничныеДни", Comment = "", Synonym = "Учитывать предпраздничные дни")]
    public bool УчитыватьПредпраздничныеДни {get; set;}
    #endregion реквізити
    }
}
