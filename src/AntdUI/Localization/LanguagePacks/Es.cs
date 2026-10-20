// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License
// Gitee: https://gitee.com/AntdUI/AntdUI
// GitHub: https://github.com/AntdUI/AntdUI
// GitCode: https://gitcode.com/AntdUI/AntdUI

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>
    /// Spanish (es-ES) language pack for AntdUI's built-in ids.
    /// Usage: AntdUI.Localization.Provider = AntdUI.LanguagePacks.Es.Instance;
    /// </summary>
    public static class Es
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            ["OK"] = "Aceptar",
            ["Cancel"] = "Cancelar",
            ["Now"] = "Ahora",
            ["ToDay"] = "Hoy",
            ["NoData"] = "Sin datos",
            ["ItemsPerPage"] = "elem./pág.",
            ["Filter"] = "Filtrar",
            ["Filter.Search"] = "Buscar",
            ["All Files"] = "Todos los archivos",
            ["Picture Files"] = "Archivos de imagen",
            ["Transfer.Source"] = "Lista de origen",
            ["Transfer.Target"] = "Lista de destino",
            ["YearFormat"] = "yyyy",
            ["MonthFormat"] = "MMM",
            ["Mon"] = "Lun",
            ["Tue"] = "Mar",
            ["Wed"] = "Mié",
            ["Thu"] = "Jue",
            ["Fri"] = "Vie",
            ["Sat"] = "Sáb",
            ["Sun"] = "Dom",
            ["Copy"] = "Copiar",
            ["Cut"] = "Cortar",
            ["Paste"] = "Pegar",
            ["Undo"] = "Deshacer",
            ["Redo"] = "Rehacer",
            ["SelectAll"] = "Seleccionar todo",
            ["Delete"] = "Eliminar",
            ["Table.Summary.SUM"] = "Suma",
            ["Table.Summary.AVG"] = "Promedio",
            ["Table.Summary.MIN"] = "Mínimo",
            ["Table.Summary.MAX"] = "Máximo",
            ["Table.Summary.COUNT"] = "Contar",
            ["Table.Summary.NONE"] = "Sin resumen",
            ["Table.Summary.Mode"] = "Modo fila seleccionada",
            ["Table.Summary.ModeALL"] = "Modo todas las filas",
            ["Filter.Equal"] = "Igual a",
            ["Filter.NotEqual"] = "Distinto de",
            ["Filter.Greater"] = "Mayor que (empieza por...)",
            ["Filter.Less"] = "Menor que (termina en...)",
            ["Filter.Contain"] = "Contiene",
            ["Filter.NotContain"] = "No contiene",
            ["Filter.Blank"] = "(en blanco)",
            ["Filter.SelectAll"] = "(Seleccionar todo)",
            ["Filter.Clean"] = "Restablecer",
            ["Filter.BoolTrue"] = "Sí",
            ["Filter.BoolFalse"] = "No",
            ["Preview.CopySuccess"] = "Copiado correctamente",
            ["Chat.TipDateFormat"] = "dd-MM-yyyy dddd HH:mm",
            ["Captcha.Success"] = "Verificación correcta",
            ["Captcha.Failed"] = "Verificación fallida",
            ["Captcha.DragHint"] = "Arrastra la pieza hacia la derecha para completar el puzle",
            ["Chart.DefaultDatasetLabel"] = "Conjunto de datos",
            ["Chart.DataPointsSuffix"] = "puntos de datos",
        };

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
