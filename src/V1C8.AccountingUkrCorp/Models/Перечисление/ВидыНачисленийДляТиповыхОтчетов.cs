using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыНачисленийДляТиповыхОтчетов", Comment = "", Synonym = "Виды начислений для типовых отчетов П-6, П-7")]
    public enum ВидыНачисленийДляТиповыхОтчетов
    {
        [Description1C8(Name = "БольничныеЗаСчетПредприятия", Comment = "", Synonym = "Оплата первых 5 дней временной нетрудоспособности за счет предприятия")]
        БольничныеЗаСчетПредприятия,
        [Description1C8(Name = "ВзносыПредприятийНаМедИПенсСтрахование", Comment = "", Synonym = "Взносы предприятий на медицинское и пенсионное страхование работников")]
        ВзносыПредприятийНаМедИПенсСтрахование,
        [Description1C8(Name = "ВысокоеПрофессиональноеМастерство", Comment = "", Synonym = "Высокое профессиональное мастерство")]
        ВысокоеПрофессиональноеМастерство,
        [Description1C8(Name = "ВознагражденияРазовогоХарактера", Comment = "", Synonym = "Вознаграждения и поощрения разового характера")]
        ВознагражденияРазовогоХарактера,
        [Description1C8(Name = "ВыплатыСоциальногоХарактера", Comment = "", Synonym = "Выплаты социального характера")]
        ВыплатыСоциальногоХарактера,
        [Description1C8(Name = "ВыполнениеОбязанностейВременноОтсутствующегоРаботника", Comment = "", Synonym = "Выполнение обязанностей временно отсутствующего работника")]
        ВыполнениеОбязанностейВременноОтсутствующегоРаботника,
        [Description1C8(Name = "ВыполнениеОсобоВажнойРаботы", Comment = "", Synonym = "Выполнение особо важной работы на определенный срок")]
        ВыполнениеОсобоВажнойРаботы,
        [Description1C8(Name = "ВысокиеДостиженияТруда", Comment = "", Synonym = "Высокие достижения труда")]
        ВысокиеДостиженияТруда,
        [Description1C8(Name = "ГонорарАвторскоеВознаграждение", Comment = "", Synonym = "Гонорар авторское вознаграждение")]
        ГонорарАвторскоеВознаграждение,
        [Description1C8(Name = "ДивидендыПроцентыВыплатыЗаПаями", Comment = "", Synonym = "Дивиденды, проценты, выплаты за паями")]
        ДивидендыПроцентыВыплатыЗаПаями,
        [Description1C8(Name = "ДопускКГосударственнойТайне", Comment = "", Synonym = "Допуск к государственной тайне")]
        ДопускКГосударственнойТайне,
        [Description1C8(Name = "ДругиеВидыНачисленийДопФОТ", Comment = "", Synonym = "Другие виды начислений (фонд дополнительной заработной платы)")]
        ДругиеВидыНачисленийДопФОТ,
        [Description1C8(Name = "ДругиеВидыНачисленийНеФОТ", Comment = "", Synonym = "Другие виды начислений, не принадлежащие фонду оплаты труда")]
        ДругиеВидыНачисленийНеФОТ,
        [Description1C8(Name = "ДругиеВидыНачисленийФОТ", Comment = "", Synonym = "Другие виды начислений, принадлежащие фонду оплаты труда")]
        ДругиеВидыНачисленийФОТ,
        [Description1C8(Name = "ДругиеВыплатыНеФОТ", Comment = "", Synonym = "Другие выплаты, не принадлежащие фонду оплаты труда")]
        ДругиеВыплатыНеФОТ,
        [Description1C8(Name = "ДругиеНадбавкиИДоплаты", Comment = "", Synonym = "Другие надбавки и доплаты")]
        ДругиеНадбавкиИДоплаты,
        [Description1C8(Name = "ДругиеНачисленияЗаНеотработанноеВремя", Comment = "", Synonym = "Другие начисления за неотработанное время")]
        ДругиеНачисленияЗаНеотработанноеВремя,
        [Description1C8(Name = "ДругиеПоощрительныеИКомпенсационныеВыплаты", Comment = "", Synonym = "Другие поощрительные и компенсационные выплаты")]
        ДругиеПоощрительныеИКомпенсационныеВыплаты,
        [Description1C8(Name = "ЗначениеПеречисления1", Comment = "", Synonym = "")]
        ЗначениеПеречисления1,
        [Description1C8(Name = "ЗатратыНаБесплатныйПроезд", Comment = "", Synonym = "Затраты на бесплатный проезд")]
        ЗатратыНаБесплатныйПроезд,
        [Description1C8(Name = "ЗатратыНаКомандировки", Comment = "", Synonym = "Затраты на командировки")]
        ЗатратыНаКомандировки,
        [Description1C8(Name = "ЗнаниеИностранногоЯзыка", Comment = "", Synonym = "Знание и использование в работе иностранного языка")]
        ЗнаниеИностранногоЯзыка,
        [Description1C8(Name = "ИндексацияЗарплаты", Comment = "", Synonym = "Индексация зарплаты")]
        ИндексацияЗарплаты,
        [Description1C8(Name = "ИнтенсивностьТруда", Comment = "", Synonym = "Интенсивность труда")]
        ИнтенсивностьТруда,
        [Description1C8(Name = "КлассностьВодителямТранспортныхСредств", Comment = "", Synonym = "Классность водителям транспортных средств")]
        КлассностьВодителямТранспортныхСредств,
        [Description1C8(Name = "КомиссионныеОтРеализацииПродукции", Comment = "", Synonym = "Комиссионные от реализации продукции")]
        КомиссионныеОтРеализацииПродукции,
        [Description1C8(Name = "КомпенсацияЗаНарушениеСроковВыплатыЗП", Comment = "", Synonym = "Компенсация работникам в связи с нарушением сроков выплаты ЗП")]
        КомпенсацияЗаНарушениеСроковВыплатыЗП,
        [Description1C8(Name = "МатпомощьРазовогоХарактера", Comment = "", Synonym = "Матпомощь разового характера")]
        МатпомощьРазовогоХарактера,
        [Description1C8(Name = "НаучнаяСтепень", Comment = "", Synonym = "Научная степень")]
        НаучнаяСтепень,
        [Description1C8(Name = "НормативноеВремяПередвиженияВШахте", Comment = "", Synonym = "Нормативное время передвижения в шахте")]
        НормативноеВремяПередвиженияВШахте,
        [Description1C8(Name = "ОплатаДнейОтдыха", Comment = "", Synonym = "Оплата дней отдыха")]
        ОплатаДнейОтдыха,
        [Description1C8(Name = "ОплатаЗаПрофобучение", Comment = "", Synonym = "Оплата за профобучение")]
        ОплатаЗаПрофобучение,
        [Description1C8(Name = "ОплатаРаботыСверхурочноВПраздникиНерабочиеДни", Comment = "", Synonym = "Оплата работы в сверхурочное время, в праздничные и нерабочие дни")]
        ОплатаРаботыСверхурочноВПраздникиНерабочиеДни,
        [Description1C8(Name = "ОплатаТрудаВКомандировке", Comment = "", Synonym = "Оплата труда в командировке")]
        ОплатаТрудаВКомандировке,
        [Description1C8(Name = "Отпускные", Comment = "", Synonym = "Отпускные")]
        Отпускные,
        [Description1C8(Name = "ПомощьИДругиеВыплатыЗаСчетФСС", Comment = "", Synonym = "Помощь и другие выплаты, производящиеся за счет средств ФСС")]
        ПомощьИДругиеВыплатыЗаСчетФСС,
        [Description1C8(Name = "Премия", Comment = "", Synonym = "Премия")]
        Премия,
        [Description1C8(Name = "ПроцентныеКомиссионныеВознаграждения", Comment = "", Synonym = "Процентные или комиссионные вознаграждения")]
        ПроцентныеКомиссионныеВознаграждения,
        [Description1C8(Name = "РаботаВНочноеВремя", Comment = "", Synonym = "Работа в ночное время")]
        РаботаВНочноеВремя,
        [Description1C8(Name = "РаботаВТяжелыхВредныхУсловиях", Comment = "", Synonym = "Работа в тяжелых и вредных и особо тяжелых и особо вредных условиях")]
        РаботаВТяжелыхВредныхУсловиях,
        [Description1C8(Name = "РаботаНаТерриторияхРадиоактивногоЗагрязнения", Comment = "", Synonym = "Работа на территориях радиоактивного загрязнения")]
        РаботаНаТерриторияхРадиоактивногоЗагрязнения,
        [Description1C8(Name = "РангиЗвания", Comment = "", Synonym = "Дипломатические ранги, персональные звания служебных лиц, ранги госслужащих, квалификационные классы судей")]
        РангиЗвания,
        [Description1C8(Name = "РасширениеЗоныОбслуживания", Comment = "", Synonym = "Расширение зоны обслуживания или увеличение объема работ")]
        РасширениеЗоныОбслуживания,
        [Description1C8(Name = "РуководствоБригадой", Comment = "", Synonym = "Руководство бригадой")]
        РуководствоБригадой,
        [Description1C8(Name = "СистематическаяМатпомощь", Comment = "", Synonym = "Систематическая матпомощь")]
        СистематическаяМатпомощь,
        [Description1C8(Name = "СовмещениеПрофессий", Comment = "", Synonym = "Совмещение профессий")]
        СовмещениеПрофессий,
        [Description1C8(Name = "СтоимостьПродукцииПриНатуральнойОплатеТруда", Comment = "", Synonym = "Стоимость продукции при натуральной оплате труда")]
        СтоимостьПродукцииПриНатуральнойОплатеТруда,
        [Description1C8(Name = "СтоимостьФорменнойОдежды", Comment = "", Synonym = "Стоимость форменной одежды")]
        СтоимостьФорменнойОдежды,
        [Description1C8(Name = "ТарифнаяСтавкаОклад", Comment = "", Synonym = "Тарифная ставка оклад")]
        ТарифнаяСтавкаОклад,
        [Description1C8(Name = "ПрофсоюзныйВзнос", Comment = "", Synonym = "Профсоюзный взнос")]
        ПрофсоюзныйВзнос
    }
}
