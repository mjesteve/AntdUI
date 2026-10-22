// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>French (fr-FR) language pack for AntdUI's built-in ids.</summary>
    public static class Fr
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            ["OK"] = "Accepter",
            ["Cancel"] = "Annuler",
            ["Now"] = "Maintenant",
            ["ToDay"] = "Aujourd’hui",
            ["NoData"] = "Aucune donnée",
            ["ItemsPerPage"] = "éléments/page",
            ["Filter"] = "Filtrer",
            ["Filter.Search"] = "Rechercher",
            ["All Files"] = "Tous les fichiers",
            ["Picture Files"] = "Fichiers image",
            ["Transfer.Source"] = "Liste source",
            ["Transfer.Target"] = "Liste cible",
            ["YearFormat"] = "yyyy",
            ["MonthFormat"] = "MMM",
            ["Mon"] = "Lun",
            ["Tue"] = "Mar",
            ["Wed"] = "Mer",
            ["Thu"] = "Jeu",
            ["Fri"] = "Ven",
            ["Sat"] = "Sam",
            ["Sun"] = "Dim",
            ["Copy"] = "Copier",
            ["Cut"] = "Couper",
            ["Paste"] = "Coller",
            ["Undo"] = "Annuler",
            ["Redo"] = "Rétablir",
            ["SelectAll"] = "Tout sélectionner",
            ["Delete"] = "Supprimer",
            ["Table.Summary.SUM"] = "Somme",
            ["Table.Summary.AVG"] = "Moyenne",
            ["Table.Summary.MIN"] = "Minimum",
            ["Table.Summary.MAX"] = "Maximum",
            ["Table.Summary.COUNT"] = "Nombre",
            ["Table.Summary.NONE"] = "Aucun résumé",
            ["Table.Summary.Mode"] = "Mode ligne sélectionnée",
            ["Table.Summary.ModeALL"] = "Mode toutes les lignes",
            ["Filter.Equal"] = "Égal à",
            ["Filter.NotEqual"] = "Différent de",
            ["Filter.Greater"] = "Supérieur à (commence par…)",
            ["Filter.Less"] = "Inférieur à (se termine par…)",
            ["Filter.Contain"] = "Contient",
            ["Filter.NotContain"] = "Ne contient pas",
            ["Filter.Blank"] = "(Vide)",
            ["Filter.SelectAll"] = "(Tout sélectionner)",
            ["Filter.Clean"] = "Réinitialiser",
            ["Filter.BoolTrue"] = "Oui",
            ["Filter.BoolFalse"] = "Non",
            ["Preview.CopySuccess"] = "Copie réussie",
            ["Chat.TipDateFormat"] = "dd-MM-yyyy dddd HH:mm",
            ["Captcha.Success"] = "Vérification réussie",
            ["Captcha.Failed"] = "Échec de la vérification",
            ["Captcha.DragHint"] = "Faites glisser le curseur vers la droite pour terminer le puzzle",
            ["Chart.DefaultDatasetLabel"] = "Jeu de données",
            ["Chart.DataPointsSuffix"] = "points de données",
        };

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
