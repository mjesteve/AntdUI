// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License

using System;
using System.Collections.Generic;

namespace AntdUI.LanguagePacks
{
    static class LanguagePackMapBuilder
    {
        static readonly string[] Keys =
        {
            "OK", "Cancel", "Now", "ToDay", "NoData", "ItemsPerPage",
            "Filter", "Filter.Search", "All Files", "Picture Files",
            "Transfer.Source", "Transfer.Target", "YearFormat", "MonthFormat",
            "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun",
            "Copy", "Cut", "Paste", "Undo", "Redo", "SelectAll", "Delete",
            "Table.Summary.SUM", "Table.Summary.AVG", "Table.Summary.MIN",
            "Table.Summary.MAX", "Table.Summary.COUNT", "Table.Summary.NONE",
            "Table.Summary.Mode", "Table.Summary.ModeALL", "Filter.Equal",
            "Filter.NotEqual", "Filter.Greater", "Filter.Less", "Filter.Contain",
            "Filter.NotContain", "Filter.Blank", "Filter.SelectAll", "Filter.Clean",
            "Filter.BoolTrue", "Filter.BoolFalse", "Preview.CopySuccess",
            "Chat.TipDateFormat", "Captcha.Success", "Captcha.Failed",
            "Captcha.DragHint", "Chart.DefaultDatasetLabel", "Chart.DataPointsSuffix",
        };

        public static Dictionary<string, string> Create(params string[] values)
        {
            if (values.Length != Keys.Length)
                throw new ArgumentException("The language pack has an invalid number of values.", nameof(values));

            var result = new Dictionary<string, string>(Keys.Length);
            for (int index = 0; index < Keys.Length; index++) result.Add(Keys[index], values[index]);
            return result;
        }
    }

    /// <summary>French (fr-FR) language pack for AntdUI's built-in ids.</summary>
    public static class Fr
    {
        public static readonly Dictionary<string, string> Map = LanguagePackMapBuilder.Create(
            "Accepter", "Annuler", "Maintenant", "Aujourd’hui", "Aucune donnée", "éléments/page",
            "Filtrer", "Rechercher", "Tous les fichiers", "Fichiers image",
            "Liste source", "Liste cible", "yyyy", "MMM",
            "Lun", "Mar", "Mer", "Jeu", "Ven", "Sam", "Dim",
            "Copier", "Couper", "Coller", "Annuler", "Rétablir", "Tout sélectionner", "Supprimer",
            "Somme", "Moyenne", "Minimum", "Maximum", "Nombre", "Aucun résumé",
            "Mode ligne sélectionnée", "Mode toutes les lignes", "Égal à", "Différent de",
            "Supérieur à (commence par…)", "Inférieur à (se termine par…)", "Contient", "Ne contient pas",
            "(Vide)", "(Tout sélectionner)", "Réinitialiser", "Oui", "Non", "Copie réussie",
            "dd-MM-yyyy dddd HH:mm", "Vérification réussie", "Échec de la vérification",
            "Faites glisser le curseur vers la droite pour terminer le puzzle", "Jeu de données", "points de données");

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }

    /// <summary>Galician (gl-ES) language pack for AntdUI's built-in ids.</summary>
    public static class Gl
    {
        public static readonly Dictionary<string, string> Map = LanguagePackMapBuilder.Create(
            "Aceptar", "Cancelar", "Agora", "Hoxe", "Sen datos", "elem./páx.",
            "Filtrar", "Buscar", "Todos os ficheiros", "Ficheiros de imaxe",
            "Lista de orixe", "Lista de destino", "yyyy", "MMM",
            "Lun", "Mar", "Mér", "Xov", "Ven", "Sáb", "Dom",
            "Copiar", "Cortar", "Pegar", "Desfacer", "Refacer", "Seleccionar todo", "Eliminar",
            "Suma", "Media", "Mínimo", "Máximo", "Contar", "Sen resumo",
            "Modo de fila seleccionada", "Modo de todas as filas", "Igual a", "Distinto de",
            "Maior ca (comeza por…)", "Menor ca (remata en…)", "Contén", "Non contén",
            "(En branco)", "(Seleccionar todo)", "Restablecer", "Si", "Non", "Copiado correctamente",
            "dd-MM-yyyy dddd HH:mm", "Verificación correcta", "Fallou a verificación",
            "Arrastra o control cara á dereita para completar o quebracabezas", "Conxunto de datos", "puntos de datos");

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }

    /// <summary>Basque (eu-ES) language pack for AntdUI's built-in ids.</summary>
    public static class Eu
    {
        public static readonly Dictionary<string, string> Map = LanguagePackMapBuilder.Create(
            "Onartu", "Utzi", "Orain", "Gaur", "Daturik ez", "elementu/orri",
            "Iragazi", "Bilatu", "Fitxategi guztiak", "Irudi-fitxategiak",
            "Jatorri-zerrenda", "Helburu-zerrenda", "yyyy", "MMM",
            "Al", "Ar", "Az", "Og", "Or", "Lr", "Ig",
            "Kopiatu", "Ebaki", "Itsatsi", "Desegin", "Berregin", "Hautatu dena", "Ezabatu",
            "Batura", "Batez bestekoa", "Minimoa", "Maximoa", "Kopurua", "Laburpenik ez",
            "Hautatutako errenkadaren modua", "Errenkada guztien modua", "Berdina", "Ezberdina",
            "Handiagoa (honekin hasten da…)", "Txikiagoa (honekin amaitzen da…)", "Dauka", "Ez dauka",
            "(Hutsik)", "(Hautatu dena)", "Berrezarri", "Bai", "Ez", "Ondo kopiatu da",
            "dd-MM-yyyy dddd HH:mm", "Egiaztapena zuzena", "Egiaztapenak huts egin du",
            "Arrastatu graduatzailea eskuinera puzzlea osatzeko", "Datu-multzoa", "datu-puntu");

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }

    /// <summary>European Portuguese (pt-PT) language pack for AntdUI's built-in ids.</summary>
    public static class PtPt
    {
        public static readonly Dictionary<string, string> Map = LanguagePackMapBuilder.Create(
            "Aceitar", "Cancelar", "Agora", "Hoje", "Sem dados", "itens/página",
            "Filtrar", "Pesquisar", "Todos os ficheiros", "Ficheiros de imagem",
            "Lista de origem", "Lista de destino", "yyyy", "MMM",
            "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb", "Dom",
            "Copiar", "Cortar", "Colar", "Anular", "Refazer", "Selecionar tudo", "Eliminar",
            "Soma", "Média", "Mínimo", "Máximo", "Contagem", "Sem resumo",
            "Modo de linha selecionada", "Modo de todas as linhas", "Igual a", "Diferente de",
            "Maior que (começa por…)", "Menor que (termina em…)", "Contém", "Não contém",
            "(Em branco)", "(Selecionar tudo)", "Repor", "Sim", "Não", "Copiado com sucesso",
            "dd-MM-yyyy dddd HH:mm", "Verificação concluída", "Falha na verificação",
            "Arraste o controlo para a direita para concluir o puzzle", "Conjunto de dados", "pontos de dados");

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }

    /// <summary>Italian (it-IT) language pack for AntdUI's built-in ids.</summary>
    public static class It
    {
        public static readonly Dictionary<string, string> Map = LanguagePackMapBuilder.Create(
            "Accetta", "Annulla", "Adesso", "Oggi", "Nessun dato", "elementi/pagina",
            "Filtra", "Cerca", "Tutti i file", "File immagine",
            "Elenco origine", "Elenco destinazione", "yyyy", "MMM",
            "Lun", "Mar", "Mer", "Gio", "Ven", "Sab", "Dom",
            "Copia", "Taglia", "Incolla", "Annulla", "Ripristina", "Seleziona tutto", "Elimina",
            "Somma", "Media", "Minimo", "Massimo", "Conteggio", "Nessun riepilogo",
            "Modalità riga selezionata", "Modalità tutte le righe", "Uguale a", "Diverso da",
            "Maggiore di (inizia con…)", "Minore di (termina con…)", "Contiene", "Non contiene",
            "(Vuoto)", "(Seleziona tutto)", "Reimposta", "Sì", "No", "Copia completata",
            "dd-MM-yyyy dddd HH:mm", "Verifica riuscita", "Verifica non riuscita",
            "Trascina il cursore verso destra per completare il puzzle", "Set di dati", "punti dati");

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }

    /// <summary>Catalan (ca-ES) language pack for AntdUI's built-in ids.</summary>
    public static class Ca
    {
        public static readonly Dictionary<string, string> Map = LanguagePackMapBuilder.Create(
            "Accepta", "Cancel·la", "Ara", "Avui", "Sense dades", "elem./pàg.",
            "Filtra", "Cerca", "Tots els fitxers", "Fitxers d’imatge",
            "Llista d’origen", "Llista de destinació", "yyyy", "MMM",
            "Dl", "Dt", "Dc", "Dj", "Dv", "Ds", "Dg",
            "Copia", "Retalla", "Enganxa", "Desfés", "Refés", "Selecciona-ho tot", "Suprimeix",
            "Suma", "Mitjana", "Mínim", "Màxim", "Recompte", "Sense resum",
            "Mode de fila seleccionada", "Mode de totes les files", "Igual a", "Diferent de",
            "Més gran que (comença per…)", "Més petit que (acaba en…)", "Conté", "No conté",
            "(En blanc)", "(Selecciona-ho tot)", "Restableix", "Sí", "No", "S’ha copiat correctament",
            "dd-MM-yyyy dddd HH:mm", "Verificació correcta", "La verificació ha fallat",
            "Arrossega el control cap a la dreta per completar el trencaclosques", "Conjunt de dades", "punts de dades");

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }

    /// <summary>Valencian (ca-ES-valencia) language pack for AntdUI's built-in ids.</summary>
    public static class CaEsValencia
    {
        public static readonly Dictionary<string, string> Map = LanguagePackMapBuilder.Create(
            "Accepta", "Cancel·la", "Ara", "Hui", "Sense dades", "elem./pàg.",
            "Filtra", "Busca", "Tots els fitxers", "Fitxers d’imatge",
            "Llista d’origen", "Llista de destinació", "yyyy", "MMM",
            "Dl", "Dt", "Dc", "Dj", "Dv", "Ds", "Dg",
            "Copia", "Retalla", "Apega", "Desfés", "Refés", "Selecciona-ho tot", "Elimina",
            "Suma", "Mitjana", "Mínim", "Màxim", "Recompte", "Sense resum",
            "Mode de fila seleccionada", "Mode de totes les files", "Igual a", "Diferent de",
            "Més gran que (comença per…)", "Més menut que (acaba en…)", "Conté", "No conté",
            "(En blanc)", "(Selecciona-ho tot)", "Restablix", "Sí", "No", "S’ha copiat correctament",
            "dd-MM-yyyy dddd HH:mm", "Verificació correcta", "La verificació ha fallat",
            "Arrossega el control cap a la dreta per completar el trencaclosques", "Conjunt de dades", "punts de dades");

        public static readonly ILocalization Instance = new DictionaryLocalization(Map);
    }
}
