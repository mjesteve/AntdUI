// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>Catalan (ca-ES) language pack for AntdUI's built-in ids.</summary>
    public static class Ca
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            ["OK"] = "Accepta",
            ["Cancel"] = "Cancel·la",
            ["Now"] = "Ara",
            ["ToDay"] = "Avui",
            ["NoData"] = "Sense dades",
            ["ItemsPerPage"] = "elem./pàg.",
            ["Filter"] = "Filtra",
            ["Filter.Search"] = "Cerca",
            ["All Files"] = "Tots els fitxers",
            ["Picture Files"] = "Fitxers d’imatge",
            ["Transfer.Source"] = "Llista d’origen",
            ["Transfer.Target"] = "Llista de destinació",
            ["YearFormat"] = "yyyy",
            ["MonthFormat"] = "MMM",
            ["Mon"] = "Dl",
            ["Tue"] = "Dt",
            ["Wed"] = "Dc",
            ["Thu"] = "Dj",
            ["Fri"] = "Dv",
            ["Sat"] = "Ds",
            ["Sun"] = "Dg",
            ["Copy"] = "Copia",
            ["Cut"] = "Retalla",
            ["Paste"] = "Enganxa",
            ["Undo"] = "Desfés",
            ["Redo"] = "Refés",
            ["SelectAll"] = "Selecciona-ho tot",
            ["Delete"] = "Suprimeix",
            ["Table.Summary.SUM"] = "Suma",
            ["Table.Summary.AVG"] = "Mitjana",
            ["Table.Summary.MIN"] = "Mínim",
            ["Table.Summary.MAX"] = "Màxim",
            ["Table.Summary.COUNT"] = "Recompte",
            ["Table.Summary.NONE"] = "Sense resum",
            ["Table.Summary.Mode"] = "Mode de fila seleccionada",
            ["Table.Summary.ModeALL"] = "Mode de totes les files",
            ["Filter.Equal"] = "Igual a",
            ["Filter.NotEqual"] = "Diferent de",
            ["Filter.Greater"] = "Més gran que (comença per…)",
            ["Filter.Less"] = "Més petit que (acaba en…)",
            ["Filter.Contain"] = "Conté",
            ["Filter.NotContain"] = "No conté",
            ["Filter.Blank"] = "(En blanc)",
            ["Filter.SelectAll"] = "(Selecciona-ho tot)",
            ["Filter.Clean"] = "Restableix",
            ["Filter.BoolTrue"] = "Sí",
            ["Filter.BoolFalse"] = "No",
            ["Preview.CopySuccess"] = "S’ha copiat correctament",
            ["Chat.TipDateFormat"] = "dd-MM-yyyy dddd HH:mm",
            ["Captcha.Success"] = "Verificació correcta",
            ["Captcha.Failed"] = "La verificació ha fallat",
            ["Captcha.DragHint"] = "Arrossega el control cap a la dreta per completar el trencaclosques",
            ["Chart.DefaultDatasetLabel"] = "Conjunt de dades",
            ["Chart.DataPointsSuffix"] = "punts de dades",
        };

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
