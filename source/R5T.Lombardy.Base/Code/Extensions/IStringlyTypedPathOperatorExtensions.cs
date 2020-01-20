using System;
using System.IO;


namespace R5T.Lombardy
{
    public static class IStringlyTypedPathOperatorExtensions
    {
        /// <summary>
        /// Ensures the path uses the directory separator specified by <see cref="System.IO.Path.DirectorySeparatorChar"/>.
        /// </summary>
        public static string EnsureDirectorySeparator(this IStringlyTypedPathOperator stringlyTypedPathOperator, string path)
        {
            var output = stringlyTypedPathOperator.EnsureDirectorySeparator(path, Path.DirectorySeparatorChar.ToString());
            return output;
        }
    }
}
