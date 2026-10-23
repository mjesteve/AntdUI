// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License
// Gitee: https://gitee.com/AntdUI/AntdUI
// GitHub: https://github.com/AntdUI/AntdUI
// GitCode: https://gitcode.com/AntdUI/AntdUI

namespace AntdUI
{
    /// <summary>
    /// Defines how a date picker formats and parses its value.
    /// </summary>
    public enum DatePickerFormatMode
    {
        /// <summary>
        /// Uses the explicit <see cref="DatePicker.Format"/> value.
        /// </summary>
        Custom = 0,
        /// <summary>
        /// Uses the active localization culture short date pattern.
        /// </summary>
        CultureDate = 1,
        /// <summary>
        /// Uses the active localization culture short date and short time patterns.
        /// </summary>
        CultureDateTime = 2,
    }
}
