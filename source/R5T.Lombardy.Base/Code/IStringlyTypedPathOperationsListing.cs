using System;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all stringly-typed path operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all stringly-typed path operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IStringlyTypedPathOperationsListing
    {
        bool ExistsFilePath(string filePath);
        bool ExistsDirectoryPath(string directoryPath);

        void DeleteFilePath(string filePath);
        void DeleteDirectoryPath(string directoryPath);

        char GetTerminatingChar(string path); // Gets the last character in the path.

        // Classification.
        bool IsWindowsPathAssumeWindows(string path);
        bool IsWindowsPathStrict(string path);
        bool IsWindowsPath(string path); // Uses -AssumeWindows().
        bool IsNonWindowsPathAssumeNonWindows(string path);
        bool IsNonWindowsPathStrict(string path);
        bool IsNonWindowsPath(string path); // Uses -AssumeWindows().

        bool IsRootIndicatedPath(string path);
        bool IsNotRootIndicatedPath(string path);
        bool IsRelativeIndicatedPath(string path); // Same as IsNotRootIndicated().
        bool IsAbsolutePath(string path); // Same as IsRootIndicatedPath().
        bool IsRelativePath(string path); // Same as IsNotRootIndicatedPath().

        bool IsDirectoryIndicatedPath(string path);
        bool IsNotDirectoryIndicatedPath(string path);
        bool IsFileIndicatedPath(string path); // Same as IsNotDirectoryIndicated().

        bool IsExistingDirectory(string path); // Tests the file system.
        bool IsExistingFile(string path);
        bool IsDirectory(string path); // With caveat that directory must exist.
        bool IsFile(string path); // With caveat that file must exist.

        bool IsResolvedPath(string path);
        bool IsUnresolvedPath(string path);

        // Ensure.
        string EnsureWindowsPath(string path);
        string EnsureNonWindowsPath(string path);

        string EnsureRootIndicatedPath(string path, string directorySeparator); // Checked.
        string EnsureRootIndicatedPath(string path);
        string EnsureNotRootIndicatedPath(string path);
        string EnsureRelativeIndicatedPath(string path); // Same as EnsureNotRootIndicatedPath().
        string EnsureRootedPathIsRootIndicated(string rootedPath, string directorySeparator); // Same as EnsureRootIndicatedPath(). Directory separator is checked.
        string EnsureRootedPathIsRootIndicated(string rootedPath); // Same as EnsureRootIndicatedPath().
        string EnsureRelativePathIsNotRootIndicated(string relativePath); // Same as EnsureNotRootIndicatedPath().

        string MakePathRootIndicatedUnchecked(string path, string directorySeparator);
        string MakePathRootIndicated(string path, string directorySeparator); // Directory separator is checked, path is not.

        string EnsureDirectoryIndicatedPath(string path, string directorySeparator); // Checked.
        string EnsureDirectoryIndicatedPath(string path);
        string EnsureNotDirectoryIndicatedPath(string path);
        string EnsureFileIndicatedPath(string path); // Same as EnsureNotDirectoryIndicatedPath().
        string EnsureDirectoryPathIsDirectoryIndicated(string directoryPath, string directorySeparator); // Same as EnsureDirectoryIndicatedPath(). Directory separator is checked.
        string EnsureDirectoryPathIsDirectoryIndicated(string directoryPath); // Same as EnsureDirectoryIndicatedPath().
        string EnsureFilePathIsNotDirectoryIndicated(string filePath); // Same as EnsureNotDirectoryIndicatedPath().

        string MakePathDirectoryIndicatedUnchecked(string path, string directorySeparator);
        string MakePathDirectoryIndicatedChecked(string path, string directorySeparator); // Directory separator is checked, path is not.
        string MakePathDirectoryIndicated(string path, string directorySeparator); // Uses checked.

        string EnsureResolvedPath(string path);

        // Relative paths.
        string GetRelativePath(string sourcePath, string destinationPath); // Limitations due to assumption of directory vs. file, output Windows if source is Windows, Non-Windows if source is Non-Windows.
        string GetRelativePathFileToFile(string sourceFilePath, string destinationFilePath);
        string GetRelativePathFileToDirectory(string sourceFilePath, string destinationDirectoryPath);
        string GetRelativePathDirectoryToFile(string sourceDirectoryPath, string destinationFilePath);
        string GetRelativePathDirectoryToDirectory(string sourceDirectoryPath, string destinationDirectoryPath);

        // Combining relative paths is handled well by the Combine() methods.
        //string CombineRelativePathUnchecked(string sourcePath, string relativePath, string directoryPath); // Directory separator is unchecked, sourcePath is unchecked for directory indication, and relative path is unchecked for root indication.
        //string CombineRelativePathSimple(string sourcePath, string relativePath, string directoryPath); // Directory separator is checked, sourcePath is checked for directory indication, and relative path is checked for root indication.
        //string CombineRelativePath(string sourcePath, string relativePath, string directorySeparator); // Directory separator is checked, sourcePath and relativePath are ensured.

        // Resolution.
        string ResolvePath(string path);

        // Combine.
        string CombineDirectoryIndicatedUnchecked(string directoryIndicatedPathSegment1, string pathSegment2);
        string CombineDirectoryIndicatedChecked(string directoryIndicatedPathSegment1, string pathSegment2);
        string CombineDirectoryIndicatedEnsured(string directoryIndicatedPathSegment1, string pathSegment2);
        string CombineDirectoryIndicated(string directoryIndicatedPathSegment1, string pathSegment2); // Uses ensured.

        string CombineUnresolvedUnchecked(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUnresolvedChecked(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUnresolvedEnsured(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineTwoUnresolved(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUnresolved(string directorySeparator, params string[] paths);
        string CombineTwo(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUsingDirectorySeparator(string directorySeparator, params string[] paths);
        string CombineTwo(string pathSegment1, string pathSegment2);
        string Combine(params string[] paths);
        string Combine(string pathSegment1, string pathSegment2);

        string CombineWindows(params string[] pathSegments);
        string CombineNonWindows(params string[] pathSegments);

        string GetFilePathUnchecked(string directoryPath, string fileName, string directorySeparator);
        string GetFilePathChecked(string directoryPath, string fileName, string directorySeparator);
        string GetFilePathEnsured(string directoryPath, string fileName, string directorySeparator);
        string GetFilePath(string directoryPath, string fileName, string directorySeparator); // Uses ensured.
        string GetFilePath(string directoryPath, string fileName);

        string GetDirectoryPathUnchecked(string directoryPath, string directoryName, string directorySeparator);
        string GetDirectoryPathChecked(string directoryPath, string directoryName, string directorySeparator);
        string GetDirectoryPathEnsured(string directoryPath, string directoryName, string directorySeparator);
        string GetDirectoryPath(string directoryPath, string directoryName, string directorySeparator); // Uses ensured.

        // Separate.
        string GetFileName(string filePath); // FilePath is checked.
        string GetFileNameWithoutExtension(string filePath); // FilePath is checked.
        string GetFileExtension(string filePath); // FilePath is checked.
        string GetDirectoryPathForFilePath(string filePath); // FilePath is checked.
        string GetDirectoryNameForFilePath(string filePath); // FilePath is checked.

        string GetDirectoryNameForDirectoryPathChecked(string directoryPath); // DirectoryPath is checked.
        string GetDirectoryNameForDirectoryPathEnsured(string directoryPath); // DirectoryPath is ensured.
        string GetDirectoryNameForDirectoryPath(string directoryPath); // Uses ensured.

        string GetParentDirectoryPathForDirectoryPathChecked(string directoryPath); // Directory path is checked.
        string GetParentDirectoryPathForDirectoryPathEnsured(string directoryPath); // Directory path is ensured.
        string GetParentDirectoryPathForDirectoryPath(string directoryPath); // Uses ensured.
    }
}
