// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System;

namespace Demo
{
    static class DemoLanguage
    {
        static readonly AntdUI.LanguageCatalog catalog = AntdUI.BuiltInLanguages.CreateCatalog();

        public static string Apply(string requestedIdentifier)
        {
            AntdUI.LanguageDefinition language;
            if (!catalog.TryGet(requestedIdentifier, out language))
            {
                language = requestedIdentifier.StartsWith("en", StringComparison.OrdinalIgnoreCase)
                    ? AntdUI.BuiltInLanguages.English
                    : AntdUI.BuiltInLanguages.SimplifiedChinese;
            }

            AntdUI.Localization.Provider = ReferenceEquals(language, AntdUI.BuiltInLanguages.English)
                ? new Localizer()
                : language.Provider;
            AntdUI.Localization.SetLanguage(language.Culture.Name);
            return language.Identifier;
        }
    }
}
