// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>Galician (gl-ES) language pack for AntdUI's built-in ids.</summary>
    public static class Gl
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            ["OK"] = "Aceptar",
            ["Cancel"] = "Cancelar",
            ["Now"] = "Agora",
            ["ToDay"] = "Hoxe",
            ["NoData"] = "Sen datos",
            ["ItemsPerPage"] = "elem./páx.",
            ["Filter"] = "Filtrar",
            ["Filter.Search"] = "Buscar",
            ["All Files"] = "Todos os ficheiros",
            ["Picture Files"] = "Ficheiros de imaxe",
            ["Transfer.Source"] = "Lista de orixe",
            ["Transfer.Target"] = "Lista de destino",
            ["YearFormat"] = "yyyy",
            ["MonthFormat"] = "MMM",
            ["Mon"] = "Lun",
            ["Tue"] = "Mar",
            ["Wed"] = "Mér",
            ["Thu"] = "Xov",
            ["Fri"] = "Ven",
            ["Sat"] = "Sáb",
            ["Sun"] = "Dom",
            ["Copy"] = "Copiar",
            ["Cut"] = "Cortar",
            ["Paste"] = "Pegar",
            ["Undo"] = "Desfacer",
            ["Redo"] = "Refacer",
            ["SelectAll"] = "Seleccionar todo",
            ["Delete"] = "Eliminar",
            ["Table.Summary.SUM"] = "Suma",
            ["Table.Summary.AVG"] = "Media",
            ["Table.Summary.MIN"] = "Mínimo",
            ["Table.Summary.MAX"] = "Máximo",
            ["Table.Summary.COUNT"] = "Contar",
            ["Table.Summary.NONE"] = "Sen resumo",
            ["Table.Summary.Mode"] = "Modo de fila seleccionada",
            ["Table.Summary.ModeALL"] = "Modo de todas as filas",
            ["Filter.Equal"] = "Igual a",
            ["Filter.NotEqual"] = "Distinto de",
            ["Filter.Greater"] = "Maior ca (comeza por…)",
            ["Filter.Less"] = "Menor ca (remata en…)",
            ["Filter.Contain"] = "Contén",
            ["Filter.NotContain"] = "Non contén",
            ["Filter.Blank"] = "(En branco)",
            ["Filter.SelectAll"] = "(Seleccionar todo)",
            ["Filter.Clean"] = "Restablecer",
            ["Filter.BoolTrue"] = "Si",
            ["Filter.BoolFalse"] = "Non",
            ["Preview.CopySuccess"] = "Copiado correctamente",
            ["Chat.TipDateFormat"] = "dd-MM-yyyy dddd HH:mm",
            ["Captcha.Success"] = "Verificación correcta",
            ["Captcha.Failed"] = "Fallou a verificación",
            ["Captcha.DragHint"] = "Arrastra o control cara á dereita para completar o quebracabezas",
            ["Chart.DefaultDatasetLabel"] = "Conxunto de datos",
            ["Chart.DataPointsSuffix"] = "puntos de datos",
        };

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
