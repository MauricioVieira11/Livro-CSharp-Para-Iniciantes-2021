using System;
using static System.Console;


namespace Course
{
    public static class MetodosExtensao
    {
        public static string FormatarData(this DateTime data, string formato) => data.ToString(formato);
        public static string Formatar(this decimal valor, string formato) => valor.ToString(formato);

    }
}
