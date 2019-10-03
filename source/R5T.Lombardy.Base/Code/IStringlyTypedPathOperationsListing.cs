using System;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all stringly-typed path operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all stringly-typed path operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IStringlyTypedPathOperationsListing
    {
        bool ExistsFilePath(string filePath); // Done in: StringlyTypedPath
        bool ExistsDirectoryPath(string directoryPath); // Done in: StringlyTypedPath

        void DeleteFilePath(string filePath); // Done in: StringlyTypedPath
        void DeleteDirectoryPath(string directoryPath, bool recursive = true); // Done in: StringlyTypedPath

        char GetTerminatingChar(string path); // Gets the last character in the path. // Done in: StringlyTypedPath

        char DetectDirectorySeparatorChar(string path); // Done in: StringlyTypedPath
        bool TryDetectDirectorySeparatorChar(string path, out char directorySeparatorChar); // Done in: StringlyTypedPath
        string DetectDirectorySeparator(string path); // Done in: StringlyTypedPath
        bool TryDetectDirectorySeparator(string path, out string directorySeparator); // Done in: StringlyTypedPath

        // Classification.
        bool IsWindowsPathAssumeWindows(string path); // Done in: StringlyTypedPath
        bool IsWindowsPathStrict(string path); // Done in: StringlyTypedPath
        bool IsWindowsPath(string path); // Uses -AssumeWindows(). // Done in: StringlyTypedPath
        bool IsNonWindowsPathAssumeNonWindows(string path); // Done in: StringlyTypedPath
        bool IsNonWindowsPathStrict(string path); // Done in: StringlyTypedPath
        bool IsNonWindowsPath(string path); // Uses -AssumeWindows(). // Done in: StringlyTypedPath

        bool IsRootIndicatedPath(string path); // Done in: StringlyTypedPath
        bool IsNotRootIndicatedPath(string path); // Done in: StringlyTypedPath
        bool IsRelativeIndicatedPath(string path); // Same as IsNotRootIndicated(). // Done in: StringlyTypedPath
        bool IsRootedPath(string path); // Same as IsRootIndicatedPath(). // Done in: StringlyTypedPath
        bool IsAbsolutePath(string path); // Same as IsRootIndicatedPath(). // Done in: StringlyTypedPath
        bool IsRelativePath(string path); // Same as IsNotRootIndicatedPath(). // Done in: StringlyTypedPath

        bool IsDirectoryIndicatedPath(string path); // Done in: StringlyTypedPath
        bool IsNotDirectoryIndicatedPath(string path); // Done in: StringlyTypedPath
        bool IsFileIndicatedPath(string path); // Same as IsNotDirectoryIndicated(). // Done in: StringlyTypedPath
        bool IsDirectoryPath(string path); // Same as IsDirectoryIndicatedPath(). Caveat is that directory paths must be directory indicated! // Done in: StringlyTypedPath
        bool IsFilePath(string path); // Same as IsNotDirectoryIndicatedPath(). Caveat is that directory paths must be directory indicated! // Done in: StringlyTypedPath

        bool IsExistingDirectory(string path); // Tests the file system. Same as ExistsDirectoryPath(). // Done in: StringlyTypedPath
        bool IsExistingFile(string path); // Tests the file system. Same as ExistsFilePath(). Done in: StringlyTypedPath
        bool IsDirectory(string path); // With caveat that directory must exist. Same as ExistsDirectoryPath(). // Done in: StringlyTypedPath
        bool IsFile(string path); // With caveat that file must exist. Same as ExistsFilePath(). // Done in: StringlyTypedPath

        bool IsResolvedPath(string path); // Done in: // Done in: StringlyTypedPath
        bool IsUnresolvedPath(string path); // Done in: // Done in: StringlyTypedPath

        // Validate.
        void ValidateIsDirectoryIndicatedPath(string pathSegment); // Done in: StringlyTypedPath
        void ValidateIsDirectoryIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath
        void ValidateNotDirectoryIndicatedPath(string pathSegment); // Done in: StringlyTypedPath
        void ValidateNotDirectoryIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath
        void ValidateIsFileIndicatedPath(string pathSegment); // Same as ValidateNotDirectoryIndicatedPath(). Done in: StringlyTypedPath
        void ValidateIsFileIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath
        void ValidateIsRootIndicatedPath(string pathSegment); // Same as ValidateNotDirectoryIndicatedPath(). Done in: StringlyTypedPath
        void ValidateIsRootIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath
        void ValidateNotRootIndicatedPath(string pathSegment); // Done in: StringlyTypedPath
        void ValidateNotRootIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath

        // Ensure.
        string EnsureDirectorySeparatorUnchecked(string path, string directorySeparator); // Done in: StringlyTypedPath
        string EnsureDirectorySeparatorChecked(string path, string directorySeparator); // Done in: StringlyTypedPath
        string EnsureDirectorySeparator(string path, string directorySeparator); // Uses -Checked(). // Done in: StringlyTypedPath
        string EnsureWindowsDirectorySeparator(string path); // Done in: StringlyTypedPath
        string EnsureNonWindowsDirectorySeparator(string path); // Done in: StringlyTypedPath
        string EnsureWindowsPath(string path); // Done in: StringlyTypedPath
        string EnsureNonWindowsPath(string path); // Done in: StringlyTypedPath

        string EnsureRootIndicatedPath(string path, string directorySeparator); // Checked. // Done in: StringlyTypedPath
        string EnsureRootIndicatedPath(string path); // Done in: StringlyTypedPath
        string EnsureNotRootIndicatedPath(string path); // Done in: StringlyTypedPath
        string EnsureRelativeIndicatedPath(string path); // Same as EnsureNotRootIndicatedPath(). // Done in: StringlyTypedPath
        string EnsureRootedPath(string path); // Done in: StringlyTypedPath
        string EnsureAbsolutePath(string path); // Done in: StringlyTypedPath
        string EnsureRelativePath(string path); // Done in: StringlyTypedPath
        string EnsureRootedPathIsRootIndicated(string rootedPath, string directorySeparator); // Same as EnsureRootIndicatedPath(). Directory separator is checked. // Done in: StringlyTypedPath
        string EnsureRootedPathIsRootIndicated(string rootedPath); // Same as EnsureRootIndicatedPath(). // Done in: StringlyTypedPath
        string EnsureRelativePathIsNotRootIndicated(string relativePath); // Same as EnsureNotRootIndicatedPath(). // Done in: StringlyTypedPath

        string MakePathRootIndicatedUnchecked(string path, string directorySeparator); // Done in: StringlyTypedPath
        string MakePathRootIndicatedChecked(string path, string directorySeparator); // Done in: StringlyTypedPath
        string MakePathRootIndicated(string path, string directorySeparator); // Directory separator is checked, path is not. // Done in: StringlyTypedPath

        string EnsureDirectoryIndicatedPath(string path, string directorySeparator); // Checked. // Done in: StringlyTypedPath
        string EnsureDirectoryIndicatedPath(string path); // Done in: StringlyTypedPath
        string EnsureNotDirectoryIndicatedPath(string path); // Done in: StringlyTypedPath
        string EnsureFileIndicatedPath(string path); // Same as EnsureNotDirectoryIndicatedPath(). // Done in: StringlyTypedPath
        string EnsureDirectoryPathIsDirectoryIndicated(string directoryPath, string directorySeparator); // Same as EnsureDirectoryIndicatedPath(). Directory separator is checked. // Done in: StringlyTypedPath
        string EnsureDirectoryPathIsDirectoryIndicated(string directoryPath); // Same as EnsureDirectoryIndicatedPath(). // Done in: StringlyTypedPath
        string EnsureFilePathIsNotDirectoryIndicated(string filePath); // Same as EnsureNotDirectoryIndicatedPath(). // Done in: StringlyTypedPath

        string MakePathDirectoryIndicatedUnchecked(string path, string directorySeparator); // Done in: StringlyTypedPath
        string MakePathDirectoryIndicatedChecked(string path, string directorySeparator); // Directory separator is checked, path is not. // Done in: StringlyTypedPath
        string MakePathDirectoryIndicated(string path, string directorySeparator); // Uses checked. // Done in: StringlyTypedPath

        string EnsureResolvedPath(string path); // Done in: StringlyTypedPath

        // Relative paths.
        string GetRelativePathUriToUri_Internal(string sourcePath, string destinationPath); // Internal, uses Uri.MakeRelativeUri(). StringlyTypedPathInternals.
        string GetRelativePathOutputWindowsIfWindows_Internal(string sourcePath, string destinationPath); // Internal. StringlyTypedPathInternals.

        string GetRelativePath(string sourcePath, string destinationPath); // Limitations due to assumption of directory vs. file, output Windows if source is Windows, Non-Windows if source is Non-Windows. // Done in: StringlyTypedPath
        string GetRelativePathFileToFile(string sourceFilePath, string destinationFilePath); // Done in: StringlyTypedPath
        string GetRelativePathFileToDirectory(string sourceFilePath, string destinationDirectoryPath); // Done in: StringlyTypedPath
        string GetRelativePathDirectoryToFile(string sourceDirectoryPath, string destinationFilePath); // Done in: StringlyTypedPath
        string GetRelativePathDirectoryToDirectory(string sourceDirectoryPath, string destinationDirectoryPath); // Done in: StringlyTypedPath

        // Combining relative paths is handled well by the Combine() methods.
        //string CombineRelativePathUnchecked(string sourcePath, string relativePath, string directoryPath); // Directory separator is unchecked, sourcePath is unchecked for directory indication, and relative path is unchecked for root indication.
        //string CombineRelativePathSimple(string sourcePath, string relativePath, string directoryPath); // Directory separator is checked, sourcePath is checked for directory indication, and relative path is checked for root indication.
        //string CombineRelativePath(string sourcePath, string relativePath, string directorySeparator); // Directory separator is checked, sourcePath and relativePath are ensured.

        // Resolution.
        string ResolvePath(string unresolvedPath); // Done in: StringlyTypedPath
        // ?? Others, depending on file vs. directory output?

        // Combine.
        string CombineDirectoryIndicatedUnchecked(string directoryIndicatedPathSegment1, string pathSegment2); // Done in: StringlyTypedPath
        string CombineDirectoryIndicatedChecked(string directoryIndicatedPathSegment1, string pathSegment2); // Done in: StringlyTypedPath
        string CombineDirectoryIndicatedEnsured(string directoryIndicatedPathSegment1, string pathSegment2); // Done in: StringlyTypedPath
        string CombineDirectoryIndicated(string directoryIndicatedPathSegment1, string pathSegment2); // Uses ensured. // Done in: StringlyTypedPath

        string CombineUnresolvedUnchecked(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath
        string CombineUnresolvedChecked(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath
        string CombineUnresolvedEnsured(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath
        string CombineTwoUnresolved(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath
        string CombineUnresolved(string directorySeparator, params string[] pathSegments); // Done in: StringlyTypedPath
        string CombineTwo(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath
        string CombineUsingDirectorySeparator(string directorySeparator, params string[] pathSegments); // Done in: StringlyTypedPath
        string CombineTwo(string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath
        string Combine(params string[] pathSegments); // Done in: StringlyTypedPath
        string Combine(string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath

        string CombineWindows(params string[] pathSegments); // Done in: StringlyTypedPath
        string CombineNonWindows(params string[] pathSegments); // Done in: StringlyTypedPath

        string GetFilePathUnchecked(string directoryPath, string fileName, string directorySeparator); // Done in: StringlyTypedPath
        string GetFilePathChecked(string directoryPath, string fileName, string directorySeparator); // Done in: StringlyTypedPath
        string GetFilePathEnsured(string directoryPath, string fileName, string directorySeparator); // Done in: StringlyTypedPath
        string GetFilePath(string directoryPath, string fileName, string directorySeparator); // Uses ensured. // Done in: StringlyTypedPath
        string GetFilePath(string directoryPath, string fileName); // Done in: StringlyTypedPath

        string GetDirectoryPathUnchecked(string directoryPath, string directoryName, string directorySeparator); // Done in: StringlyTypedPath
        string GetDirectoryPathChecked(string directoryPath, string directoryName, string directorySeparator); // Done in: StringlyTypedPath
        string GetDirectoryPathEnsured(string directoryPath, string directoryName, string directorySeparator); // Done in: StringlyTypedPath
        string GetDirectoryPath(string directoryPath, string directoryName, string directorySeparator); // Uses ensured. // Done in: StringlyTypedPath

        // Separate.
        string[] GetPathSegmentsUnchecked(string path, string directorySeparator); // Directory separator is unchecked. // Done in: StringlyTypedPath
        string[] GetPathSegmentsChecked(string path, string directorySeparator); // Directory separator is checked, path is not. // Done in: StringlyTypedPath
        string[] GetPathSegments(string path, string directorySeparator); // Uses -Checked(). // Done in: StringlyTypedPath
        string[] GetPathSegments(string path); // Uses both valid directory separators to split the path. // Done in: StringlyTypedPath

        string GetFileNamePathSegment(params string[] pathSegments); // Done in: StringlyTypedPath

        string GetFileName(string filePath); // FilePath is checked. // Done in: StringlyTypedPath
        string GetFileNameWithoutExtension(string filePath); // FilePath is checked. // Done in: StringlyTypedPath
        string GetFileExtension(string filePath); // FilePath is checked. // Done in: StringlyTypedPath
        string GetDirectoryPathForFilePath(string filePath); // FilePath is checked. // Done in: StringlyTypedPath
        string GetDirectoryNameForFilePath(string filePath); // FilePath is checked. // Done in: StringlyTypedPath

        string GetDirectoryNameForDirectoryPathChecked(string directoryPath); // DirectoryPath is checked. // Done in: StringlyTypedPath
        string GetDirectoryNameForDirectoryPathEnsured(string directoryPath); // DirectoryPath is ensured. // Done in: StringlyTypedPath
        string GetDirectoryNameForDirectoryPath(string directoryPath); // Uses ensured. // Done in: StringlyTypedPath

        string GetParentDirectoryPathForDirectoryPathChecked(string directoryPath); // Directory path is checked. // Done in: StringlyTypedPath
        string GetParentDirectoryPathForDirectoryPathEnsured(string directoryPath); // Directory path is ensured. // Done in: StringlyTypedPath
        string GetParentDirectoryPathForDirectoryPath(string directoryPath); // Uses ensured. // Done in: StringlyTypedPath


        #region Exceptions

        string GetPathIsDirectoryIndicatedExceptionMessage(string path); // Done in: StringlyTypedPath
        Exception GetPathIsDirectoryIndicatedException(string path); // Done in: StringlyTypedPath
        ArgumentException GetPathIsDirectoryIndicatedArgumentException(string path, string parameterName); // Done in: StringlyTypedPath
        string GetPathNotDirectoryIndicatedExceptionMessage(string path); // Done in: StringlyTypedPath
        Exception GetPathNotDirectoryIndicatedException(string path); // Done in: StringlyTypedPath
        ArgumentException GetPathNotDirectoryIndicatedArgumentException(string path, string parameterName); // Done in: StringlyTypedPath
        string GetPathIsRootIndicatedExceptionMessage(string path); // Done in: StringlyTypedPath
        Exception GetPathIsRootIndicatedException(string path); // Done in: StringlyTypedPath
        ArgumentException GetPathIsRootIndicatedArgumentException(string path, string parameterName); // Done in: StringlyTypedPath
        string GetPathNotRootIndicatedExceptionMessage(string path); // Done in: StringlyTypedPath
        Exception GetPathNotRootIndicatedException(string path); // Done in: StringlyTypedPath
        ArgumentException GetPathNotRootIndicatedArgumentException(string path, string parameterName); // Done in: StringlyTypedPath

        #endregion
    }
}
