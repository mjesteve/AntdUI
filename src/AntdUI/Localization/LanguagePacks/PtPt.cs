// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    /// <summary>European Portuguese (pt-PT) language pack for AntdUI's built-in ids.</summary>
    public static class PtPt
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            ["OK"] = "Aceitar",
            ["Cancel"] = "Cancelar",
            ["Now"] = "Agora",
            ["ToDay"] = "Hoje",
            ["NoData"] = "Sem dados",
            ["ItemsPerPage"] = "itens/página",
            ["Filter"] = "Filtrar",
            ["Filter.Search"] = "Pesquisar",
            ["All Files"] = "Todos os ficheiros",
            ["Picture Files"] = "Ficheiros de imagem",
            ["Transfer.Source"] = "Lista de origem",
            ["Transfer.Target"] = "Lista de destino",
            ["YearFormat"] = "yyyy",
            ["MonthFormat"] = "MMM",
            ["Mon"] = "Seg",
            ["Tue"] = "Ter",
            ["Wed"] = "Qua",
            ["Thu"] = "Qui",
            ["Fri"] = "Sex",
            ["Sat"] = "Sáb",
            ["Sun"] = "Dom",
            ["Copy"] = "Copiar",
            ["Cut"] = "Cortar",
            ["Paste"] = "Colar",
            ["Undo"] = "Anular",
            ["Redo"] = "Refazer",
            ["SelectAll"] = "Selecionar tudo",
            ["Delete"] = "Eliminar",
            ["Table.Summary.SUM"] = "Soma",
            ["Table.Summary.AVG"] = "Média",
            ["Table.Summary.MIN"] = "Mínimo",
            ["Table.Summary.MAX"] = "Máximo",
            ["Table.Summary.COUNT"] = "Contagem",
            ["Table.Summary.NONE"] = "Sem resumo",
            ["Table.Summary.Mode"] = "Modo de linha selecionada",
            ["Table.Summary.ModeALL"] = "Modo de todas as linhas",
            ["Filter.Equal"] = "Igual a",
            ["Filter.NotEqual"] = "Diferente de",
            ["Filter.Greater"] = "Maior que (começa por…)",
            ["Filter.Less"] = "Menor que (termina em…)",
            ["Filter.Contain"] = "Contém",
            ["Filter.NotContain"] = "Não contém",
            ["Filter.Blank"] = "(Em branco)",
            ["Filter.SelectAll"] = "(Selecionar tudo)",
            ["Filter.Clean"] = "Repor",
            ["Filter.BoolTrue"] = "Sim",
            ["Filter.BoolFalse"] = "Não",
            ["Preview.CopySuccess"] = "Copiado com sucesso",
            ["Chat.TipDateFormat"] = "dd-MM-yyyy dddd HH:mm",
            ["Captcha.Success"] = "Verificação concluída",
            ["Captcha.Failed"] = "Falha na verificação",
            ["Captcha.DragHint"] = "Arraste o controlo para a direita para concluir o puzzle",
            ["Chart.DefaultDatasetLabel"] = "Conjunto de dados",
            ["Chart.DataPointsSuffix"] = "pontos de dados",
        };

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
