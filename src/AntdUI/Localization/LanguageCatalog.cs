// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System;
using System.Collections.Generic;
using System.Globalization;

namespace AntdUI
{
    /// <summary>Registers language definitions and resolves their identifiers and aliases.</summary>
    public sealed class LanguageCatalog
    {
        readonly Dictionary<string, LanguageDefinition> definitions = new Dictionary<string, LanguageDefinition>(StringComparer.OrdinalIgnoreCase);

        public void Register(LanguageDefinition definition)
        {
            if (definition == null) throw new ArgumentNullException(nameof(definition));

            var names = new List<string> { definition.Identifier };
            names.AddRange(definition.Aliases);
            foreach (var name in names)
            {
                if (definitions.ContainsKey(name)) throw new ArgumentException(string.Format(CultureInfo.InvariantCulture,
                    "The language identifier or alias '{0}' is already registered.", name), nameof(definition));
            }
            foreach (var name in names) definitions.Add(name, definition);
        }

        public bool TryGet(string? identifier, out LanguageDefinition? definition)
        {
            definition = null;
            if (identifier == null) return false;
            string normalizedIdentifier = identifier.Trim();
            return normalizedIdentifier.Length > 0 && definitions.TryGetValue(normalizedIdentifier, out definition);
        }
    }
}
