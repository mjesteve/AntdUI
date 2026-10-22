// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System.Collections.Generic;
using System.Collections.ObjectModel;
using AntdUI.LanguagePacks;

namespace AntdUI
{
    /// <summary>Languages provided by AntdUI and their internal text providers.</summary>
    public static class BuiltInLanguages
    {
        public static readonly LanguageDefinition Spanish = new LanguageDefinition("es-ES", "es-ES", "Castellano", Es.Instance, "es", "esp");
        public static readonly LanguageDefinition English = new LanguageDefinition("en-US", "en-US", "English", EnUs.Instance, "en", "eng");
        public static readonly LanguageDefinition French = new LanguageDefinition("fr-FR", "fr-FR", "Français", Fr.Instance, "fr", "fra");
        public static readonly LanguageDefinition Galician = new LanguageDefinition("gl-ES", "gl-ES", "Galego", Gl.Instance, "gl", "gal");
        public static readonly LanguageDefinition Basque = new LanguageDefinition("eu-ES", "eu-ES", "Euskara", Eu.Instance, "eu", "eus");
        public static readonly LanguageDefinition Portuguese = new LanguageDefinition("pt-PT", "pt-PT", "Português", PtPt.Instance, "pt", "por");
        public static readonly LanguageDefinition Italian = new LanguageDefinition("it-IT", "it-IT", "Italiano", It.Instance, "it", "ita");
        public static readonly LanguageDefinition Catalan = new LanguageDefinition("ca-ES", "ca-ES", "Català", Ca.Instance, "ca", "cat");
        public static readonly LanguageDefinition Valencian = new LanguageDefinition("ca-ES-valencia", "ca-ES-valencia", "Valencià", CaEsValencia.Instance, "val");
        public static readonly LanguageDefinition SimplifiedChinese = new LanguageDefinition("zh-CN", "zh-CN", "简体中文", ZhCn.Instance, "zh", "zh-Hans", "zho");

        static readonly ReadOnlyCollection<LanguageDefinition> all = new List<LanguageDefinition>
        {
            Spanish, English, French, Galician, Basque, Portuguese, Italian, Catalan, Valencian, SimplifiedChinese
        }.AsReadOnly();

        public static ReadOnlyCollection<LanguageDefinition> All { get { return all; } }

        public static LanguageCatalog CreateCatalog()
        {
            var catalog = new LanguageCatalog();
            foreach (var language in all) catalog.Register(language);
            return catalog;
        }
    }
}
