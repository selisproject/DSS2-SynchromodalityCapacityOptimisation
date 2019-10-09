using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zAppDev.DotNet.Framework.Web.UI
{
    public class WebFormResources
    {
        public static bool ClearResources = false;
		
		public static Object GetResources(String type)
        {
			ClearResources = false;
		 
			switch (type.ToLower())
            {
                case "generic":
                    return new WebFormResourcesGeneric();
                case "picklist":
                    return new WebFormResourcesPicklist();
                case "validation":
                    return new WebFormResourcesValidation();
                case "listcontrol":
                    return new WebFormResourcesListControl();
                default:
                    return null;
            }
        }
    }

    public class WebFormResourcesGeneric
    {
        public string OKText;
        public string CancelText;
        public string ExitText;
        public string ProgressTitle;
        public string ProgressDescription;
        public string RequiredFieldsLegend;
        public string DirtyFormMessage;
        public string ExitDescription;
        public string ExitConfirmation;

        public WebFormResourcesGeneric()
        {
            OKText = (string)HttpContext.GetGlobalResourceObject("SiteResources", "RES_SITE_PREFS_OKButtonText");
            CancelText = (string)HttpContext.GetGlobalResourceObject("SiteResources", "RES_SITE_PREFS_CancelButtonText");
            ExitText = (string)HttpContext.GetGlobalResourceObject("SiteResources", "RES_SITE_Exit");
            ExitDescription = (string)HttpContext.GetGlobalResourceObject("SiteResources", "RES_SITE_ExitConfirmationMessage");
            ExitConfirmation = (string)HttpContext.GetGlobalResourceObject("SiteResources", "RES_SITE_ExitConfirmation");
            ProgressTitle = (string)HttpContext.GetGlobalResourceObject("SiteResources", "RES_SITE_ProgressText");
            ProgressDescription = (string)HttpContext.GetGlobalResourceObject("SiteResources", "RES_SITE_ProgressDescription");
            RequiredFieldsLegend = (string)HttpContext.GetGlobalResourceObject("Webforms", "RES_WEBFORM_REQUIRED_Legend");
            DirtyFormMessage = (string)HttpContext.GetGlobalResourceObject("Webforms", "RES_WEBFORM_DirtyMessage");
        }
    }

    public class WebFormResourcesPicklist
    {
        public string FilterListText;
        public string ColumnText;
        public string ApplyFilterText;
        public string RemoveFilterText;
        public string ShowRowsText;
        public string ofPagesText;
        public string FirstPageText;
        public string PreviousPageText;
        public string NextPageText;
        public string LastPageText;
        public string ClicktoCheckAllText;
        public string ClicktoUnCheckAllText;
        public string ClicktoSortbyText;
        public string OrderBydescText;
        public string OrderByascText;
        public string CloseText;
        public string MaximizeText;
        public string RestoreDownText;
        public string ClearSelectedText;
        public string SelectText;
        public string PageText;
        public string NoRecordsFoundText;
        public string TotalRecordsCountText;
        public string SelectedRecordsCountText;
        public string SelectAllRecordsPromptText;
        public string ClearSelectedRecordsText;
        public string Search;

        public WebFormResourcesPicklist()
        {
            FilterListText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_FilterList");
            ColumnText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_Column");
            ApplyFilterText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_ApplyFilter");
            RemoveFilterText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_RemoveFilter");
            ShowRowsText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_ShowRows");
            ofPagesText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_ofPages");
            FirstPageText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_FirstPage");
            PreviousPageText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_PreviousPage");
            NextPageText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_NextPage");
            LastPageText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_LastPage");
            ClicktoCheckAllText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_ClicktoCheckAll");
            ClicktoUnCheckAllText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_ClicktoUnCheckAll");
            ClicktoSortbyText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_ClicktoSortby");
            OrderBydescText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_OrderBydesc");
            OrderByascText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_OrderByasc");
            CloseText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_Close");
            MaximizeText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_Maximize");
            RestoreDownText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_RestoreDown");
            ClearSelectedText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_ClearSelected");
            SelectText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_Select");
            PageText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_Page");
            NoRecordsFoundText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_NoRecordsFound");
            TotalRecordsCountText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_TotalRecordsCount");
            SelectedRecordsCountText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_SelectedRecordsCount");
            SelectAllRecordsPromptText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_SelectAllRecordsPrompt");
            ClearSelectedRecordsText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_ClearSelectedRecordsPrompt");
            Search = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_Search");
        }
    }

    public class WebFormResourcesValidation
    {
        public string validationMessages;
        public string information;
        public string warning;
        public string error;
        public string ignore;
        public string ignoreAll;
        public string showIgnoredWarnings;
        public string requireYourAttention;
        public string proceed;
        public string cancel;

        public WebFormResourcesValidation()
        {
            validationMessages = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_Messages");
            information = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_Information");
            warning = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_Warning");
            error = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_Error");
            ignore = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_Ignore");
            ignoreAll = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_IgnoreAll");
            showIgnoredWarnings = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_ShowIgnoredWarnings");
            requireYourAttention = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_RequireYourAttention");
            proceed = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_Proceed");
            cancel = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_WEBFORM_VALIDATIONS_Cancel");
        }
    }

    public class WebFormResourcesListControl
    {
        public string NoResults;
        public string NextPage;
        public string PreviousPage;
        public string Ok;
        public string Cancel;
        public string AddFilter;
        public string FiltersPopUpTitle;
        public string NoFiltersDefined;
        public string Column;
        public string Operator;
        public string Criteria;
        public string RowOperator;
        public string Or;
        public string And;
        public string Range;
        public string Like;
        public string EqualTo;
        public string NotEqualTo;
        public string GreaterThan;
        public string GreaterThanOrEqualTo;
        public string LessThan;
        public string LessThanOrEqualTo;
        public string Order;
        public string Visible;
        public string Sorting;
        public string SortOrder;
        public string Rearrange;
        public string PreferencesPopUpTitle;
        public string Search;
        public string ShowQuickFilters;
        public string HideQuickFilters;
        public string Of;
        public string Items;
        public string PerPage;
        public string Pages;
        public string PredefinedView;
        public string ResetTooltip;
        public string ResetConfirmation;
        public string RefreshTooltip;
        public string PreferencesTooltip;
        public string FiltersTooltip;
        public string SaveCurrentView;
        public string OverwriteCurrentView;
        public string DeleteCurrentView;
        public string DeleteCurrentViewCommand;
        public string DeleteCurrentViewConfirmation;
        public string SaveCurrentViewNameAlert;
        public string ViewName;
        public string IsDefault;
        public string MakeDefault;
        public string MakeDefaultConfirmation;
        public string PrevPageTooltip;
        public string NextPageTooltip;
        public string Ascending;
        public string Descending;
        public string FiltersApplied;
        public string GrandTotal;
        public string PageTotal;
        public string GrandAverage;
        public string PageAverage;
        public string GrandCount;
        public string PageCount;
        public string GroupingOrder;
        public string Page;
        public string Export;
        public string MoveColumnLeft;
        public string MoveColumnRight;
        public string SortASC;
        public string SortDESC;
        public string Unsort;
        public string FirstPageTooltip;
        public string LastPageTooltip;
        public string HasValue;
        public string HasNoValue;
        public string CalculateSum;
        public string CalculateAverage;
        public string CalculateCount;
        public string CommonActions;
        public string True;
        public string False;
        public string Apply;
        public string ClearAll;
        public string ApplyQuickFilter;
        public string ClearQuickFilter;
        public string ExportType;
        public string ExportRange;
        public string ExportRangeCurrent;
        public string ExportRange100;
        public string ExportRangeAll;
        public string ExportOnlyGroups;
        public string RequiredFiltersMissingTitle;
        public string RequiredFiltersMissingMessage;
        public string SubGroups;
        public string PortraitOrientation;
        public string SumHeader;
        public string AverageHeader;
        public string VisibleExport;
        public string ColumnExport;
        public string IncludeGridLines;
        public string FileName;
        public string DisplayColumns;
        public string HeaderColor;
        public string OddColor;
        public string EvenColor;
        public string GroupColor;
        public string AggregateColor;
        public string CountHeader;
        public string TotalNonGroupCount;
        public string GetGroupsClosed;
        public string PrevStateTooltip;
        public string DisplayGroupItems;
        public string ClearAggregators;
        public string DownloadCsv;
        public string UploadCsv;
        public string Import;
        public string ImportResults;
        public string ImportedRecords;        
        public string FailedRecords;
        public string ErrorDetails;
        public string RowNumber;
        public string ErrorDescription;
        public string ErrorMessage;
        public string PreferedEncoding;
        public string SelectAllRecordsPromptText;

        public WebFormResourcesListControl()
        {
            NextPage = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGER_NextPage");
            PreviousPage = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGER_PreviousPage");
            Ok = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_Ok");
            Cancel = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_Cancel");
            AddFilter = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_AddFilter");
            FiltersPopUpTitle = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_DialogTitle");
            NoFiltersDefined = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_NoFilterDefined");
            Column = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Column_Header");
            Operator = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_Header");
            Criteria = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_FilterValue_Header");
            RowOperator = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_RowOperator_Header");
            Or = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_RowOperatorTypes_Or");
            And = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_RowOperatorTypes_And");
            Range = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_Range");
            EqualTo = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_EqualTo");
            Like = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_Like");
            NotEqualTo = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_NotEqualTo");
            GreaterThan = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_GreaterThan");
            GreaterThanOrEqualTo = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_GreaterThanOrEqualTo");
            LessThan = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_LessThan");
            LessThanOrEqualTo = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_LessThanOrEqualTo");
            Order = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PREFERENCES_Order");
            Visible = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PREFERENCES_Visible");
            Sorting = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PREFERENCES_Sorting");
            SortOrder = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PREFERENCES_SortOrder");
            PreferencesPopUpTitle = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PREFERENCES_DialogTitle");
            Rearrange = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PREFERENCES_Rearrange");
            Search = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_Search");
            ShowQuickFilters = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_ShowQuickFilters");
            HideQuickFilters = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_HideQuickFilters");
            Of = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGER_Of");
            Items = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGER_Items");
            PerPage = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGER_PerPage");
            Pages = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGE_Pages");
            PredefinedView = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_PredefinedView");
            ResetTooltip = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_RefreshResetButtonTooltip");
            ResetConfirmation = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_ResetConfrmation");
            RefreshTooltip = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_RefreshButtonTooltip");
            PreferencesTooltip = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_PreferencesButtonTooltip");
            FiltersTooltip = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_FilterButtonTooltip");
            SaveCurrentView = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_Save");
            OverwriteCurrentView = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_Overwrite");
            DeleteCurrentView = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_Remove");
            DeleteCurrentViewCommand = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_Delete");
            DeleteCurrentViewConfirmation = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_RemovePrompt");
            SaveCurrentViewNameAlert = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_NameAlert");
            ViewName = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_Name");
            IsDefault = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_IsDefault");
            MakeDefault = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_MakeDefault");
            MakeDefaultConfirmation = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_VIEWS_MakeDefaultConfirmation");
            PrevPageTooltip = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGER_PreviousPage");
            NextPageTooltip = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGER_NextPage");
            NoResults = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LISTFORM_NORESULTS_NoResults");
            Ascending = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PREFERENCES_SortingType_ASC");
            Descending = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PREFERENCES_SortingType_DESC");
            FiltersApplied = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LISTFORM_FiltersApplied");
            GrandTotal = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_GrandTotal");
            PageTotal = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_PageTotal");
            GrandAverage = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_GrandAverage");
            PageAverage = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_PageAverage");
            GrandCount = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_GrandCount");
            PageCount = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_PageCount");
            GroupingOrder = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_GroupingOrder");
            Page = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_Page");
            Export = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_ExportOK");
            MoveColumnLeft = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_MoveColumnLeft_Tooltip");
            MoveColumnRight = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_MoveColumnRight_Tooltip");
            SortASC = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_SortASC_Tooltip");
            SortDESC = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_SortDESC_Tooltip");
            Unsort = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_UnSort_Tooltip");
            FirstPageTooltip = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGER_FirstPage");
            LastPageTooltip = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_PAGER_LastPage");
            HasNoValue = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_HasNoValue");
            HasValue = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Operators_HasValue");
            CalculateCount = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_CalculateCount");
            CalculateSum = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_CalculateSum");
            CalculateAverage = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_CalculateAverage");
            CommonActions = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_TOOLBAR_CommonActions");
            True = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_True");
            False = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_False");
            Apply = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_Apply");
            ClearAll = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_ClearAll");
            ApplyQuickFilter = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_ApplyQuickFilter");
            ClearQuickFilter = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_FILTERS_ClearQuickFilter");
            ExportType = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_ExportTo");
            ExportRange = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_PrintRange");
            ExportRangeCurrent = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_ExportRange_CurrentPage");
            ExportRange100 = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_ExportRange_Top100Pages");
            ExportRangeAll = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_ExportRange_AllPages");
            ExportOnlyGroups = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_ExportOnlyGroups");
            RequiredFiltersMissingMessage = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_RequiredFiltersMissingMessage");
            RequiredFiltersMissingTitle = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_RequiredFiltersMissingTitle");
            SubGroups = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LISTFORM_SubGroups");
            VisibleExport = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_Visible");
            ColumnExport = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_Column");
            SumHeader = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_SumHeader");
            AverageHeader = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_AverageHeader");
            PortraitOrientation = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_PortraitOrientation");
            IncludeGridLines = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_IncludeGridLines");
            FileName = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_Filename");
            DisplayColumns = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_DisplayColumns");
            HeaderColor = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_HeaderColor");
            OddColor = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_OddColor");
            EvenColor = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_EvenColor");
            GroupColor = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_GroupColor");
            AggregateColor = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_AggregateColor");
            CountHeader = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_CountHeader");
            TotalNonGroupCount = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_EXPORT_TotalNonGroupCount");
            GetGroupsClosed = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LISTFORM_GetGroupsClosed");
            PrevStateTooltip = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LISTFORM_PrevStateTooltip");
            DisplayGroupItems = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LISTFORM_DisplayGroupItems");
            ClearAggregators = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_AGGREGATORS_ClearAll");
            DownloadCsv = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_DownloadCsv");
            UploadCsv = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_UploadCsv");
            Import = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_Import");
            PreferedEncoding = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_PreferedEncoding");
            ImportResults = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_ImportResults");
            ImportedRecords = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_ImportedRecords");
            FailedRecords = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_FailedRecords");
            ErrorDetails = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_ErrorDetails");
            RowNumber = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_RowNumber");
            ErrorDescription = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_ErrorDescription");
            ErrorMessage = (string)HttpContext.GetGlobalResourceObject("ListForms", "RES_LIST_Import_ErrorMessage");
            SelectAllRecordsPromptText = (string)HttpContext.GetGlobalResourceObject("WebForms", "RES_PICKLIST_SelectAllRecordsPrompt");
        }
    }

}

namespace zAppDev.DotNet.Framework.Mvc.UI.Helper
{
    public class Routes
    {
        public static Dictionary<string, string> GetRouteData()
        {
            var result = new Dictionary<string, string>();

            var keys = HttpContext.Current?.Request?.RequestContext?.RouteData?.Values.Keys;
            if (keys != null)
            {
                foreach (var key in keys)
                {
                    var value = HttpContext.Current?.Request?.RequestContext?.RouteData?.Values[key];
                    result.Add(key, value?.ToString());
                }
            }

            return result;
        }
    }

    public class HtmlAttribute : IHtmlString
    {
        public string Name { get; }
        public string Value { get; }

        public HtmlAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string ToHtmlString()
        {
            return $"{Name}=\"{Value}\"";
        }
    }
    public static class RulesHelper
    {
        public static HtmlAttribute Attribute(string name, string value)
        {
            return new HtmlAttribute(name, value);
        }
    }
}