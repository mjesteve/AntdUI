// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace AntdUI
{
    /// <summary>Associates a stable identifier and culture with an AntdUI language provider.</summary>
    public sealed class LanguageDefinition
    {
        readonly ReadOnlyCollection<string> aliases;

        public LanguageDefinition(string identifier, string cultureName, string nativeDisplayName,
            ILocalization provider, params string[] aliases)
        {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentException("The language identifier is required.", nameof(identifier));
            if (string.IsNullOrWhiteSpace(cultureName)) throw new ArgumentException("The culture name is required.", nameof(cultureName));
            if (string.IsNullOrWhiteSpace(nativeDisplayName)) throw new ArgumentException("The native display name is required.", nameof(nativeDisplayName));
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));

            Identifier = identifier.Trim();
            Culture = CultureInfo.ReadOnly(new CultureInfo(cultureName.Trim()));
            NativeDisplayName = nativeDisplayName.Trim();

            var normalizedAliases = new List<string>();
            var knownNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { Identifier };
            if (aliases != null)
            {
                foreach (var alias in aliases)
                {
                    if (string.IsNullOrWhiteSpace(alias)) throw new ArgumentException("Language aliases cannot be empty.", nameof(aliases));
                    var normalizedAlias = alias.Trim();
                    if (!knownNames.Add(normalizedAlias)) throw new ArgumentException("The language definition contains duplicate identifiers or aliases.", nameof(aliases));
                    normalizedAliases.Add(normalizedAlias);
                }
            }
            this.aliases = normalizedAliases.AsReadOnly();
        }

        public string Identifier { get; private set; }

        public CultureInfo Culture { get; private set; }

        public string NativeDisplayName { get; private set; }

        public ILocalization Provider { get; private set; }

        public ReadOnlyCollection<string> Aliases { get { return aliases; } }
    }
}
