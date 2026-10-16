// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License
// Gitee: https://gitee.com/AntdUI/AntdUI
// GitHub: https://github.com/AntdUI/AntdUI
// GitCode: https://gitcode.com/AntdUI/AntdUI

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>
    /// ILocalization provider backed by a plain id -> text dictionary.
    /// Use this to plug a language pack (e.g. <see cref="Es"/>, <see cref="EnUs"/>)
    /// into <see cref="Localization.Provider"/>.
    /// </summary>
    public class DictionaryLocalization : ILocalization
    {
        readonly IDictionary<string, string> map;

        public DictionaryLocalization(IDictionary<string, string> map)
        {
            this.map = map;
        }

        public string? GetLocalizedString(string key)
        {
            return map.TryGetValue(key, out var value) ? value : null;
        }
    }
}
