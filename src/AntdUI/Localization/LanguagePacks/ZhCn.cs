// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License
// Gitee: https://gitee.com/AntdUI/AntdUI
// GitHub: https://github.com/AntdUI/AntdUI
// GitCode: https://gitcode.com/AntdUI/AntdUI

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>
    /// Simplified Chinese (zh-CN) language pack for AntdUI's built-in localization identifiers.
    /// AntdUI uses Simplified Chinese as its native fallback; this explicit provider allows
    /// applications to select it in the same way as the other language packs.
    /// </summary>
    public static class ZhCn
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            ["OK"] = "确定",
            ["Cancel"] = "取消",
            ["Now"] = "此刻",
            ["ToDay"] = "今天",
            ["NoData"] = "暂无数据",
            ["ItemsPerPage"] = "条/页",
            ["Filter"] = "筛选",
            ["Filter.Search"] = "搜索",
            ["All Files"] = "所有文件",
            ["Picture Files"] = "图片文件",
            ["Transfer.Source"] = "源列表",
            ["Transfer.Target"] = "目标列表",
            ["YearFormat"] = "yyyy年",
            ["MonthFormat"] = "MM月",
            ["Mon"] = "一",
            ["Tue"] = "二",
            ["Wed"] = "三",
            ["Thu"] = "四",
            ["Fri"] = "五",
            ["Sat"] = "六",
            ["Sun"] = "日",
            ["Copy"] = "复制",
            ["Cut"] = "剪切",
            ["Paste"] = "粘贴",
            ["Undo"] = "撤销",
            ["Redo"] = "重做",
            ["SelectAll"] = "全选",
            ["Delete"] = "删除",
            ["Table.Summary.SUM"] = "总和",
            ["Table.Summary.AVG"] = "平均",
            ["Table.Summary.MIN"] = "最小",
            ["Table.Summary.MAX"] = "最大",
            ["Table.Summary.COUNT"] = "计数",
            ["Table.Summary.NONE"] = "不汇总",
            ["Table.Summary.Mode"] = "选择行模式",
            ["Table.Summary.ModeALL"] = "所有行模式",
            ["Filter.Equal"] = "等于",
            ["Filter.NotEqual"] = "不等于",
            ["Filter.Greater"] = "大于 (以...开头)",
            ["Filter.Less"] = "小于 (以...结尾)",
            ["Filter.Contain"] = "存在",
            ["Filter.NotContain"] = "不存在",
            ["Filter.Blank"] = "(空白)",
            ["Filter.SelectAll"] = "(全选)",
            ["Filter.Clean"] = "重置",
            ["Filter.BoolTrue"] = "是",
            ["Filter.BoolFalse"] = "否",
            ["Preview.CopySuccess"] = "复制成功",
            ["Chat.TipDateFormat"] = "yyyy年M月d日 dddd HH:mm",
            ["Captcha.Success"] = "验证成功",
            ["Captcha.Failed"] = "验证失败",
            ["Captcha.DragHint"] = "向右拖动滑块填充拼图",
            ["Chart.DefaultDatasetLabel"] = "数据集",
            ["Chart.DataPointsSuffix"] = "个数据点",
        };

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
