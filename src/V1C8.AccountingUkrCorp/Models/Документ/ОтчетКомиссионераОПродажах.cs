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
    [Table("OtchetKomyssyoneraOProdazhakh")]
    [Description1C8(Name = "ОтчетКомиссионераОПродажах", Comment = "", Synonym = "Отчет комиссионера о продажах")]
    public class ОтчетКомиссионераОПродажах:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СпособРасчетаКомиссионногоВознаграждения", Comment = "", Synonym = "Способ расчета комиссионного вознаграждения")]
        public Enums.СпособыРасчетаКомиссионногоВознаграждения СпособРасчетаКомиссионногоВознаграждения {get; set;}
        [Description1C8(Name = "ПроцентКомиссионногоВознаграждения", Comment = "", Synonym = "Процент комиссионного вознаграждения")]
        // Format 5.2
        public decimal ПроцентКомиссионногоВознаграждения {get; set;}
        [Description1C8(Name = "СтавкаНДСВознаграждения", Comment = "", Synonym = "% НДС с комиссионного вознаграждения")]
        public Enums.СтавкиНДС СтавкаНДСВознаграждения {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "СделкаПоПриобретению", Comment = "", Synonym = "Документ расчетов по приобретению")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств СделкаПоПриобретению {get; set;}
        [Description1C8(Name = "СделкаПоРеализации", Comment = "", Synonym = "Документ расчетов по реализации")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств СделкаПоРеализации {get; set;}
        [Description1C8(Name = "УдержатьВознаграждение", Comment = "", Synonym = "Удержать вознаграждение")]
        public bool УдержатьВознаграждение {get; set;}
        [Description1C8(Name = "СчетУчетаЗатрат", Comment = "", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетУчетаЗатрат {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "СуммаВознаграждения", Comment = "", Synonym = "Вознаграждение")]
        // Format 15.2
        public decimal СуммаВознаграждения {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "", Synonym = "Счет расчетов за товары")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансамПолученным", Comment = "", Synonym = "Счет расчетов по авансам полученным")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансамПолученным {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансамВыданным", Comment = "", Synonym = "Счет расчетов по авансам выданным")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансамВыданным {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовЗаПосредническиеУслуги", Comment = "", Synonym = "Счет расчетов по вознаграждению")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовЗаПосредническиеУслуги {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПриобретений", Comment = "", Synonym = "Счет НДС по вознаграждению (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПриобретений {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "", Synonym = "Номер документа сторонней организации")]
        [StringLength(30)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "", Synonym = "Дата документа сторонней организации")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПриобретенийПодтвержденный", Comment = "", Synonym = "Счет НДС по вознаграждению (налоговый кредит)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПриобретенийПодтвержденный {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПродаж", Comment = "", Synonym = "Счет НДС по продаже (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПродаж {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПродажПодтвержденный", Comment = "", Synonym = "Счет НДС по продаже (нал. обязательстава)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПродажПодтвержденный {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
        public List<ОтчетКомиссионераОПродажах_Товары> ОтчетКомиссионераОПродажахТовары {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
    [Table("OtchetKomyssyoneraOProdazhakh_Tovary")]
    public class ОтчетКомиссионераОПродажах_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ЦенаПередачи", Comment = "", Synonym = "Цена передачи")]
        // Format 15.2
        public decimal ЦенаПередачи {get; set;}
        [Description1C8(Name = "СуммаПередачи", Comment = "", Synonym = "Сумма передачи")]
        // Format 15.2
        public decimal СуммаПередачи {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СуммаВознаграждения", Comment = "", Synonym = "Сумма вознаграждения")]
        // Format 15.2
        public decimal СуммаВознаграждения {get; set;}
        [Description1C8(Name = "СуммаНДСВознаграждения", Comment = "", Synonym = "НДС вознаграждения")]
        // Format 15.2
        public decimal СуммаНДСВознаграждения {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СхемаРеализации", Comment = "", Synonym = "Схема реализации")]
        public Catalogs.СхемыРеализации СхемаРеализации {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение (доходов и затрат)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    }
}
