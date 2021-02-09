
using DevExpress.XtraGrid.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.MailClient.Win.Localizer
{

	// TODO: translate arabic strings to Polish
	public class PolishGridLocalizer : GridLocalizer
	{
		public override string GetLocalizedString(GridStringId id)
		{
			switch (id)
			{
				case GridStringId.FileIsNotFoundError:
					return "Nie znaleziono pliku {0}";
				case GridStringId.ColumnViewExceptionMessage:
					return "Błąd przy próbie zmiany wartości";
				case GridStringId.CustomizationCaption:
					return "Wytworzone na zamówienie";
				case GridStringId.CustomizationColumns:
					return "Kolumna";
				case GridStringId.CustomizationBands:
					return "Konfiguracja pasm";
				case GridStringId.FilterPanelCustomizeButton:
					return "Konfiguruj filtrowanie";
				case GridStringId.PopupFilterAll:
					return "(wszystko)";
				case GridStringId.PopupFilterCustom:
					return "(سفارشی)";
				case GridStringId.PopupFilterBlanks:
					return "(فاصله ها)";
				case GridStringId.PopupFilterNonBlanks:
					return "(بدون فاصله)";
				case GridStringId.CustomFilterDialogFormCaption:
					return "پالایش خودکار سفارشی";
				case GridStringId.CustomFilterDialogCaption:
					return "نمایش ردیفها جایی که:";
				case GridStringId.CustomFilterDialogRadioAnd:
					return "& و";
				case GridStringId.CustomFilterDialogRadioOr:
					return "O & r";
				case GridStringId.CustomFilterDialogOkButton:
					return "& خوب";
				case GridStringId.CustomFilterDialogClearFilter:
					return "فیلتر C & لیر";
				case GridStringId.CustomFilterDialog2FieldCheck:
					return "زمینه";
				case GridStringId.CustomFilterDialogCancelButton:
					return "& لغو";
				case GridStringId.CustomFilterDialogEmptyValue:
					return "(یک مقدار را وارد کنید)";
				case GridStringId.CustomFilterDialogEmptyOperator:
					return "(انتخاب اپراتور)";
				case GridStringId.CustomFilterDialogHint:
					return "_ برای نمایش هر نویسه تکی #Use % به نمایندگی از هر سری از نویسه استفاده کنید";
				case GridStringId.WindowErrorCaption:
					return "خطا";
				case GridStringId.MenuFooterSum:
					return "مجموع";
				case GridStringId.MenuFooterMin:
					return "دقیقه";
				case GridStringId.MenuFooterMax:
					return "حداکثر";
				case GridStringId.MenuFooterCount:
					return "تعداد دفعات مشاهده";
				case GridStringId.MenuFooterAverage:
					return "به طور متوسط";
				case GridStringId.MenuFooterNone:
					return "هیچ کدام";
				case GridStringId.MenuFooterSumFormat:
					return "مجموع = {0:0. ##}";
				case GridStringId.MenuFooterMinFormat:
					return "دقیقه = {0}";
				case GridStringId.MenuFooterMaxFormat:
					return "حداکثر = {0}";
				case GridStringId.MenuFooterCountFormat:
					return "{0}";
				case GridStringId.MenuFooterAverageFormat:
					return "میانگین = {0:0. ##}";
				case GridStringId.MenuColumnSortAscending:
					return "مرتب سازی افزایشی";
				case GridStringId.MenuColumnSortDescending:
					return "مرتب سازی افزایشی";
				case GridStringId.MenuColumnShowColumn:
					return "نمایش این ستون";
				case GridStringId.MenuColumnRemoveColumn:
					return "پنهان کردن این ستون";
				case GridStringId.MenuColumnGroup:
					return "گروه براساس این ستون";
				case GridStringId.MenuColumnUnGroup:
					return "لغو گروه بندی";
				case GridStringId.MenuColumnColumnCustomization:
					return "انتخابگر ستون";
				case GridStringId.MenuColumnBandCustomization:
					return "نوار/ستون انتخاب کننده";
				case GridStringId.MenuColumnBestFit:
					return "بهترین جا";
				case GridStringId.MenuColumnFilter:
					return "می توانید فیلتر";
				case GridStringId.MenuColumnClearFilter:
					return "روشن فیلتر";
				case GridStringId.MenuColumnBestFitAllColumns:
					return "بهترین جا (همه ستون)";
				case GridStringId.MenuColumnResetGroupSummarySort:
					return "پاک کردن مرتب سازی خلاصه";
				case GridStringId.MenuColumnGroupSummarySortFormat:
					return "{1} توسط '{0}' - {2}";
				case GridStringId.MenuColumnSumSummaryTypeDescription:
					return "مجموع";
				case GridStringId.MenuColumnMinSummaryTypeDescription:
					return "دقیقه";
				case GridStringId.MenuColumnMaxSummaryTypeDescription:
					return "حداکثر";
				case GridStringId.MenuColumnCountSummaryTypeDescription:
					return "تعداد دفعات مشاهده";
				case GridStringId.MenuColumnAverageSummaryTypeDescription:
					return "به طور متوسط";
				case GridStringId.MenuColumnCustomSummaryTypeDescription:
					return "سفارشی";
				case GridStringId.MenuColumnSortGroupBySummaryMenu:
					return "مرتب کردن بر اساس خلاصه";
				case GridStringId.MenuColumnGroupIntervalMenu:
					return "گروه فاصله";
				case GridStringId.MenuColumnGroupIntervalNone:
					return "هیچ کدام";
				case GridStringId.MenuColumnGroupIntervalDay:
					return "روز";
				case GridStringId.MenuColumnGroupIntervalMonth:
					return "ماه";
				case GridStringId.MenuColumnGroupIntervalYear:
					return "سال";
				case GridStringId.MenuColumnGroupIntervalSmart:
					return "هوشمند";
				case GridStringId.MenuColumnGroupSummaryEditor:
					return "گروه تدوین خلاصه...";
				case GridStringId.MenuColumnExpressionEditor:
					return "ویرایشگر بیان...";
				case GridStringId.MenuColumnConditionalFormatting:
					return "شکلبندی شرطی";
				case GridStringId.MenuColumnFilterMode:
					return "حالت پالایه";
				case GridStringId.MenuColumnFilterModeValue:
					return "ارزش";
				case GridStringId.MenuColumnFilterModeDisplayText:
					return "نمایش متن";
				case GridStringId.MenuGroupPanelFullExpand:
					return "گسترش کامل";
				case GridStringId.MenuGroupPanelFullCollapse:
					return "فروپاشی کامل";
				case GridStringId.MenuGroupPanelClearGrouping:
					return "گروه بندی روشن";
				case GridStringId.MenuGroupPanelShow:
					return "نمایش گروه بندی بر اساس جعبه";
				case GridStringId.MenuGroupPanelHide:
					return "مخفی کردن گروه بندی بر اساس جعبه";
				case GridStringId.PrintDesignerGridView:
					return "تنظیمات چاپ (شبکه مشاهده)";
				case GridStringId.PrintDesignerCardView:
					return "تنظیمات چاپ (کارت مشاهده)";
				case GridStringId.PrintDesignerLayoutView:
					return "تنظیمات چاپ (طرح مشاهده)";
				case GridStringId.PrintDesignerBandedView:
					return "تنظیمات چاپ (بررسي مشاهده)";
				case GridStringId.PrintDesignerBandHeader:
					return "سر صفحه گروه";
				case GridStringId.MenuColumnGroupBox:
					return "گروه بندی بر اساس جعبه";
				case GridStringId.CardViewNewCard:
					return "کارت جدید";
				case GridStringId.CardViewQuickCustomizationButton:
					return "سفارشی کردن";
				case GridStringId.CardViewQuickCustomizationButtonFilter:
					return "فیلتر";
				case GridStringId.CardViewQuickCustomizationButtonSort:
					return "مرتب کردن بر اساس:";
				case GridStringId.CardViewCaptionFormat:
					return "رکورد N {0}";
				case GridStringId.GridGroupPanelText:
					return "یک سرصفحه ستون را به گروه براساس آن ستون بکشید";
				case GridStringId.GridNewRowText:
					return "اینجا را کلیک کنید برای اضافه کردن سطر جدید";
				case GridStringId.GridOutlookIntervals:
					return "قدیمی تر; ماه گذشته; اوایل این ماه; سه هفته پیش؛ دو هفته پیش؛ هفته گذشته;; دیروز; امروز; فردا;; هفته آینده؛ دو هفته بعد؛ سه هفته بعد؛ بعد از این ماه; ماه آینده؛ پس از ماه بعد;";
				case GridStringId.PrintDesignerDescription:
					return "تنظیم گزینه های چاپ مختلف برای نمای کنونی.";
				case GridStringId.MenuFooterCustomFormat:
					return "سفارشی {0} =";
				case GridStringId.MenuFooterCountGroupFormat:
					return "تعداد دفعات مشاهده = {0}";
				case GridStringId.MenuColumnClearSorting:
					return "پاک کردن مرتب سازی";
				case GridStringId.MenuColumnClearAllSorting:
					return "پاک کردن مرتب سازی همه";
				case GridStringId.MenuColumnFilterEditor:
					return "ویرایشگر فیلتر...";
				case GridStringId.MenuColumnAutoFilterRowHide:
					return "پنهان کردن خودکار فیلتر ردیف";
				case GridStringId.MenuColumnAutoFilterRowShow:
					return "نشان دادن ردیف فیلتر خودرو";
				case GridStringId.MenuColumnFindFilterHide:
					return "مخفی کردن صفحه پیدا کردن";
				case GridStringId.MenuColumnFindFilterShow:
					return "پیدا کردن صفحه نمایش";
				case GridStringId.FilterBuilderOkButton:
					return "& خوب";
				case GridStringId.FilterBuilderCancelButton:
					return "& لغو";
				case GridStringId.FilterBuilderApplyButton:
					return "& اعمال";
				case GridStringId.FilterBuilderCaption:
					return "ویرایشگر فیلتر";
				case GridStringId.CustomizationFormColumnHint:
					return "کشیدن و رها کردن اینجا برای سفارشی کردن طرح بندی";
				case GridStringId.CustomizationFormBandHint:
					return "کشیدن و رها کردن عکس در اینجا برای سفارشی کردن طرح بندی";
				case GridStringId.LayoutViewSingleModeBtnHint:
					return "یک کارت";
				case GridStringId.LayoutViewRowModeBtnHint:
					return "یک ردیف";
				case GridStringId.LayoutViewColumnModeBtnHint:
					return "یک ستون";
				case GridStringId.LayoutViewMultiRowModeBtnHint:
					return "چندین ردیف";
				case GridStringId.LayoutViewMultiColumnModeBtnHint:
					return "ستون های متعدد";
				case GridStringId.LayoutViewCarouselModeBtnHint:
					return "حالت چرخ فلک";
				case GridStringId.LayoutViewPanBtnHint:
					return "سوژه متحرک از روبرو";
				case GridStringId.LayoutViewCustomizeBtnHint:
					return "سفارشی";
				case GridStringId.LayoutViewCloseZoomBtnHintClose:
					return "بازگرداندن مشاهده";
				case GridStringId.LayoutViewCloseZoomBtnHintZoom:
					return "حداکثر رساندن جزئیات";
				case GridStringId.LayoutViewButtonApply:
					return "& اعمال";
				case GridStringId.LayoutViewButtonPreview:
					return "نمایش & کارت های بیشتر";
				case GridStringId.LayoutViewButtonOk:
					return "& خوب";
				case GridStringId.LayoutViewButtonCancel:
					return "& لغو";
				case GridStringId.LayoutViewButtonSaveLayout:
					return "س & و طرح...";
				case GridStringId.LayoutViewButtonLoadLayout:
					return "& بار طرح...";
				case GridStringId.LayoutViewFormLoadLayoutCaption:
					return "طرح بار";
				case GridStringId.LayoutViewFormSaveLayoutCaption:
					return "ذخیره چیدمان";
				case GridStringId.LayoutViewButtonCustomizeShow:
					return "& نمایش سفارشی";
				case GridStringId.LayoutViewButtonCustomizeHide:
					return "پنهان کردن تنظیم & zation";
				case GridStringId.LayoutViewButtonReset:
					return "& تنظیم مجدد قالب کارت";
				case GridStringId.LayoutViewButtonShrinkToMinimum:
					return "& کوچک قالب کارت";
				case GridStringId.LayoutViewPageTemplateCard:
					return "قالب کارت";
				case GridStringId.LayoutViewPageViewLayout:
					return "مشاهده طرح";
				case GridStringId.LayoutViewGroupCustomization:
					return "سفارشی";
				case GridStringId.LayoutViewGroupCaptions:
					return "شرح";
				case GridStringId.LayoutViewGroupIndents:
					return "تورفتگی";
				case GridStringId.LayoutViewGroupHiddenItems:
					return "موارد پنهان";
				case GridStringId.LayoutViewGroupTreeStructure:
					return "چیدمان نمای درختی";
				case GridStringId.LayoutViewGroupPropertyGrid:
					return "املاک شبکه";
				case GridStringId.LayoutViewLabelTextIndent:
					return "تورفتگی متن";
				case GridStringId.LayoutViewLabelPadding:
					return "پارچه کشی";
				case GridStringId.LayoutViewLabelSpacing:
					return "فاصله";
				case GridStringId.LayoutViewLabelCaptionLocation:
					return "زمینه محل زیرنویس:";
				case GridStringId.LayoutViewLabelGroupCaptionLocation:
					return "گروه زیرنویس محل:";
				case GridStringId.LayoutViewLabelTextAlignment:
					return "شرح زمینه تراز متن:";
				case GridStringId.LayoutViewGroupView:
					return "مشاهده";
				case GridStringId.LayoutViewGroupLayout:
					return "چیدمان";
				case GridStringId.LayoutViewGroupCards:
					return "کارت";
				case GridStringId.LayoutViewGroupFields:
					return "زمینه های";
				case GridStringId.LayoutViewLabelShowLines:
					return "نمایش خطوط";
				case GridStringId.LayoutViewLabelShowHeaderPanel:
					return "صفحه نمایش سرصفحه";
				case GridStringId.LayoutViewLabelShowFilterPanel:
					return "نمایش صفحه فیلتر:";
				case GridStringId.LayoutViewLabelScrollVisibility:
					return "پیمایش دید:";
				case GridStringId.LayoutViewLabelViewMode:
					return "حالت مشاهده:";
				case GridStringId.LayoutViewLabelCardArrangeRule:
					return "ترتیب قانون:";
				case GridStringId.LayoutViewLabelCardEdgeAlignment:
					return "تراز لبه کارت:";
				case GridStringId.LayoutViewGroupIntervals:
					return "فواصل";
				case GridStringId.LayoutViewLabelHorizontal:
					return "فاصله افقی";
				case GridStringId.LayoutViewLabelVertical:
					return "فاصله عمودی";
				case GridStringId.LayoutViewLabelShowCardCaption:
					return "نمایش زیرنویس";
				case GridStringId.LayoutViewLabelShowCardExpandButton:
					return "نمایش گسترش دکمه";
				case GridStringId.LayoutViewLabelShowCardBorder:
					return "نشان دادن مرز";
				case GridStringId.LayoutViewLabelAllowFieldHotTracking:
					return "امکان ردیابی داغ";
				case GridStringId.LayoutViewLabelShowFieldBorder:
					return "نشان دادن مرز";
				case GridStringId.LayoutViewLabelShowFieldHint:
					return "نمایش نشانه";
				case GridStringId.LayoutViewCustomizationFormCaption:
					return "LayoutView سفارشی";
				case GridStringId.LayoutViewCustomizationFormDescription:
					return "طرح کارت با استفاده از کشیدن و رها کردن و منو سفارشی و پیش نمایش داده ها را در نمای چیدمان صفحه را سفارشی کنید.";
				case GridStringId.LayoutViewCardCaptionFormat:
					return "رکورد [{0} از {1}]";
				case GridStringId.LayoutViewFieldCaptionFormat:
					return "{0}:";
				case GridStringId.GroupSummaryEditorFormCaption:
					return "گروه تدوین خلاصه";
				case GridStringId.GroupSummaryEditorFormOkButton:
					return "باشه";
				case GridStringId.GroupSummaryEditorFormCancelButton:
					return "لغو";
				case GridStringId.GroupSummaryEditorFormItemsTabCaption:
					return "موارد";
				case GridStringId.GroupSummaryEditorFormOrderTabCaption:
					return "سفارش";
				case GridStringId.GroupSummaryEditorSummaryMin:
					return "دقیقه";
				case GridStringId.GroupSummaryEditorSummaryMax:
					return "حداکثر";
				case GridStringId.GroupSummaryEditorSummaryAverage:
					return "به طور متوسط";
				case GridStringId.GroupSummaryEditorSummarySum:
					return "مجموع";
				case GridStringId.GroupSummaryEditorSummaryCount:
					return "تعداد دفعات مشاهده";
				case GridStringId.FindControlFindButton:
					return "پیدا کردن";
				case GridStringId.FindControlClearButton:
					return "روشن";
				case GridStringId.SearchLookUpAddNewButton:
					return "افزودن جدید";
				case GridStringId.MenuFooterAddSummaryItem:
					return "خلاصه جدید اضافه کنید";
				case GridStringId.MenuFooterClearSummaryItems:
					return "پاک کردن موارد خلاصه";
				case GridStringId.MenuShowSplitItem:
					return "اسپلیت";
				case GridStringId.MenuHideSplitItem:
					return "حذف تقسیم بندی";
				case GridStringId.ServerRequestError:
					return "خطا هنگام پردازش درخواست سرور ({0}...)";
				case GridStringId.WindowWarningCaption:
					return "هشدار";
				case GridStringId.EditFormUpdateButton:
					return "به روز رسانی";
				case GridStringId.EditFormCancelButton:
					return "لغو";
				case GridStringId.EditFormCancelMessage:
					return "شما می خواهید به لغو ویرایش";
				case GridStringId.EditFormSaveMessage:
					return "داده های شما تغییر یافته است. آیا مایلید تغییرات را ذخیره کنید";
				case GridStringId.CheckboxSelectorColumnCaption:
					return "انتخاب";
				case GridStringId.FindNullPrompt:
					return "متن جستجو را وارد کنید...";
				case GridStringId.SearchForBand:
					return "جستجو برای گروه...";


				default:
					return base.GetLocalizedString(id);
			}
		}
	}
}
