using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.AccountingUkrCorp;

namespace sabatex.V1C8.AccountingUkrCorp.PostgreSQLDbContext
{
    public class V1C8DbContext:DbContext
    {
        public DbSet<Models.Enums.БазаРаспределенияВнутреннихУслуг> БазаРаспределенияВнутреннихУслуг { get; set; }
        public DbSet<Models.Enums.БонусныеПрограммыБанков> БонусныеПрограммыБанков { get; set; }
        public DbSet<Models.Enums.ВариантВыраженияВнутреннихУслуг> ВариантВыраженияВнутреннихУслуг { get; set; }
        public DbSet<Models.Enums.ВариантыSMTPАутентификации> ВариантыSMTPАутентификации { get; set; }
        public DbSet<Models.Enums.ВариантыАлгоритмовРасчетНДФЛ17> ВариантыАлгоритмовРасчетНДФЛ17 { get; set; }
        public DbSet<Models.Enums.ВариантыВерсионированияОбъектов> ВариантыВерсионированияОбъектов { get; set; }
        public DbSet<Models.Enums.ВариантыИспользованияВнешнихКомпонент> ВариантыИспользованияВнешнихКомпонент { get; set; }
        public DbSet<Models.Enums.ВариантыИспользованияПериодаНачисления> ВариантыИспользованияПериодаНачисления { get; set; }
        public DbSet<Models.Enums.ВариантыОчисткиФайлов> ВариантыОчисткиФайлов { get; set; }
        public DbSet<Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники> ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники { get; set; }
        public DbSet<Models.Enums.ВариантыПубликацииДополнительныхОтчетовИОбработок> ВариантыПубликацииДополнительныхОтчетовИОбработок { get; set; }
        public DbSet<Models.Enums.ВариантыСжатияTIFF> ВариантыСжатияTIFF { get; set; }
        public DbSet<Models.Enums.ВариантыУдержанияНДФЛ> ВариантыУдержанияНДФЛ { get; set; }
        public DbSet<Models.Enums.ВедениеВзаиморасчетовПоДоговорам> ВедениеВзаиморасчетовПоДоговорам { get; set; }
        public DbSet<Models.Enums.ВерсииПодсистемыОбменаДанными> ВерсииПодсистемыОбменаДанными { get; set; }
        public DbSet<Models.Enums.ВерсииФорматовВыгрузки> ВерсииФорматовВыгрузки { get; set; }
        public DbSet<Models.Enums.ВидыБазыУдержанияПоИсполнительномуДокументу> ВидыБазыУдержанияПоИсполнительномуДокументу { get; set; }
        public DbSet<Models.Enums.ВидыВзаиморасчетовССотрудниками> ВидыВзаиморасчетовССотрудниками { get; set; }
        public DbSet<Models.Enums.ВидыГруппУчетаНачисленийИУдержаний> ВидыГруппУчетаНачисленийИУдержаний { get; set; }
        public DbSet<Models.Enums.ВидыДанныхУчетаВремениСотрудников> ВидыДанныхУчетаВремениСотрудников { get; set; }
        public DbSet<Models.Enums.ВидыДействийКалендаряБухгалтера> ВидыДействийКалендаряБухгалтера { get; set; }
        public DbSet<Models.Enums.ВидыДействияСНачислением> ВидыДействияСНачислением { get; set; }
        public DbSet<Models.Enums.ВидыДеятельностиДляДДС> ВидыДеятельностиДляДДС { get; set; }
        public DbSet<Models.Enums.ВидыДеятельностиНДС> ВидыДеятельностиНДС { get; set; }
        public DbSet<Models.Enums.ВидыДнейПроизводственногоКалендаря> ВидыДнейПроизводственногоКалендаря { get; set; }
        public DbSet<Models.Enums.ВидыДоговоровКонтрагентов> ВидыДоговоровКонтрагентов { get; set; }
        public DbSet<Models.Enums.ВидыДоговоровССотрудниками> ВидыДоговоровССотрудниками { get; set; }
        public DbSet<Models.Enums.ВидыДокументовМежрасчетныхНачислений> ВидыДокументовМежрасчетныхНачислений { get; set; }
        public DbSet<Models.Enums.ВидыДокументовНачисления> ВидыДокументовНачисления { get; set; }
        public DbSet<Models.Enums.ВидыДокументовУдержания> ВидыДокументовУдержания { get; set; }
        public DbSet<Models.Enums.ВидыДополнительныхОтчетовИОбработок> ВидыДополнительныхОтчетовИОбработок { get; set; }
        public DbSet<Models.Enums.ВидыЕСВ> ВидыЕСВ { get; set; }
        public DbSet<Models.Enums.ВидыЗадолженности> ВидыЗадолженности { get; set; }
        public DbSet<Models.Enums.ВидыЗанятости> ВидыЗанятости { get; set; }
        public DbSet<Models.Enums.ВидыЗатрат> ВидыЗатрат { get; set; }
        public DbSet<Models.Enums.ВидыИсполнительныхДокументов> ВидыИсполнительныхДокументов { get; set; }
        public DbSet<Models.Enums.ВидыИспользованияАмортизации> ВидыИспользованияАмортизации { get; set; }
        public DbSet<Models.Enums.ВидыКадровыхСобытий> ВидыКадровыхСобытий { get; set; }
        public DbSet<Models.Enums.ВидыКодовДляНалоговойНакладной> ВидыКодовДляНалоговойНакладной { get; set; }
        public DbSet<Models.Enums.ВидыКонтактныхЛиц> ВидыКонтактныхЛиц { get; set; }
        public DbSet<Models.Enums.ВидыКонтрагентовВМонитореРуководителя> ВидыКонтрагентовВМонитореРуководителя { get; set; }
        public DbSet<Models.Enums.ВидыКорректировокНалоговогоКредита> ВидыКорректировокНалоговогоКредита { get; set; }
        public DbSet<Models.Enums.ВидыМалоценныхАктивов> ВидыМалоценныхАктивов { get; set; }
        public DbSet<Models.Enums.ВидыМестВыплатыЗарплаты> ВидыМестВыплатыЗарплаты { get; set; }
        public DbSet<Models.Enums.ВидыМонетарныхСтатейВВалюте> ВидыМонетарныхСтатейВВалюте { get; set; }
        public DbSet<Models.Enums.ВидыНазначенияДатЗапрета> ВидыНазначенияДатЗапрета { get; set; }
        public DbSet<Models.Enums.ВидыНалоговыхГруппНА> ВидыНалоговыхГруппНА { get; set; }
        public DbSet<Models.Enums.ВидыНалоговыхДеклараций> ВидыНалоговыхДеклараций { get; set; }
        public DbSet<Models.Enums.ВидыНаследованияПравДоступаИерархическихСправочников> ВидыНаследованияПравДоступаИерархическихСправочников { get; set; }
        public DbSet<Models.Enums.ВидыНачисленийДляТиповыхОтчетов> ВидыНачисленийДляТиповыхОтчетов { get; set; }
        public DbSet<Models.Enums.ВидыОбъектовДоступа> ВидыОбъектовДоступа { get; set; }
        public DbSet<Models.Enums.ВидыОбязательногоСтрахованияСотрудников> ВидыОбязательногоСтрахованияСотрудников { get; set; }
        public DbSet<Models.Enums.ВидыОграниченияПособия> ВидыОграниченияПособия { get; set; }
        public DbSet<Models.Enums.ВидыОперацийВозвратТоваров> ВидыОперацийВозвратТоваров { get; set; }
        public DbSet<Models.Enums.ВидыОперацийВозвратТоваровОтПокупателя> ВидыОперацийВозвратТоваровОтПокупателя { get; set; }
        public DbSet<Models.Enums.ВидыОперацийВозвратТоваровПоставщику> ВидыОперацийВозвратТоваровПоставщику { get; set; }
        public DbSet<Models.Enums.ВидыОперацийДоверенность> ВидыОперацийДоверенность { get; set; }
        public DbSet<Models.Enums.ВидыОперацийКомплектацияНоменклатуры> ВидыОперацийКомплектацияНоменклатуры { get; set; }
        public DbSet<Models.Enums.ВидыОперацийКорректировкаДолга> ВидыОперацийКорректировкаДолга { get; set; }
        public DbSet<Models.Enums.ВидыОперацийНалоговаяНакладная> ВидыОперацийНалоговаяНакладная { get; set; }
        public DbSet<Models.Enums.ВидыОперацийОприходованиеТоваров> ВидыОперацийОприходованиеТоваров { get; set; }
        public DbSet<Models.Enums.ВидыОперацийОтчетОРозничныхПродажах> ВидыОперацийОтчетОРозничныхПродажах { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПередачаТоваров> ВидыОперацийПередачаТоваров { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПеремещениеТоваров> ВидыОперацийПеремещениеТоваров { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПКО> ВидыОперацийПКО { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПоЗарплате> ВидыОперацийПоЗарплате { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПокупкаПродажаВалюты> ВидыОперацийПокупкаПродажаВалюты { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПоступлениеДенежныхСредств> ВидыОперацийПоступлениеДенежныхСредств { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПоступлениеТоваровУслуг> ВидыОперацийПоступлениеТоваровУслуг { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПриложение1КНалоговойНакладной> ВидыОперацийПриложение1КНалоговойНакладной { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной> ВидыОперацийПриложение2КНалоговойНакладной { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПринятияКУчетуНМА> ВидыОперацийПринятияКУчетуНМА { get; set; }
        public DbSet<Models.Enums.ВидыОперацийПринятияКУчетуОсновныхСредств> ВидыОперацийПринятияКУчетуОсновныхСредств { get; set; }
        public DbSet<Models.Enums.ВидыОперацийРасчетаКосвенныхРасходов> ВидыОперацийРасчетаКосвенныхРасходов { get; set; }
        public DbSet<Models.Enums.ВидыОперацийРасчетаСебестоимости> ВидыОперацийРасчетаСебестоимости { get; set; }
        public DbSet<Models.Enums.ВидыОперацийРеализацияТоваров> ВидыОперацийРеализацияТоваров { get; set; }
        public DbSet<Models.Enums.ВидыОперацийРегистрацияАвансовВНалоговомУчете> ВидыОперацийРегистрацияАвансовВНалоговомУчете { get; set; }
        public DbSet<Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента> ВидыОперацийРегистрацияВходящегоНалоговогоДокумента { get; set; }
        public DbSet<Models.Enums.ВидыОперацийРКО> ВидыОперацийРКО { get; set; }
        public DbSet<Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств> ВидыОперацийСписаниеБезналичныхДенежныхСредств { get; set; }
        public DbSet<Models.Enums.ВидыОперацийСписаниеДенежныхСредств> ВидыОперацийСписаниеДенежныхСредств { get; set; }
        public DbSet<Models.Enums.ВидыОперацийСписаниеТоваров> ВидыОперацийСписаниеТоваров { get; set; }
        public DbSet<Models.Enums.ВидыОперацийСчетНаОплатуПоставщика> ВидыОперацийСчетНаОплатуПоставщика { get; set; }
        public DbSet<Models.Enums.ВидыОперацийТребованиеНакладная> ВидыОперацийТребованиеНакладная { get; set; }
        public DbSet<Models.Enums.ВидыОплатыЗарплатнойКарты> ВидыОплатыЗарплатнойКарты { get; set; }
        public DbSet<Models.Enums.ВидыОплатыТруда> ВидыОплатыТруда { get; set; }
        public DbSet<Models.Enums.ВидыОсобыхНачисленийИУдержаний> ВидыОсобыхНачисленийИУдержаний { get; set; }
        public DbSet<Models.Enums.ВидыОстатковНДСПриобретенийОжидаемый> ВидыОстатковНДСПриобретенийОжидаемый { get; set; }
        public DbSet<Models.Enums.ВидыОстатковНДСПриобретенийПодтвержденный> ВидыОстатковНДСПриобретенийПодтвержденный { get; set; }
        public DbSet<Models.Enums.ВидыОстатковНДСПродажОжидаемый> ВидыОстатковНДСПродажОжидаемый { get; set; }
        public DbSet<Models.Enums.ВидыОстатковНДСПродажПодтвержденный> ВидыОстатковНДСПродажПодтвержденный { get; set; }
        public DbSet<Models.Enums.ВидыОтчетности> ВидыОтчетности { get; set; }
        public DbSet<Models.Enums.ВидыПлатежейВСоциальныеФонды> ВидыПлатежейВСоциальныеФонды { get; set; }
        public DbSet<Models.Enums.ВидыПлатежейПогашенияЗаймаСотруднику> ВидыПлатежейПогашенияЗаймаСотруднику { get; set; }
        public DbSet<Models.Enums.ВидыПодтверждающихДокументовОтпускаПоУходу> ВидыПодтверждающихДокументовОтпускаПоУходу { get; set; }
        public DbSet<Models.Enums.ВидыПравилДляОбменаДанными> ВидыПравилДляОбменаДанными { get; set; }
        public DbSet<Models.Enums.ВидыПределовДоходовНДФЛ> ВидыПределовДоходовНДФЛ { get; set; }
        public DbSet<Models.Enums.ВидыПризовПодарков> ВидыПризовПодарков { get; set; }
        public DbSet<Models.Enums.ВидыПрофессиональнойПодготовки> ВидыПрофессиональнойПодготовки { get; set; }
        public DbSet<Models.Enums.ВидыПрочихСчетовУчета> ВидыПрочихСчетовУчета { get; set; }
        public DbSet<Models.Enums.ВидыРаботСДосрочнойПенсией> ВидыРаботСДосрочнойПенсией { get; set; }
        public DbSet<Models.Enums.ВидыРабочегоВремениСотрудников> ВидыРабочегоВремениСотрудников { get; set; }
        public DbSet<Models.Enums.ВидыРабочихГрафиков> ВидыРабочихГрафиков { get; set; }
        public DbSet<Models.Enums.ВидыРасчетовПоДоговорам> ВидыРасчетовПоДоговорам { get; set; }
        public DbSet<Models.Enums.ВидыРасчетовПоСредствамФСС> ВидыРасчетовПоСредствамФСС { get; set; }
        public DbSet<Models.Enums.ВидыСобытийОС> ВидыСобытийОС { get; set; }
        public DbSet<Models.Enums.ВидыСообщений> ВидыСообщений { get; set; }
        public DbSet<Models.Enums.ВидыСостоянийНМА> ВидыСостоянийНМА { get; set; }
        public DbSet<Models.Enums.ВидыСправокОДоходах> ВидыСправокОДоходах { get; set; }
        public DbSet<Models.Enums.ВидыСтавокНДФЛ> ВидыСтавокНДФЛ { get; set; }
        public DbSet<Models.Enums.ВидыСтоимости> ВидыСтоимости { get; set; }
        public DbSet<Models.Enums.ВидыТарифныхСеток> ВидыТарифныхСеток { get; set; }
        public DbSet<Models.Enums.ВидыТарифныхСтавок> ВидыТарифныхСтавок { get; set; }
        public DbSet<Models.Enums.ВидыТранспортаСообщенийОбмена> ВидыТранспортаСообщенийОбмена { get; set; }
        public DbSet<Models.Enums.ВидыТрудовогоСтажа> ВидыТрудовогоСтажа { get; set; }
        public DbSet<Models.Enums.ВидыУдержанийДляТиповыхОтчетов> ВидыУдержанийДляТиповыхОтчетов { get; set; }
        public DbSet<Models.Enums.ВидыУлучшения> ВидыУлучшения { get; set; }
        public DbSet<Models.Enums.ВидыУчетаВремениДляСредней> ВидыУчетаВремениДляСредней { get; set; }
        public DbSet<Models.Enums.ГодностьКВоеннойСлужбе> ГодностьКВоеннойСлужбе { get; set; }
        public DbSet<Models.Enums.ГруппыИнвалидности> ГруппыИнвалидности { get; set; }
        public DbSet<Models.Enums.ГруппыНалоговыхНазначений> ГруппыНалоговыхНазначений { get; set; }
        public DbSet<Models.Enums.ГруппыНачисленияУдержанияВыплаты> ГруппыНачисленияУдержанияВыплаты { get; set; }
        public DbSet<Models.Enums.ГруппыПлательщиковЕдиногоНалога> ГруппыПлательщиковЕдиногоНалога { get; set; }
        public DbSet<Models.Enums.ГруппыУчетаКарточкиВоинскогоУчета> ГруппыУчетаКарточкиВоинскогоУчета { get; set; }
        public DbSet<Models.Enums.ДействияПриОбмене> ДействияПриОбмене { get; set; }
        public DbSet<Models.Enums.ДействияСЕжегоднымиОтпусками> ДействияСЕжегоднымиОтпусками { get; set; }
        public DbSet<Models.Enums.ДействияСНачислениямиИУдержаниями> ДействияСНачислениямиИУдержаниями { get; set; }
        public DbSet<Models.Enums.ДействияСПозициямиШтатногоРасписания> ДействияСПозициямиШтатногоРасписания { get; set; }
        public DbSet<Models.Enums.ДействияСУдержаниями> ДействияСУдержаниями { get; set; }
        public DbSet<Models.Enums.ДействияСФайламиПоДвойномуЩелчку> ДействияСФайламиПоДвойномуЩелчку { get; set; }
        public DbSet<Models.Enums.ДополнительнаяКолонкаПечатныхФормДокументов> ДополнительнаяКолонкаПечатныхФормДокументов { get; set; }
        public DbSet<Models.Enums.ДополнительныеЗначенияДоступа> ДополнительныеЗначенияДоступа { get; set; }
        public DbSet<Models.Enums.ДоступныеПериодыОтчета> ДоступныеПериодыОтчета { get; set; }
        public DbSet<Models.Enums.ЕдиницыВремениУчетаСпецстажа> ЕдиницыВремениУчетаСпецстажа { get; set; }
        public DbSet<Models.Enums.ЗадачиНачалаРаботы> ЗадачиНачалаРаботы { get; set; }
        public DbSet<Models.Enums.ЗначениеРесурсаРегистровСостоянийСотрудника> ЗначениеРесурсаРегистровСостоянийСотрудника { get; set; }
        public DbSet<Models.Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка> ИсточникиДанныхДляРасчетаСреднегоЗаработка { get; set; }
        public DbSet<Models.Enums.ИсточникиПравилДляОбменаДанными> ИсточникиПравилДляОбменаДанными { get; set; }
        public DbSet<Models.Enums.КатегорииДолжностейДляВоинскогоУчета> КатегорииДолжностейДляВоинскогоУчета { get; set; }
        public DbSet<Models.Enums.КатегорииДолжностейДляСтатистическогоУчета> КатегорииДолжностейДляСтатистическогоУчета { get; set; }
        public DbSet<Models.Enums.КатегорииДолжностейДляУчетаЗабронированных> КатегорииДолжностейДляУчетаЗабронированных { get; set; }
        public DbSet<Models.Enums.КатегорииЗапасаВоеннообязанных> КатегорииЗапасаВоеннообязанных { get; set; }
        public DbSet<Models.Enums.КатегорииНачисленийИНеоплаченногоВремени> КатегорииНачисленийИНеоплаченногоВремени { get; set; }
        public DbSet<Models.Enums.КатегорииРасчетов> КатегорииРасчетов { get; set; }
        public DbSet<Models.Enums.КатегорииСведенийОФизическихЛицах> КатегорииСведенийОФизическихЛицах { get; set; }
        public DbSet<Models.Enums.КатегорииСотрудниковОбменаСБанками> КатегорииСотрудниковОбменаСБанками { get; set; }
        public DbSet<Models.Enums.КатегорииСтажа> КатегорииСтажа { get; set; }
        public DbSet<Models.Enums.КатегорииСтатистическогоНаблюдения> КатегорииСтатистическогоНаблюдения { get; set; }
        public DbSet<Models.Enums.КатегорииУдержаний> КатегорииУдержаний { get; set; }
        public DbSet<Models.Enums.КлассификаторВоинскихЗваний> КлассификаторВоинскихЗваний { get; set; }
        public DbSet<Models.Enums.КлассыСчетовРасходов> КлассыСчетовРасходов { get; set; }
        public DbSet<Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки> КлассыУсловийТрудаПоРезультатамСпециальнойОценки { get; set; }
        public DbSet<Models.Enums.КодировкаФайловОбменаПоЗарплатномуПроекту> КодировкаФайловОбменаПоЗарплатномуПроекту { get; set; }
        public DbSet<Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций> КодыОперацийВзаиморасчетыСРаботникамиОрганизаций { get; set; }
        public DbSet<Models.Enums.КодыОперацийНДСНалоговыйКредит> КодыОперацийНДСНалоговыйКредит { get; set; }
        public DbSet<Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений> КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений { get; set; }
        public DbSet<Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж> КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж { get; set; }
        public DbSet<Models.Enums.КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет> КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет { get; set; }
        public DbSet<Models.Enums.КомпенсацияУдержаниеОтпускаПриУвольнении> КомпенсацияУдержаниеОтпускаПриУвольнении { get; set; }
        public DbSet<Models.Enums.МетодыКорректировкиНалоговогоКредита> МетодыКорректировкиНалоговогоКредита { get; set; }
        public DbSet<Models.Enums.МетодыНачисленияРезервовОтпусков> МетодыНачисленияРезервовОтпусков { get; set; }
        public DbSet<Models.Enums.МетодыРаспределенияРБП> МетодыРаспределенияРБП { get; set; }
        public DbSet<Models.Enums.МоментыОпределенияНалоговойБазы> МоментыОпределенияНалоговойБазы { get; set; }
        public DbSet<Models.Enums.НазначенияПоказателейРасчетаЗарплаты> НазначенияПоказателейРасчетаЗарплаты { get; set; }
        public DbSet<Models.Enums.Нумераторы> Нумераторы { get; set; }
        public DbSet<Models.Enums.ОперацииАдминистрированияПрофилейБезопасности> ОперацииАдминистрированияПрофилейБезопасности { get; set; }
        public DbSet<Models.Enums.ОснованияДляДоначисленияСтраховыхВзносов> ОснованияДляДоначисленияСтраховыхВзносов { get; set; }
        public DbSet<Models.Enums.ОснованияЛьготПоПособию> ОснованияЛьготПоПособию { get; set; }
        public DbSet<Models.Enums.ОтветственныеЛицаОрганизаций> ОтветственныеЛицаОрганизаций { get; set; }
        public DbSet<Models.Enums.ОтношениеКВоинскойОбязанности> ОтношениеКВоинскойОбязанности { get; set; }
        public DbSet<Models.Enums.ОтношениеКВоинскомуУчету> ОтношениеКВоинскомуУчету { get; set; }
        public DbSet<Models.Enums.ПереченьПособийСоциальногоСтрахования> ПереченьПособийСоциальногоСтрахования { get; set; }
        public DbSet<Models.Enums.ПериодичностиРасписанийРассылокОтчетов> ПериодичностиРасписанийРассылокОтчетов { get; set; }
        public DbSet<Models.Enums.Периодичность> Периодичность { get; set; }
        public DbSet<Models.Enums.ПериодОчисткиФайлов> ПериодОчисткиФайлов { get; set; }
        public DbSet<Models.Enums.ПериодыВводаДанныхОВремени> ПериодыВводаДанныхОВремени { get; set; }
        public DbSet<Models.Enums.ПериодыРасчетаБазовыхНачислений> ПериодыРасчетаБазовыхНачислений { get; set; }
        public DbSet<Models.Enums.ПолФизическогоЛица> ПолФизическогоЛица { get; set; }
        public DbSet<Models.Enums.ПорогиШкалыСтавокНалогов> ПорогиШкалыСтавокНалогов { get; set; }
        public DbSet<Models.Enums.ПорядкиОкругления> ПорядкиОкругления { get; set; }
        public DbSet<Models.Enums.ПорядкиОкругленияОтчетности> ПорядкиОкругленияОтчетности { get; set; }
        public DbSet<Models.Enums.ПорядокЗаполненияНалогов> ПорядокЗаполненияНалогов { get; set; }
        public DbSet<Models.Enums.ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка> ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка { get; set; }
        public DbSet<Models.Enums.ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг> ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг { get; set; }
        public DbSet<Models.Enums.ПорядокРаспределенияРасходовНаОказаниеУслуг> ПорядокРаспределенияРасходовНаОказаниеУслуг { get; set; }
        public DbSet<Models.Enums.ПорядокРасчетаСреднегоЗаработкаОбщий> ПорядокРасчетаСреднегоЗаработкаОбщий { get; set; }
        public DbSet<Models.Enums.ПорядокРасчетаСреднегоЗаработкаФСС> ПорядокРасчетаСреднегоЗаработкаФСС { get; set; }
        public DbSet<Models.Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда> ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда { get; set; }
        public DbSet<Models.Enums.ПорядокФормированияИндивидуальныхСведенийУчетаВремени> ПорядокФормированияИндивидуальныхСведенийУчетаВремени { get; set; }
        public DbSet<Models.Enums.ПорядокФормированияСправкиОДоходахФизическогоЛица> ПорядокФормированияСправкиОДоходахФизическогоЛица { get; set; }
        public DbSet<Models.Enums.ПравилаОкругленияПриРасчетеЗарплаты> ПравилаОкругленияПриРасчетеЗарплаты { get; set; }
        public DbSet<Models.Enums.ПредставлениеТарифовИНадбавок> ПредставлениеТарифовИНадбавок { get; set; }
        public DbSet<Models.Enums.ПриоритетыОбъектовОбмена> ПриоритетыОбъектовОбмена { get; set; }
        public DbSet<Models.Enums.ПричиныИзмененияСостояния> ПричиныИзмененияСостояния { get; set; }
        public DbSet<Models.Enums.ПричиныНетрудоспособности> ПричиныНетрудоспособности { get; set; }
        public DbSet<Models.Enums.ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса> ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса { get; set; }
        public DbSet<Models.Enums.ПричиныОтключенияРасширенийВМоделиСервиса> ПричиныОтключенияРасширенийВМоделиСервиса { get; set; }
        public DbSet<Models.Enums.ПричиныСовмещения> ПричиныСовмещения { get; set; }
        public DbSet<Models.Enums.ПрофилиОфицеров> ПрофилиОфицеров { get; set; }
        public DbSet<Models.Enums.РазделыМонитораРуководителя> РазделыМонитораРуководителя { get; set; }
        public DbSet<Models.Enums.РазделыОтчетовПоЗарплате> РазделыОтчетовПоЗарплате { get; set; }
        public DbSet<Models.Enums.РазделыУчета> РазделыУчета { get; set; }
        public DbSet<Models.Enums.РазделыУчетаДляВводаОстатков> РазделыУчетаДляВводаОстатков { get; set; }
        public DbSet<Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011> РазделыУчетаДляКорректировкиОстатковНКУна01042011 { get; set; }
        public DbSet<Models.Enums.РазмерыБумаги> РазмерыБумаги { get; set; }
        public DbSet<Models.Enums.РазрешенияСканированногоИзображения> РазрешенияСканированногоИзображения { get; set; }
        public DbSet<Models.Enums.РасчетыВозврат> РасчетыВозврат { get; set; }
        public DbSet<Models.Enums.РежимНачисленияЗарплаты> РежимНачисленияЗарплаты { get; set; }
        public DbSet<Models.Enums.РежимОтбораДокументов> РежимОтбораДокументов { get; set; }
        public DbSet<Models.Enums.РежимыВыбораПартий> РежимыВыбораПартий { get; set; }
        public DbSet<Models.Enums.РежимыВыгрузкиОбъектовОбмена> РежимыВыгрузкиОбъектовОбмена { get; set; }
        public DbSet<Models.Enums.РежимыЗавершенияРаботыПользователей> РежимыЗавершенияРаботыПользователей { get; set; }
        public DbSet<Models.Enums.РежимыИспользованияИнформационнойБазы> РежимыИспользованияИнформационнойБазы { get; set; }
        public DbSet<Models.Enums.РежимыОбменаДанными> РежимыОбменаДанными { get; set; }
        public DbSet<Models.Enums.РежимыРаботыФормыСотрудника> РежимыРаботыФормыСотрудника { get; set; }
        public DbSet<Models.Enums.РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок> РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок { get; set; }
        public DbSet<Models.Enums.РежимыФормированияПечатныхФорм> РежимыФормированияПечатныхФорм { get; set; }
        public DbSet<Models.Enums.РезультатыВыполненияОбмена> РезультатыВыполненияОбмена { get; set; }
        public DbSet<Models.Enums.РезультатыЗачисленияЗарплаты> РезультатыЗачисленияЗарплаты { get; set; }
        public DbSet<Models.Enums.РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса> РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса { get; set; }
        public DbSet<Models.Enums.РезультатыОткрытияЛицевыхСчетовСотрудников> РезультатыОткрытияЛицевыхСчетовСотрудников { get; set; }
        public DbSet<Models.Enums.РолиСотрудников> РолиСотрудников { get; set; }
        public DbSet<Models.Enums.РолиФизическихЛиц> РолиФизическихЛиц { get; set; }
        public DbSet<Models.Enums.СлучаиУходаЗаБольнымиДетьми> СлучаиУходаЗаБольнымиДетьми { get; set; }
        public DbSet<Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПриобретений> СобытияОжидаемыйИПодтвержденныйНДСПриобретений { get; set; }
        public DbSet<Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж> СобытияОжидаемыйИПодтвержденныйНДСПродаж { get; set; }
        public DbSet<Models.Enums.СобытияПриобретенияНалоговыйУчет> СобытияПриобретенияНалоговыйУчет { get; set; }
        public DbSet<Models.Enums.СобытияПродажиНалоговыйУчет> СобытияПродажиНалоговыйУчет { get; set; }
        public DbSet<Models.Enums.СообщенияДляРегОтчетов> СообщенияДляРегОтчетов { get; set; }
        public DbSet<Models.Enums.СостояниеЗачисленияЗарплаты> СостояниеЗачисленияЗарплаты { get; set; }
        public DbSet<Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника> СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника { get; set; }
        public DbSet<Models.Enums.СостоянияЗаданий> СостоянияЗаданий { get; set; }
        public DbSet<Models.Enums.СостоянияЗапросовНаИспользованиеВнешнихРесурсов> СостоянияЗапросовНаИспользованиеВнешнихРесурсов { get; set; }
        public DbSet<Models.Enums.СостоянияИнтеграцииОбъектов> СостоянияИнтеграцииОбъектов { get; set; }
        public DbSet<Models.Enums.СостоянияМиграцииПриложения> СостоянияМиграцииПриложения { get; set; }
        public DbSet<Models.Enums.СостоянияОС> СостоянияОС { get; set; }
        public DbSet<Models.Enums.СостоянияПодключенияСервисов> СостоянияПодключенияСервисов { get; set; }
        public DbSet<Models.Enums.СостоянияПроведенияВПоследовательности> СостоянияПроведенияВПоследовательности { get; set; }
        public DbSet<Models.Enums.СостоянияСогласования> СостоянияСогласования { get; set; }
        public DbSet<Models.Enums.СостоянияСотрудника> СостоянияСотрудника { get; set; }
        public DbSet<Models.Enums.СоциальныеГруппыНаселения> СоциальныеГруппыНаселения { get; set; }
        public DbSet<Models.Enums.СпособыPOP3Аутентификации> СпособыPOP3Аутентификации { get; set; }
        public DbSet<Models.Enums.СпособыSMTPАутентификации> СпособыSMTPАутентификации { get; set; }
        public DbSet<Models.Enums.СпособыАутентификации> СпособыАутентификации { get; set; }
        public DbSet<Models.Enums.СпособыВводаЗначенийПоказателейРасчетаЗарплаты> СпособыВводаЗначенийПоказателейРасчетаЗарплаты { get; set; }
        public DbSet<Models.Enums.СпособыВызоваДополнительныхОбработок> СпособыВызоваДополнительныхОбработок { get; set; }
        public DbSet<Models.Enums.СпособыВыполненияНачислений> СпособыВыполненияНачислений { get; set; }
        public DbSet<Models.Enums.СпособыВыполненияУдержаний> СпособыВыполненияУдержаний { get; set; }
        public DbSet<Models.Enums.СпособыДоставкиКорреспонденцииБанка> СпособыДоставкиКорреспонденцииБанка { get; set; }
        public DbSet<Models.Enums.СпособыЗаполненияГрафикаРаботы> СпособыЗаполненияГрафикаРаботы { get; set; }
        public DbSet<Models.Enums.СпособыЗаполненияЦен> СпособыЗаполненияЦен { get; set; }
        public DbSet<Models.Enums.СпособыКомпенсацииПереработки> СпособыКомпенсацииПереработки { get; set; }
        public DbSet<Models.Enums.СпособыНачисленияАмортизацииНМА> СпособыНачисленияАмортизацииНМА { get; set; }
        public DbSet<Models.Enums.СпособыНачисленияАмортизацииОС> СпособыНачисленияАмортизацииОС { get; set; }
        public DbSet<Models.Enums.СпособыОплатыПоДоговоруГПХ> СпособыОплатыПоДоговоруГПХ { get; set; }
        public DbSet<Models.Enums.СпособыОпределенияНормыСуммированногоУчета> СпособыОпределенияНормыСуммированногоУчета { get; set; }
        public DbSet<Models.Enums.СпособыОткрытияФайлаНаПросмотр> СпособыОткрытияФайлаНаПросмотр { get; set; }
        public DbSet<Models.Enums.СпособыОценки> СпособыОценки { get; set; }
        public DbSet<Models.Enums.СпособыОценкиСтоимостиВстречногоВыпуска> СпособыОценкиСтоимостиВстречногоВыпуска { get; set; }
        public DbSet<Models.Enums.СпособыОценкиТоваровВРознице> СпособыОценкиТоваровВРознице { get; set; }
        public DbSet<Models.Enums.СпособыПоворотаИзображения> СпособыПоворотаИзображения { get; set; }
        public DbSet<Models.Enums.СпособыПогашенияЗаймаСотруднику> СпособыПогашенияЗаймаСотруднику { get; set; }
        public DbSet<Models.Enums.СпособыПредоставленияЗаймаСотруднику> СпособыПредоставленияЗаймаСотруднику { get; set; }
        public DbSet<Models.Enums.СпособыПримененияЗначенийПоказателейРасчетаЗарплаты> СпособыПримененияЗначенийПоказателейРасчетаЗарплаты { get; set; }
        public DbSet<Models.Enums.СпособыПримененияЛьготРаботников> СпособыПримененияЛьготРаботников { get; set; }
        public DbSet<Models.Enums.СпособыРаспределенияДопРасходов> СпособыРаспределенияДопРасходов { get; set; }
        public DbSet<Models.Enums.СпособыРаспределенияКосвенныхРасходов> СпособыРаспределенияКосвенныхРасходов { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаАванса> СпособыРасчетаАванса { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаВзносов> СпособыРасчетаВзносов { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаДоплатыЗаСовмещение> СпособыРасчетаДоплатыЗаСовмещение { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаКомиссионногоВознаграждения> СпособыРасчетаКомиссионногоВознаграждения { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаНачислений> СпособыРасчетаНачислений { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаОтпуска> СпособыРасчетаОтпуска { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаПоШкале> СпособыРасчетаПоШкале { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаСебестоимостиПродукции> СпособыРасчетаСебестоимостиПродукции { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаСреднегоЗаработкаДляОплатыПособия> СпособыРасчетаСреднегоЗаработкаДляОплатыПособия { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаУдержаний> СпособыРасчетаУдержаний { get; set; }
        public DbSet<Models.Enums.СпособыРасчетаУдержанияПоИсполнительномуДокументу> СпособыРасчетаУдержанияПоИсполнительномуДокументу { get; set; }
        public DbSet<Models.Enums.СпособыРедактированияЭлектронныхПисем> СпособыРедактированияЭлектронныхПисем { get; set; }
        public DbSet<Models.Enums.СпособыСравненияВерсийФайлов> СпособыСравненияВерсийФайлов { get; set; }
        public DbSet<Models.Enums.СпособыУстановкиКурсаВалюты> СпособыУстановкиКурсаВалюты { get; set; }
        public DbSet<Models.Enums.СпособыФинансированияПособийСоцстрахования> СпособыФинансированияПособийСоцстрахования { get; set; }
        public DbSet<Models.Enums.СрокиХраненияВерсий> СрокиХраненияВерсий { get; set; }
        public DbSet<Models.Enums.СтавкиНДС> СтавкиНДС { get; set; }
        public DbSet<Models.Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий> СтатусыЗаявленийИРеестровНаВыплатуПособий { get; set; }
        public DbSet<Models.Enums.СтатусыИзвлеченияТекстаФайлов> СтатусыИзвлеченияТекстаФайлов { get; set; }
        public DbSet<Models.Enums.СтатусыКонтрагентов> СтатусыКонтрагентов { get; set; }
        public DbSet<Models.Enums.СтатусыЛистковСообщения> СтатусыЛистковСообщения { get; set; }
        public DbSet<Models.Enums.СтатусыОбластейДанных> СтатусыОбластейДанных { get; set; }
        public DbSet<Models.Enums.СтатусыРегистрацииВЕРНННалоговыхДокументов> СтатусыРегистрацииВЕРНННалоговыхДокументов { get; set; }
        public DbSet<Models.Enums.СтатусыРегламентированныхОтчетов> СтатусыРегламентированныхОтчетов { get; set; }
        public DbSet<Models.Enums.СтратегииОтраженияВУчетеЕСВ> СтратегииОтраженияВУчетеЕСВ { get; set; }
        public DbSet<Models.Enums.СтратегииОтраженияВУчетеНачислений> СтратегииОтраженияВУчетеНачислений { get; set; }
        public DbSet<Models.Enums.СтратегииОтраженияВУчетеНачисленийУдержаний> СтратегииОтраженияВУчетеНачисленийУдержаний { get; set; }
        public DbSet<Models.Enums.СтратегияРедактированияНомеровОбъектов> СтратегияРедактированияНомеровОбъектов { get; set; }
        public DbSet<Models.Enums.ТарифыМобильногоБанка> ТарифыМобильногоБанка { get; set; }
        public DbSet<Models.Enums.ТипДетализацииСтандартныхОтчетов> ТипДетализацииСтандартныхОтчетов { get; set; }
        public DbSet<Models.Enums.ТипНалоговойДеятельности> ТипНалоговойДеятельности { get; set; }
        public DbSet<Models.Enums.ТипХранилищаСертификатов> ТипХранилищаСертификатов { get; set; }
        public DbSet<Models.Enums.ТипыВерсийОбъекта> ТипыВерсийОбъекта { get; set; }
        public DbSet<Models.Enums.ТипыДанныхКэшаПрограммныхИнтерфейсов> ТипыДанныхКэшаПрограммныхИнтерфейсов { get; set; }
        public DbSet<Models.Enums.ТипыКонтактнойИнформации> ТипыКонтактнойИнформации { get; set; }
        public DbSet<Models.Enums.ТипыОплат> ТипыОплат { get; set; }
        public DbSet<Models.Enums.ТипыОтчетов> ТипыОтчетов { get; set; }
        public DbSet<Models.Enums.ТипыОценочныхОбязательств> ТипыОценочныхОбязательств { get; set; }
        public DbSet<Models.Enums.ТипыПоказателейРасчетаЗарплаты> ТипыПоказателейРасчетаЗарплаты { get; set; }
        public DbSet<Models.Enums.ТипыПолейРегистра> ТипыПолейРегистра { get; set; }
        public DbSet<Models.Enums.ТипыПроблемОбменаДанными> ТипыПроблемОбменаДанными { get; set; }
        public DbSet<Models.Enums.ТипыРегистров> ТипыРегистров { get; set; }
        public DbSet<Models.Enums.ТипыРесурсовМеханизмаОнлайнСервисовРО> ТипыРесурсовМеханизмаОнлайнСервисовРО { get; set; }
        public DbSet<Models.Enums.ТипыСкладов> ТипыСкладов { get; set; }
        public DbSet<Models.Enums.ТипыСуммДляВводаОстатков> ТипыСуммДляВводаОстатков { get; set; }
        public DbSet<Models.Enums.ТипыСчетчиковВыгрузки> ТипыСчетчиковВыгрузки { get; set; }
        public DbSet<Models.Enums.ТипыТекстовЭлектронныхПисем> ТипыТекстовЭлектронныхПисем { get; set; }
        public DbSet<Models.Enums.ТипыУслуг> ТипыУслуг { get; set; }
        public DbSet<Models.Enums.ТипыФайловДляВстроенногоРедактора> ТипыФайловДляВстроенногоРедактора { get; set; }
        public DbSet<Models.Enums.ТипыХраненияФайлов> ТипыХраненияФайлов { get; set; }
        public DbSet<Models.Enums.УдалитьВидыВзаиморасчетовСРаботниками> УдалитьВидыВзаиморасчетовСРаботниками { get; set; }
        public DbSet<Models.Enums.УдалитьВидыКалендарей> УдалитьВидыКалендарей { get; set; }
        public DbSet<Models.Enums.УдалитьВидыОбъектовКонтактнойИнформации> УдалитьВидыОбъектовКонтактнойИнформации { get; set; }
        public DbSet<Models.Enums.УдалитьВидыТекстовЭлектронныхПисем> УдалитьВидыТекстовЭлектронныхПисем { get; set; }
        public DbSet<Models.Enums.УдалитьДействиеПриОбмене> УдалитьДействиеПриОбмене { get; set; }
        public DbSet<Models.Enums.УдалитьНаборПравПользователей> УдалитьНаборПравПользователей { get; set; }
        public DbSet<Models.Enums.УдалитьПолФизическихЛиц> УдалитьПолФизическихЛиц { get; set; }
        public DbSet<Models.Enums.УдалитьТипыАвтоматическогоОбменаДанными> УдалитьТипыАвтоматическогоОбменаДанными { get; set; }
        public DbSet<Models.Enums.УдалитьТипыСкладов> УдалитьТипыСкладов { get; set; }
        public DbSet<Models.Enums.УровниПроизводительности> УровниПроизводительности { get; set; }
        public DbSet<Models.Enums.УстарелоВидыЗанятости> УстарелоВидыЗанятости { get; set; }
        public DbSet<Models.Enums.УстарелоВидыПропорцииВремени> УстарелоВидыПропорцииВремени { get; set; }
        public DbSet<Models.Enums.УстарелоВыплаченностьЗарплаты> УстарелоВыплаченностьЗарплаты { get; set; }
        public DbSet<Models.Enums.УстарелоКолонкиУпрощенногоРасчета> УстарелоКолонкиУпрощенногоРасчета { get; set; }
        public DbSet<Models.Enums.УстарелоСпособыВыплатыЗарплаты> УстарелоСпособыВыплатыЗарплаты { get; set; }
        public DbSet<Models.Enums.УчетНачисленийВСреднемЗаработкеОбщий> УчетНачисленийВСреднемЗаработкеОбщий { get; set; }
        public DbSet<Models.Enums.УчетНачисленийВСреднемЗаработкеФСС> УчетНачисленийВСреднемЗаработкеФСС { get; set; }
        public DbSet<Models.Enums.ФорматыСканированногоИзображения> ФорматыСканированногоИзображения { get; set; }
        public DbSet<Models.Enums.ФорматыСохраненияОтчетов> ФорматыСохраненияОтчетов { get; set; }
        public DbSet<Models.Enums.ФорматыФайловОбменаПоЗарплатномуПроекту> ФорматыФайловОбменаПоЗарплатномуПроекту { get; set; }
        public DbSet<Models.Enums.ФорматыХраненияМногостраничныхФайлов> ФорматыХраненияМногостраничныхФайлов { get; set; }
        public DbSet<Models.Enums.ФорматыХраненияОдностраничныхФайлов> ФорматыХраненияОдностраничныхФайлов { get; set; }
        public DbSet<Models.Enums.ФормыОбучения> ФормыОбучения { get; set; }
        public DbSet<Models.Enums.ФормыОплаты> ФормыОплаты { get; set; }
        public DbSet<Models.Enums.ХарактерВыплатыЗарплаты> ХарактерВыплатыЗарплаты { get; set; }
        public DbSet<Models.Enums.ХарактерЗависимостиКоличестваДнейОтпуска> ХарактерЗависимостиКоличестваДнейОтпуска { get; set; }
        public DbSet<Models.Enums.ХарактерПлановогоНачисления> ХарактерПлановогоНачисления { get; set; }
        public DbSet<Models.Enums.ЦветностиИзображения> ЦветностиИзображения { get; set; }
        public DbSet<Models.Enums.ЮридическоеФизическоеЛицо> ЮридическоеФизическоеЛицо { get; set; }
        public V1C8DbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Enums.БазаРаспределенияВнутреннихУслуг>(mb =>
            {
                mb.HasData(new Models.Enums.БазаРаспределенияВнутреннихУслуг[]
                {
                    Models.Enums.БазаРаспределенияВнутреннихУслуг.ПлановаяСебестоимость,
                    Models.Enums.БазаРаспределенияВнутреннихУслуг.НатуральныеПоказатели,
                });
            });
            modelBuilder.Entity<Models.Enums.БонусныеПрограммыБанков>(mb =>
            {
                mb.HasData(new Models.Enums.БонусныеПрограммыБанков[]
                {
                    Models.Enums.БонусныеПрограммыБанков.AE,
                    Models.Enums.БонусныеПрограммыБанков.GM,
                    Models.Enums.БонусныеПрограммыБанков.PG,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантВыраженияВнутреннихУслуг>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантВыраженияВнутреннихУслуг[]
                {
                    Models.Enums.ВариантВыраженияВнутреннихУслуг.ВПлановыхЦенах,
                    Models.Enums.ВариантВыраженияВнутреннихУслуг.ВКоличественныхПоказателях,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыSMTPАутентификации>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыSMTPАутентификации[]
                {
                    Models.Enums.ВариантыSMTPАутентификации.АналогичноPOP3,
                    Models.Enums.ВариантыSMTPАутентификации.ЗадаетсяПараметрами,
                    Models.Enums.ВариантыSMTPАутентификации.POP3ПередSMTP,
                    Models.Enums.ВариантыSMTPАутентификации.НеЗадано,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыАлгоритмовРасчетНДФЛ17>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыАлгоритмовРасчетНДФЛ17[]
                {
                    Models.Enums.ВариантыАлгоритмовРасчетНДФЛ17.ДоначислениеНаСуммуПревышения,
                    Models.Enums.ВариантыАлгоритмовРасчетНДФЛ17.ОтдельныйРасчетБазы,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыВерсионированияОбъектов>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыВерсионированияОбъектов[]
                {
                    Models.Enums.ВариантыВерсионированияОбъектов.ВерсионироватьПриЗаписи,
                    Models.Enums.ВариантыВерсионированияОбъектов.ВерсионироватьПриПроведении,
                    Models.Enums.ВариантыВерсионированияОбъектов.ВерсионироватьПриСтарте,
                    Models.Enums.ВариантыВерсионированияОбъектов.НеВерсионировать,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыИспользованияВнешнихКомпонент>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыИспользованияВнешнихКомпонент[]
                {
                    Models.Enums.ВариантыИспользованияВнешнихКомпонент.Используется,
                    Models.Enums.ВариантыИспользованияВнешнихКомпонент.Отключена,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыИспользованияПериодаНачисления>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыИспользованияПериодаНачисления[]
                {
                    Models.Enums.ВариантыИспользованияПериодаНачисления.ПериодДействия,
                    Models.Enums.ВариантыИспользованияПериодаНачисления.БазовыйПериод,
                    Models.Enums.ВариантыИспользованияПериодаНачисления.НеИспользовать,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыОчисткиФайлов>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыОчисткиФайлов[]
                {
                    Models.Enums.ВариантыОчисткиФайлов.ОчиститьФайлыИВерсии,
                    Models.Enums.ВариантыОчисткиФайлов.ОчиститьФайлы,
                    Models.Enums.ВариантыОчисткиФайлов.ОчиститьВерсии,
                    Models.Enums.ВариантыОчисткиФайлов.НеОчищать,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники[]
                {
                    Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники.ФамилияИОДополнение,
                    Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники.ФамилияИмяОтчествоДополнение,
                    Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники.ФамилияИОВидЗанятостиДополнение,
                    Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники.ФамилияИмяОтчествоВидЗанятостиДополнение,
                    Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники.ФамилияИОВидЗанятостиУволенДополнение,
                    Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники.ФамилияИмяОтчествоВидЗанятостиУволенДополнение,
                    Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники.ФамилияИОУволенДополнение,
                    Models.Enums.ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники.ФамилияИмяОтчествоУволенДополнение,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыПубликацииДополнительныхОтчетовИОбработок>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыПубликацииДополнительныхОтчетовИОбработок[]
                {
                    Models.Enums.ВариантыПубликацииДополнительныхОтчетовИОбработок.Используется,
                    Models.Enums.ВариантыПубликацииДополнительныхОтчетовИОбработок.РежимОтладки,
                    Models.Enums.ВариантыПубликацииДополнительныхОтчетовИОбработок.Отключена,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыСжатияTIFF>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыСжатияTIFF[]
                {
                    Models.Enums.ВариантыСжатияTIFF.CCITT3,
                    Models.Enums.ВариантыСжатияTIFF.CCITT4,
                    Models.Enums.ВариантыСжатияTIFF.LZW,
                    Models.Enums.ВариантыСжатияTIFF.RLE,
                    Models.Enums.ВариантыСжатияTIFF.БезСжатия,
                });
            });
            modelBuilder.Entity<Models.Enums.ВариантыУдержанияНДФЛ>(mb =>
            {
                mb.HasData(new Models.Enums.ВариантыУдержанияНДФЛ[]
                {
                    Models.Enums.ВариантыУдержанияНДФЛ.Удержано,
                    Models.Enums.ВариантыУдержанияНДФЛ.ПереданоНаВзысканиеВНалоговыйОрган,
                    Models.Enums.ВариантыУдержанияНДФЛ.ВозвращеноНалоговымАгентом,
                    Models.Enums.ВариантыУдержанияНДФЛ.ЗачетАвансовыхПлатежей,
                });
            });
            modelBuilder.Entity<Models.Enums.ВедениеВзаиморасчетовПоДоговорам>(mb =>
            {
                mb.HasData(new Models.Enums.ВедениеВзаиморасчетовПоДоговорам[]
                {
                    Models.Enums.ВедениеВзаиморасчетовПоДоговорам.ПоДоговоруВЦелом,
                    Models.Enums.ВедениеВзаиморасчетовПоДоговорам.ПоРасчетнымДокументам,
                });
            });
            modelBuilder.Entity<Models.Enums.ВерсииПодсистемыОбменаДанными>(mb =>
            {
                mb.HasData(new Models.Enums.ВерсииПодсистемыОбменаДанными[]
                {
                    Models.Enums.ВерсииПодсистемыОбменаДанными.Версия10,
                    Models.Enums.ВерсииПодсистемыОбменаДанными.Версия20,
                    Models.Enums.ВерсииПодсистемыОбменаДанными.Версия30,
                });
            });
            modelBuilder.Entity<Models.Enums.ВерсииФорматовВыгрузки>(mb =>
            {
                mb.HasData(new Models.Enums.ВерсииФорматовВыгрузки[]
                {
                    Models.Enums.ВерсииФорматовВыгрузки.ГНСУ_XML,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыБазыУдержанияПоИсполнительномуДокументу>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыБазыУдержанияПоИсполнительномуДокументу[]
                {
                    Models.Enums.ВидыБазыУдержанияПоИсполнительномуДокументу.Заработок,
                    Models.Enums.ВидыБазыУдержанияПоИсполнительномуДокументу.ПрожиточныйМинимум,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыВзаиморасчетовССотрудниками>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыВзаиморасчетовССотрудниками[]
                {
                    Models.Enums.ВидыВзаиморасчетовССотрудниками.ВыплатаАванса,
                    Models.Enums.ВидыВзаиморасчетовССотрудниками.ВыплатаЗарплаты,
                    Models.Enums.ВидыВзаиморасчетовССотрудниками.ВыплатаВМежрасчетныйПериод,
                    Models.Enums.ВидыВзаиморасчетовССотрудниками.ПогашениеЗадолженностиПоЗарплате,
                    Models.Enums.ВидыВзаиморасчетовССотрудниками.ВнеочередноеПогашениеЗайма,
                    Models.Enums.ВидыВзаиморасчетовССотрудниками.ПереносЗадолженности,
                    Models.Enums.ВидыВзаиморасчетовССотрудниками.НачальнаяЗадолженность,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыГруппУчетаНачисленийИУдержаний>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыГруппУчетаНачисленийИУдержаний[]
                {
                    Models.Enums.ВидыГруппУчетаНачисленийИУдержаний.Начисления,
                    Models.Enums.ВидыГруппУчетаНачисленийИУдержаний.ОсобыеНачисления,
                    Models.Enums.ВидыГруппУчетаНачисленийИУдержаний.НалогиИВзносы,
                    Models.Enums.ВидыГруппУчетаНачисленийИУдержаний.Удержания,
                    Models.Enums.ВидыГруппУчетаНачисленийИУдержаний.Депоненты,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДанныхУчетаВремениСотрудников>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДанныхУчетаВремениСотрудников[]
                {
                    Models.Enums.ВидыДанныхУчетаВремениСотрудников.ДанныеОбщихГрафиков,
                    Models.Enums.ВидыДанныхУчетаВремениСотрудников.ДанныеИндивидуальныхГрафиков,
                    Models.Enums.ВидыДанныхУчетаВремениСотрудников.ДанныеТабельногоУчета,
                    Models.Enums.ВидыДанныхУчетаВремениСотрудников.ДанныеОперативногоУчета,
                    Models.Enums.ВидыДанныхУчетаВремениСотрудников.ДанныеВнутрисменныхНеявок,
                    Models.Enums.ВидыДанныхУчетаВремениСотрудников.ВытесняемоеПлановоеВремя,
                    Models.Enums.ВидыДанныхУчетаВремениСотрудников.ДополнительноеВнутрисменноеВремя,
                    Models.Enums.ВидыДанныхУчетаВремениСотрудников.СводныеДанные,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДействийКалендаряБухгалтера>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДействийКалендаряБухгалтера[]
                {
                    Models.Enums.ВидыДействийКалендаряБухгалтера.Отчет,
                    Models.Enums.ВидыДействийКалендаряБухгалтера.УплатаНалога,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДействияСНачислением>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДействияСНачислением[]
                {
                    Models.Enums.ВидыДействияСНачислением.Начать,
                    Models.Enums.ВидыДействияСНачислением.Изменить,
                    Models.Enums.ВидыДействияСНачислением.НеИзменять,
                    Models.Enums.ВидыДействияСНачислением.Прекратить,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДеятельностиДляДДС>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДеятельностиДляДДС[]
                {
                    Models.Enums.ВидыДеятельностиДляДДС.Операционная,
                    Models.Enums.ВидыДеятельностиДляДДС.Инвестиционная,
                    Models.Enums.ВидыДеятельностиДляДДС.Финансовая,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДеятельностиНДС>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДеятельностиНДС[]
                {
                    Models.Enums.ВидыДеятельностиНДС.Облагаемая,
                    Models.Enums.ВидыДеятельностиНДС.Необлагаемая,
                    Models.Enums.ВидыДеятельностиНДС.ПропорциональноОблагаемая,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДнейПроизводственногоКалендаря>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДнейПроизводственногоКалендаря[]
                {
                    Models.Enums.ВидыДнейПроизводственногоКалендаря.Рабочий,
                    Models.Enums.ВидыДнейПроизводственногоКалендаря.Суббота,
                    Models.Enums.ВидыДнейПроизводственногоКалендаря.Воскресенье,
                    Models.Enums.ВидыДнейПроизводственногоКалендаря.Предпраздничный,
                    Models.Enums.ВидыДнейПроизводственногоКалендаря.Праздник,
                    Models.Enums.ВидыДнейПроизводственногоКалендаря.Нерабочий,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДоговоровКонтрагентов>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДоговоровКонтрагентов[]
                {
                    Models.Enums.ВидыДоговоровКонтрагентов.СПоставщиком,
                    Models.Enums.ВидыДоговоровКонтрагентов.СПокупателем,
                    Models.Enums.ВидыДоговоровКонтрагентов.СКомитентом,
                    Models.Enums.ВидыДоговоровКонтрагентов.СКомиссионером,
                    Models.Enums.ВидыДоговоровКонтрагентов.Бартерный,
                    Models.Enums.ВидыДоговоровКонтрагентов.Прочее,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДоговоровССотрудниками>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДоговоровССотрудниками[]
                {
                    Models.Enums.ВидыДоговоровССотрудниками.ТрудовойДоговор,
                    Models.Enums.ВидыДоговоровССотрудниками.КонтрактГосслужащего,
                    Models.Enums.ВидыДоговоровССотрудниками.ДоговорМуниципальногоСлужащего,
                    Models.Enums.ВидыДоговоровССотрудниками.КонтрактВоеннослужащего,
                    Models.Enums.ВидыДоговоровССотрудниками.ВоеннослужащийПоПризыву,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДокументовМежрасчетныхНачислений>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДокументовМежрасчетныхНачислений[]
                {
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.БольничныйЛист,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.ВозвратНДФЛ,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.ЕдиновременноеПособиеЗаСчетФСС,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.Командировка,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.КомпенсацияЗаЗадержкуЗарплаты,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.МатериальнаяПомощь,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.НачислениеЗарплаты,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.ОплатаДнейУходаЗаДетьмиИнвалидами,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.ОплатаПоСреднемуЗаработку,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.Отпуск,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.ОтпускПоУходуЗаРебенком,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.Премия,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.ПростойСотрудников,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.РазовоеНачисление,
                    Models.Enums.ВидыДокументовМежрасчетныхНачислений.Увольнение,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДокументовНачисления>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДокументовНачисления[]
                {
                    Models.Enums.ВидыДокументовНачисления.БольничныйЛист,
                    Models.Enums.ВидыДокументовНачисления.ДоходВНатуральнойФорме,
                    Models.Enums.ВидыДокументовНачисления.Командировка,
                    Models.Enums.ВидыДокументовНачисления.МатериальнаяПомощь,
                    Models.Enums.ВидыДокументовНачисления.ОплатаДнейУходаЗаДетьмиИнвалидами,
                    Models.Enums.ВидыДокументовНачисления.ОплатаПоСреднемуЗаработку,
                    Models.Enums.ВидыДокументовНачисления.Отпуск,
                    Models.Enums.ВидыДокументовНачисления.ОтпускБезСохраненияОплаты,
                    Models.Enums.ВидыДокументовНачисления.Премия,
                    Models.Enums.ВидыДокументовНачисления.ПрогулНеявка,
                    Models.Enums.ВидыДокументовНачисления.ПростойСотрудников,
                    Models.Enums.ВидыДокументовНачисления.РазовоеНачисление,
                    Models.Enums.ВидыДокументовНачисления.Увольнение,
                    Models.Enums.ВидыДокументовНачисления.Отгул,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДокументовУдержания>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДокументовУдержания[]
                {
                    Models.Enums.ВидыДокументовУдержания.Увольнение,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыДополнительныхОтчетовИОбработок>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыДополнительныхОтчетовИОбработок[]
                {
                    Models.Enums.ВидыДополнительныхОтчетовИОбработок.ДополнительнаяОбработка,
                    Models.Enums.ВидыДополнительныхОтчетовИОбработок.ДополнительныйОтчет,
                    Models.Enums.ВидыДополнительныхОтчетовИОбработок.ЗаполнениеОбъекта,
                    Models.Enums.ВидыДополнительныхОтчетовИОбработок.Отчет,
                    Models.Enums.ВидыДополнительныхОтчетовИОбработок.ПечатнаяФорма,
                    Models.Enums.ВидыДополнительныхОтчетовИОбработок.СозданиеСвязанныхОбъектов,
                    Models.Enums.ВидыДополнительныхОтчетовИОбработок.ШаблонСообщения,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыЕСВ>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыЕСВ[]
                {
                    Models.Enums.ВидыЕСВ.ОсновнаяЗарплата,
                    Models.Enums.ВидыЕСВ.ПоДоговорамГПХ,
                    Models.Enums.ВидыЕСВ.Больничные,
                    Models.Enums.ВидыЕСВ.Декретные,
                    Models.Enums.ВидыЕСВ.НачисленияМобилизованным,
                    Models.Enums.ВидыЕСВ.НеУчитывается,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыЗадолженности>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыЗадолженности[]
                {
                    Models.Enums.ВидыЗадолженности.Дебиторская,
                    Models.Enums.ВидыЗадолженности.Кредиторская,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыЗанятости>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыЗанятости[]
                {
                    Models.Enums.ВидыЗанятости.ОсновноеМестоРаботы,
                    Models.Enums.ВидыЗанятости.Совместительство,
                    Models.Enums.ВидыЗанятости.ВнутреннееСовместительство,
                    Models.Enums.ВидыЗанятости.Подработка,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыЗатрат>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыЗатрат[]
                {
                    Models.Enums.ВидыЗатрат.Материальные,
                    Models.Enums.ВидыЗатрат.ОплатаТруда,
                    Models.Enums.ВидыЗатрат.ОтчисленияНаСоциальныеНужды,
                    Models.Enums.ВидыЗатрат.Амортизация,
                    Models.Enums.ВидыЗатрат.Прочие,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыИсполнительныхДокументов>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыИсполнительныхДокументов[]
                {
                    Models.Enums.ВидыИсполнительныхДокументов.ИсполнительныйЛист,
                    Models.Enums.ВидыИсполнительныхДокументов.СоглашениеОбУплатеАлиментов,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыИспользованияАмортизации>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыИспользованияАмортизации[]
                {
                    Models.Enums.ВидыИспользованияАмортизации.СтроительствоОбъектов,
                    Models.Enums.ВидыИспользованияАмортизации.ПриобретениеОсновныхСредств,
                    Models.Enums.ВидыИспользованияАмортизации.УлучшениеОсновныхСредств,
                    Models.Enums.ВидыИспользованияАмортизации.ПриобретениеНематериальныхАктивов,
                    Models.Enums.ВидыИспользованияАмортизации.ДругиеКапитальныеРаботы,
                    Models.Enums.ВидыИспользованияАмортизации.ПогашениеПолученныхЗаймов,
                    Models.Enums.ВидыИспользованияАмортизации.Прочее,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыКадровыхСобытий>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыКадровыхСобытий[]
                {
                    Models.Enums.ВидыКадровыхСобытий.Прием,
                    Models.Enums.ВидыКадровыхСобытий.Перемещение,
                    Models.Enums.ВидыКадровыхСобытий.Увольнение,
                    Models.Enums.ВидыКадровыхСобытий.НачальныеДанные,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыКодовДляНалоговойНакладной>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыКодовДляНалоговойНакладной[]
                {
                    Models.Enums.ВидыКодовДляНалоговойНакладной.КодТовара,
                    Models.Enums.ВидыКодовДляНалоговойНакладной.КодТовараИмпортированного,
                    Models.Enums.ВидыКодовДляНалоговойНакладной.КодУслуги,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыКонтактныхЛиц>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыКонтактныхЛиц[]
                {
                    Models.Enums.ВидыКонтактныхЛиц.КонтактноеЛицоКонтрагента,
                    Models.Enums.ВидыКонтактныхЛиц.ПрочееКонтактноеЛицо,
                    Models.Enums.ВидыКонтактныхЛиц.ЛичныйКонтакт,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыКонтрагентовВМонитореРуководителя>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыКонтрагентовВМонитореРуководителя[]
                {
                    Models.Enums.ВидыКонтрагентовВМонитореРуководителя.Покупатели,
                    Models.Enums.ВидыКонтрагентовВМонитореРуководителя.Поставщики,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыКорректировокНалоговогоКредита>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыКорректировокНалоговогоКредита[]
                {
                    Models.Enums.ВидыКорректировокНалоговогоКредита.ПотеряПраваНаНалоговыйКредит,
                    Models.Enums.ВидыКорректировокНалоговогоКредита.ВосстановлениеПраваНаНалоговыйКредит,
                    Models.Enums.ВидыКорректировокНалоговогоКредита.НетКорректировок,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыМалоценныхАктивов>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыМалоценныхАктивов[]
                {
                    Models.Enums.ВидыМалоценныхАктивов.МалоценныйБыстроизнашивающийсяПредмет,
                    Models.Enums.ВидыМалоценныхАктивов.МалоценныйНеоборотныйАктив,
                    Models.Enums.ВидыМалоценныхАктивов.БиблиотечныеФонды,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыМестВыплатыЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыМестВыплатыЗарплаты[]
                {
                    Models.Enums.ВидыМестВыплатыЗарплаты.Касса,
                    Models.Enums.ВидыМестВыплатыЗарплаты.ЗарплатныйПроект,
                    Models.Enums.ВидыМестВыплатыЗарплаты.Раздатчик,
                    Models.Enums.ВидыМестВыплатыЗарплаты.БанковскийСчет,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыМонетарныхСтатейВВалюте>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыМонетарныхСтатейВВалюте[]
                {
                    Models.Enums.ВидыМонетарныхСтатейВВалюте.НеоперационнаяДеятельность,
                    Models.Enums.ВидыМонетарныхСтатейВВалюте.ОбязательстваУчредителей,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыНазначенияДатЗапрета>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыНазначенияДатЗапрета[]
                {
                    Models.Enums.ВидыНазначенияДатЗапрета.ДляВсехПользователей,
                    Models.Enums.ВидыНазначенияДатЗапрета.ДляВсехИнформационныхБаз,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыНалоговыхГруппНА>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыНалоговыхГруппНА[]
                {
                    Models.Enums.ВидыНалоговыхГруппНА.ДоНКУ,
                    Models.Enums.ВидыНалоговыхГруппНА.ОС,
                    Models.Enums.ВидыНалоговыхГруппНА.НМА,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыНалоговыхДеклараций>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыНалоговыхДеклараций[]
                {
                    Models.Enums.ВидыНалоговыхДеклараций.ДекларацияПоНалогуНаПрибыль2015,
                    Models.Enums.ВидыНалоговыхДеклараций.ДекларацияПоНДС,
                    Models.Enums.ВидыНалоговыхДеклараций.Пенсионный,
                    Models.Enums.ВидыНалоговыхДеклараций.Безработица,
                    Models.Enums.ВидыНалоговыхДеклараций.НесчастныйСлучай,
                    Models.Enums.ВидыНалоговыхДеклараций.УтратаТрудоспобности,
                    Models.Enums.ВидыНалоговыхДеклараций.ЕдиныйНалог,
                    Models.Enums.ВидыНалоговыхДеклараций.ОтчетПоТруду,
                    Models.Enums.ВидыНалоговыхДеклараций.ОтчетОбИспользованииРабочегоВремени,
                    Models.Enums.ВидыНалоговыхДеклараций.ЕСВ,
                    Models.Enums.ВидыНалоговыхДеклараций.ДекларацияОПрибыли,
                    Models.Enums.ВидыНалоговыхДеклараций.ДекларацияПоНалогуНаПрибыльНКУ,
                    Models.Enums.ВидыНалоговыхДеклараций.ДекларацияПоАкцизномуНалогу,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыНаследованияПравДоступаИерархическихСправочников>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыНаследованияПравДоступаИерархическихСправочников[]
                {
                    Models.Enums.ВидыНаследованияПравДоступаИерархическихСправочников.НаследуетсяОтРодителя,
                    Models.Enums.ВидыНаследованияПравДоступаИерархическихСправочников.РаспространитьНаПодчиненных,
                    Models.Enums.ВидыНаследованияПравДоступаИерархическихСправочников.ТолькоДляТекущегоПрава,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыНачисленийДляТиповыхОтчетов>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыНачисленийДляТиповыхОтчетов[]
                {
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.БольничныеЗаСчетПредприятия,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ВзносыПредприятийНаМедИПенсСтрахование,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ВысокоеПрофессиональноеМастерство,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ВознагражденияРазовогоХарактера,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ВыплатыСоциальногоХарактера,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ВыполнениеОбязанностейВременноОтсутствующегоРаботника,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ВыполнениеОсобоВажнойРаботы,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ВысокиеДостиженияТруда,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ГонорарАвторскоеВознаграждение,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ДивидендыПроцентыВыплатыЗаПаями,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ДопускКГосударственнойТайне,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ДругиеВидыНачисленийДопФОТ,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ДругиеВидыНачисленийНеФОТ,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ДругиеВидыНачисленийФОТ,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ДругиеВыплатыНеФОТ,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ДругиеНадбавкиИДоплаты,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ДругиеНачисленияЗаНеотработанноеВремя,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ДругиеПоощрительныеИКомпенсационныеВыплаты,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ЗначениеПеречисления1,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ЗатратыНаБесплатныйПроезд,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ЗатратыНаКомандировки,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ЗнаниеИностранногоЯзыка,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ИндексацияЗарплаты,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ИнтенсивностьТруда,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.КлассностьВодителямТранспортныхСредств,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.КомиссионныеОтРеализацииПродукции,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.КомпенсацияЗаНарушениеСроковВыплатыЗП,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.МатпомощьРазовогоХарактера,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.НаучнаяСтепень,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.НормативноеВремяПередвиженияВШахте,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ОплатаДнейОтдыха,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ОплатаЗаПрофобучение,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ОплатаРаботыСверхурочноВПраздникиНерабочиеДни,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ОплатаТрудаВКомандировке,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.Отпускные,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ПомощьИДругиеВыплатыЗаСчетФСС,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.Премия,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ПроцентныеКомиссионныеВознаграждения,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.РаботаВНочноеВремя,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.РаботаВТяжелыхВредныхУсловиях,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.РаботаНаТерриторияхРадиоактивногоЗагрязнения,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.РангиЗвания,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.РасширениеЗоныОбслуживания,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.РуководствоБригадой,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.СистематическаяМатпомощь,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.СовмещениеПрофессий,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.СтоимостьПродукцииПриНатуральнойОплатеТруда,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.СтоимостьФорменнойОдежды,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ТарифнаяСтавкаОклад,
                    Models.Enums.ВидыНачисленийДляТиповыхОтчетов.ПрофсоюзныйВзнос,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОбъектовДоступа>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОбъектовДоступа[]
                {
                    Models.Enums.ВидыОбъектовДоступа.Организации,
                    Models.Enums.ВидыОбъектовДоступа.ВнешниеОбработки,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОбязательногоСтрахованияСотрудников>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОбязательногоСтрахованияСотрудников[]
                {
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ПФРПоСуммарномуТарифу,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ФССНесчастныеСлучаи,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ФСС,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ФФОМС,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ПФРЗаЗанятыхНаПодземныхИВредныхРаботах,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ДоплатаКПенсииЛетчикам,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ДоплатаКПенсииШахтерам,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ПФРСтраховая,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ПФРНакопительная,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ТФОМС,
                    Models.Enums.ВидыОбязательногоСтрахованияСотрудников.ПФРСПревышения,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОграниченияПособия>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОграниченияПособия[]
                {
                    Models.Enums.ВидыОграниченияПособия.ОбщееОграничение,
                    Models.Enums.ВидыОграниченияПособия.ОграничениеВРазмереММОТ,
                    Models.Enums.ВидыОграниченияПособия.БезОграничений,
                    Models.Enums.ВидыОграниченияПособия.МаксимальныйРазмерЕжемесячнойСтраховойВыплаты,
                    Models.Enums.ВидыОграниченияПособия.ОграничениеВРазмереДвухММОТ,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийВозвратТоваров>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийВозвратТоваров[]
                {
                    Models.Enums.ВидыОперацийВозвратТоваров.ИзПереработки,
                    Models.Enums.ВидыОперацийВозвратТоваров.ОтЗаказчика,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийВозвратТоваровОтПокупателя>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийВозвратТоваровОтПокупателя[]
                {
                    Models.Enums.ВидыОперацийВозвратТоваровОтПокупателя.ПродажаКомиссия,
                    Models.Enums.ВидыОперацийВозвратТоваровОтПокупателя.Оборудование,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийВозвратТоваровПоставщику>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийВозвратТоваровПоставщику[]
                {
                    Models.Enums.ВидыОперацийВозвратТоваровПоставщику.ПокупкаКомиссия,
                    Models.Enums.ВидыОперацийВозвратТоваровПоставщику.ИзПереработки,
                    Models.Enums.ВидыОперацийВозвратТоваровПоставщику.Оборудование,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийДоверенность>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийДоверенность[]
                {
                    Models.Enums.ВидыОперацийДоверенность.Доверенность,
                    Models.Enums.ВидыОперацийДоверенность.ДоверенностьСтрогогоУчета,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийКомплектацияНоменклатуры>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийКомплектацияНоменклатуры[]
                {
                    Models.Enums.ВидыОперацийКомплектацияНоменклатуры.Комплектация,
                    Models.Enums.ВидыОперацийКомплектацияНоменклатуры.Разукомплектация,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийКорректировкаДолга>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийКорректировкаДолга[]
                {
                    Models.Enums.ВидыОперацийКорректировкаДолга.ПереносЗадолженности,
                    Models.Enums.ВидыОперацийКорректировкаДолга.СписаниеЗадолженности,
                    Models.Enums.ВидыОперацийКорректировкаДолга.ИзменениеЗадолженности,
                    Models.Enums.ВидыОперацийКорректировкаДолга.ПроведениеВзаимозачета,
                    Models.Enums.ВидыОперацийКорректировкаДолга.ВводНачальныхОстатков,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийНалоговаяНакладная>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийНалоговаяНакладная[]
                {
                    Models.Enums.ВидыОперацийНалоговаяНакладная.ОблагаемыеОперации,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.ОсвобожденныеОперации,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.НеНДСОперации,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.ИтоговаяРозницаОблагаемыеОперации,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.ИтоговаяРозницаОсвобожденныеОперации,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.РозницаКонрагентуОблагаемыеОперации,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.РозницаКонрагентуОсвобожденныеОперации,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.УсловнаяПродажа,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.УсловнаяПродажаСписаниеОС,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.РаботыОтНерезидента,
                    Models.Enums.ВидыОперацийНалоговаяНакладная.СводнаяНаПревышениеБазыНадЦенойПоставки,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийОприходованиеТоваров>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийОприходованиеТоваров[]
                {
                    Models.Enums.ВидыОперацийОприходованиеТоваров.ТоварыПродукция,
                    Models.Enums.ВидыОперацийОприходованиеТоваров.Оборудование,
                    Models.Enums.ВидыОперацийОприходованиеТоваров.БланкиСтрогогоУчета,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийОтчетОРозничныхПродажах>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийОтчетОРозничныхПродажах[]
                {
                    Models.Enums.ВидыОперацийОтчетОРозничныхПродажах.ОтчетККМОПродажах,
                    Models.Enums.ВидыОперацийОтчетОРозничныхПродажах.ОтчетНТТОПродажах,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПередачаТоваров>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПередачаТоваров[]
                {
                    Models.Enums.ВидыОперацийПередачаТоваров.ВПереработку,
                    Models.Enums.ВидыОперацийПередачаТоваров.ИзПереработки,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПеремещениеТоваров>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПеремещениеТоваров[]
                {
                    Models.Enums.ВидыОперацийПеремещениеТоваров.ТоварыПродукция,
                    Models.Enums.ВидыОперацийПеремещениеТоваров.Оборудование,
                    Models.Enums.ВидыОперацийПеремещениеТоваров.БланкиСтрогогоУчета,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПКО>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПКО[]
                {
                    Models.Enums.ВидыОперацийПКО.ОплатаПокупателя,
                    Models.Enums.ВидыОперацийПКО.ПриходДенежныхСредствРозничнаяВыручка,
                    Models.Enums.ВидыОперацийПКО.ВозвратДенежныхСредствПодотчетником,
                    Models.Enums.ВидыОперацийПКО.ВозвратДенежныхСредствПоставщиком,
                    Models.Enums.ВидыОперацийПКО.ВозвратДенежныхСредствРаботником,
                    Models.Enums.ВидыОперацийПКО.ПолучениеНаличныхДенежныхСредствВБанке,
                    Models.Enums.ВидыОперацийПКО.РасчетыПоКредитамИЗаймамСКонтрагентами,
                    Models.Enums.ВидыОперацийПКО.ПриходДенежныхСредствПрочее,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПоЗарплате>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПоЗарплате[]
                {
                    Models.Enums.ВидыОперацийПоЗарплате.НачисленоДоход,
                    Models.Enums.ВидыОперацийПоЗарплате.НачисленоБольничные,
                    Models.Enums.ВидыОперацийПоЗарплате.НачисленоОтпускныеДоход,
                    Models.Enums.ВидыОперацийПоЗарплате.НачисленоОтпускныеРезерв,
                    Models.Enums.ВидыОперацийПоЗарплате.ВозвратИзлишнеВыплаченныхСуммВследствиеСчетныхОшибок,
                    Models.Enums.ВидыОперацийПоЗарплате.ВозмещениеУщерба,
                    Models.Enums.ВидыОперацийПоЗарплате.ВознаграждениеПлатежногоАгента,
                    Models.Enums.ВидыОперацийПоЗарплате.ВыплатыБывшимСотрудникам,
                    Models.Enums.ВидыОперацийПоЗарплате.НатуральныйДоход,
                    Models.Enums.ВидыОперацийПоЗарплате.Дивиденды,
                    Models.Enums.ВидыОперацийПоЗарплате.НачисленоСдельноДоход,
                    Models.Enums.ВидыОперацийПоЗарплате.НачисленоЗаСчетФССДоход,
                    Models.Enums.ВидыОперацийПоЗарплате.ДивидендыСотрудников,
                    Models.Enums.ВидыОперацийПоЗарплате.ДоговорАвторскогоЗаказа,
                    Models.Enums.ВидыОперацийПоЗарплате.ДоговорРаботыУслуги,
                    Models.Enums.ВидыОперацийПоЗарплате.ДоходыКонтрагентов,
                    Models.Enums.ВидыОперацийПоЗарплате.ДСВ,
                    Models.Enums.ВидыОперацийПоЗарплате.МатериальнаяПомощь,
                    Models.Enums.ВидыОперацийПоЗарплате.АлиментыПрочиеИсполнительныеЛисты,
                    Models.Enums.ВидыОперацийПоЗарплате.ИсполнительныеЛисты,
                    Models.Enums.ВидыОперацийПоЗарплате.ПочтовыйСбор,
                    Models.Enums.ВидыОперацийПоЗарплате.ПогашениеЗаймов,
                    Models.Enums.ВидыОперацийПоЗарплате.НачисленоПроцентовПоЗайму,
                    Models.Enums.ВидыОперацийПоЗарплате.ПроцентыПоЗайму,
                    Models.Enums.ВидыОперацийПоЗарплате.КомпенсацияЗаЗадержкуЗарплаты,
                    Models.Enums.ВидыОперацийПоЗарплате.ПрочиеУдержания,
                    Models.Enums.ВидыОперацийПоЗарплате.НДФЛДоначисленныйПоРезультатамПроверки,
                    Models.Enums.ВидыОперацийПоЗарплате.НДФЛДоходыКонтрагентов,
                    Models.Enums.ВидыОперацийПоЗарплате.НДФЛПередачаЗадолженностиВНалоговыйОрган,
                    Models.Enums.ВидыОперацийПоЗарплате.НДФЛПрочиеРасчетыСПерсоналом,
                    Models.Enums.ВидыОперацийПоЗарплате.НДФЛРасчетыСБывшимиСотрудниками,
                    Models.Enums.ВидыОперацийПоЗарплате.НФДЛДивиденды,
                    Models.Enums.ВидыОперацийПоЗарплате.НФДЛДивидендыСотрудникам,
                    Models.Enums.ВидыОперацийПоЗарплате.ОценкаОбязательстваИФормированиеРезервов,
                    Models.Enums.ВидыОперацийПоЗарплате.ДобровольныеВзносыВНПФ,
                    Models.Enums.ВидыОперацийПоЗарплате.НачислениеЕСВРезерв,
                    Models.Enums.ВидыОперацийПоЗарплате.Профвзносы,
                    Models.Enums.ВидыОперацийПоЗарплате.НачислениеЕСВ,
                    Models.Enums.ВидыОперацийПоЗарплате.НДФЛ,
                    Models.Enums.ВидыОперацийПоЗарплате.Депонирование,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФРДополнительныйТарифЛЭ,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФРДополнительныйТарифШахтеры,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФРЗаЗанятыхНаПодземныхИВредныхРаботах,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФРНакопительнаяЧасть,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФРСПревышения,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФРДоПредельнойВеличины,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФРПоСуммарномуТарифу,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФРСтраховаяЧасть,
                    Models.Enums.ВидыОперацийПоЗарплате.РасходыПоСтрахованиюБюджет,
                    Models.Enums.ВидыОперацийПоЗарплате.РасходыПоСтрахованиюРаботодатель,
                    Models.Enums.ВидыОперацийПоЗарплате.РасходыПоСтрахованиюФСС,
                    Models.Enums.ВидыОперацийПоЗарплате.РасходыПоСтрахованиюФССНС,
                    Models.Enums.ВидыОперацийПоЗарплате.СписаниеДепонента,
                    Models.Enums.ВидыОперацийПоЗарплате.ТФОМС,
                    Models.Enums.ВидыОперацийПоЗарплате.УдержаниеЗаОтпуск,
                    Models.Enums.ВидыОперацийПоЗарплате.УдержаниеНеизрасходованныхПодотчетныхСумм,
                    Models.Enums.ВидыОперацийПоЗарплате.УдержаниеПоПрочимОперациямСРаботниками,
                    Models.Enums.ВидыОперацийПоЗарплате.ФСС,
                    Models.Enums.ВидыОперацийПоЗарплате.ФССНС,
                    Models.Enums.ВидыОперацийПоЗарплате.ФФОМС,
                    Models.Enums.ВидыОперацийПоЗарплате.ЕжегодныйОтпуск,
                    Models.Enums.ВидыОперацийПоЗарплате.ЕжегодныйОтпускОценочныеОбязательства,
                    Models.Enums.ВидыОперацийПоЗарплате.ПФР,
                    Models.Enums.ВидыОперацийПоЗарплате.ФОМС,
                    Models.Enums.ВидыОперацийПоЗарплате.ЕжегодныйОтпускОценочныеОбязательстваИРезервыБУ,
                    Models.Enums.ВидыОперацийПоЗарплате.ЕжегодныйОтпускОценочныеОбязательстваИРезервыНУ,
                    Models.Enums.ВидыОперацийПоЗарплате.ЕжегодныйОтпускОценочныеОбязательстваИРезервы,
                    Models.Enums.ВидыОперацийПоЗарплате.ЕжегодныйОтпускРезервы,
                    Models.Enums.ВидыОперацийПоЗарплате.КомпенсацияЕжегодногоОтпуска,
                    Models.Enums.ВидыОперацийПоЗарплате.КомпенсацияЕжегодногоОтпускаОценочныеОбязательства,
                    Models.Enums.ВидыОперацийПоЗарплате.ПрочиеРасчетыСПерсоналом,
                    Models.Enums.ВидыОперацийПоЗарплате.ВоенныйСбор,
                    Models.Enums.ВидыОперацийПоЗарплате.ВСДоходыКонтрагентов,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПокупкаПродажаВалюты>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПокупкаПродажаВалюты[]
                {
                    Models.Enums.ВидыОперацийПокупкаПродажаВалюты.ПокупкаВалюты,
                    Models.Enums.ВидыОперацийПокупкаПродажаВалюты.ПродажаВалюты,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПоступлениеДенежныхСредств>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПоступлениеДенежныхСредств[]
                {
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.ОплатаПокупателя,
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.ВозвратДенежныхСредствПоставщиком,
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.РасчетыПоКредитамИЗаймам,
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.ПрочиеРасчетыСКонтрагентами,
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.ИнкассацияДенежныхСредств,
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.ПокупкаПродажаВалюты,
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.ПрочееПоступлениеБезналичныхДенежныхСредств,
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.ПоступленияОтПродажПоПлатежнымКартамИБанковскимКредитам,
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.ПоступлениеСредствОтФСС,
                    Models.Enums.ВидыОперацийПоступлениеДенежныхСредств.ВозвратДенежныхСредствПодотчетником,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПоступлениеТоваровУслуг>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПоступлениеТоваровУслуг[]
                {
                    Models.Enums.ВидыОперацийПоступлениеТоваровУслуг.ПокупкаКомиссия,
                    Models.Enums.ВидыОперацийПоступлениеТоваровУслуг.ВПереработку,
                    Models.Enums.ВидыОперацийПоступлениеТоваровУслуг.Оборудование,
                    Models.Enums.ВидыОперацийПоступлениеТоваровУслуг.ОбъектыСтроительства,
                    Models.Enums.ВидыОперацийПоступлениеТоваровУслуг.БланкиСтрогогоУчета,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПриложение1КНалоговойНакладной>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПриложение1КНалоговойНакладной[]
                {
                    Models.Enums.ВидыОперацийПриложение1КНалоговойНакладной.ОблагаемыеОперации,
                    Models.Enums.ВидыОперацийПриложение1КНалоговойНакладной.ОсвобожденныеОперации,
                    Models.Enums.ВидыОперацийПриложение1КНалоговойНакладной.НеНДСОперации,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной[]
                {
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.ОблагаемыеОперацииВозврат,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.ОблагаемыеОперацииКорректировка,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.ОсвобожденныеОперацииВозврат,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.ОсвобожденныеОперацииКорректировка,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.НеНДСОперацииВозврат,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.НеНДСОперацииКорректировка,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.ИтоговаяРозницаОблагаемыеОперацииВозврат,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.ИтоговаяРозницаОсвобожденныеОперацииВозврат,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.РозницаКонрагентуОблагаемыеОперацииВозврат,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.РозницаКонрагентуОсвобожденныеОперацииВозврат,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.РаботыОтНерезидентаКорректировка,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.УсловнаяПродажаВозврат,
                    Models.Enums.ВидыОперацийПриложение2КНалоговойНакладной.СводнаяНаПревышениеБазыНадЦенойПоставки,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПринятияКУчетуНМА>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПринятияКУчетуНМА[]
                {
                    Models.Enums.ВидыОперацийПринятияКУчетуНМА.НематериальныеАктивы,
                    Models.Enums.ВидыОперацийПринятияКУчетуНМА.ОбъектыСтроительства,
                    Models.Enums.ВидыОперацийПринятияКУчетуНМА.ВводНачальныхОстатков,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийПринятияКУчетуОсновныхСредств>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийПринятияКУчетуОсновныхСредств[]
                {
                    Models.Enums.ВидыОперацийПринятияКУчетуОсновныхСредств.Оборудование,
                    Models.Enums.ВидыОперацийПринятияКУчетуОсновныхСредств.ОбъектыСтроительства,
                    Models.Enums.ВидыОперацийПринятияКУчетуОсновныхСредств.ПоРезультатамИнвентаризации,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийРасчетаКосвенныхРасходов>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийРасчетаКосвенныхРасходов[]
                {
                    Models.Enums.ВидыОперацийРасчетаКосвенныхРасходов.РаспределениеОбщепроизводственныхРасходов,
                    Models.Enums.ВидыОперацийРасчетаКосвенныхРасходов.РаспределениеОбщехозяйственныхРасходов,
                    Models.Enums.ВидыОперацийРасчетаКосвенныхРасходов.УслугиБезИспользованияПлановыхЦен,
                    Models.Enums.ВидыОперацийРасчетаКосвенныхРасходов.ВыпускПродукцииИУслуг,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийРасчетаСебестоимости>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийРасчетаСебестоимости[]
                {
                    Models.Enums.ВидыОперацийРасчетаСебестоимости.РасходыНаПроизводствоПродукцииИУслуг,
                    Models.Enums.ВидыОперацийРасчетаСебестоимости.УслугиБезИспользованияПлановыхЦен,
                    Models.Enums.ВидыОперацийРасчетаСебестоимости.ВыпускПродукцииИУслуг,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийРеализацияТоваров>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийРеализацияТоваров[]
                {
                    Models.Enums.ВидыОперацийРеализацияТоваров.ПродажаКомиссия,
                    Models.Enums.ВидыОперацийРеализацияТоваров.Оборудование,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийРегистрацияАвансовВНалоговомУчете>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийРегистрацияАвансовВНалоговомУчете[]
                {
                    Models.Enums.ВидыОперацийРегистрацияАвансовВНалоговомУчете.АвансОпределениеПараметровНУ,
                    Models.Enums.ВидыОперацийРегистрацияАвансовВНалоговомУчете.АвансВозвратОпределениеПараметровНУ,
                    Models.Enums.ВидыОперацийРегистрацияАвансовВНалоговомУчете.ОтгрузкаОтменаРегистрацииВНУ,
                    Models.Enums.ВидыОперацийРегистрацияАвансовВНалоговомУчете.ОтгрузкаВозвратОтменаРегистрацииВНУ,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента[]
                {
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.НалоговаяНакладная,
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.РасчетКорректировкиВозврат,
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.РасчетКорректировкиКорректировка,
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.РаботыОтНерезидентаПрошлогоПериода,
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.ПогашениеНалоговогоВекселя,
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.BeксeльПpoшлoгoПepиoдa,
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.ТаможенноеОформлениеТоваровКомитента,
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.ИсправлениеОшибки,
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.ВосстановлениеНалоговогоКредита,
                    Models.Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента.ТоварныйЧек,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийРКО>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийРКО[]
                {
                    Models.Enums.ВидыОперацийРКО.ОплатаПоставщику,
                    Models.Enums.ВидыОперацийРКО.ВозвратДенежныхСредствПокупателю,
                    Models.Enums.ВидыОперацийРКО.ВыдачаДенежныхСредствПодотчетнику,
                    Models.Enums.ВидыОперацийРКО.ВыплатаЗаработнойПлатыПоВедомостям,
                    Models.Enums.ВидыОперацийРКО.ВыплатаЗарплатыРаздатчиком,
                    Models.Enums.ВидыОперацийРКО.ВыплатаЗаработнойПлатыРаботнику,
                    Models.Enums.ВидыОперацийРКО.ВыдачаЗаймаСотруднику,
                    Models.Enums.ВидыОперацийРКО.ВзносНаличнымиВБанк,
                    Models.Enums.ВидыОперацийРКО.РасчетыПоКредитамИЗаймамСКонтрагентами,
                    Models.Enums.ВидыОперацийРКО.ИнкассацияДенежныхСредств,
                    Models.Enums.ВидыОперацийРКО.РасходДенежныхСредствПрочее,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств[]
                {
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.ОплатаПоставщику,
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.ВозвратДенежныхСредствПокупателю,
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.ПеречислениеНалога,
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.РасчетыПоКредитамИЗаймам,
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.ПрочиеРасчетыСКонтрагентами,
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.ПереводНаДругойСчет,
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.ПеречислениеДенежныхСредствПодотчетнику,
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.ПокупкаПродажаВалюты,
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.ПеречислениеЗП,
                    Models.Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств.ПрочееСписаниеБезналичныхДенежныхСредств,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийСписаниеДенежныхСредств>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийСписаниеДенежныхСредств[]
                {
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ОплатаПоставщику,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ВозвратДенежныхСредствПокупателю,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ПеречислениеНалога,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.РасчетыПоКредитамИЗаймамСКонтрагентами,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ПрочиеРасчетыСКонтрагентами,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ПереводНаДругойСчет,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ПеречислениеЗП,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ВыплатаЗарплатыНаЛицевыеСчета,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ПокупкаПродажаВалюты,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ПеречислениеДенежныхСредствПодотчетнику,
                    Models.Enums.ВидыОперацийСписаниеДенежныхСредств.ПрочееСписаниеБезналичныхДенежныхСредств,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийСписаниеТоваров>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийСписаниеТоваров[]
                {
                    Models.Enums.ВидыОперацийСписаниеТоваров.ТоварыПродукция,
                    Models.Enums.ВидыОперацийСписаниеТоваров.Оборудование,
                    Models.Enums.ВидыОперацийСписаниеТоваров.БланкиСтрогогоУчета,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийСчетНаОплатуПоставщика>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийСчетНаОплатуПоставщика[]
                {
                    Models.Enums.ВидыОперацийСчетНаОплатуПоставщика.ПокупкаКомиссия,
                    Models.Enums.ВидыОперацийСчетНаОплатуПоставщика.Оборудование,
                    Models.Enums.ВидыОперацийСчетНаОплатуПоставщика.ОбъектыСтроительства,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОперацийТребованиеНакладная>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОперацийТребованиеНакладная[]
                {
                    Models.Enums.ВидыОперацийТребованиеНакладная.Материалы,
                    Models.Enums.ВидыОперацийТребованиеНакладная.Оборудование,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОплатыЗарплатнойКарты>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОплатыЗарплатнойКарты[]
                {
                    Models.Enums.ВидыОплатыЗарплатнойКарты.ОплачиваетсяПредприятием,
                    Models.Enums.ВидыОплатыЗарплатнойКарты.ОплачиваетсяДержателем,
                    Models.Enums.ВидыОплатыЗарплатнойКарты.ОплачиваетсяПредприятиемИДержателемВДолях,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОплатыТруда>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОплатыТруда[]
                {
                    Models.Enums.ВидыОплатыТруда.ФОТ,
                    Models.Enums.ВидыОплатыТруда.НеФОТ,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОсобыхНачисленийИУдержаний>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОсобыхНачисленийИУдержаний[]
                {
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.Дивиденды,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ДивидендыСотрудников,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ДоговорАвторскогоЗаказа,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ДоговорРаботыУслуги,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ДСВРаботодателя,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.КомпенсацияЗаЗадержкуЗарплаты,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.МатериальнаяВыгодаПоЗаймам,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.УдалитьМатериальнаяПомощь,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НачисленоПроцентовПоЗайму,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НДФЛ,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НДФЛДоначисленныйПоРезультатамПроверки,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НДФЛДоходыКонтрагентов,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НДФЛЗачтено,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НДФЛКЗачету,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НДФЛПередачаЗадолженностиВНалоговыйОрган,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НДФЛПрочиеРасчетыСПерсоналом,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НДФЛРасчетыСБывшимиСотрудниками,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НФДЛДивиденды,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.НФДЛДивидендыСотрудникам,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ПогашениеЗаймаИзЗарплаты,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ПособиеПриПостановкеНаУчетВРанниеСрокиБеременности,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ПособиеПриРожденииРебенка,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ПроцентыПоЗайму,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.СтоимостьПодарковПризов,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ПособиеНаПогребение,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ВоенныйСбор,
                    Models.Enums.ВидыОсобыхНачисленийИУдержаний.ВСДоходыКонтрагентов,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОстатковНДСПриобретенийОжидаемый>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОстатковНДСПриобретенийОжидаемый[]
                {
                    Models.Enums.ВидыОстатковНДСПриобретенийОжидаемый.ПравильнаяРегистрация,
                    Models.Enums.ВидыОстатковНДСПриобретенийОжидаемый.ЕщеНеПолучены,
                    Models.Enums.ВидыОстатковНДСПриобретенийОжидаемый.НеБудутПолучены,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОстатковНДСПриобретенийПодтвержденный>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОстатковНДСПриобретенийПодтвержденный[]
                {
                    Models.Enums.ВидыОстатковНДСПриобретенийПодтвержденный.НеправильноЗарегистрированы,
                    Models.Enums.ВидыОстатковНДСПриобретенийПодтвержденный.ПолученыИзлишне,
                    Models.Enums.ВидыОстатковНДСПриобретенийПодтвержденный.ПолученыЗаранее,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОстатковНДСПродажОжидаемый>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОстатковНДСПродажОжидаемый[]
                {
                    Models.Enums.ВидыОстатковНДСПродажОжидаемый.ПравильнаяРегистрация,
                    Models.Enums.ВидыОстатковНДСПродажОжидаемый.ЕщеНеВыписаны,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОстатковНДСПродажПодтвержденный>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОстатковНДСПродажПодтвержденный[]
                {
                    Models.Enums.ВидыОстатковНДСПродажПодтвержденный.НеправильноЗарегистрированы,
                    Models.Enums.ВидыОстатковНДСПродажПодтвержденный.ВыписаныЗаранее,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыОтчетности>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыОтчетности[]
                {
                    Models.Enums.ВидыОтчетности.РегламентированнаяОтчетность,
                    Models.Enums.ВидыОтчетности.ОтчетностьПоМСФО,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыПлатежейВСоциальныеФонды>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыПлатежейВСоциальныеФонды[]
                {
                    Models.Enums.ВидыПлатежейВСоциальныеФонды.Взносы,
                    Models.Enums.ВидыПлатежейВСоциальныеФонды.Пени,
                    Models.Enums.ВидыПлатежейВСоциальныеФонды.Штрафы,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыПлатежейПогашенияЗаймаСотруднику>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыПлатежейПогашенияЗаймаСотруднику[]
                {
                    Models.Enums.ВидыПлатежейПогашенияЗаймаСотруднику.ДифференцированныеПлатежи,
                    Models.Enums.ВидыПлатежейПогашенияЗаймаСотруднику.АннуитетныеПлатежи,
                    Models.Enums.ВидыПлатежейПогашенияЗаймаСотруднику.ТолькоПроценты,
                    Models.Enums.ВидыПлатежейПогашенияЗаймаСотруднику.ТолькоЗаем,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыПодтверждающихДокументовОтпускаПоУходу>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыПодтверждающихДокументовОтпускаПоУходу[]
                {
                    Models.Enums.ВидыПодтверждающихДокументовОтпускаПоУходу.СвидетельствоОРождении,
                    Models.Enums.ВидыПодтверждающихДокументовОтпускаПоУходу.РешениеОбУстановленииОпеки,
                    Models.Enums.ВидыПодтверждающихДокументовОтпускаПоУходу.ИнойДокументПодтверждающийРождениеРебенка,
                    Models.Enums.ВидыПодтверждающихДокументовОтпускаПоУходу.СвидетельствоОСмерти,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыПравилДляОбменаДанными>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыПравилДляОбменаДанными[]
                {
                    Models.Enums.ВидыПравилДляОбменаДанными.ПравилаКонвертацииОбъектов,
                    Models.Enums.ВидыПравилДляОбменаДанными.ПравилаРегистрацииОбъектов,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыПределовДоходовНДФЛ>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыПределовДоходовНДФЛ[]
                {
                    Models.Enums.ВидыПределовДоходовНДФЛ.Годовой,
                    Models.Enums.ВидыПределовДоходовНДФЛ.Разовый,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыПризовПодарков>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыПризовПодарков[]
                {
                    Models.Enums.ВидыПризовПодарков.Подарок,
                    Models.Enums.ВидыПризовПодарков.Приз,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыПрофессиональнойПодготовки>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыПрофессиональнойПодготовки[]
                {
                    Models.Enums.ВидыПрофессиональнойПодготовки.Переподготовка,
                    Models.Enums.ВидыПрофессиональнойПодготовки.ПовышениеКвалификации,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыПрочихСчетовУчета>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыПрочихСчетовУчета[]
                {
                    Models.Enums.ВидыПрочихСчетовУчета.СчетДоходовВозвратПоставщику,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетЗатратВозвратПоставщику,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетЗатратОтчетКомиссионераОПродажах,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетЗатратКомиссионныеПокупкаПродажаВалюты,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетЗатратПенсионныйПродажаВалюты,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетЗатратСебестоимостьПродажаВалюты,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетДоходовСебестоимостьПродажаВалюты,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетДтСписаниеЗадолженностиКорректировкаДолга,
                    Models.Enums.ВидыПрочихСчетовУчета.СчетКтСписаниеЗадолженностиКорректировкаДолга,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыРаботСДосрочнойПенсией>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыРаботСДосрочнойПенсией[]
                {
                    Models.Enums.ВидыРаботСДосрочнойПенсией.ПодземныеИВредныеРаботы,
                    Models.Enums.ВидыРаботСДосрочнойПенсией.ТяжелыеИПрочиеРаботы,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыРабочегоВремениСотрудников>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыРабочегоВремениСотрудников[]
                {
                    Models.Enums.ВидыРабочегоВремениСотрудников.ОтработанноеВПределахНормы,
                    Models.Enums.ВидыРабочегоВремениСотрудников.ОтработанноеСверхНормы,
                    Models.Enums.ВидыРабочегоВремениСотрудников.ЦелодневноеНеотработанное,
                    Models.Enums.ВидыРабочегоВремениСотрудников.ЧасовоеНеотработанное,
                    Models.Enums.ВидыРабочегоВремениСотрудников.ДополнительноОплачиваемоеВПределахНормы,
                    Models.Enums.ВидыРабочегоВремениСотрудников.ЧасовоеОтработанноеВПределахНормы,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыРабочихГрафиков>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыРабочихГрафиков[]
                {
                    Models.Enums.ВидыРабочихГрафиков.Пятидневка,
                    Models.Enums.ВидыРабочихГрафиков.Шестидневка,
                    Models.Enums.ВидыРабочихГрафиков.Сменный,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыРасчетовПоДоговорам>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыРасчетовПоДоговорам[]
                {
                    Models.Enums.ВидыРасчетовПоДоговорам.РасчетыВВалютеРегламентированногоУчета,
                    Models.Enums.ВидыРасчетовПоДоговорам.РасчетыВИностраннойВалюте,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыРасчетовПоСредствамФСС>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыРасчетовПоСредствамФСС[]
                {
                    Models.Enums.ВидыРасчетовПоСредствамФСС.РасходыПоСтрахованию,
                    Models.Enums.ВидыРасчетовПоСредствамФСС.ПолученоИзФонда,
                    Models.Enums.ВидыРасчетовПоСредствамФСС.НеПринято,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыСобытийОС>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыСобытийОС[]
                {
                    Models.Enums.ВидыСобытийОС.ВводВЭксплуатацию,
                    Models.Enums.ВидыСобытийОС.НачислениеАмортизации,
                    Models.Enums.ВидыСобытийОС.ВнутреннееПеремещение,
                    Models.Enums.ВидыСобытийОС.ЧастичнаяЛиквидация,
                    Models.Enums.ВидыСобытийОС.Модернизация,
                    Models.Enums.ВидыСобытийОС.ПодготовкаКПередаче,
                    Models.Enums.ВидыСобытийОС.Передача,
                    Models.Enums.ВидыСобытийОС.Списание,
                    Models.Enums.ВидыСобытийОС.Прочее,
                    Models.Enums.ВидыСобытийОС.Ремонт,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыСообщений>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыСообщений[]
                {
                    Models.Enums.ВидыСообщений.Раздел,
                    Models.Enums.ВидыСообщений.Информация,
                    Models.Enums.ВидыСообщений.ВажнаяИнформация,
                    Models.Enums.ВидыСообщений.Ошибка,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыСостоянийНМА>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыСостоянийНМА[]
                {
                    Models.Enums.ВидыСостоянийНМА.Поступил,
                    Models.Enums.ВидыСостоянийНМА.ПринятКУчету,
                    Models.Enums.ВидыСостоянийНМА.Списан,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыСправокОДоходах>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыСправокОДоходах[]
                {
                    Models.Enums.ВидыСправокОДоходах.Произвольная,
                    Models.Enums.ВидыСправокОДоходах.Соцстрах2015,
                    Models.Enums.ВидыСправокОДоходах.Субсидия2015,
                    Models.Enums.ВидыСправокОДоходах.Пенсия2015,
                    Models.Enums.ВидыСправокОДоходах.ДоходыИНалоги,
                    Models.Enums.ВидыСправокОДоходах.Соцстрах,
                    Models.Enums.ВидыСправокОДоходах.Безработица,
                    Models.Enums.ВидыСправокОДоходах.Пенсия,
                    Models.Enums.ВидыСправокОДоходах.Субсидия,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыСтавокНДФЛ>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыСтавокНДФЛ[]
                {
                    Models.Enums.ВидыСтавокНДФЛ.Уменьшенная,
                    Models.Enums.ВидыСтавокНДФЛ.Основная,
                    Models.Enums.ВидыСтавокНДФЛ.Двойная,
                    Models.Enums.ВидыСтавокНДФЛ.НеОблагается,
                    Models.Enums.ВидыСтавокНДФЛ.СтавкаШахтеров,
                    Models.Enums.ВидыСтавокНДФЛ.Увеличенная,
                    Models.Enums.ВидыСтавокНДФЛ.ВоенныйСбор,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыСтоимости>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыСтоимости[]
                {
                    Models.Enums.ВидыСтоимости.Фактическая,
                    Models.Enums.ВидыСтоимости.Плановая,
                    Models.Enums.ВидыСтоимости.Отклонение,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыТарифныхСеток>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыТарифныхСеток[]
                {
                    Models.Enums.ВидыТарифныхСеток.Тариф,
                    Models.Enums.ВидыТарифныхСеток.Надбавка,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыТарифныхСтавок>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыТарифныхСтавок[]
                {
                    Models.Enums.ВидыТарифныхСтавок.МесячнаяТарифнаяСтавка,
                    Models.Enums.ВидыТарифныхСтавок.ЧасоваяТарифнаяСтавка,
                    Models.Enums.ВидыТарифныхСтавок.ДневнаяТарифнаяСтавка,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыТранспортаСообщенийОбмена>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыТранспортаСообщенийОбмена[]
                {
                    Models.Enums.ВидыТранспортаСообщенийОбмена.EMAIL,
                    Models.Enums.ВидыТранспортаСообщенийОбмена.FILE,
                    Models.Enums.ВидыТранспортаСообщенийОбмена.FTP,
                    Models.Enums.ВидыТранспортаСообщенийОбмена.WS,
                    Models.Enums.ВидыТранспортаСообщенийОбмена.COM,
                    Models.Enums.ВидыТранспортаСообщенийОбмена.WSПассивныйРежим,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыТрудовогоСтажа>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыТрудовогоСтажа[]
                {
                    Models.Enums.ВидыТрудовогоСтажа.ОбщийТрудовойСтаж,
                    Models.Enums.ВидыТрудовогоСтажа.ТерриториальныеУсловия,
                    Models.Enums.ВидыТрудовогоСтажа.ОсобыеУсловияТруда,
                    Models.Enums.ВидыТрудовогоСтажа.ВыслугаЛет,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыУдержанийДляТиповыхОтчетов>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыУдержанийДляТиповыхОтчетов[]
                {
                    Models.Enums.ВидыУдержанийДляТиповыхОтчетов.ПрофсоюзныеВзносы,
                    Models.Enums.ВидыУдержанийДляТиповыхОтчетов.Алименты,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыУлучшения>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыУлучшения[]
                {
                    Models.Enums.ВидыУлучшения.Модернизация,
                    Models.Enums.ВидыУлучшения.Ремонт,
                });
            });
            modelBuilder.Entity<Models.Enums.ВидыУчетаВремениДляСредней>(mb =>
            {
                mb.HasData(new Models.Enums.ВидыУчетаВремениДляСредней[]
                {
                    Models.Enums.ВидыУчетаВремениДляСредней.ПоРабочимДням,
                    Models.Enums.ВидыУчетаВремениДляСредней.ПоРабочимЧасам,
                });
            });
            modelBuilder.Entity<Models.Enums.ГодностьКВоеннойСлужбе>(mb =>
            {
                mb.HasData(new Models.Enums.ГодностьКВоеннойСлужбе[]
                {
                    Models.Enums.ГодностьКВоеннойСлужбе.Годен,
                    Models.Enums.ГодностьКВоеннойСлужбе.ГоденСОграничениями,
                    Models.Enums.ГодностьКВоеннойСлужбе.ОграниченноГоден,
                    Models.Enums.ГодностьКВоеннойСлужбе.ВременноНеГоден,
                    Models.Enums.ГодностьКВоеннойСлужбе.НеГоден,
                });
            });
            modelBuilder.Entity<Models.Enums.ГруппыИнвалидности>(mb =>
            {
                mb.HasData(new Models.Enums.ГруппыИнвалидности[]
                {
                    Models.Enums.ГруппыИнвалидности.ПерваяГруппа,
                    Models.Enums.ГруппыИнвалидности.ВтораяГруппа,
                    Models.Enums.ГруппыИнвалидности.ТретьяГруппа,
                });
            });
            modelBuilder.Entity<Models.Enums.ГруппыНалоговыхНазначений>(mb =>
            {
                mb.HasData(new Models.Enums.ГруппыНалоговыхНазначений[]
                {
                    Models.Enums.ГруппыНалоговыхНазначений.НалоговыеНазначенияДоНКУ,
                    Models.Enums.ГруппыНалоговыхНазначений.НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС,
                    Models.Enums.ГруппыНалоговыхНазначений.НалоговыеНазначенияДоходовИЗатрат,
                });
            });
            modelBuilder.Entity<Models.Enums.ГруппыНачисленияУдержанияВыплаты>(mb =>
            {
                mb.HasData(new Models.Enums.ГруппыНачисленияУдержанияВыплаты[]
                {
                    Models.Enums.ГруппыНачисленияУдержанияВыплаты.НачальноеСальдоПериода,
                    Models.Enums.ГруппыНачисленияУдержанияВыплаты.НачальноеСальдо,
                    Models.Enums.ГруппыНачисленияУдержанияВыплаты.Начислено,
                    Models.Enums.ГруппыНачисленияУдержанияВыплаты.Удержано,
                    Models.Enums.ГруппыНачисленияУдержанияВыплаты.Выплачено,
                    Models.Enums.ГруппыНачисленияУдержанияВыплаты.КонечноеСальдо,
                    Models.Enums.ГруппыНачисленияУдержанияВыплаты.КонечноеСальдоПериода,
                    Models.Enums.ГруппыНачисленияУдержанияВыплаты.Справочно,
                    Models.Enums.ГруппыНачисленияУдержанияВыплаты.Льготы,
                });
            });
            modelBuilder.Entity<Models.Enums.ГруппыПлательщиковЕдиногоНалога>(mb =>
            {
                mb.HasData(new Models.Enums.ГруппыПлательщиковЕдиногоНалога[]
                {
                    Models.Enums.ГруппыПлательщиковЕдиногоНалога.ПерваяГруппа,
                    Models.Enums.ГруппыПлательщиковЕдиногоНалога.ВтораяГруппа,
                    Models.Enums.ГруппыПлательщиковЕдиногоНалога.ТретьяГруппа,
                    Models.Enums.ГруппыПлательщиковЕдиногоНалога.ЧетвертаяГруппа,
                    Models.Enums.ГруппыПлательщиковЕдиногоНалога.ПятаяГруппа,
                    Models.Enums.ГруппыПлательщиковЕдиногоНалога.ШестаяГруппа,
                });
            });
            modelBuilder.Entity<Models.Enums.ГруппыУчетаКарточкиВоинскогоУчета>(mb =>
            {
                mb.HasData(new Models.Enums.ГруппыУчетаКарточкиВоинскогоУчета[]
                {
                    Models.Enums.ГруппыУчетаКарточкиВоинскогоУчета.ОфицерскийСостав,
                    Models.Enums.ГруппыУчетаКарточкиВоинскогоУчета.РедовойСержантскийСтаршинскийСостав,
                    Models.Enums.ГруппыУчетаКарточкиВоинскогоУчета.Женщины,
                    Models.Enums.ГруппыУчетаКарточкиВоинскогоУчета.Призывники,
                });
            });
            modelBuilder.Entity<Models.Enums.ДействияПриОбмене>(mb =>
            {
                mb.HasData(new Models.Enums.ДействияПриОбмене[]
                {
                    Models.Enums.ДействияПриОбмене.ЗагрузкаДанных,
                    Models.Enums.ДействияПриОбмене.ВыгрузкаДанных,
                });
            });
            modelBuilder.Entity<Models.Enums.ДействияСЕжегоднымиОтпусками>(mb =>
            {
                mb.HasData(new Models.Enums.ДействияСЕжегоднымиОтпусками[]
                {
                    Models.Enums.ДействияСЕжегоднымиОтпусками.Утвердить,
                    Models.Enums.ДействияСЕжегоднымиОтпусками.Отменить,
                });
            });
            modelBuilder.Entity<Models.Enums.ДействияСНачислениямиИУдержаниями>(mb =>
            {
                mb.HasData(new Models.Enums.ДействияСНачислениямиИУдержаниями[]
                {
                    Models.Enums.ДействияСНачислениямиИУдержаниями.Утвердить,
                    Models.Enums.ДействияСНачислениямиИУдержаниями.Отменить,
                });
            });
            modelBuilder.Entity<Models.Enums.ДействияСПозициямиШтатногоРасписания>(mb =>
            {
                mb.HasData(new Models.Enums.ДействияСПозициямиШтатногоРасписания[]
                {
                    Models.Enums.ДействияСПозициямиШтатногоРасписания.СоздатьНовуюПозицию,
                    Models.Enums.ДействияСПозициямиШтатногоРасписания.ЗакрытьПозицию,
                });
            });
            modelBuilder.Entity<Models.Enums.ДействияСУдержаниями>(mb =>
            {
                mb.HasData(new Models.Enums.ДействияСУдержаниями[]
                {
                    Models.Enums.ДействияСУдержаниями.Начать,
                    Models.Enums.ДействияСУдержаниями.Изменить,
                    Models.Enums.ДействияСУдержаниями.Прекратить,
                });
            });
            modelBuilder.Entity<Models.Enums.ДействияСФайламиПоДвойномуЩелчку>(mb =>
            {
                mb.HasData(new Models.Enums.ДействияСФайламиПоДвойномуЩелчку[]
                {
                    Models.Enums.ДействияСФайламиПоДвойномуЩелчку.ОткрыватьФайл,
                    Models.Enums.ДействияСФайламиПоДвойномуЩелчку.ОткрыватьКарточку,
                });
            });
            modelBuilder.Entity<Models.Enums.ДополнительнаяКолонкаПечатныхФормДокументов>(mb =>
            {
                mb.HasData(new Models.Enums.ДополнительнаяКолонкаПечатныхФормДокументов[]
                {
                    Models.Enums.ДополнительнаяКолонкаПечатныхФормДокументов.НеВыводить,
                    Models.Enums.ДополнительнаяКолонкаПечатныхФормДокументов.Артикул,
                    Models.Enums.ДополнительнаяКолонкаПечатныхФормДокументов.Код,
                });
            });
            modelBuilder.Entity<Models.Enums.ДополнительныеЗначенияДоступа>(mb =>
            {
                mb.HasData(new Models.Enums.ДополнительныеЗначенияДоступа[]
                {
                    Models.Enums.ДополнительныеЗначенияДоступа.ДоступРазрешен,
                    Models.Enums.ДополнительныеЗначенияДоступа.ДоступЗапрещен,
                    Models.Enums.ДополнительныеЗначенияДоступа.Истина,
                    Models.Enums.ДополнительныеЗначенияДоступа.Ложь,
                    Models.Enums.ДополнительныеЗначенияДоступа.ПустаяСсылкаЛюбогоТипа,
                    Models.Enums.ДополнительныеЗначенияДоступа.Неопределено,
                    Models.Enums.ДополнительныеЗначенияДоступа.Null,
                    Models.Enums.ДополнительныеЗначенияДоступа.ТипРазрешенный,
                    Models.Enums.ДополнительныеЗначенияДоступа.ТипЗапрещенный,
                });
            });
            modelBuilder.Entity<Models.Enums.ДоступныеПериодыОтчета>(mb =>
            {
                mb.HasData(new Models.Enums.ДоступныеПериодыОтчета[]
                {
                    Models.Enums.ДоступныеПериодыОтчета.День,
                    Models.Enums.ДоступныеПериодыОтчета.Неделя,
                    Models.Enums.ДоступныеПериодыОтчета.Декада,
                    Models.Enums.ДоступныеПериодыОтчета.Месяц,
                    Models.Enums.ДоступныеПериодыОтчета.Квартал,
                    Models.Enums.ДоступныеПериодыОтчета.Полугодие,
                    Models.Enums.ДоступныеПериодыОтчета.Год,
                    Models.Enums.ДоступныеПериодыОтчета.ПроизвольныйПериод,
                });
            });
            modelBuilder.Entity<Models.Enums.ЕдиницыВремениУчетаСпецстажа>(mb =>
            {
                mb.HasData(new Models.Enums.ЕдиницыВремениУчетаСпецстажа[]
                {
                    Models.Enums.ЕдиницыВремениУчетаСпецстажа.КалендарныеДни,
                    Models.Enums.ЕдиницыВремениУчетаСпецстажа.Смены,
                    Models.Enums.ЕдиницыВремениУчетаСпецстажа.Часы,
                });
            });
            modelBuilder.Entity<Models.Enums.ЗадачиНачалаРаботы>(mb =>
            {
                mb.HasData(new Models.Enums.ЗадачиНачалаРаботы[]
                {
                    Models.Enums.ЗадачиНачалаРаботы.ДоступКОрганизациям,
                    Models.Enums.ЗадачиНачалаРаботы.РеквизитыОрганизации,
                    Models.Enums.ЗадачиНачалаРаботы.ПараметрыУчета,
                    Models.Enums.ЗадачиНачалаРаботы.УчетнаяПолитика,
                    Models.Enums.ЗадачиНачалаРаботы.НачальныеОстатки,
                });
            });
            modelBuilder.Entity<Models.Enums.ЗначениеРесурсаРегистровСостоянийСотрудника>(mb =>
            {
                mb.HasData(new Models.Enums.ЗначениеРесурсаРегистровСостоянийСотрудника[]
                {
                    Models.Enums.ЗначениеРесурсаРегистровСостоянийСотрудника.НеУстановлено,
                    Models.Enums.ЗначениеРесурсаРегистровСостоянийСотрудника.Установлено,
                    Models.Enums.ЗначениеРесурсаРегистровСостоянийСотрудника.УстановленоЗначениеПоУмолчанию,
                });
            });
            modelBuilder.Entity<Models.Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка>(mb =>
            {
                mb.HasData(new Models.Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка[]
                {
                    Models.Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка.ПереносДанных,
                    Models.Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка.СведенияДоНачалаЭксплуатации,
                    Models.Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка.Начисления,
                    Models.Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка.Исправления,
                });
            });
            modelBuilder.Entity<Models.Enums.ИсточникиПравилДляОбменаДанными>(mb =>
            {
                mb.HasData(new Models.Enums.ИсточникиПравилДляОбменаДанными[]
                {
                    Models.Enums.ИсточникиПравилДляОбменаДанными.МакетКонфигурации,
                    Models.Enums.ИсточникиПравилДляОбменаДанными.Файл,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииДолжностейДляВоинскогоУчета>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииДолжностейДляВоинскогоУчета[]
                {
                    Models.Enums.КатегорииДолжностейДляВоинскогоУчета.Руководители,
                    Models.Enums.КатегорииДолжностейДляВоинскогоУчета.Специалисты,
                    Models.Enums.КатегорииДолжностейДляВоинскогоУчета.ДругиеСлужащие,
                    Models.Enums.КатегорииДолжностейДляВоинскогоУчета.Рабочие,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииДолжностейДляСтатистическогоУчета>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииДолжностейДляСтатистическогоУчета[]
                {
                    Models.Enums.КатегорииДолжностейДляСтатистическогоУчета.Руководители,
                    Models.Enums.КатегорииДолжностейДляСтатистическогоУчета.Специалисты,
                    Models.Enums.КатегорииДолжностейДляСтатистическогоУчета.ДругиеСлужащие,
                    Models.Enums.КатегорииДолжностейДляСтатистическогоУчета.Рабочие,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииДолжностейДляУчетаЗабронированных>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииДолжностейДляУчетаЗабронированных[]
                {
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.Руководители,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.СпециалистыСХ,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.СпециалистыПолезныеИскопаемые,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.СпециалистыОбрабатывающиеПроизводства,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.СпециалистыПроизводствоЭлектроэнергии,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.СпециалистыСтроительство,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.СпециалистыТранспорт,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.СпециалистыОбразования,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.СпециалистыЗдравоохранение,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.ПрочиеСпециалисты,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.ДругиеСлужащие,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.РабочиеИмеющиеТарифныйРазряд,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.РабочиеНеИмеющиеТарифныхРазрядов,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.РабочиеСХ,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.РабочиеЛокомотивныхБригад,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.Водители,
                    Models.Enums.КатегорииДолжностейДляУчетаЗабронированных.Трактористы,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииЗапасаВоеннообязанных>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииЗапасаВоеннообязанных[]
                {
                    Models.Enums.КатегорииЗапасаВоеннообязанных.ПерваяКатегория,
                    Models.Enums.КатегорииЗапасаВоеннообязанных.ВтораяКатегория,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииНачисленийИНеоплаченногоВремени>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииНачисленийИНеоплаченногоВремени[]
                {
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ПовременнаяОплатаТруда,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаПоДоговоруГПХ,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.Доплата,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.СдельнаяОплатаТруда,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаТрудаВНатуральнойФорме,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ДоходВНатуральнойФорме,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.КомпенсационныеВыплаты,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.Премия,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.РайонныйКоэффициент,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.СевернаяНадбавка,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ДенежноеСодержаниеНаПериодОтпуска,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ДенежноеСодержаниеКомпенсацияОтпуска,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.Индексация,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.КомпенсацияОтпуска,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ЕдиновременнаяВыплатаКОтпускуГосслужащего,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ЕдиновременнаяВыплатаКОтпуску,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.МатериальнаяПомощьПриОтпускеГосслужащего,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.МатериальнаяПомощьПриОтпуске,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ДоплатаДоМЗП,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.НеявкаПоНевыясненнымПричинам,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.Прогул,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ПростойПоВинеРаботника,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаПростояПоВинеРаботодателя,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаПростояПоНезависящимОтРаботодателяПричинам,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ДенежноеСодержаниеНаПериодКомандировки,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаКомандировки,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.СохраняемоеДенежноеСодержание,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаПоСреднемуЗаработку,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ДоплатаДоСреднегоЗаработка,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаОтпуска,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОтпускБезОплаты,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаБольничногоЛиста,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаБольничногоПрофзаболевание,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаБольничногоЛистаЗаСчетРаботодателя,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ДоплатаДоСреднегоЗаработкаЗаДниБолезни,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаДнейУходаЗаДетьмиИнвалидами,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ПособиеПоУходуЗаРебенкомДоПолутораЛет,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ПособиеПоУходуЗаРебенкомДоТрехЛет,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ВыходноеПособиеМесячноеДенежноеСодержание,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ВыходноеПособие,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ДоплатаЗаСовмещение,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.БолезньБезОплаты,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОтпускПоБеременностиИРодамБезОплаты,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаБольничногоНесчастныйСлучайНаПроизводстве,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОтпускПоБеременностиИРодам,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОтпускПоУходуЗаРебенкомДо3Лет,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОтпускПоУходуЗаРебенкомДо6Лет,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.НачисленияМобилизованным,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ПрогулИлиНеявка,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ЗаработокНаВремяТрудоустройства,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.МатериальнаяПомощь,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.Льгота,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.НадбавкаЗаВредность,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОтпускНаСанаторноКурортноеЛечение,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.Отгул,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ОплатаПредыдущимиДокументами,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.Прочее,
                    Models.Enums.КатегорииНачисленийИНеоплаченногоВремени.ДоплатаДоДенежногоСодержанияЗаДниБолезни,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииРасчетов>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииРасчетов[]
                {
                    Models.Enums.КатегорииРасчетов.Первичное,
                    Models.Enums.КатегорииРасчетов.ЗависимоеПервогоУровня,
                    Models.Enums.КатегорииРасчетов.ЗависимоеВторогоУровня,
                    Models.Enums.КатегорииРасчетов.ЗависимоеТретьегоУровня,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииСведенийОФизическихЛицах>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииСведенийОФизическихЛицах[]
                {
                    Models.Enums.КатегорииСведенийОФизическихЛицах.Должность,
                    Models.Enums.КатегорииСведенийОФизическихЛицах.Инвалидность,
                    Models.Enums.КатегорииСведенийОФизическихЛицах.КонтактнаяИнформация,
                    Models.Enums.КатегорииСведенийОФизическихЛицах.Образование,
                    Models.Enums.КатегорииСведенийОФизическихЛицах.Организация,
                    Models.Enums.КатегорииСведенийОФизическихЛицах.Подразделение,
                    Models.Enums.КатегорииСведенийОФизическихЛицах.СемейноеПоложение,
                    Models.Enums.КатегорииСведенийОФизическихЛицах.СоставСемьи,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииСотрудниковОбменаСБанками>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииСотрудниковОбменаСБанками[]
                {
                    Models.Enums.КатегорииСотрудниковОбменаСБанками.Прочие,
                    Models.Enums.КатегорииСотрудниковОбменаСБанками.Пенсионеры,
                    Models.Enums.КатегорииСотрудниковОбменаСБанками.Студенты,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииСтажа>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииСтажа[]
                {
                    Models.Enums.КатегорииСтажа.ВыслугаЛет,
                    Models.Enums.КатегорииСтажа.Медицинский,
                    Models.Enums.КатегорииСтажа.Непрерывный,
                    Models.Enums.КатегорииСтажа.Общий,
                    Models.Enums.КатегорииСтажа.ОбщийНаучноПедагогический,
                    Models.Enums.КатегорииСтажа.Педагогический,
                    Models.Enums.КатегорииСтажа.Прочее,
                    Models.Enums.КатегорииСтажа.РасширенныйСтраховой,
                    Models.Enums.КатегорииСтажа.Северный,
                    Models.Enums.КатегорииСтажа.Страховой,
                    Models.Enums.КатегорииСтажа.ВыслугаЛетНаГосударственнойСлужбе,
                    Models.Enums.КатегорииСтажа.ВыслугаЛетНаВоеннойСлужбе,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииСтатистическогоНаблюдения>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииСтатистическогоНаблюдения[]
                {
                    Models.Enums.КатегорииСтатистическогоНаблюдения.ВыплатаСоциальногоХарактера,
                    Models.Enums.КатегорииСтатистическогоНаблюдения.ЗаработнаяПлатаРаботников,
                });
            });
            modelBuilder.Entity<Models.Enums.КатегорииУдержаний>(mb =>
            {
                mb.HasData(new Models.Enums.КатегорииУдержаний[]
                {
                    Models.Enums.КатегорииУдержаний.ПрофсоюзныеВзносы,
                    Models.Enums.КатегорииУдержаний.Алименты,
                    Models.Enums.КатегорииУдержаний.ИсполнительныйЛист,
                    Models.Enums.КатегорииУдержаний.ПочтовыйСбор,
                    Models.Enums.КатегорииУдержаний.Прочее,
                    Models.Enums.КатегорииУдержаний.ВознаграждениеПлатежногоАгента,
                    Models.Enums.КатегорииУдержаний.УдержаниеЗаНеотработанныеДниОтпуска,
                    Models.Enums.КатегорииУдержаний.ДСВ,
                    Models.Enums.КатегорииУдержаний.ДобровольныеВзносыВНПФ,
                    Models.Enums.КатегорииУдержаний.ПрочееУдержаниеВПользуТретьихЛиц,
                    Models.Enums.КатегорииУдержаний.УдержаниеВСчетРасчетовПоПрочимОперациям,
                    Models.Enums.КатегорииУдержаний.ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска,
                    Models.Enums.КатегорииУдержаний.ОбязательстваПоУченическомуДоговору,
                });
            });
            modelBuilder.Entity<Models.Enums.КлассификаторВоинскихЗваний>(mb =>
            {
                mb.HasData(new Models.Enums.КлассификаторВоинскихЗваний[]
                {
                    Models.Enums.КлассификаторВоинскихЗваний.Солдат,
                    Models.Enums.КлассификаторВоинскихЗваний.Матрос,
                    Models.Enums.КлассификаторВоинскихЗваний.СтаршийСолдат,
                    Models.Enums.КлассификаторВоинскихЗваний.СтаршийМатрос,
                    Models.Enums.КлассификаторВоинскихЗваний.МладшийСержант,
                    Models.Enums.КлассификаторВоинскихЗваний.Старшина2Статьи,
                    Models.Enums.КлассификаторВоинскихЗваний.Сержант,
                    Models.Enums.КлассификаторВоинскихЗваний.Старшина1Статьи,
                    Models.Enums.КлассификаторВоинскихЗваний.СтаршийСержант,
                    Models.Enums.КлассификаторВоинскихЗваний.ГлавныйСтаршина,
                    Models.Enums.КлассификаторВоинскихЗваний.Старшина,
                    Models.Enums.КлассификаторВоинскихЗваний.ГлавныйКорабельныйСтаршина,
                    Models.Enums.КлассификаторВоинскихЗваний.Прапорщик,
                    Models.Enums.КлассификаторВоинскихЗваний.Мичман,
                    Models.Enums.КлассификаторВоинскихЗваний.СтаршийПрапорщик,
                    Models.Enums.КлассификаторВоинскихЗваний.СтаршийМичман,
                    Models.Enums.КлассификаторВоинскихЗваний.МладшийЛейтенант,
                    Models.Enums.КлассификаторВоинскихЗваний.Лейтенант,
                    Models.Enums.КлассификаторВоинскихЗваний.СтаршийЛейтенант,
                    Models.Enums.КлассификаторВоинскихЗваний.Капитан,
                    Models.Enums.КлассификаторВоинскихЗваний.КапитанЛейтенант,
                    Models.Enums.КлассификаторВоинскихЗваний.Майор,
                    Models.Enums.КлассификаторВоинскихЗваний.Капитан3Ранга,
                    Models.Enums.КлассификаторВоинскихЗваний.Подполковник,
                    Models.Enums.КлассификаторВоинскихЗваний.Капитан2Ранга,
                    Models.Enums.КлассификаторВоинскихЗваний.Полковник,
                    Models.Enums.КлассификаторВоинскихЗваний.Капитан1Ранга,
                    Models.Enums.КлассификаторВоинскихЗваний.ГенералМайор,
                    Models.Enums.КлассификаторВоинскихЗваний.КонтрАдмирал,
                    Models.Enums.КлассификаторВоинскихЗваний.ГенералЛейтенант,
                    Models.Enums.КлассификаторВоинскихЗваний.ВицеАдмирал,
                    Models.Enums.КлассификаторВоинскихЗваний.ГенералПолковник,
                    Models.Enums.КлассификаторВоинскихЗваний.Адмирал,
                    Models.Enums.КлассификаторВоинскихЗваний.ГенералАрмии,
                });
            });
            modelBuilder.Entity<Models.Enums.КлассыСчетовРасходов>(mb =>
            {
                mb.HasData(new Models.Enums.КлассыСчетовРасходов[]
                {
                    Models.Enums.КлассыСчетовРасходов.Класс8,
                    Models.Enums.КлассыСчетовРасходов.Класс9,
                    Models.Enums.КлассыСчетовРасходов.Класс8и9,
                });
            });
            modelBuilder.Entity<Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки>(mb =>
            {
                mb.HasData(new Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки[]
                {
                    Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки.Опасный,
                    Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки.Вредный1,
                    Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки.Вредный2,
                    Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки.Вредный3,
                    Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки.Вредный4,
                    Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки.Допустимый,
                    Models.Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки.Оптимальный,
                });
            });
            modelBuilder.Entity<Models.Enums.КодировкаФайловОбменаПоЗарплатномуПроекту>(mb =>
            {
                mb.HasData(new Models.Enums.КодировкаФайловОбменаПоЗарплатномуПроекту[]
                {
                    Models.Enums.КодировкаФайловОбменаПоЗарплатномуПроекту.UTF8,
                    Models.Enums.КодировкаФайловОбменаПоЗарплатномуПроекту.Windows1251,
                });
            });
            modelBuilder.Entity<Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций>(mb =>
            {
                mb.HasData(new Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций[]
                {
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.Начисления,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.Взносы,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.НДФЛ,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.Удержания,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.Выплата,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.ПереносКопеекНаСледующийМесяц,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.УдалитьВыплатаАванса,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.УдалитьВыплатаМежрасчетная,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.УдалитьВыплатаОчередная,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.УдалитьВыплатаДивидендов,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.УдалитьВыплатаДепонента,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.УдалитьПогашениеНачисленийПоФактуВыплаты,
                    Models.Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций.УдалитьВключениеКопеекПредыдущегоМесяца,
                });
            });
            modelBuilder.Entity<Models.Enums.КодыОперацийНДСНалоговыйКредит>(mb =>
            {
                mb.HasData(new Models.Enums.КодыОперацийНДСНалоговыйКредит[]
                {
                    Models.Enums.КодыОперацийНДСНалоговыйКредит.ПервичныйДокумент,
                    Models.Enums.КодыОперацийНДСНалоговыйКредит.КорректировкиПоИспользованию,
                    Models.Enums.КодыОперацийНДСНалоговыйКредит.КорректировкиНеправильноЗарегистрированныхДокументов,
                });
            });
            modelBuilder.Entity<Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений>(mb =>
            {
                mb.HasData(new Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений[]
                {
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений.ОжидаемыйНДС,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений.ПодтвержденныйНДС,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений.КорректировкаПервичныйДокумент,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений.КорректировкаНалоговыйДокумент,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений.КорректировкаРегламентная,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений.КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений.РегистрацияАвансов,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений.ОтменаРегистрацииАвансов,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений.КорректировкаНеправильноОформленныхНалоговыхДокументов,
                });
            });
            modelBuilder.Entity<Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж>(mb =>
            {
                mb.HasData(new Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж[]
                {
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж.ОжидаемыйНДС,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж.ПодтвержденныйНДС,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж.КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж.РегистрацияАвансов,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж.ОтменаРегистрацииАвансов,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж.КорректировкаНеправильноОформленныхНалоговыхДокументов,
                    Models.Enums.КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж.ПереводОФвСоставНепроизводственных,
                });
            });
            modelBuilder.Entity<Models.Enums.КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет>(mb =>
            {
                mb.HasData(new Models.Enums.КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет[]
                {
                    Models.Enums.КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет.Поступление,
                    Models.Enums.КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет.Возврат,
                    Models.Enums.КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет.Реализация,
                });
            });
            modelBuilder.Entity<Models.Enums.КомпенсацияУдержаниеОтпускаПриУвольнении>(mb =>
            {
                mb.HasData(new Models.Enums.КомпенсацияУдержаниеОтпускаПриУвольнении[]
                {
                    Models.Enums.КомпенсацияУдержаниеОтпускаПриУвольнении.НеИспользовать,
                    Models.Enums.КомпенсацияУдержаниеОтпускаПриУвольнении.КомпенсироватьНеИспользованные,
                    Models.Enums.КомпенсацияУдержаниеОтпускаПриУвольнении.УдержатьЗаИспользованныеАвансом,
                });
            });
            modelBuilder.Entity<Models.Enums.МетодыКорректировкиНалоговогоКредита>(mb =>
            {
                mb.HasData(new Models.Enums.МетодыКорректировкиНалоговогоКредита[]
                {
                    Models.Enums.МетодыКорректировкиНалоговогоКредита.НаНалоговыйКредит,
                    Models.Enums.МетодыКорректировкиНалоговогоКредита.НаНалоговыеОбязательства,
                    Models.Enums.МетодыКорректировкиНалоговогоКредита.НеКорректировать,
                });
            });
            modelBuilder.Entity<Models.Enums.МетодыНачисленияРезервовОтпусков>(mb =>
            {
                mb.HasData(new Models.Enums.МетодыНачисленияРезервовОтпусков[]
                {
                    Models.Enums.МетодыНачисленияРезервовОтпусков.МетодОбязательств,
                    Models.Enums.МетодыНачисленияРезервовОтпусков.НормативныйМетод,
                });
            });
            modelBuilder.Entity<Models.Enums.МетодыРаспределенияРБП>(mb =>
            {
                mb.HasData(new Models.Enums.МетодыРаспределенияРБП[]
                {
                    Models.Enums.МетодыРаспределенияРБП.ПоДням,
                    Models.Enums.МетодыРаспределенияРБП.ПоМесяцам,
                });
            });
            modelBuilder.Entity<Models.Enums.МоментыОпределенияНалоговойБазы>(mb =>
            {
                mb.HasData(new Models.Enums.МоментыОпределенияНалоговойБазы[]
                {
                    Models.Enums.МоментыОпределенияНалоговойБазы.ПоОплате,
                    Models.Enums.МоментыОпределенияНалоговойБазы.ПоОтгрузке,
                    Models.Enums.МоментыОпределенияНалоговойБазы.ПоПервомуСобытию,
                    Models.Enums.МоментыОпределенияНалоговойБазы.НеОпределять,
                });
            });
            modelBuilder.Entity<Models.Enums.НазначенияПоказателейРасчетаЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.НазначенияПоказателейРасчетаЗарплаты[]
                {
                    Models.Enums.НазначенияПоказателейРасчетаЗарплаты.ДляСотрудника,
                    Models.Enums.НазначенияПоказателейРасчетаЗарплаты.ДляПодразделения,
                    Models.Enums.НазначенияПоказателейРасчетаЗарплаты.ДляОрганизации,
                });
            });
            modelBuilder.Entity<Models.Enums.Нумераторы>(mb =>
            {
                mb.HasData(new Models.Enums.Нумераторы[]
                {
                    Models.Enums.Нумераторы.ПлатежноеПоручение,
                    Models.Enums.Нумераторы.РасходныйКассовыйОрдер,
                    Models.Enums.Нумераторы.ПриходныйКассовыйОрдер,
                });
            });
            modelBuilder.Entity<Models.Enums.ОперацииАдминистрированияПрофилейБезопасности>(mb =>
            {
                mb.HasData(new Models.Enums.ОперацииАдминистрированияПрофилейБезопасности[]
                {
                    Models.Enums.ОперацииАдминистрированияПрофилейБезопасности.Создание,
                    Models.Enums.ОперацииАдминистрированияПрофилейБезопасности.Назначение,
                    Models.Enums.ОперацииАдминистрированияПрофилейБезопасности.Обновление,
                    Models.Enums.ОперацииАдминистрированияПрофилейБезопасности.Удаление,
                    Models.Enums.ОперацииАдминистрированияПрофилейБезопасности.УдалениеНазначения,
                });
            });
            modelBuilder.Entity<Models.Enums.ОснованияДляДоначисленияСтраховыхВзносов>(mb =>
            {
                mb.HasData(new Models.Enums.ОснованияДляДоначисленияСтраховыхВзносов[]
                {
                    Models.Enums.ОснованияДляДоначисленияСтраховыхВзносов.КамеральнаяПроверка,
                    Models.Enums.ОснованияДляДоначисленияСтраховыхВзносов.ВыезднаяПроверка,
                    Models.Enums.ОснованияДляДоначисленияСтраховыхВзносов.ДляИсправленияОшибок,
                    Models.Enums.ОснованияДляДоначисленияСтраховыхВзносов.КорректировкаНеПризнаннаяОшибкой,
                });
            });
            modelBuilder.Entity<Models.Enums.ОснованияЛьготПоПособию>(mb =>
            {
                mb.HasData(new Models.Enums.ОснованияЛьготПоПособию[]
                {
                    Models.Enums.ОснованияЛьготПоПособию.Чернобыль,
                    Models.Enums.ОснованияЛьготПоПособию.ВетераныВойны,
                    Models.Enums.ОснованияЛьготПоПособию.ЖертвыНацистскихПреследований,
                    Models.Enums.ОснованияЛьготПоПособию.РодительРебенкаЧернобыльца,
                    Models.Enums.ОснованияЛьготПоПособию.Донор,
                    Models.Enums.ОснованияЛьготПоПособию.УчастникРеволюцииДостоинства,
                });
            });
            modelBuilder.Entity<Models.Enums.ОтветственныеЛицаОрганизаций>(mb =>
            {
                mb.HasData(new Models.Enums.ОтветственныеЛицаОрганизаций[]
                {
                    Models.Enums.ОтветственныеЛицаОрганизаций.Руководитель,
                    Models.Enums.ОтветственныеЛицаОрганизаций.ГлавныйБухгалтер,
                    Models.Enums.ОтветственныеЛицаОрганизаций.РуководительКадровойСлужбы,
                    Models.Enums.ОтветственныеЛицаОрганизаций.Кассир,
                    Models.Enums.ОтветственныеЛицаОрганизаций.ОтветственныйЗаБухгалтерскиеРегистры,
                });
            });
            modelBuilder.Entity<Models.Enums.ОтношениеКВоинскойОбязанности>(mb =>
            {
                mb.HasData(new Models.Enums.ОтношениеКВоинскойОбязанности[]
                {
                    Models.Enums.ОтношениеКВоинскойОбязанности.Военнообязанный,
                    Models.Enums.ОтношениеКВоинскойОбязанности.НеВоеннообязанный,
                    Models.Enums.ОтношениеКВоинскойОбязанности.Призывник,
                });
            });
            modelBuilder.Entity<Models.Enums.ОтношениеКВоинскомуУчету>(mb =>
            {
                mb.HasData(new Models.Enums.ОтношениеКВоинскомуУчету[]
                {
                    Models.Enums.ОтношениеКВоинскомуУчету.Состоит,
                    Models.Enums.ОтношениеКВоинскомуУчету.Встает,
                    Models.Enums.ОтношениеКВоинскомуУчету.НеСостоит,
                    Models.Enums.ОтношениеКВоинскомуУчету.СнятПоВозрасту,
                    Models.Enums.ОтношениеКВоинскомуУчету.СнятПоСостояниюЗдоровья,
                    Models.Enums.ОтношениеКВоинскомуУчету.ПризванНаВоинскуюСлужбу,
                    Models.Enums.ОтношениеКВоинскомуУчету.СлужбаПоКонтракту,
                });
            });
            modelBuilder.Entity<Models.Enums.ПереченьПособийСоциальногоСтрахования>(mb =>
            {
                mb.HasData(new Models.Enums.ПереченьПособийСоциальногоСтрахования[]
                {
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.Нетрудоспособность,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.БеременностьРоды,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.ПриРожденииРебенка,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.ПриПостановкеНаУчетВРанниеСрокиБеременности,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.ВСвязиСоСмертью,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.ДополнительныеВыходныеДниПоУходуЗаДетьмиИнвалидами,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.НетрудоспособностьНесчастныйСлучай,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.НетрудоспособностьПрофзаболевание,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.ДополнительныйОтпускПослеНесчастныхСлучаев,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.ПоУходуЗаРебенком,
                    Models.Enums.ПереченьПособийСоциальногоСтрахования.СтраховыеВзносыПоДопВыходнымПоУходуЗаДетьмиИнвалидами,
                });
            });
            modelBuilder.Entity<Models.Enums.ПериодичностиРасписанийРассылокОтчетов>(mb =>
            {
                mb.HasData(new Models.Enums.ПериодичностиРасписанийРассылокОтчетов[]
                {
                    Models.Enums.ПериодичностиРасписанийРассылокОтчетов.Ежедневно,
                    Models.Enums.ПериодичностиРасписанийРассылокОтчетов.Еженедельно,
                    Models.Enums.ПериодичностиРасписанийРассылокОтчетов.Ежемесячно,
                    Models.Enums.ПериодичностиРасписанийРассылокОтчетов.Произвольное,
                });
            });
            modelBuilder.Entity<Models.Enums.Периодичность>(mb =>
            {
                mb.HasData(new Models.Enums.Периодичность[]
                {
                    Models.Enums.Периодичность.День,
                    Models.Enums.Периодичность.Неделя,
                    Models.Enums.Периодичность.Месяц,
                    Models.Enums.Периодичность.Квартал,
                    Models.Enums.Периодичность.Год,
                    Models.Enums.Периодичность.Декада,
                    Models.Enums.Периодичность.Полугодие,
                });
            });
            modelBuilder.Entity<Models.Enums.ПериодОчисткиФайлов>(mb =>
            {
                mb.HasData(new Models.Enums.ПериодОчисткиФайлов[]
                {
                    Models.Enums.ПериодОчисткиФайлов.СтаршеМесяца,
                    Models.Enums.ПериодОчисткиФайлов.СтаршеШестиМесяцев,
                    Models.Enums.ПериодОчисткиФайлов.СтаршеГода,
                    Models.Enums.ПериодОчисткиФайлов.ПоПравилу,
                });
            });
            modelBuilder.Entity<Models.Enums.ПериодыВводаДанныхОВремени>(mb =>
            {
                mb.HasData(new Models.Enums.ПериодыВводаДанныхОВремени[]
                {
                    Models.Enums.ПериодыВводаДанныхОВремени.ТекущийМесяц,
                    Models.Enums.ПериодыВводаДанныхОВремени.ПерваяПоловинаТекущегоМесяца,
                    Models.Enums.ПериодыВводаДанныхОВремени.ВтораяПоловинаТекущегоМесяца,
                    Models.Enums.ПериодыВводаДанныхОВремени.ПрошлыйПериод,
                });
            });
            modelBuilder.Entity<Models.Enums.ПериодыРасчетаБазовыхНачислений>(mb =>
            {
                mb.HasData(new Models.Enums.ПериодыРасчетаБазовыхНачислений[]
                {
                    Models.Enums.ПериодыРасчетаБазовыхНачислений.ТекущийМесяц,
                    Models.Enums.ПериодыРасчетаБазовыхНачислений.ПредыдущийМесяц,
                    Models.Enums.ПериодыРасчетаБазовыхНачислений.ТекущийКвартал,
                    Models.Enums.ПериодыРасчетаБазовыхНачислений.ПредыдущийКвартал,
                    Models.Enums.ПериодыРасчетаБазовыхНачислений.ТекущийГод,
                    Models.Enums.ПериодыРасчетаБазовыхНачислений.ПредыдущийГод,
                    Models.Enums.ПериодыРасчетаБазовыхНачислений.НесколькоПредыдущихМесяцев,
                });
            });
            modelBuilder.Entity<Models.Enums.ПолФизическогоЛица>(mb =>
            {
                mb.HasData(new Models.Enums.ПолФизическогоЛица[]
                {
                    Models.Enums.ПолФизическогоЛица.Мужской,
                    Models.Enums.ПолФизическогоЛица.Женский,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорогиШкалыСтавокНалогов>(mb =>
            {
                mb.HasData(new Models.Enums.ПорогиШкалыСтавокНалогов[]
                {
                    Models.Enums.ПорогиШкалыСтавокНалогов.Порог1,
                    Models.Enums.ПорогиШкалыСтавокНалогов.Порог2,
                    Models.Enums.ПорогиШкалыСтавокНалогов.Порог3,
                    Models.Enums.ПорогиШкалыСтавокНалогов.Порог4,
                    Models.Enums.ПорогиШкалыСтавокНалогов.Порог5,
                    Models.Enums.ПорогиШкалыСтавокНалогов.Порог6,
                    Models.Enums.ПорогиШкалыСтавокНалогов.Порог7,
                    Models.Enums.ПорогиШкалыСтавокНалогов.Порог8,
                    Models.Enums.ПорогиШкалыСтавокНалогов.Порог9,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядкиОкругления>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядкиОкругления[]
                {
                    Models.Enums.ПорядкиОкругления.Окр0_01,
                    Models.Enums.ПорядкиОкругления.Окр0_05,
                    Models.Enums.ПорядкиОкругления.Окр0_1,
                    Models.Enums.ПорядкиОкругления.Окр0_5,
                    Models.Enums.ПорядкиОкругления.Окр1,
                    Models.Enums.ПорядкиОкругления.Окр5,
                    Models.Enums.ПорядкиОкругления.Окр10,
                    Models.Enums.ПорядкиОкругления.Окр50,
                    Models.Enums.ПорядкиОкругления.Окр100,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядкиОкругленияОтчетности>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядкиОкругленияОтчетности[]
                {
                    Models.Enums.ПорядкиОкругленияОтчетности.Окр1,
                    Models.Enums.ПорядкиОкругленияОтчетности.Окр1000,
                    Models.Enums.ПорядкиОкругленияОтчетности.Окр1000000,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядокЗаполненияНалогов>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядокЗаполненияНалогов[]
                {
                    Models.Enums.ПорядокЗаполненияНалогов.БезНалогов,
                    Models.Enums.ПорядокЗаполненияНалогов.НДФЛИВзносы,
                    Models.Enums.ПорядокЗаполненияНалогов.НДФЛ,
                    Models.Enums.ПорядокЗаполненияНалогов.Взносы,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка[]
                {
                    Models.Enums.ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка.ПоТрудовомуЗаконодательству,
                    Models.Enums.ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка.ПоКолдоговору,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг[]
                {
                    Models.Enums.ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг.ПоПлановымЦенам,
                    Models.Enums.ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг.ПоОбъемуВыпуска,
                    Models.Enums.ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг.ПоПлановымЦенамИОбъемуВыпуска,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядокРаспределенияРасходовНаОказаниеУслуг>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядокРаспределенияРасходовНаОказаниеУслуг[]
                {
                    Models.Enums.ПорядокРаспределенияРасходовНаОказаниеУслуг.ПоПлановымЦенам,
                    Models.Enums.ПорядокРаспределенияРасходовНаОказаниеУслуг.ПоВыручке,
                    Models.Enums.ПорядокРаспределенияРасходовНаОказаниеУслуг.ПоПлановымЦенамИВыручке,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядокРасчетаСреднегоЗаработкаОбщий>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядокРасчетаСреднегоЗаработкаОбщий[]
                {
                    Models.Enums.ПорядокРасчетаСреднегоЗаработкаОбщий.Постановление2010,
                    Models.Enums.ПорядокРасчетаСреднегоЗаработкаОбщий.Постановление100Отпускные,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядокРасчетаСреднегоЗаработкаФСС>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядокРасчетаСреднегоЗаработкаФСС[]
                {
                    Models.Enums.ПорядокРасчетаСреднегоЗаработкаФСС.Постановление2010,
                    Models.Enums.ПорядокРасчетаСреднегоЗаработкаФСС.Постановление2011,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда[]
                {
                    Models.Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда.ПоНормеВремениГрафикаСотрудника,
                    Models.Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда.ПоНормеВремениПроизводственногоКалендаря,
                    Models.Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда.ПоСреднегодовомуЗначению,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядокФормированияИндивидуальныхСведенийУчетаВремени>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядокФормированияИндивидуальныхСведенийУчетаВремени[]
                {
                    Models.Enums.ПорядокФормированияИндивидуальныхСведенийУчетаВремени.НеФормировать,
                    Models.Enums.ПорядокФормированияИндивидуальныхСведенийУчетаВремени.ФормироватьПоЗарегистрированнымВидамВремени,
                    Models.Enums.ПорядокФормированияИндивидуальныхСведенийУчетаВремени.ФормироватьПолностью,
                });
            });
            modelBuilder.Entity<Models.Enums.ПорядокФормированияСправкиОДоходахФизическогоЛица>(mb =>
            {
                mb.HasData(new Models.Enums.ПорядокФормированияСправкиОДоходахФизическогоЛица[]
                {
                    Models.Enums.ПорядокФормированияСправкиОДоходахФизическогоЛица.Сводно,
                    Models.Enums.ПорядокФормированияСправкиОДоходахФизическогоЛица.ВРазрезеКодовОКАТО,
                });
            });
            modelBuilder.Entity<Models.Enums.ПравилаОкругленияПриРасчетеЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.ПравилаОкругленияПриРасчетеЗарплаты[]
                {
                    Models.Enums.ПравилаОкругленияПриРасчетеЗарплаты.Авто,
                    Models.Enums.ПравилаОкругленияПриРасчетеЗарплаты.ВМеньшуюСторону,
                    Models.Enums.ПравилаОкругленияПриРасчетеЗарплаты.ВБольшуюСторону,
                });
            });
            modelBuilder.Entity<Models.Enums.ПредставлениеТарифовИНадбавок>(mb =>
            {
                mb.HasData(new Models.Enums.ПредставлениеТарифовИНадбавок[]
                {
                    Models.Enums.ПредставлениеТарифовИНадбавок.МесячныйРазмерВГривнах,
                    Models.Enums.ПредставлениеТарифовИНадбавок.ТарифыКоэффициенты,
                    Models.Enums.ПредставлениеТарифовИНадбавок.МесячныйРазмерВГривнахИТарифыКоэффициенты,
                });
            });
            modelBuilder.Entity<Models.Enums.ПриоритетыОбъектовОбмена>(mb =>
            {
                mb.HasData(new Models.Enums.ПриоритетыОбъектовОбмена[]
                {
                    Models.Enums.ПриоритетыОбъектовОбмена.ПриоритетОбъектаОбменаНиже,
                    Models.Enums.ПриоритетыОбъектовОбмена.ПриоритетОбъектаОбменаСовпадает,
                    Models.Enums.ПриоритетыОбъектовОбмена.ПриоритетОбъектаОбменаВыше,
                });
            });
            modelBuilder.Entity<Models.Enums.ПричиныИзмененияСостояния>(mb =>
            {
                mb.HasData(new Models.Enums.ПричиныИзмененияСостояния[]
                {
                    Models.Enums.ПричиныИзмененияСостояния.ПриемНаРаботу,
                    Models.Enums.ПричиныИзмененияСостояния.Перемещение,
                    Models.Enums.ПричиныИзмененияСостояния.Увольнение,
                });
            });
            modelBuilder.Entity<Models.Enums.ПричиныНетрудоспособности>(mb =>
            {
                mb.HasData(new Models.Enums.ПричиныНетрудоспособности[]
                {
                    Models.Enums.ПричиныНетрудоспособности.ОбщееЗаболевание,
                    Models.Enums.ПричиныНетрудоспособности.ПоБеременностиИРодам,
                    Models.Enums.ПричиныНетрудоспособности.ТравмаНаПроизводстве,
                    Models.Enums.ПричиныНетрудоспособности.Профзаболевание,
                    Models.Enums.ПричиныНетрудоспособности.ПоУходуЗаРебенком,
                    Models.Enums.ПричиныНетрудоспособности.ПоУходуЗаВзрослым,
                    Models.Enums.ПричиныНетрудоспособности.Карантин,
                    Models.Enums.ПричиныНетрудоспособности.Протезирование,
                    Models.Enums.ПричиныНетрудоспособности.ПособиеПриДолечивании,
                    Models.Enums.ПричиныНетрудоспособности.ЗаболеваниеЧернобыльцев,
                    Models.Enums.ПричиныНетрудоспособности.НепроизводственныеТравмы,
                    Models.Enums.ПричиныНетрудоспособности.СанаторноКурортноеЛечение,
                    Models.Enums.ПричиныНетрудоспособности.COVID_19,
                });
            });
            modelBuilder.Entity<Models.Enums.ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса>(mb =>
            {
                mb.HasData(new Models.Enums.ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса[]
                {
                    Models.Enums.ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса.БлокировкаАдминистраторомСервиса,
                    Models.Enums.ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса.БлокировкаВладельцем,
                    Models.Enums.ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса.ОбновлениеВерсииКонфигурации,
                });
            });
            modelBuilder.Entity<Models.Enums.ПричиныОтключенияРасширенийВМоделиСервиса>(mb =>
            {
                mb.HasData(new Models.Enums.ПричиныОтключенияРасширенийВМоделиСервиса[]
                {
                    Models.Enums.ПричиныОтключенияРасширенийВМоделиСервиса.БлокировкаАдминистраторомСервиса,
                    Models.Enums.ПричиныОтключенияРасширенийВМоделиСервиса.БлокировкаВладельцем,
                    Models.Enums.ПричиныОтключенияРасширенийВМоделиСервиса.ОбновлениеВерсииКонфигурации,
                });
            });
            modelBuilder.Entity<Models.Enums.ПричиныСовмещения>(mb =>
            {
                mb.HasData(new Models.Enums.ПричиныСовмещения[]
                {
                    Models.Enums.ПричиныСовмещения.СовмещениеПрофессийДолжностей,
                    Models.Enums.ПричиныСовмещения.УвеличениеОбъемаРабот,
                    Models.Enums.ПричиныСовмещения.ИсполнениеОбязанностей,
                });
            });
            modelBuilder.Entity<Models.Enums.ПрофилиОфицеров>(mb =>
            {
                mb.HasData(new Models.Enums.ПрофилиОфицеров[]
                {
                    Models.Enums.ПрофилиОфицеров.Командный,
                    Models.Enums.ПрофилиОфицеров.Инженерный,
                    Models.Enums.ПрофилиОфицеров.Технический,
                    Models.Enums.ПрофилиОфицеров.Юридический,
                    Models.Enums.ПрофилиОфицеров.Медицинский,
                    Models.Enums.ПрофилиОфицеров.Ветеринарный,
                    Models.Enums.ПрофилиОфицеров.Оперативный,
                    Models.Enums.ПрофилиОфицеров.Административный,
                    Models.Enums.ПрофилиОфицеров.ОперативноТехнический,
                });
            });
            modelBuilder.Entity<Models.Enums.РазделыМонитораРуководителя>(mb =>
            {
                mb.HasData(new Models.Enums.РазделыМонитораРуководителя[]
                {
                    Models.Enums.РазделыМонитораРуководителя.ОстаткиДенежныхСредств,
                    Models.Enums.РазделыМонитораРуководителя.ДвижениеДенежныхСредств,
                    Models.Enums.РазделыМонитораРуководителя.ПродажиПоКонтрагентам,
                    Models.Enums.РазделыМонитораРуководителя.ПродажиПоНоменклатурнымГруппам,
                    Models.Enums.РазделыМонитораРуководителя.ЗадолженностьПокупателей,
                    Models.Enums.РазделыМонитораРуководителя.ПросроченнаяЗадолженностьПокупателей,
                    Models.Enums.РазделыМонитораРуководителя.ЗадолженностьПоставщикам,
                    Models.Enums.РазделыМонитораРуководителя.ПросроченнаяЗадолженностьПоставщикам,
                });
            });
            modelBuilder.Entity<Models.Enums.РазделыОтчетовПоЗарплате>(mb =>
            {
                mb.HasData(new Models.Enums.РазделыОтчетовПоЗарплате[]
                {
                    Models.Enums.РазделыОтчетовПоЗарплате.Начисления,
                    Models.Enums.РазделыОтчетовПоЗарплате.Удержания,
                    Models.Enums.РазделыОтчетовПоЗарплате.Выплаты,
                    Models.Enums.РазделыОтчетовПоЗарплате.ДоходыВНеденежнойФорме,
                    Models.Enums.РазделыОтчетовПоЗарплате.ПогашениеЗадолженности,
                });
            });
            modelBuilder.Entity<Models.Enums.РазделыУчета>(mb =>
            {
                mb.HasData(new Models.Enums.РазделыУчета[]
                {
                    Models.Enums.РазделыУчета.ОценкаМПЗ,
                    Models.Enums.РазделыУчета.РасчетыСКонтрагентами,
                });
            });
            modelBuilder.Entity<Models.Enums.РазделыУчетаДляВводаОстатков>(mb =>
            {
                mb.HasData(new Models.Enums.РазделыУчетаДляВводаОстатков[]
                {
                    Models.Enums.РазделыУчетаДляВводаОстатков.ОсновныеСредства,
                    Models.Enums.РазделыУчетаДляВводаОстатков.МалоценныеАктивыВЭксплуатации,
                    Models.Enums.РазделыУчетаДляВводаОстатков.НематериальныеАктивы,
                    Models.Enums.РазделыУчетаДляВводаОстатков.КапитальныеИнвестиции,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ЗапасыСебестоимость,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ЗапасыПереданные,
                    Models.Enums.РазделыУчетаДляВводаОстатков.НезавершенноеПроизводство,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ТоварыПоПродажнойЦене,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ДенежныеСредства,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ВзаиморасчетыСКонтрагентами,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ВзаиморасчетыСПодотчетнымиЛицами,
                    Models.Enums.РазделыУчетаДляВводаОстатков.РасходыБудущихПериодов,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ЗарплатаИОтчисления,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ТоварыНаКомиссии,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ПрочиеСчетаБухгалтерскогоУчета,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ОтсроченныеНалоговыеАктивыИОбязательства,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ДанныеНалоговогоУчета,
                    Models.Enums.РазделыУчетаДляВводаОстатков.ГруппыОСНалоговыйУчет,
                });
            });
            modelBuilder.Entity<Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011>(mb =>
            {
                mb.HasData(new Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011[]
                {
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.ОсновныеСредства,
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.МалоценныеАктивыВЭксплуатации,
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.НематериальныеАктивы,
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.КапитальныеИнвестиции,
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.ЗапасыСебестоимость,
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах,
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.ЗапасыПереданные,
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.НезавершенноеПроизводство,
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.ТоварыПоПродажнойЦене,
                    Models.Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011.РасходыБудущихПериодов,
                });
            });
            modelBuilder.Entity<Models.Enums.РазмерыБумаги>(mb =>
            {
                mb.HasData(new Models.Enums.РазмерыБумаги[]
                {
                    Models.Enums.РазмерыБумаги.НеЗадано,
                    Models.Enums.РазмерыБумаги.A3,
                    Models.Enums.РазмерыБумаги.A4,
                    Models.Enums.РазмерыБумаги.A5,
                    Models.Enums.РазмерыБумаги.B4,
                    Models.Enums.РазмерыБумаги.B5,
                    Models.Enums.РазмерыБумаги.B6,
                    Models.Enums.РазмерыБумаги.C4,
                    Models.Enums.РазмерыБумаги.C5,
                    Models.Enums.РазмерыБумаги.C6,
                    Models.Enums.РазмерыБумаги.USExecutive,
                    Models.Enums.РазмерыБумаги.USLegal,
                    Models.Enums.РазмерыБумаги.USLetter,
                });
            });
            modelBuilder.Entity<Models.Enums.РазрешенияСканированногоИзображения>(mb =>
            {
                mb.HasData(new Models.Enums.РазрешенияСканированногоИзображения[]
                {
                    Models.Enums.РазрешенияСканированногоИзображения.dpi200,
                    Models.Enums.РазрешенияСканированногоИзображения.dpi300,
                    Models.Enums.РазрешенияСканированногоИзображения.dpi600,
                    Models.Enums.РазрешенияСканированногоИзображения.dpi1200,
                });
            });
            modelBuilder.Entity<Models.Enums.РасчетыВозврат>(mb =>
            {
                mb.HasData(new Models.Enums.РасчетыВозврат[]
                {
                    Models.Enums.РасчетыВозврат.Расчеты,
                    Models.Enums.РасчетыВозврат.Возврат,
                });
            });
            modelBuilder.Entity<Models.Enums.РежимНачисленияЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.РежимНачисленияЗарплаты[]
                {
                    Models.Enums.РежимНачисленияЗарплаты.ОкончательныйРасчет,
                    Models.Enums.РежимНачисленияЗарплаты.РасчетПервойПоловиныМесяца,
                });
            });
            modelBuilder.Entity<Models.Enums.РежимОтбораДокументов>(mb =>
            {
                mb.HasData(new Models.Enums.РежимОтбораДокументов[]
                {
                    Models.Enums.РежимОтбораДокументов.ПоРеквизитам,
                    Models.Enums.РежимОтбораДокументов.ПоОборотам,
                    Models.Enums.РежимОтбораДокументов.ПоОстаткам,
                });
            });
            modelBuilder.Entity<Models.Enums.РежимыВыбораПартий>(mb =>
            {
                mb.HasData(new Models.Enums.РежимыВыбораПартий[]
                {
                    Models.Enums.РежимыВыбораПартий.ВыборИзПолногоСпискаПартий,
                    Models.Enums.РежимыВыбораПартий.ВыборИзПартийПоНоменклатуре,
                    Models.Enums.РежимыВыбораПартий.ВыборИзПартийИмеющихОстатки,
                });
            });
            modelBuilder.Entity<Models.Enums.РежимыВыгрузкиОбъектовОбмена>(mb =>
            {
                mb.HasData(new Models.Enums.РежимыВыгрузкиОбъектовОбмена[]
                {
                    Models.Enums.РежимыВыгрузкиОбъектовОбмена.ВыгружатьВсегда,
                    Models.Enums.РежимыВыгрузкиОбъектовОбмена.ВыгружатьПоУсловию,
                    Models.Enums.РежимыВыгрузкиОбъектовОбмена.ВыгружатьПриНеобходимости,
                    Models.Enums.РежимыВыгрузкиОбъектовОбмена.ВыгружатьВручную,
                    Models.Enums.РежимыВыгрузкиОбъектовОбмена.НеВыгружать,
                });
            });
            modelBuilder.Entity<Models.Enums.РежимыЗавершенияРаботыПользователей>(mb =>
            {
                mb.HasData(new Models.Enums.РежимыЗавершенияРаботыПользователей[]
                {
                    Models.Enums.РежимыЗавершенияРаботыПользователей.РазрешитьРаботу,
                    Models.Enums.РежимыЗавершенияРаботыПользователей.ПредупредитьПользователейОЗавершенииРаботы,
                    Models.Enums.РежимыЗавершенияРаботыПользователей.ЗавершитьССохранениемДанныхПользователей,
                    Models.Enums.РежимыЗавершенияРаботыПользователей.ПрекратитьРаботуБезусловно,
                });
            });
            modelBuilder.Entity<Models.Enums.РежимыИспользованияИнформационнойБазы>(mb =>
            {
                mb.HasData(new Models.Enums.РежимыИспользованияИнформационнойБазы[]
                {
                    Models.Enums.РежимыИспользованияИнформационнойБазы.Рабочий,
                    Models.Enums.РежимыИспользованияИнформационнойБазы.Демонстрационный,
                });
            });
            modelBuilder.Entity<Models.Enums.РежимыРаботыФормыСотрудника>(mb =>
            {
                mb.HasData(new Models.Enums.РежимыРаботыФормыСотрудника[]
                {
                    Models.Enums.РежимыРаботыФормыСотрудника.Сотрудник,
                    Models.Enums.РежимыРаботыФормыСотрудника.СотрудникОформленныйПоДоговоруГПХ,
                    Models.Enums.РежимыРаботыФормыСотрудника.СотрудникОформленныйПоТрудовомуДоговору,
                    Models.Enums.РежимыРаботыФормыСотрудника.СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ,
                    Models.Enums.РежимыРаботыФормыСотрудника.ФизическоеЛицо,
                });
            });
            modelBuilder.Entity<Models.Enums.РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок>(mb =>
            {
                mb.HasData(new Models.Enums.РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок[]
                {
                    Models.Enums.РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок.Версия_2_1_3,
                    Models.Enums.РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок.Версия_2_2_2,
                });
            });
            modelBuilder.Entity<Models.Enums.РежимыФормированияПечатныхФорм>(mb =>
            {
                mb.HasData(new Models.Enums.РежимыФормированияПечатныхФорм[]
                {
                    Models.Enums.РежимыФормированияПечатныхФорм.НаЯзыкеИнформационнойБазы,
                    Models.Enums.РежимыФормированияПечатныхФорм.НаЯзыкеИнтерфейсаПользователя,
                    Models.Enums.РежимыФормированияПечатныхФорм.НаРусскомЯзыке,
                    Models.Enums.РежимыФормированияПечатныхФорм.НаУкраинскомЯзыке,
                });
            });
            modelBuilder.Entity<Models.Enums.РезультатыВыполненияОбмена>(mb =>
            {
                mb.HasData(new Models.Enums.РезультатыВыполненияОбмена[]
                {
                    Models.Enums.РезультатыВыполненияОбмена.Выполнено,
                    Models.Enums.РезультатыВыполненияОбмена.Отменено,
                    Models.Enums.РезультатыВыполненияОбмена.Ошибка,
                    Models.Enums.РезультатыВыполненияОбмена.Ошибка_ТранспортСообщения,
                    Models.Enums.РезультатыВыполненияОбмена.Предупреждение_СообщениеОбменаБылоРанееПринято,
                    Models.Enums.РезультатыВыполненияОбмена.ВыполненоСПредупреждениями,
                });
            });
            modelBuilder.Entity<Models.Enums.РезультатыЗачисленияЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.РезультатыЗачисленияЗарплаты[]
                {
                    Models.Enums.РезультатыЗачисленияЗарплаты.Зачислено,
                    Models.Enums.РезультатыЗачисленияЗарплаты.ОшибкаФИО,
                    Models.Enums.РезультатыЗачисленияЗарплаты.СчетЗакрыт,
                    Models.Enums.РезультатыЗачисленияЗарплаты.СчетОтсутствует,
                    Models.Enums.РезультатыЗачисленияЗарплаты.НеЗачислено,
                });
            });
            modelBuilder.Entity<Models.Enums.РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса>(mb =>
            {
                mb.HasData(new Models.Enums.РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса[]
                {
                    Models.Enums.РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса.ЗапросОдобрен,
                    Models.Enums.РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса.ЗапросОтклонен,
                });
            });
            modelBuilder.Entity<Models.Enums.РезультатыОткрытияЛицевыхСчетовСотрудников>(mb =>
            {
                mb.HasData(new Models.Enums.РезультатыОткрытияЛицевыхСчетовСотрудников[]
                {
                    Models.Enums.РезультатыОткрытияЛицевыхСчетовСотрудников.СчетОткрыт,
                    Models.Enums.РезультатыОткрытияЛицевыхСчетовСотрудников.ОшибкаЗаполненияДанных,
                    Models.Enums.РезультатыОткрытияЛицевыхСчетовСотрудников.СчетНеОткрыт,
                });
            });
            modelBuilder.Entity<Models.Enums.РолиСотрудников>(mb =>
            {
                mb.HasData(new Models.Enums.РолиСотрудников[]
                {
                    Models.Enums.РолиСотрудников.Работник,
                    Models.Enums.РолиСотрудников.Договорник,
                });
            });
            modelBuilder.Entity<Models.Enums.РолиФизическихЛиц>(mb =>
            {
                mb.HasData(new Models.Enums.РолиФизическихЛиц[]
                {
                    Models.Enums.РолиФизическихЛиц.Сотрудник,
                    Models.Enums.РолиФизическихЛиц.БывшийСотрудник,
                    Models.Enums.РолиФизическихЛиц.Акционер,
                    Models.Enums.РолиФизическихЛиц.ПрочийПолучательДоходов,
                    Models.Enums.РолиФизическихЛиц.РаздатчикЗарплаты,
                    Models.Enums.РолиФизическихЛиц.Кандидат,
                });
            });
            modelBuilder.Entity<Models.Enums.СлучаиУходаЗаБольнымиДетьми>(mb =>
            {
                mb.HasData(new Models.Enums.СлучаиУходаЗаБольнымиДетьми[]
                {
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетАмбулаторно,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетВСтационаре,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетАмбулаторно,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетВСтационаре,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуЗаРебенкомИнвалидомАмбулаторно,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуЗаРебенкомИнвалидомВСтационаре,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре,
                    Models.Enums.СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетПриВИЧ,
                });
            });
            modelBuilder.Entity<Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПриобретений>(mb =>
            {
                mb.HasData(new Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПриобретений[]
                {
                    Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПриобретений.Поступление,
                    Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПриобретений.Возврат,
                });
            });
            modelBuilder.Entity<Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж>(mb =>
            {
                mb.HasData(new Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж[]
                {
                    Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж.Реализация,
                    Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж.Возврат,
                    Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж.РеализацияРозница,
                    Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж.ВозвратРозница,
                    Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж.УсловнаяПродажа,
                    Models.Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж.УсловнаяПродажаВозврат,
                });
            });
            modelBuilder.Entity<Models.Enums.СобытияПриобретенияНалоговыйУчет>(mb =>
            {
                mb.HasData(new Models.Enums.СобытияПриобретенияНалоговыйУчет[]
                {
                    Models.Enums.СобытияПриобретенияНалоговыйУчет.ОплатаПоставщику,
                    Models.Enums.СобытияПриобретенияНалоговыйУчет.ВозвратОплатыПоставщиком,
                    Models.Enums.СобытияПриобретенияНалоговыйУчет.ПоступлениеОтПоставщика,
                    Models.Enums.СобытияПриобретенияНалоговыйУчет.ВозвратПоставщику,
                });
            });
            modelBuilder.Entity<Models.Enums.СобытияПродажиНалоговыйУчет>(mb =>
            {
                mb.HasData(new Models.Enums.СобытияПродажиНалоговыйУчет[]
                {
                    Models.Enums.СобытияПродажиНалоговыйУчет.ОплатаПокупателем,
                    Models.Enums.СобытияПродажиНалоговыйУчет.ВозвратОплатыПокупателю,
                    Models.Enums.СобытияПродажиНалоговыйУчет.РеализацияПокупателю,
                    Models.Enums.СобытияПродажиНалоговыйУчет.ВозвратОтПокупателя,
                });
            });
            modelBuilder.Entity<Models.Enums.СообщенияДляРегОтчетов>(mb =>
            {
                mb.HasData(new Models.Enums.СообщенияДляРегОтчетов[]
                {
                    Models.Enums.СообщенияДляРегОтчетов.СдачаОтчета,
                    Models.Enums.СообщенияДляРегОтчетов.УплатаНалога,
                });
            });
            modelBuilder.Entity<Models.Enums.СостояниеЗачисленияЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.СостояниеЗачисленияЗарплаты[]
                {
                    Models.Enums.СостояниеЗачисленияЗарплаты.ОжидаетПодтверждения,
                    Models.Enums.СостояниеЗачисленияЗарплаты.ГотовКВыгрузке,
                    Models.Enums.СостояниеЗачисленияЗарплаты.ЗачисленоПолностью,
                    Models.Enums.СостояниеЗачисленияЗарплаты.ЗачисленоСОшибками,
                    Models.Enums.СостояниеЗачисленияЗарплаты.НеЗачислено,
                });
            });
            modelBuilder.Entity<Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника>(mb =>
            {
                mb.HasData(new Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника[]
                {
                    Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника.ЗаявкаНеЗаполнена,
                    Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника.ОжидаетПодтверждения,
                    Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника.ГотовКВыгрузке,
                    Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника.ОтложеноОткрытиеЛицевогоСчета,
                    Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника.ЛицевойСчетНеОткрыт,
                    Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника.ЛицевыеСчетаОткрыты,
                    Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника.ЛицевыеСчетаОткрытыСОшибками,
                    Models.Enums.СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника.ЛицевыеСчетаНеОткрыты,
                });
            });
            modelBuilder.Entity<Models.Enums.СостоянияЗаданий>(mb =>
            {
                mb.HasData(new Models.Enums.СостоянияЗаданий[]
                {
                    Models.Enums.СостоянияЗаданий.Запланировано,
                    Models.Enums.СостоянияЗаданий.Выполняется,
                    Models.Enums.СостоянияЗаданий.Завершено,
                    Models.Enums.СостоянияЗаданий.НеЗапланировано,
                    Models.Enums.СостоянияЗаданий.ОшибкаВыполнения,
                    Models.Enums.СостоянияЗаданий.НеАктивно,
                    Models.Enums.СостоянияЗаданий.ОбработкаОшибкиПриАварийномЗавершении,
                });
            });
            modelBuilder.Entity<Models.Enums.СостоянияЗапросовНаИспользованиеВнешнихРесурсов>(mb =>
            {
                mb.HasData(new Models.Enums.СостоянияЗапросовНаИспользованиеВнешнихРесурсов[]
                {
                    Models.Enums.СостоянияЗапросовНаИспользованиеВнешнихРесурсов.Новый,
                    Models.Enums.СостоянияЗапросовНаИспользованиеВнешнихРесурсов.Применен,
                    Models.Enums.СостоянияЗапросовНаИспользованиеВнешнихРесурсов.Проверен,
                });
            });
            modelBuilder.Entity<Models.Enums.СостоянияИнтеграцииОбъектов>(mb =>
            {
                mb.HasData(new Models.Enums.СостоянияИнтеграцииОбъектов[]
                {
                    Models.Enums.СостоянияИнтеграцииОбъектов.Ожидание,
                    Models.Enums.СостоянияИнтеграцииОбъектов.Интегрирован,
                    Models.Enums.СостоянияИнтеграцииОбъектов.Ошибка,
                });
            });
            modelBuilder.Entity<Models.Enums.СостоянияМиграцииПриложения>(mb =>
            {
                mb.HasData(new Models.Enums.СостоянияМиграцииПриложения[]
                {
                    Models.Enums.СостоянияМиграцииПриложения.Выполняется,
                    Models.Enums.СостоянияМиграцииПриложения.ЗавершенаСОшибкой,
                    Models.Enums.СостоянияМиграцииПриложения.ЗавершенаУспешно,
                    Models.Enums.СостоянияМиграцииПриложения.ОжиданиеЗагрузки,
                    Models.Enums.СостоянияМиграцииПриложения.ОжиданиеОбновления,
                });
            });
            modelBuilder.Entity<Models.Enums.СостоянияОС>(mb =>
            {
                mb.HasData(new Models.Enums.СостоянияОС[]
                {
                    Models.Enums.СостоянияОС.ВведеноВЭксплуатацию,
                    Models.Enums.СостоянияОС.СнятоСУчета,
                });
            });
            modelBuilder.Entity<Models.Enums.СостоянияПодключенияСервисов>(mb =>
            {
                mb.HasData(new Models.Enums.СостоянияПодключенияСервисов[]
                {
                    Models.Enums.СостоянияПодключенияСервисов.НеПодключен,
                    Models.Enums.СостоянияПодключенияСервисов.ОшибкаПодключения,
                    Models.Enums.СостоянияПодключенияСервисов.Подключен,
                    Models.Enums.СостоянияПодключенияСервисов.Подключение,
                    Models.Enums.СостоянияПодключенияСервисов.ПодключениеНедоступно,
                });
            });
            modelBuilder.Entity<Models.Enums.СостоянияПроведенияВПоследовательности>(mb =>
            {
                mb.HasData(new Models.Enums.СостоянияПроведенияВПоследовательности[]
                {
                    Models.Enums.СостоянияПроведенияВПоследовательности.ПроведенВПоследовательности,
                    Models.Enums.СостоянияПроведенияВПоследовательности.ПроведенСНарушениемПоследовательности,
                    Models.Enums.СостоянияПроведенияВПоследовательности.ИсключенИзПоследовательности,
                });
            });
            modelBuilder.Entity<Models.Enums.СостоянияСогласования>(mb =>
            {
                mb.HasData(new Models.Enums.СостоянияСогласования[]
                {
                    Models.Enums.СостоянияСогласования.Отклонено,
                    Models.Enums.СостоянияСогласования.Рассматривается,
                    Models.Enums.СостоянияСогласования.Согласовано,
                });
            });
            modelBuilder.Entity<Models.Enums.СостоянияСотрудника>(mb =>
            {
                mb.HasData(new Models.Enums.СостоянияСотрудника[]
                {
                    Models.Enums.СостоянияСотрудника.Работа,
                    Models.Enums.СостоянияСотрудника.РаботаВОтпускеПоУходуЗаРебенком,
                    Models.Enums.СостоянияСотрудника.Прогул,
                    Models.Enums.СостоянияСотрудника.ВынужденныйПрогул,
                    Models.Enums.СостоянияСотрудника.ПростойПоВинеРаботника,
                    Models.Enums.СостоянияСотрудника.ПростойПоВинеРаботодателя,
                    Models.Enums.СостоянияСотрудника.ПростойНеЗависящийОтРаботодателяИРаботника,
                    Models.Enums.СостоянияСотрудника.ОтпускОсновной,
                    Models.Enums.СостоянияСотрудника.ДополнительныйОтпуск,
                    Models.Enums.СостоянияСотрудника.ДополнительныйОтпускНеоплачиваемый,
                    Models.Enums.СостоянияСотрудника.ОтпускУчебныйОплачиваемый,
                    Models.Enums.СостоянияСотрудника.ОтпускУчебныйНеоплачиваемый,
                    Models.Enums.СостоянияСотрудника.ОтпускНеоплачиваемыйПоРазрешениюРаботодателя,
                    Models.Enums.СостоянияСотрудника.ОтпускНеоплачиваемыйПоЗаконодательству,
                    Models.Enums.СостоянияСотрудника.ОтпускПоУходуЗаРебенком,
                    Models.Enums.СостоянияСотрудника.Командировка,
                    Models.Enums.СостоянияСотрудника.ОтсутствиеССохранениемОплаты,
                    Models.Enums.СостоянияСотрудника.ВыполнениеГосударственныхОбязанностей,
                    Models.Enums.СостоянияСотрудника.ДополнительныеВыходныеДниОплачиваемые,
                    Models.Enums.СостоянияСотрудника.ДополнительныеВыходныеДниНеОплачиваемые,
                    Models.Enums.СостоянияСотрудника.ОтсутствиеПоНевыясненнымПричинам,
                    Models.Enums.СостоянияСотрудника.ОтпускПоБеременностиИРодам,
                    Models.Enums.СостоянияСотрудника.ОтпускНаСанаторноКурортноеЛечение,
                    Models.Enums.СостоянияСотрудника.Болезнь,
                    Models.Enums.СостоянияСотрудника.БолезньБезОплаты,
                    Models.Enums.СостоянияСотрудника.Факт,
                    Models.Enums.СостоянияСотрудника.Увольнение,
                    Models.Enums.СостоянияСотрудника.ОтпускПоУходуЗаРебенком6лет,
                });
            });
            modelBuilder.Entity<Models.Enums.СоциальныеГруппыНаселения>(mb =>
            {
                mb.HasData(new Models.Enums.СоциальныеГруппыНаселения[]
                {
                    Models.Enums.СоциальныеГруппыНаселения.ДетиДо6,
                    Models.Enums.СоциальныеГруппыНаселения.ДетиДо18,
                    Models.Enums.СоциальныеГруппыНаселения.Трудоспособные,
                    Models.Enums.СоциальныеГруппыНаселения.НеТрудоспособные,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыPOP3Аутентификации>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыPOP3Аутентификации[]
                {
                    Models.Enums.СпособыPOP3Аутентификации.APOP,
                    Models.Enums.СпособыPOP3Аутентификации.CramMD5,
                    Models.Enums.СпособыPOP3Аутентификации.Обычная,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыSMTPАутентификации>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыSMTPАутентификации[]
                {
                    Models.Enums.СпособыSMTPАутентификации.CramMD5,
                    Models.Enums.СпособыSMTPАутентификации.Login,
                    Models.Enums.СпособыSMTPАутентификации.Plain,
                    Models.Enums.СпособыSMTPАутентификации.БезАутентификации,
                    Models.Enums.СпособыSMTPАутентификации.ПоУмолчанию,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыАутентификации>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыАутентификации[]
                {
                    Models.Enums.СпособыАутентификации.Анонимный,
                    Models.Enums.СпособыАутентификации.ОбычнаяПроверка,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыВводаЗначенийПоказателейРасчетаЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыВводаЗначенийПоказателейРасчетаЗарплаты[]
                {
                    Models.Enums.СпособыВводаЗначенийПоказателейРасчетаЗарплаты.ВводитсяЕдиновременно,
                    Models.Enums.СпособыВводаЗначенийПоказателейРасчетаЗарплаты.НакапливаетсяПоОтдельнымЗначениям,
                    Models.Enums.СпособыВводаЗначенийПоказателейРасчетаЗарплаты.ВводитсяПриРасчете,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыВызоваДополнительныхОбработок>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыВызоваДополнительныхОбработок[]
                {
                    Models.Enums.СпособыВызоваДополнительныхОбработок.ВызовКлиентскогоМетода,
                    Models.Enums.СпособыВызоваДополнительныхОбработок.ВызовСерверногоМетода,
                    Models.Enums.СпособыВызоваДополнительныхОбработок.ЗаполнениеФормы,
                    Models.Enums.СпособыВызоваДополнительныхОбработок.ОткрытиеФормы,
                    Models.Enums.СпособыВызоваДополнительныхОбработок.СценарийВБезопасномРежиме,
                    Models.Enums.СпособыВызоваДополнительныхОбработок.ЗагрузкаДанныхИзФайла,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыВыполненияНачислений>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыВыполненияНачислений[]
                {
                    Models.Enums.СпособыВыполненияНачислений.ЕжемесячноПриОкончательномРасчете,
                    Models.Enums.СпособыВыполненияНачислений.ПоОтдельномуДокументуДоОкончательногоРасчета,
                    Models.Enums.СпособыВыполненияНачислений.ВЗаданныхМесяцахПриОкончательномРасчете,
                    Models.Enums.СпособыВыполненияНачислений.ПоЗначениюПоказателяПриОкончательномРасчете,
                    Models.Enums.СпособыВыполненияНачислений.ПоЗначениюВидаВремениПриОкончательномРасчете,
                    Models.Enums.СпособыВыполненияНачислений.ЗаПраздничныеДниПриОкончательномРасчете,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыВыполненияУдержаний>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыВыполненияУдержаний[]
                {
                    Models.Enums.СпособыВыполненияУдержаний.ЕжемесячноПриОкончательномРасчете,
                    Models.Enums.СпособыВыполненияУдержаний.ПоОтдельномуДокументуДоОкончательногоРасчета,
                    Models.Enums.СпособыВыполненияУдержаний.ПоЗначениюПоказателяПриОкончательномРасчете,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыДоставкиКорреспонденцииБанка>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыДоставкиКорреспонденцииБанка[]
                {
                    Models.Enums.СпособыДоставкиКорреспонденцииБанка.НеРассылать,
                    Models.Enums.СпособыДоставкиКорреспонденцииБанка.Email,
                    Models.Enums.СпособыДоставкиКорреспонденцииБанка.Почтой,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыЗаполненияГрафикаРаботы>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыЗаполненияГрафикаРаботы[]
                {
                    Models.Enums.СпособыЗаполненияГрафикаРаботы.ПоНеделям,
                    Models.Enums.СпособыЗаполненияГрафикаРаботы.ПоЦикламПроизвольнойДлины,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыЗаполненияЦен>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыЗаполненияЦен[]
                {
                    Models.Enums.СпособыЗаполненияЦен.ПоЦенамНоменклатуры,
                    Models.Enums.СпособыЗаполненияЦен.ПоЦенамНоменклатурыКонтрагентов,
                    Models.Enums.СпособыЗаполненияЦен.ПоНоменклатуреИЦенамКонтрагентов,
                    Models.Enums.СпособыЗаполненияЦен.ПоРозничнымЦенам,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыКомпенсацииПереработки>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыКомпенсацииПереработки[]
                {
                    Models.Enums.СпособыКомпенсацииПереработки.ПовышеннаяОплата,
                    Models.Enums.СпособыКомпенсацииПереработки.Отгул,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыНачисленияАмортизацииНМА>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыНачисленияАмортизацииНМА[]
                {
                    Models.Enums.СпособыНачисленияАмортизацииНМА.Прямолинейный,
                    Models.Enums.СпособыНачисленияАмортизацииНМА.УменьшенияОстатка,
                    Models.Enums.СпособыНачисленияАмортизацииНМА.Производственный,
                    Models.Enums.СпособыНачисленияАмортизацииНМА.Кумулятивный,
                    Models.Enums.СпособыНачисленияАмортизацииНМА.УскоренногоУменьшенияОстатка,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыНачисленияАмортизацииОС>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыНачисленияАмортизацииОС[]
                {
                    Models.Enums.СпособыНачисленияАмортизацииОС.Прямолинейный,
                    Models.Enums.СпособыНачисленияАмортизацииОС.Налоговый,
                    Models.Enums.СпособыНачисленияАмортизацииОС.УменьшенияОстатка,
                    Models.Enums.СпособыНачисленияАмортизацииОС.Кумулятивный,
                    Models.Enums.СпособыНачисленияАмортизацииОС.Производственный,
                    Models.Enums.СпособыНачисленияАмортизацииОС.УскоренногоУменьшенияОстатка,
                    Models.Enums.СпособыНачисленияАмортизацииОС._100,
                    Models.Enums.СпособыНачисленияАмортизацииОС._50_50,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыОплатыПоДоговоруГПХ>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыОплатыПоДоговоруГПХ[]
                {
                    Models.Enums.СпособыОплатыПоДоговоруГПХ.ОднократноВКонцеСрока,
                    Models.Enums.СпособыОплатыПоДоговоруГПХ.ПоАктамВыполненныхРабот,
                    Models.Enums.СпособыОплатыПоДоговоруГПХ.ВКонцеСрокаСАвансовымиПлатежами,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыОпределенияНормыСуммированногоУчета>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыОпределенияНормыСуммированногоУчета[]
                {
                    Models.Enums.СпособыОпределенияНормыСуммированногоУчета.ПоПроизводственномуКалендарю,
                    Models.Enums.СпособыОпределенияНормыСуммированногоУчета.ПоДаннымЭтогоГрафика,
                    Models.Enums.СпособыОпределенияНормыСуммированногоУчета.ПоДаннымДругогоГрафика,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыОткрытияФайлаНаПросмотр>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыОткрытияФайлаНаПросмотр[]
                {
                    Models.Enums.СпособыОткрытияФайлаНаПросмотр.СтандартнымПриложением,
                    Models.Enums.СпособыОткрытияФайлаНаПросмотр.ВоВстроенномРедакторе,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыОценки>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыОценки[]
                {
                    Models.Enums.СпособыОценки.ПоСредней,
                    Models.Enums.СпособыОценки.ФИФО,
                    Models.Enums.СпособыОценки.ЛИФО,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыОценкиСтоимостиВстречногоВыпуска>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыОценкиСтоимостиВстречногоВыпуска[]
                {
                    Models.Enums.СпособыОценкиСтоимостиВстречногоВыпуска.ПоРасчетнойСтоимости,
                    Models.Enums.СпособыОценкиСтоимостиВстречногоВыпуска.НеРассчитывается,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыОценкиТоваровВРознице>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыОценкиТоваровВРознице[]
                {
                    Models.Enums.СпособыОценкиТоваровВРознице.ПоСтоимостиПриобретения,
                    Models.Enums.СпособыОценкиТоваровВРознице.ПоПродажнойСтоимости,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыПоворотаИзображения>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыПоворотаИзображения[]
                {
                    Models.Enums.СпособыПоворотаИзображения.НетПоворота,
                    Models.Enums.СпособыПоворотаИзображения.ВправоНа90,
                    Models.Enums.СпособыПоворотаИзображения.ВправоНа180,
                    Models.Enums.СпособыПоворотаИзображения.ВлевоНа90,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыПогашенияЗаймаСотруднику>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыПогашенияЗаймаСотруднику[]
                {
                    Models.Enums.СпособыПогашенияЗаймаСотруднику.ВТечениеСрока,
                    Models.Enums.СпособыПогашенияЗаймаСотруднику.ПоОкончанииСрока,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыПредоставленияЗаймаСотруднику>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыПредоставленияЗаймаСотруднику[]
                {
                    Models.Enums.СпособыПредоставленияЗаймаСотруднику.Единовременно,
                    Models.Enums.СпособыПредоставленияЗаймаСотруднику.Траншами,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыПримененияЗначенийПоказателейРасчетаЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыПримененияЗначенийПоказателейРасчетаЗарплаты[]
                {
                    Models.Enums.СпособыПримененияЗначенийПоказателейРасчетаЗарплаты.Постоянное,
                    Models.Enums.СпособыПримененияЗначенийПоказателейРасчетаЗарплаты.Разовое,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыПримененияЛьготРаботников>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыПримененияЛьготРаботников[]
                {
                    Models.Enums.СпособыПримененияЛьготРаботников.Основной,
                    Models.Enums.СпособыПримененияЛьготРаботников.НаКаждогоРебенка,
                    Models.Enums.СпособыПримененияЛьготРаботников.НаКаждогоРебенкаИнвалида,
                    Models.Enums.СпособыПримененияЛьготРаботников.НаТроихДетей,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРаспределенияДопРасходов>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРаспределенияДопРасходов[]
                {
                    Models.Enums.СпособыРаспределенияДопРасходов.ПоСумме,
                    Models.Enums.СпособыРаспределенияДопРасходов.ПоКоличеству,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРаспределенияКосвенныхРасходов>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРаспределенияКосвенныхРасходов[]
                {
                    Models.Enums.СпособыРаспределенияКосвенныхРасходов.ОбъемВыпуска,
                    Models.Enums.СпособыРаспределенияКосвенныхРасходов.ПлановаяСебестоимость,
                    Models.Enums.СпособыРаспределенияКосвенныхРасходов.ОплатаТруда,
                    Models.Enums.СпособыРаспределенияКосвенныхРасходов.МатериальныеЗатраты,
                    Models.Enums.СпособыРаспределенияКосвенныхРасходов.ПрямыеЗатраты,
                    Models.Enums.СпособыРаспределенияКосвенныхРасходов.ОтдельныеСтатьиПрямыхЗатрат,
                    Models.Enums.СпособыРаспределенияКосвенныхРасходов.НеРаспределяется,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаАванса>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаАванса[]
                {
                    Models.Enums.СпособыРасчетаАванса.ФиксированнойСуммой,
                    Models.Enums.СпособыРасчетаАванса.ПроцентомОтТарифа,
                    Models.Enums.СпособыРасчетаАванса.РасчетомЗаПервуюПоловинуМесяца,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаВзносов>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаВзносов[]
                {
                    Models.Enums.СпособыРасчетаВзносов.Взносы,
                    Models.Enums.СпособыРасчетаВзносов.ВзносыФОТ,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаДоплатыЗаСовмещение>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаДоплатыЗаСовмещение[]
                {
                    Models.Enums.СпособыРасчетаДоплатыЗаСовмещение.ПроцентФОТ,
                    Models.Enums.СпособыРасчетаДоплатыЗаСовмещение.РазницаФОТ,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаКомиссионногоВознаграждения>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаКомиссионногоВознаграждения[]
                {
                    Models.Enums.СпособыРасчетаКомиссионногоВознаграждения.НеРассчитывается,
                    Models.Enums.СпособыРасчетаКомиссионногоВознаграждения.ПроцентОтРазностиСуммПродажиИПоступления,
                    Models.Enums.СпособыРасчетаКомиссионногоВознаграждения.ПроцентОтСуммыПродажи,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаНачислений>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаНачислений[]
                {
                    Models.Enums.СпособыРасчетаНачислений.ПоМесячнойТарифнойСтавкеПоЧасам,
                    Models.Enums.СпособыРасчетаНачислений.ПроизвольнаяФормула,
                    Models.Enums.СпособыРасчетаНачислений.ПоМесячнойТарифнойСтавкеПоДням,
                    Models.Enums.СпособыРасчетаНачислений.ПоДневнойТарифнойСтавке,
                    Models.Enums.СпособыРасчетаНачислений.ПоЧасовойТарифнойСтавке,
                    Models.Enums.СпособыРасчетаНачислений.ФиксированнойСуммой,
                    Models.Enums.СпособыРасчетаНачислений.Процентом,
                    Models.Enums.СпособыРасчетаНачислений.ИндексацияЗарплаты,
                    Models.Enums.СпособыРасчетаНачислений.ДоплатаДоСреднегоЗаработка,
                    Models.Enums.СпособыРасчетаНачислений.ДоплатаДоСреднегоЗаработкаФСС,
                    Models.Enums.СпособыРасчетаНачислений.ОплатаБольничного,
                    Models.Enums.СпособыРасчетаНачислений.ОплатаОтпускаПоКалендарнымДням,
                    Models.Enums.СпособыРасчетаНачислений.ОплатаОтпускаПоШестидневке,
                    Models.Enums.СпособыРасчетаНачислений.ОплатаПростоя,
                    Models.Enums.СпособыРасчетаНачислений.ПособиеПоУходуЗаРебенкомДоПолутораЛет,
                    Models.Enums.СпособыРасчетаНачислений.ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни,
                    Models.Enums.СпособыРасчетаНачислений.ДоплатаДоМЗП,
                    Models.Enums.СпособыРасчетаНачислений.ИндексацияСоциальныхНачислений,
                    Models.Enums.СпособыРасчетаНачислений.НулеваяСумма,
                    Models.Enums.СпособыРасчетаНачислений.Индексация,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаОтпуска>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаОтпуска[]
                {
                    Models.Enums.СпособыРасчетаОтпуска.ВКалендарныхДнях,
                    Models.Enums.СпособыРасчетаОтпуска.ВРабочихДнях,
                    Models.Enums.СпособыРасчетаОтпуска.ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора,
                    Models.Enums.СпособыРасчетаОтпуска.ВКалендарныхДняхСПраздниками,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаПоШкале>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаПоШкале[]
                {
                    Models.Enums.СпособыРасчетаПоШкале.ПоШкале,
                    Models.Enums.СпособыРасчетаПоШкале.Прогрессивный,
                    Models.Enums.СпособыРасчетаПоШкале.СДекретных,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаСебестоимостиПродукции>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаСебестоимостиПродукции[]
                {
                    Models.Enums.СпособыРасчетаСебестоимостиПродукции.ПоПеределам,
                    Models.Enums.СпособыРасчетаСебестоимостиПродукции.ПоПодразделениям,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаСреднегоЗаработкаДляОплатыПособия>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаСреднегоЗаработкаДляОплатыПособия[]
                {
                    Models.Enums.СпособыРасчетаСреднегоЗаработкаДляОплатыПособия.СреднийЗаработок,
                    Models.Enums.СпособыРасчетаСреднегоЗаработкаДляОплатыПособия.ИсходяИзТарифнойСтавки,
                    Models.Enums.СпособыРасчетаСреднегоЗаработкаДляОплатыПособия.ИсходяИзМРОТ,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаУдержаний>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаУдержаний[]
                {
                    Models.Enums.СпособыРасчетаУдержаний.ФиксированнойСуммой,
                    Models.Enums.СпособыРасчетаУдержаний.Процентом,
                    Models.Enums.СпособыРасчетаУдержаний.ПроизвольнаяФормула,
                    Models.Enums.СпособыРасчетаУдержаний.ИсполнительныйЛист,
                    Models.Enums.СпособыРасчетаУдержаний.ВознаграждениеПлатежногоАгента,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРасчетаУдержанияПоИсполнительномуДокументу>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРасчетаУдержанияПоИсполнительномуДокументу[]
                {
                    Models.Enums.СпособыРасчетаУдержанияПоИсполнительномуДокументу.Процентом,
                    Models.Enums.СпособыРасчетаУдержанияПоИсполнительномуДокументу.Долей,
                    Models.Enums.СпособыРасчетаУдержанияПоИсполнительномуДокументу.ФиксированнойСуммой,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыРедактированияЭлектронныхПисем>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыРедактированияЭлектронныхПисем[]
                {
                    Models.Enums.СпособыРедактированияЭлектронныхПисем.ОбычныйТекст,
                    Models.Enums.СпособыРедактированияЭлектронныхПисем.HTML,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыСравненияВерсийФайлов>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыСравненияВерсийФайлов[]
                {
                    Models.Enums.СпособыСравненияВерсийФайлов.MicrosoftOfficeWord,
                    Models.Enums.СпособыСравненияВерсийФайлов.OpenOfficeOrgWriter,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыУстановкиКурсаВалюты>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыУстановкиКурсаВалюты[]
                {
                    Models.Enums.СпособыУстановкиКурсаВалюты.ЗагрузкаИзИнтернета,
                    Models.Enums.СпособыУстановкиКурсаВалюты.РучнойВвод,
                    Models.Enums.СпособыУстановкиКурсаВалюты.НаценкаНаКурсДругойВалюты,
                    Models.Enums.СпособыУстановкиКурсаВалюты.РасчетПоФормуле,
                });
            });
            modelBuilder.Entity<Models.Enums.СпособыФинансированияПособийСоцстрахования>(mb =>
            {
                mb.HasData(new Models.Enums.СпособыФинансированияПособийСоцстрахования[]
                {
                    Models.Enums.СпособыФинансированияПособийСоцстрахования.ЗаСчетФСС,
                    Models.Enums.СпособыФинансированияПособийСоцстрахования.ЗаСчетРаботодателя,
                });
            });
            modelBuilder.Entity<Models.Enums.СрокиХраненияВерсий>(mb =>
            {
                mb.HasData(new Models.Enums.СрокиХраненияВерсий[]
                {
                    Models.Enums.СрокиХраненияВерсий.ЗаПоследнююНеделю,
                    Models.Enums.СрокиХраненияВерсий.ЗаПоследнийМесяц,
                    Models.Enums.СрокиХраненияВерсий.ЗаПоследниеТриМесяца,
                    Models.Enums.СрокиХраненияВерсий.ЗаПоследниеШестьМесяцев,
                    Models.Enums.СрокиХраненияВерсий.ЗаПоследнийГод,
                    Models.Enums.СрокиХраненияВерсий.Бессрочно,
                });
            });
            modelBuilder.Entity<Models.Enums.СтавкиНДС>(mb =>
            {
                mb.HasData(new Models.Enums.СтавкиНДС[]
                {
                    Models.Enums.СтавкиНДС.НДС20,
                    Models.Enums.СтавкиНДС.НДС7,
                    Models.Enums.СтавкиНДС.НДС0,
                    Models.Enums.СтавкиНДС.БезНДС,
                    Models.Enums.СтавкиНДС.НеНДС,
                });
            });
            modelBuilder.Entity<Models.Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий>(mb =>
            {
                mb.HasData(new Models.Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий[]
                {
                    Models.Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий.ВРаботе,
                    Models.Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий.Подготовлен,
                    Models.Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий.ПереданВФСС,
                    Models.Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий.ПринятФСС,
                    Models.Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий.НеПринятФСС,
                    Models.Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий.Аннулирован,
                });
            });
            modelBuilder.Entity<Models.Enums.СтатусыИзвлеченияТекстаФайлов>(mb =>
            {
                mb.HasData(new Models.Enums.СтатусыИзвлеченияТекстаФайлов[]
                {
                    Models.Enums.СтатусыИзвлеченияТекстаФайлов.НеИзвлечен,
                    Models.Enums.СтатусыИзвлеченияТекстаФайлов.Извлечен,
                    Models.Enums.СтатусыИзвлеченияТекстаФайлов.ИзвлечьНеУдалось,
                });
            });
            modelBuilder.Entity<Models.Enums.СтатусыКонтрагентов>(mb =>
            {
                mb.HasData(new Models.Enums.СтатусыКонтрагентов[]
                {
                    Models.Enums.СтатусыКонтрагентов.Покупатель,
                    Models.Enums.СтатусыКонтрагентов.Поставщик,
                    Models.Enums.СтатусыКонтрагентов.Прочее,
                });
            });
            modelBuilder.Entity<Models.Enums.СтатусыЛистковСообщения>(mb =>
            {
                mb.HasData(new Models.Enums.СтатусыЛистковСообщения[]
                {
                    Models.Enums.СтатусыЛистковСообщения.НеВрученСотруднику,
                    Models.Enums.СтатусыЛистковСообщения.ВрученСотруднику,
                    Models.Enums.СтатусыЛистковСообщения.ПредъявленКорешок,
                });
            });
            modelBuilder.Entity<Models.Enums.СтатусыОбластейДанных>(mb =>
            {
                mb.HasData(new Models.Enums.СтатусыОбластейДанных[]
                {
                    Models.Enums.СтатусыОбластейДанных.Новая,
                    Models.Enums.СтатусыОбластейДанных.Используется,
                    Models.Enums.СтатусыОбластейДанных.КУдалению,
                    Models.Enums.СтатусыОбластейДанных.Удалена,
                    Models.Enums.СтатусыОбластейДанных.ИмпортИзФайла,
                });
            });
            modelBuilder.Entity<Models.Enums.СтатусыРегистрацииВЕРНННалоговыхДокументов>(mb =>
            {
                mb.HasData(new Models.Enums.СтатусыРегистрацииВЕРНННалоговыхДокументов[]
                {
                    Models.Enums.СтатусыРегистрацииВЕРНННалоговыхДокументов.НеЗарегистрированВЕРНН,
                    Models.Enums.СтатусыРегистрацииВЕРНННалоговыхДокументов.НаправленНаРегистрациюВЕРНН,
                    Models.Enums.СтатусыРегистрацииВЕРНННалоговыхДокументов.ОтказаноВРегистрацииВЕРНН,
                    Models.Enums.СтатусыРегистрацииВЕРНННалоговыхДокументов.ЗарегистрированВЕРНН,
                });
            });
            modelBuilder.Entity<Models.Enums.СтатусыРегламентированныхОтчетов>(mb =>
            {
                mb.HasData(new Models.Enums.СтатусыРегламентированныхОтчетов[]
                {
                    Models.Enums.СтатусыРегламентированныхОтчетов.Принят,
                    Models.Enums.СтатусыРегламентированныхОтчетов.НеПринят,
                    Models.Enums.СтатусыРегламентированныхОтчетов.ЖдетПодтвержденияСтатуса,
                });
            });
            modelBuilder.Entity<Models.Enums.СтратегииОтраженияВУчетеЕСВ>(mb =>
            {
                mb.HasData(new Models.Enums.СтратегииОтраженияВУчетеЕСВ[]
                {
                    Models.Enums.СтратегииОтраженияВУчетеЕСВ.КакНачисление,
                    Models.Enums.СтратегииОтраженияВУчетеЕСВ.КакОсновноеНачислениеСотрудника,
                    Models.Enums.СтратегииОтраженияВУчетеЕСВ.ОсобымСпособом,
                });
            });
            modelBuilder.Entity<Models.Enums.СтратегииОтраженияВУчетеНачислений>(mb =>
            {
                mb.HasData(new Models.Enums.СтратегииОтраженияВУчетеНачислений[]
                {
                    Models.Enums.СтратегииОтраженияВУчетеНачислений.ПоБазовымРасчетам,
                    Models.Enums.СтратегииОтраженияВУчетеНачислений.ПоДаннымОСотрудникеИЕгоПлановыхНачислениях,
                    Models.Enums.СтратегииОтраженияВУчетеНачислений.КакЗаданоВидуРасчета,
                });
            });
            modelBuilder.Entity<Models.Enums.СтратегииОтраженияВУчетеНачисленийУдержаний>(mb =>
            {
                mb.HasData(new Models.Enums.СтратегииОтраженияВУчетеНачисленийУдержаний[]
                {
                    Models.Enums.СтратегииОтраженияВУчетеНачисленийУдержаний.ПоБазовымРасчетам,
                    Models.Enums.СтратегииОтраженияВУчетеНачисленийУдержаний.ПоДаннымОСотрудникеИЕгоПлановыхНачислениях,
                    Models.Enums.СтратегииОтраженияВУчетеНачисленийУдержаний.КакЗаданоВидуРасчета,
                });
            });
            modelBuilder.Entity<Models.Enums.СтратегияРедактированияНомеровОбъектов>(mb =>
            {
                mb.HasData(new Models.Enums.СтратегияРедактированияНомеровОбъектов[]
                {
                    Models.Enums.СтратегияРедактированияНомеровОбъектов.НеДоступно,
                    Models.Enums.СтратегияРедактированияНомеровОбъектов.Доступно,
                });
            });
            modelBuilder.Entity<Models.Enums.ТарифыМобильногоБанка>(mb =>
            {
                mb.HasData(new Models.Enums.ТарифыМобильногоБанка[]
                {
                    Models.Enums.ТарифыМобильногоБанка.Экономный,
                    Models.Enums.ТарифыМобильногоБанка.Полный,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипДетализацииСтандартныхОтчетов>(mb =>
            {
                mb.HasData(new Models.Enums.ТипДетализацииСтандартныхОтчетов[]
                {
                    Models.Enums.ТипДетализацииСтандартныхОтчетов.Элементы,
                    Models.Enums.ТипДетализацииСтандартныхОтчетов.Иерархия,
                    Models.Enums.ТипДетализацииСтандартныхОтчетов.ТолькоИерархия,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипНалоговойДеятельности>(mb =>
            {
                mb.HasData(new Models.Enums.ТипНалоговойДеятельности[]
                {
                    Models.Enums.ТипНалоговойДеятельности.ОблагаемыйПоОбычнойСтавке,
                    Models.Enums.ТипНалоговойДеятельности.ОсвобожденныйОтНалогообложения,
                    Models.Enums.ТипНалоговойДеятельности.НеОблагаемый,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипХранилищаСертификатов>(mb =>
            {
                mb.HasData(new Models.Enums.ТипХранилищаСертификатов[]
                {
                    Models.Enums.ТипХранилищаСертификатов.ПерсональныеСертификаты,
                    Models.Enums.ТипХранилищаСертификатов.СертификатыПолучателей,
                    Models.Enums.ТипХранилищаСертификатов.СертификатыУдостоверяющихЦентров,
                    Models.Enums.ТипХранилищаСертификатов.КорневыеСертификаты,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыВерсийОбъекта>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыВерсийОбъекта[]
                {
                    Models.Enums.ТипыВерсийОбъекта.ИзмененоПользователем,
                    Models.Enums.ТипыВерсийОбъекта.ПринятыеДанныеПоКоллизии,
                    Models.Enums.ТипыВерсийОбъекта.НепринятыеДанныеПоКоллизии,
                    Models.Enums.ТипыВерсийОбъекта.НепринятыйПоДатеЗапретаОбъектСуществуетВБазе,
                    Models.Enums.ТипыВерсийОбъекта.НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыДанныхКэшаПрограммныхИнтерфейсов>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыДанныхКэшаПрограммныхИнтерфейсов[]
                {
                    Models.Enums.ТипыДанныхКэшаПрограммныхИнтерфейсов.ОписаниеWebСервиса,
                    Models.Enums.ТипыДанныхКэшаПрограммныхИнтерфейсов.ВерсииИнтерфейса,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыКонтактнойИнформации>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыКонтактнойИнформации[]
                {
                    Models.Enums.ТипыКонтактнойИнформации.Адрес,
                    Models.Enums.ТипыКонтактнойИнформации.Телефон,
                    Models.Enums.ТипыКонтактнойИнформации.АдресЭлектроннойПочты,
                    Models.Enums.ТипыКонтактнойИнформации.Skype,
                    Models.Enums.ТипыКонтактнойИнформации.ВебСтраница,
                    Models.Enums.ТипыКонтактнойИнформации.Факс,
                    Models.Enums.ТипыКонтактнойИнформации.Другое,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыОплат>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыОплат[]
                {
                    Models.Enums.ТипыОплат.Наличные,
                    Models.Enums.ТипыОплат.ПлатежнаяКарта,
                    Models.Enums.ТипыОплат.БанковскийКредит,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыОтчетов>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыОтчетов[]
                {
                    Models.Enums.ТипыОтчетов.Внутренний,
                    Models.Enums.ТипыОтчетов.Дополнительный,
                    Models.Enums.ТипыОтчетов.Расширение,
                    Models.Enums.ТипыОтчетов.Внешний,
                    Models.Enums.ТипыОтчетов.УдалитьОтчет,
                    Models.Enums.ТипыОтчетов.УдалитьПользовательский,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыОценочныхОбязательств>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыОценочныхОбязательств[]
                {
                    Models.Enums.ТипыОценочныхОбязательств.ОценочныеОбязательстваПоВознаграждениям,
                    Models.Enums.ТипыОценочныхОбязательств.ОценочныеОбязательстваПоСтраховымВзносам,
                    Models.Enums.ТипыОценочныхОбязательств.ОценочныеОбязательстваПоВзносамФССНСиПЗ,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыПоказателейРасчетаЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыПоказателейРасчетаЗарплаты[]
                {
                    Models.Enums.ТипыПоказателейРасчетаЗарплаты.Денежный,
                    Models.Enums.ТипыПоказателейРасчетаЗарплаты.Числовой,
                    Models.Enums.ТипыПоказателейРасчетаЗарплаты.ЧисловойЗависящийОтДругогоПоказателя,
                    Models.Enums.ТипыПоказателейРасчетаЗарплаты.ЧисловойЗависящийОтСтажа,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыПолейРегистра>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыПолейРегистра[]
                {
                    Models.Enums.ТипыПолейРегистра.Измерение,
                    Models.Enums.ТипыПолейРегистра.Ресурс,
                    Models.Enums.ТипыПолейРегистра.Реквизит,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыПроблемОбменаДанными>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыПроблемОбменаДанными[]
                {
                    Models.Enums.ТипыПроблемОбменаДанными.НепроведенныйДокумент,
                    Models.Enums.ТипыПроблемОбменаДанными.НезаполненныеРеквизиты,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыРегистров>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыРегистров[]
                {
                    Models.Enums.ТипыРегистров.РегистрНакопления,
                    Models.Enums.ТипыРегистров.РегистрСведений,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыРесурсовМеханизмаОнлайнСервисовРО>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыРесурсовМеханизмаОнлайнСервисовРО[]
                {
                    Models.Enums.ТипыРесурсовМеханизмаОнлайнСервисовРО.СправочникФормИФорматов,
                    Models.Enums.ТипыРесурсовМеханизмаОнлайнСервисовРО.СправочникРелизов,
                    Models.Enums.ТипыРесурсовМеханизмаОнлайнСервисовРО.ИнформацияОРелизе,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыСкладов>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыСкладов[]
                {
                    Models.Enums.ТипыСкладов.ОптовыйСклад,
                    Models.Enums.ТипыСкладов.РозничныйМагазин,
                    Models.Enums.ТипыСкладов.НеавтоматизированнаяТорговаяТочка,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыСуммДляВводаОстатков>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыСуммДляВводаОстатков[]
                {
                    Models.Enums.ТипыСуммДляВводаОстатков.Оборот,
                    Models.Enums.ТипыСуммДляВводаОстатков.ОстатокНаНачало,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыСчетчиковВыгрузки>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыСчетчиковВыгрузки[]
                {
                    Models.Enums.ТипыСчетчиковВыгрузки.СчетчикДокументовВФормате201,
                    Models.Enums.ТипыСчетчиковВыгрузки.СчетчикДокументовВФормате300,
                    Models.Enums.ТипыСчетчиковВыгрузки.СчетчикФайлов,
                    Models.Enums.ТипыСчетчиковВыгрузки.СчетчикФайловАлко,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыТекстовЭлектронныхПисем>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыТекстовЭлектронныхПисем[]
                {
                    Models.Enums.ТипыТекстовЭлектронныхПисем.HTML,
                    Models.Enums.ТипыТекстовЭлектронныхПисем.ПростойТекст,
                    Models.Enums.ТипыТекстовЭлектронныхПисем.РазмеченныйТекст,
                    Models.Enums.ТипыТекстовЭлектронныхПисем.HTMLСКартинками,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыУслуг>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыУслуг[]
                {
                    Models.Enums.ТипыУслуг.Безлимитная,
                    Models.Enums.ТипыУслуг.Лимитированная,
                    Models.Enums.ТипыУслуг.Уникальная,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыФайловДляВстроенногоРедактора>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыФайловДляВстроенногоРедактора[]
                {
                    Models.Enums.ТипыФайловДляВстроенногоРедактора.ГеографическиеСхемы,
                    Models.Enums.ТипыФайловДляВстроенногоРедактора.ГрафическиеСхемы,
                    Models.Enums.ТипыФайловДляВстроенногоРедактора.ТабличныеФайлы,
                    Models.Enums.ТипыФайловДляВстроенногоРедактора.ТекстовыеФайлы,
                });
            });
            modelBuilder.Entity<Models.Enums.ТипыХраненияФайлов>(mb =>
            {
                mb.HasData(new Models.Enums.ТипыХраненияФайлов[]
                {
                    Models.Enums.ТипыХраненияФайлов.ВИнформационнойБазе,
                    Models.Enums.ТипыХраненияФайлов.ВТомахНаДиске,
                });
            });
            modelBuilder.Entity<Models.Enums.УдалитьВидыВзаиморасчетовСРаботниками>(mb =>
            {
                mb.HasData(new Models.Enums.УдалитьВидыВзаиморасчетовСРаботниками[]
                {
                    Models.Enums.УдалитьВидыВзаиморасчетовСРаботниками.ЗаработнаяПлата,
                    Models.Enums.УдалитьВидыВзаиморасчетовСРаботниками.ЗаработнаяПлатаНеФОТ,
                    Models.Enums.УдалитьВидыВзаиморасчетовСРаботниками.Дивиденды,
                    Models.Enums.УдалитьВидыВзаиморасчетовСРаботниками.ДепонированнаяЗарплата,
                });
            });
            modelBuilder.Entity<Models.Enums.УдалитьВидыКалендарей>(mb =>
            {
                mb.HasData(new Models.Enums.УдалитьВидыКалендарей[]
                {
                    Models.Enums.УдалитьВидыКалендарей.Пятидневка,
                    Models.Enums.УдалитьВидыКалендарей.Шестидневка,
                    Models.Enums.УдалитьВидыКалендарей.Произвольный,
                });
            });
            modelBuilder.Entity<Models.Enums.УдалитьВидыОбъектовКонтактнойИнформации>(mb =>
            {
                mb.HasData(new Models.Enums.УдалитьВидыОбъектовКонтактнойИнформации[]
                {
                    Models.Enums.УдалитьВидыОбъектовКонтактнойИнформации.Контрагенты,
                    Models.Enums.УдалитьВидыОбъектовКонтактнойИнформации.КонтактныеЛица,
                    Models.Enums.УдалитьВидыОбъектовКонтактнойИнформации.ФизическиеЛица,
                    Models.Enums.УдалитьВидыОбъектовКонтактнойИнформации.Организации,
                    Models.Enums.УдалитьВидыОбъектовКонтактнойИнформации.Пользователи,
                });
            });
            modelBuilder.Entity<Models.Enums.УдалитьВидыТекстовЭлектронныхПисем>(mb =>
            {
                mb.HasData(new Models.Enums.УдалитьВидыТекстовЭлектронныхПисем[]
                {
                    Models.Enums.УдалитьВидыТекстовЭлектронныхПисем.HTML,
                    Models.Enums.УдалитьВидыТекстовЭлектронныхПисем.Текст,
                    Models.Enums.УдалитьВидыТекстовЭлектронныхПисем.Прочее,
                    Models.Enums.УдалитьВидыТекстовЭлектронныхПисем.HTMLСКартинками,
                });
            });
            modelBuilder.Entity<Models.Enums.УдалитьДействиеПриОбмене>(mb =>
            {
                mb.HasData(new Models.Enums.УдалитьДействиеПриОбмене[]
                {
                    Models.Enums.УдалитьДействиеПриОбмене.ЗагрузкаДанных,
                    Models.Enums.УдалитьДействиеПриОбмене.ОтложенныеДвижения,
                    Models.Enums.УдалитьДействиеПриОбмене.ВыгрузкаДанных,
                });
            });
            modelBuilder.Entity<Models.Enums.УдалитьНаборПравПользователей>(mb =>
            {
                mb.HasData(new Models.Enums.УдалитьНаборПравПользователей[]
                {
                    Models.Enums.УдалитьНаборПравПользователей.Бухгалтер,
                    Models.Enums.УдалитьНаборПравПользователей.ГлавныйБухгалтер,
                    Models.Enums.УдалитьНаборПравПользователей.ПолныеПрава,
                });
            });
            modelBuilder.Entity<Models.Enums.УдалитьПолФизическихЛиц>(mb =>
            {
                mb.HasData(new Models.Enums.УдалитьПолФизическихЛиц[]
                {
                    Models.Enums.УдалитьПолФизическихЛиц.Мужской,
                    Models.Enums.УдалитьПолФизическихЛиц.Женский,
                });
            });
            modelBuilder.Entity<Models.Enums.УдалитьТипыАвтоматическогоОбменаДанными>(mb =>
            {
                mb.HasData(new Models.Enums.УдалитьТипыАвтоматическогоОбменаДанными[]
                {
                    Models.Enums.УдалитьТипыАвтоматическогоОбменаДанными.ОбменЧерезФайловыйРесурс,
                    Models.Enums.УдалитьТипыАвтоматическогоОбменаДанными.ОбменЧерезFTPРесурс,
                    Models.Enums.УдалитьТипыАвтоматическогоОбменаДанными.ОбменЧерезПочту,
                    Models.Enums.УдалитьТипыАвтоматическогоОбменаДанными.ОбменЧерезComСоединение,
                });
            });
            modelBuilder.Entity<Models.Enums.УдалитьТипыСкладов>(mb =>
            {
                mb.HasData(new Models.Enums.УдалитьТипыСкладов[]
                {
                    Models.Enums.УдалитьТипыСкладов.Оптовый,
                    Models.Enums.УдалитьТипыСкладов.Розничный,
                });
            });
            modelBuilder.Entity<Models.Enums.УровниПроизводительности>(mb =>
            {
                mb.HasData(new Models.Enums.УровниПроизводительности[]
                {
                    Models.Enums.УровниПроизводительности.Идеально,
                    Models.Enums.УровниПроизводительности.Отлично,
                    Models.Enums.УровниПроизводительности.Хорошо,
                    Models.Enums.УровниПроизводительности.Удовлетворительно,
                    Models.Enums.УровниПроизводительности.Плохо,
                });
            });
            modelBuilder.Entity<Models.Enums.УстарелоВидыЗанятости>(mb =>
            {
                mb.HasData(new Models.Enums.УстарелоВидыЗанятости[]
                {
                    Models.Enums.УстарелоВидыЗанятости.ОсновноеМестоРаботы,
                    Models.Enums.УстарелоВидыЗанятости.Совместительство,
                    Models.Enums.УстарелоВидыЗанятости.ВнутреннееСовместительство,
                });
            });
            modelBuilder.Entity<Models.Enums.УстарелоВидыПропорцииВремени>(mb =>
            {
                mb.HasData(new Models.Enums.УстарелоВидыПропорцииВремени[]
                {
                    Models.Enums.УстарелоВидыПропорцииВремени.ПоДням,
                    Models.Enums.УстарелоВидыПропорцииВремени.ПоЧасам,
                });
            });
            modelBuilder.Entity<Models.Enums.УстарелоВыплаченностьЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.УстарелоВыплаченностьЗарплаты[]
                {
                    Models.Enums.УстарелоВыплаченностьЗарплаты.НеВыплачено,
                    Models.Enums.УстарелоВыплаченностьЗарплаты.Выплачено,
                    Models.Enums.УстарелоВыплаченностьЗарплаты.Задепонировано,
                });
            });
            modelBuilder.Entity<Models.Enums.УстарелоКолонкиУпрощенногоРасчета>(mb =>
            {
                mb.HasData(new Models.Enums.УстарелоКолонкиУпрощенногоРасчета[]
                {
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.Оклад,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.Отпускные,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.БольничныеПредприятие,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.БольничныеФСС,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.Индексация,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.Доплата1,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.Доплата2,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.Доплата3,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.Доплата4,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.Доплата5,
                    Models.Enums.УстарелоКолонкиУпрощенногоРасчета.Доплата6,
                });
            });
            modelBuilder.Entity<Models.Enums.УстарелоСпособыВыплатыЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.УстарелоСпособыВыплатыЗарплаты[]
                {
                    Models.Enums.УстарелоСпособыВыплатыЗарплаты.ЧерезКассу,
                    Models.Enums.УстарелоСпособыВыплатыЗарплаты.ЧерезБанк,
                });
            });
            modelBuilder.Entity<Models.Enums.УчетНачисленийВСреднемЗаработкеОбщий>(mb =>
            {
                mb.HasData(new Models.Enums.УчетНачисленийВСреднемЗаработкеОбщий[]
                {
                    Models.Enums.УчетНачисленийВСреднемЗаработкеОбщий.ОбщийЗаработок,
                    Models.Enums.УчетНачисленийВСреднемЗаработкеОбщий.ПремияФиксированнойСуммой,
                    Models.Enums.УчетНачисленийВСреднемЗаработкеОбщий.ПремияПроцентом,
                    Models.Enums.УчетНачисленийВСреднемЗаработкеОбщий.ПремияГодоваяФиксированнойСуммой,
                    Models.Enums.УчетНачисленийВСреднемЗаработкеОбщий.ПремияГодоваяПроцентом,
                    Models.Enums.УчетНачисленийВСреднемЗаработкеОбщий.НеВключать,
                });
            });
            modelBuilder.Entity<Models.Enums.УчетНачисленийВСреднемЗаработкеФСС>(mb =>
            {
                mb.HasData(new Models.Enums.УчетНачисленийВСреднемЗаработкеФСС[]
                {
                    Models.Enums.УчетНачисленийВСреднемЗаработкеФСС.Включать,
                    Models.Enums.УчетНачисленийВСреднемЗаработкеФСС.НеВключать,
                });
            });
            modelBuilder.Entity<Models.Enums.ФорматыСканированногоИзображения>(mb =>
            {
                mb.HasData(new Models.Enums.ФорматыСканированногоИзображения[]
                {
                    Models.Enums.ФорматыСканированногоИзображения.BMP,
                    Models.Enums.ФорматыСканированногоИзображения.JPG,
                    Models.Enums.ФорматыСканированногоИзображения.GIF,
                    Models.Enums.ФорматыСканированногоИзображения.PNG,
                    Models.Enums.ФорматыСканированногоИзображения.TIF,
                });
            });
            modelBuilder.Entity<Models.Enums.ФорматыСохраненияОтчетов>(mb =>
            {
                mb.HasData(new Models.Enums.ФорматыСохраненияОтчетов[]
                {
                    Models.Enums.ФорматыСохраненияОтчетов.HTML,
                    Models.Enums.ФорматыСохраненияОтчетов.HTML4,
                    Models.Enums.ФорматыСохраненияОтчетов.XLS,
                    Models.Enums.ФорматыСохраненияОтчетов.XLSX,
                    Models.Enums.ФорматыСохраненияОтчетов.PDF,
                    Models.Enums.ФорматыСохраненияОтчетов.MXL,
                    Models.Enums.ФорматыСохраненияОтчетов.ODS,
                    Models.Enums.ФорматыСохраненияОтчетов.DOCX,
                    Models.Enums.ФорматыСохраненияОтчетов.TXT,
                    Models.Enums.ФорматыСохраненияОтчетов.ANSITXT,
                });
            });
            modelBuilder.Entity<Models.Enums.ФорматыФайловОбменаПоЗарплатномуПроекту>(mb =>
            {
                mb.HasData(new Models.Enums.ФорматыФайловОбменаПоЗарплатномуПроекту[]
                {
                    Models.Enums.ФорматыФайловОбменаПоЗарплатномуПроекту.Версия1,
                    Models.Enums.ФорматыФайловОбменаПоЗарплатномуПроекту.Версия3,
                    Models.Enums.ФорматыФайловОбменаПоЗарплатномуПроекту.Версия32,
                    Models.Enums.ФорматыФайловОбменаПоЗарплатномуПроекту.Версия33,
                    Models.Enums.ФорматыФайловОбменаПоЗарплатномуПроекту.Версия34,
                });
            });
            modelBuilder.Entity<Models.Enums.ФорматыХраненияМногостраничныхФайлов>(mb =>
            {
                mb.HasData(new Models.Enums.ФорматыХраненияМногостраничныхФайлов[]
                {
                    Models.Enums.ФорматыХраненияМногостраничныхФайлов.PDF,
                    Models.Enums.ФорматыХраненияМногостраничныхФайлов.TIF,
                });
            });
            modelBuilder.Entity<Models.Enums.ФорматыХраненияОдностраничныхФайлов>(mb =>
            {
                mb.HasData(new Models.Enums.ФорматыХраненияОдностраничныхФайлов[]
                {
                    Models.Enums.ФорматыХраненияОдностраничныхФайлов.BMP,
                    Models.Enums.ФорматыХраненияОдностраничныхФайлов.GIF,
                    Models.Enums.ФорматыХраненияОдностраничныхФайлов.JPG,
                    Models.Enums.ФорматыХраненияОдностраничныхФайлов.PDF,
                    Models.Enums.ФорматыХраненияОдностраничныхФайлов.PNG,
                    Models.Enums.ФорматыХраненияОдностраничныхФайлов.TIF,
                });
            });
            modelBuilder.Entity<Models.Enums.ФормыОбучения>(mb =>
            {
                mb.HasData(new Models.Enums.ФормыОбучения[]
                {
                    Models.Enums.ФормыОбучения.Очная,
                    Models.Enums.ФормыОбучения.Заочная,
                    Models.Enums.ФормыОбучения.Вечерняя,
                    Models.Enums.ФормыОбучения.Экстернат,
                    Models.Enums.ФормыОбучения.Прочее,
                });
            });
            modelBuilder.Entity<Models.Enums.ФормыОплаты>(mb =>
            {
                mb.HasData(new Models.Enums.ФормыОплаты[]
                {
                    Models.Enums.ФормыОплаты.Наличная,
                    Models.Enums.ФормыОплаты.Безналичная,
                    Models.Enums.ФормыОплаты.ПлатежнаяКарта,
                    Models.Enums.ФормыОплаты.Взаимозачет,
                    Models.Enums.ФормыОплаты.БонусныеБаллы,
                    Models.Enums.ФормыОплаты.ПодарочныйСертификат,
                });
            });
            modelBuilder.Entity<Models.Enums.ХарактерВыплатыЗарплаты>(mb =>
            {
                mb.HasData(new Models.Enums.ХарактерВыплатыЗарплаты[]
                {
                    Models.Enums.ХарактерВыплатыЗарплаты.Аванс,
                    Models.Enums.ХарактерВыплатыЗарплаты.Межрасчет,
                    Models.Enums.ХарактерВыплатыЗарплаты.Зарплата,
                });
            });
            modelBuilder.Entity<Models.Enums.ХарактерЗависимостиКоличестваДнейОтпуска>(mb =>
            {
                mb.HasData(new Models.Enums.ХарактерЗависимостиКоличестваДнейОтпуска[]
                {
                    Models.Enums.ХарактерЗависимостиКоличестваДнейОтпуска.НеЗависит,
                    Models.Enums.ХарактерЗависимостиКоличестваДнейОтпуска.ЗависитОтРабочегоМеста,
                    Models.Enums.ХарактерЗависимостиКоличестваДнейОтпуска.ЗависитОтСтажа,
                });
            });
            modelBuilder.Entity<Models.Enums.ХарактерПлановогоНачисления>(mb =>
            {
                mb.HasData(new Models.Enums.ХарактерПлановогоНачисления[]
                {
                    Models.Enums.ХарактерПлановогоНачисления.Штатное,
                    Models.Enums.ХарактерПлановогоНачисления.Индивидуальное,
                });
            });
            modelBuilder.Entity<Models.Enums.ЦветностиИзображения>(mb =>
            {
                mb.HasData(new Models.Enums.ЦветностиИзображения[]
                {
                    Models.Enums.ЦветностиИзображения.Монохромное,
                    Models.Enums.ЦветностиИзображения.ГрадацииСерого,
                    Models.Enums.ЦветностиИзображения.Цветное,
                });
            });
            modelBuilder.Entity<Models.Enums.ЮридическоеФизическоеЛицо>(mb =>
            {
                mb.HasData(new Models.Enums.ЮридическоеФизическоеЛицо[]
                {
                    Models.Enums.ЮридическоеФизическоеЛицо.ЮридическоеЛицо,
                    Models.Enums.ЮридическоеФизическоеЛицо.ФизическоеЛицо,
                });
            });
        }
    }
}