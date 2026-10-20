// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License
// Gitee: https://gitee.com/AntdUI/AntdUI
// GitHub: https://github.com/AntdUI/AntdUI
// GitCode: https://gitcode.com/AntdUI/AntdUI

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>
    /// English (en-US) language pack for AntdUI's built-in ids.
    /// Usage: AntdUI.Localization.Provider = AntdUI.LanguagePacks.EnUs.Instance;
    /// </summary>
    public static class EnUs
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            ["OK"] = "OK",
            ["Cancel"] = "Cancel",
            ["Now"] = "Now",
            ["ToDay"] = "Today",
            ["NoData"] = "No data",
            ["ItemsPerPage"] = "items/page",
            ["Filter"] = "Filter",
            ["Filter.Search"] = "Search",
            ["All Files"] = "All Files",
            ["Picture Files"] = "Picture Files",
            ["Transfer.Source"] = "Source List",
            ["Transfer.Target"] = "Target List",
            ["YearFormat"] = "yyyy",
            ["MonthFormat"] = "MMM",
            ["Mon"] = "Mon",
            ["Tue"] = "Tue",
            ["Wed"] = "Wed",
            ["Thu"] = "Thu",
            ["Fri"] = "Fri",
            ["Sat"] = "Sat",
            ["Sun"] = "Sun",
            ["Copy"] = "Copy",
            ["Cut"] = "Cut",
            ["Paste"] = "Paste",
            ["Undo"] = "Undo",
            ["Redo"] = "Redo",
            ["SelectAll"] = "Select All",
            ["Delete"] = "Delete",
            ["Table.Summary.SUM"] = "Sum",
            ["Table.Summary.AVG"] = "Average",
            ["Table.Summary.MIN"] = "Min",
            ["Table.Summary.MAX"] = "Max",
            ["Table.Summary.COUNT"] = "Count",
            ["Table.Summary.NONE"] = "No Summary",
            ["Table.Summary.Mode"] = "Selected Row Mode",
            ["Table.Summary.ModeALL"] = "All Rows Mode",
            ["Filter.Equal"] = "Equal",
            ["Filter.NotEqual"] = "Not Equal",
            ["Filter.Greater"] = "Greater (starts with...)",
            ["Filter.Less"] = "Less (ends with...)",
            ["Filter.Contain"] = "Contains",
            ["Filter.NotContain"] = "Does Not Contain",
            ["Filter.Blank"] = "(Blank)",
            ["Filter.SelectAll"] = "(Select All)",
            ["Filter.Clean"] = "Reset",
            ["Filter.BoolTrue"] = "Yes",
            ["Filter.BoolFalse"] = "No",
            ["Preview.CopySuccess"] = "Copied successfully",
            ["Chat.TipDateFormat"] = "MM-dd-yyyy dddd hh:mm tt",
            ["Captcha.Success"] = "Verification succeeded",
            ["Captcha.Failed"] = "Verification failed",
            ["Captcha.DragHint"] = "Drag the slider to the right to complete the puzzle",
            ["Chart.DefaultDatasetLabel"] = "Dataset",
            ["Chart.DataPointsSuffix"] = "data points",
        };

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
