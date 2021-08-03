using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using R5T.Magyar;


namespace System
{
    using R5T.Lombardy;


    public static class IStringlyTypedPathOperatorExtensions
    {
        /// <summary>
        /// Note: also produces true if the <paramref name="directoryPath"/> is the <paramref name="potentialParentDirectoryPath"/>.
        /// </summary>
        public static bool IsDirectoryInDirectory(this IStringlyTypedPathOperator stringlyTypedPathOperator,
            string directoryPath,
            string potentialParentDirectoryPath)
        {
            // Quickly test whether the directory path is at least long enough to either be, or be in, the potential parent path.
            var directoryPathIsAtLeastLongEnough = directoryPath.Length >= potentialParentDirectoryPath.Length; // Greater than or equal to, since the two paths might be the same.
            if (!directoryPathIsAtLeastLongEnough)
            {
                return false;
            }

            // In order to use string comparison, ensure that the two paths are using the same directory separator.
            var windowsDirectoryPath = stringlyTypedPathOperator.EnsureWindowsDirectorySeparator(directoryPath);
            var windowsPotentialParentDirectoryPath = stringlyTypedPathOperator.EnsureWindowsDirectorySeparator(directoryPath);

            var output = windowsDirectoryPath.BeginsWith(windowsPotentialParentDirectoryPath);
            return output;
        }

        public static bool IsEmptyPath(this IStringlyTypedPathOperator _,
            string path)
        {
            var output = path == Strings.Empty;
            return output;
        }

        public static bool IsFileInDirectory(this IStringlyTypedPathOperator stringlyTypedPathOperator,
            string filePath,
            string potentialParentDirectoryPath)
        {
            // Quickly test whether the file path is at least as long as the potential parent path.
            var filePathIsAtLeastLongEnough = filePath.Length > potentialParentDirectoryPath.Length; // Greater than, since file path must also include file name.
            if(!filePathIsAtLeastLongEnough)
            {
                return false;
            }

            // In order to use string comparison, ensure that the two paths are using the same directory separator.
            var windowsFilePath = stringlyTypedPathOperator.EnsureWindowsDirectorySeparator(filePath);
            var windowsPotentialParentDirectoryPath = stringlyTypedPathOperator.EnsureWindowsDirectorySeparator(potentialParentDirectoryPath);

            var output = windowsFilePath.BeginsWith(windowsPotentialParentDirectoryPath);
            return output;
        }
    }
}


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
