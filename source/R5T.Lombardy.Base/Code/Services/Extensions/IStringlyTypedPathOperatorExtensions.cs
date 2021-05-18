using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


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

        public static IDistinctValuedDictionary<string, string> GetFileNamesByFilePath(this IStringlyTypedPathOperator stringlyTypedPathOperator, IDistinctEnumerable<string> filePaths)
        {
            return filePaths.ToDictionary(
                filePath => filePath,
                filePath => stringlyTypedPathOperator.GetFileName(filePath))
                .AsDistinctValued();
        }

        public static IDistinctEnumerable<string> GetFileNames(this IStringlyTypedPathOperator stringlyTypedPathOperator, IDistinctEnumerable<string> filePaths)
        {
            return stringlyTypedPathOperator.GetFileNamesByFilePath(filePaths)
                .Values
                .AsDistinct();
        }

        public static IDistinctValuedDictionary<string, string> GetFilePathsByFileName(this IStringlyTypedPathOperator stringlyTypedPathOperator, string directoryPath, IDistinctEnumerable<string> fileNames)
        {
            return fileNames.ToDictionary(
                fileName => fileName,
                fileName => stringlyTypedPathOperator.GetFilePath(directoryPath, fileName))
                .AsDistinctValued();
        }

        public static IDistinctEnumerable<string> GetFilePaths(this IStringlyTypedPathOperator stringlyTypedPathOperator, string directoryPath, IDistinctEnumerable<string> fileNames)
        {
            return stringlyTypedPathOperator.GetFilePathsByFileName(directoryPath, fileNames)
                .Values
                .AsDistinct();
        }

        public static IDistinctValuedDictionary<TKey, string> GetFilePathsByKey<TKey>(this IStringlyTypedPathOperator stringlyTypedPathOperator,
            string directoryPath,
            IDistinctValuedDictionary<TKey, string> fileNamesByKey)
        {
            return fileNamesByKey.ToDictionary(
                pair => pair.Key,
                pair => stringlyTypedPathOperator.GetFilePath(directoryPath, pair.Value))
                .AsDistinctValued();
        }
    }
}
