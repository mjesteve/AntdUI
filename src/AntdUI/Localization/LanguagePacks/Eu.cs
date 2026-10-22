// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>Basque (eu-ES) language pack for AntdUI's built-in ids.</summary>
    public static class Eu
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            ["OK"] = "Onartu",
            ["Cancel"] = "Utzi",
            ["Now"] = "Orain",
            ["ToDay"] = "Gaur",
            ["NoData"] = "Daturik ez",
            ["ItemsPerPage"] = "elementu/orri",
            ["Filter"] = "Iragazi",
            ["Filter.Search"] = "Bilatu",
            ["All Files"] = "Fitxategi guztiak",
            ["Picture Files"] = "Irudi-fitxategiak",
            ["Transfer.Source"] = "Jatorri-zerrenda",
            ["Transfer.Target"] = "Helburu-zerrenda",
            ["YearFormat"] = "yyyy",
            ["MonthFormat"] = "MMM",
            ["Mon"] = "Al",
            ["Tue"] = "Ar",
            ["Wed"] = "Az",
            ["Thu"] = "Og",
            ["Fri"] = "Or",
            ["Sat"] = "Lr",
            ["Sun"] = "Ig",
            ["Copy"] = "Kopiatu",
            ["Cut"] = "Ebaki",
            ["Paste"] = "Itsatsi",
            ["Undo"] = "Desegin",
            ["Redo"] = "Berregin",
            ["SelectAll"] = "Hautatu dena",
            ["Delete"] = "Ezabatu",
            ["Table.Summary.SUM"] = "Batura",
            ["Table.Summary.AVG"] = "Batez bestekoa",
            ["Table.Summary.MIN"] = "Minimoa",
            ["Table.Summary.MAX"] = "Maximoa",
            ["Table.Summary.COUNT"] = "Kopurua",
            ["Table.Summary.NONE"] = "Laburpenik ez",
            ["Table.Summary.Mode"] = "Hautatutako errenkadaren modua",
            ["Table.Summary.ModeALL"] = "Errenkada guztien modua",
            ["Filter.Equal"] = "Berdina",
            ["Filter.NotEqual"] = "Ezberdina",
            ["Filter.Greater"] = "Handiagoa (honekin hasten da…)",
            ["Filter.Less"] = "Txikiagoa (honekin amaitzen da…)",
            ["Filter.Contain"] = "Dauka",
            ["Filter.NotContain"] = "Ez dauka",
            ["Filter.Blank"] = "(Hutsik)",
            ["Filter.SelectAll"] = "(Hautatu dena)",
            ["Filter.Clean"] = "Berrezarri",
            ["Filter.BoolTrue"] = "Bai",
            ["Filter.BoolFalse"] = "Ez",
            ["Preview.CopySuccess"] = "Ondo kopiatu da",
            ["Chat.TipDateFormat"] = "dd-MM-yyyy dddd HH:mm",
            ["Captcha.Success"] = "Egiaztapena zuzena",
            ["Captcha.Failed"] = "Egiaztapenak huts egin du",
            ["Captcha.DragHint"] = "Arrastatu graduatzailea eskuinera puzzlea osatzeko",
            ["Chart.DefaultDatasetLabel"] = "Datu-multzoa",
            ["Chart.DataPointsSuffix"] = "datu-puntu",
        };

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
