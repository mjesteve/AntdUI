// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>Italian (it-IT) language pack for AntdUI's built-in ids.</summary>
    public static class It
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            ["OK"] = "Accetta",
            ["Cancel"] = "Annulla",
            ["Now"] = "Adesso",
            ["ToDay"] = "Oggi",
            ["NoData"] = "Nessun dato",
            ["ItemsPerPage"] = "elementi/pagina",
            ["Filter"] = "Filtra",
            ["Filter.Search"] = "Cerca",
            ["All Files"] = "Tutti i file",
            ["Picture Files"] = "File immagine",
            ["Transfer.Source"] = "Elenco origine",
            ["Transfer.Target"] = "Elenco destinazione",
            ["YearFormat"] = "yyyy",
            ["MonthFormat"] = "MMM",
            ["Mon"] = "Lun",
            ["Tue"] = "Mar",
            ["Wed"] = "Mer",
            ["Thu"] = "Gio",
            ["Fri"] = "Ven",
            ["Sat"] = "Sab",
            ["Sun"] = "Dom",
            ["Copy"] = "Copia",
            ["Cut"] = "Taglia",
            ["Paste"] = "Incolla",
            ["Undo"] = "Annulla",
            ["Redo"] = "Ripristina",
            ["SelectAll"] = "Seleziona tutto",
            ["Delete"] = "Elimina",
            ["Table.Summary.SUM"] = "Somma",
            ["Table.Summary.AVG"] = "Media",
            ["Table.Summary.MIN"] = "Minimo",
            ["Table.Summary.MAX"] = "Massimo",
            ["Table.Summary.COUNT"] = "Conteggio",
            ["Table.Summary.NONE"] = "Nessun riepilogo",
            ["Table.Summary.Mode"] = "Modalità riga selezionata",
            ["Table.Summary.ModeALL"] = "Modalità tutte le righe",
            ["Filter.Equal"] = "Uguale a",
            ["Filter.NotEqual"] = "Diverso da",
            ["Filter.Greater"] = "Maggiore di (inizia con…)",
            ["Filter.Less"] = "Minore di (termina con…)",
            ["Filter.Contain"] = "Contiene",
            ["Filter.NotContain"] = "Non contiene",
            ["Filter.Blank"] = "(Vuoto)",
            ["Filter.SelectAll"] = "(Seleziona tutto)",
            ["Filter.Clean"] = "Reimposta",
            ["Filter.BoolTrue"] = "Sì",
            ["Filter.BoolFalse"] = "No",
            ["Preview.CopySuccess"] = "Copia completata",
            ["Chat.TipDateFormat"] = "dd-MM-yyyy dddd HH:mm",
            ["Captcha.Success"] = "Verifica riuscita",
            ["Captcha.Failed"] = "Verifica non riuscita",
            ["Captcha.DragHint"] = "Trascina il cursore verso destra per completare il puzzle",
            ["Chart.DefaultDatasetLabel"] = "Set di dati",
            ["Chart.DataPointsSuffix"] = "punti dati",
        };

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
