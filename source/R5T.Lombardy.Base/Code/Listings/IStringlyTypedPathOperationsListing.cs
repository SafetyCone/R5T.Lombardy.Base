using System;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all stringly-typed path operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all stringly-typed path operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IStringlyTypedPathOperationsListing
    {
        bool ExistsFilePath(string filePath); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool ExistsDirectoryPath(string directoryPath); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        void DeleteFilePath(string filePath); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        void DeleteDirectoryPath(string directoryPath, bool recursive = true); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        char GetTerminatingChar(string path); // Gets the last character in the path. // Done in: StringlyTypedPath, StringlyTypedPathOperator

        char DetectDirectorySeparatorChar(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool TryDetectDirectorySeparatorChar(string path, out char directorySeparatorChar); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string DetectDirectorySeparator(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool TryDetectDirectorySeparator(string path, out string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        // Classification.
        bool IsWindowsPathAssumeWindows(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsWindowsPathStrict(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsWindowsPath(string path); // Uses -AssumeWindows(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsNonWindowsPathAssumeNonWindows(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsNonWindowsPathStrict(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsNonWindowsPath(string path); // Uses -AssumeWindows(). // Done in: StringlyTypedPath, StringlyTypedPathOperator

        bool IsRootIndicatedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsNotRootIndicatedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsRelativeIndicatedPath(string path); // Same as IsNotRootIndicated(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsRootedPath(string path); // Same as IsRootIndicatedPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsAbsolutePath(string path); // Same as IsRootIndicatedPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsRelativePath(string path); // Same as IsNotRootIndicatedPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator

        bool IsDirectoryIndicatedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsNotDirectoryIndicatedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsFileIndicatedPath(string path); // Same as IsNotDirectoryIndicated(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsDirectoryPath(string path); // Same as IsDirectoryIndicatedPath(). Caveat is that directory paths must be directory indicated! // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsFilePath(string path); // Same as IsNotDirectoryIndicatedPath(). Caveat is that directory paths must be directory indicated! // Done in: StringlyTypedPath, StringlyTypedPathOperator

        bool IsExistingDirectory(string path); // Tests the file system. Same as ExistsDirectoryPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsExistingFile(string path); // Tests the file system. Same as ExistsFilePath(). Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsDirectory(string path); // With caveat that directory must exist. Same as ExistsDirectoryPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsFile(string path); // With caveat that file must exist. Same as ExistsFilePath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator

        bool IsResolvedPath(string path); // Done in: // Done in: StringlyTypedPath, StringlyTypedPathOperator
        bool IsUnresolvedPath(string path); // Done in: // Done in: StringlyTypedPath, StringlyTypedPathOperator

        // Validate.
        void ValidateIsDirectoryIndicatedPath(string pathSegment); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        void ValidateIsDirectoryIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        void ValidateNotDirectoryIndicatedPath(string pathSegment); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        void ValidateNotDirectoryIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        void ValidateIsFileIndicatedPath(string pathSegment); // Same as ValidateNotDirectoryIndicatedPath(). Done in: StringlyTypedPath, StringlyTypedPathOperator
        void ValidateIsFileIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        void ValidateIsRootIndicatedPath(string pathSegment); // Same as ValidateNotDirectoryIndicatedPath(). Done in: StringlyTypedPath, StringlyTypedPathOperator
        void ValidateIsRootIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        void ValidateNotRootIndicatedPath(string pathSegment); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        void ValidateNotRootIndicatedPath(string pathSegment, string parameterName); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        // Ensure.
        string EnsureDirectorySeparatorUnchecked(string path, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureDirectorySeparatorChecked(string path, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureDirectorySeparator(string path, string directorySeparator); // Uses -Checked(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureWindowsDirectorySeparator(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureNonWindowsDirectorySeparator(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureWindowsPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureNonWindowsPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string EnsureRootIndicatedPath(string path, string directorySeparator); // Checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureRootIndicatedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureNotRootIndicatedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureRelativeIndicatedPath(string path); // Same as EnsureNotRootIndicatedPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureRootedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureAbsolutePath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureRelativePath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureRootedPathIsRootIndicated(string rootedPath, string directorySeparator); // Same as EnsureRootIndicatedPath(). Directory separator is checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureRootedPathIsRootIndicated(string rootedPath); // Same as EnsureRootIndicatedPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureRelativePathIsNotRootIndicated(string relativePath); // Same as EnsureNotRootIndicatedPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string MakePathRootIndicatedUnchecked(string path, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string MakePathRootIndicatedChecked(string path, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string MakePathRootIndicated(string path, string directorySeparator); // Directory separator is checked, path is not. // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string EnsureDirectoryIndicatedPath(string path, string directorySeparator); // Checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureDirectoryIndicatedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureNotDirectoryIndicatedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureFileIndicatedPath(string path); // Same as EnsureNotDirectoryIndicatedPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureDirectoryPathIsDirectoryIndicated(string directoryPath, string directorySeparator); // Same as EnsureDirectoryIndicatedPath(). Directory separator is checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureDirectoryPathIsDirectoryIndicated(string directoryPath); // Same as EnsureDirectoryIndicatedPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string EnsureFilePathIsNotDirectoryIndicated(string filePath); // Same as EnsureNotDirectoryIndicatedPath(). // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string MakePathDirectoryIndicatedUnchecked(string path, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string MakePathDirectoryIndicatedChecked(string path, string directorySeparator); // Directory separator is checked, path is not. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string MakePathDirectoryIndicated(string path, string directorySeparator); // Uses checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string EnsureResolvedPath(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        // Relative paths.
        string GetRelativePathUriToUri_Internal(string sourcePath, string destinationPath); // Internal, uses Uri.MakeRelativeUri(). StringlyTypedPathInternals.
        string GetRelativePathOutputWindowsIfWindows_Internal(string sourcePath, string destinationPath); // Internal. StringlyTypedPathInternals.

        string GetRelativePath(string sourcePath, string destinationPath); // Limitations due to assumption of directory vs. file, output Windows if source is Windows, Non-Windows if source is Non-Windows. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetRelativePathFileToFile(string sourceFilePath, string destinationFilePath); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetRelativePathFileToDirectory(string sourceFilePath, string destinationDirectoryPath); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetRelativePathDirectoryToFile(string sourceDirectoryPath, string destinationFilePath); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetRelativePathDirectoryToDirectory(string sourceDirectoryPath, string destinationDirectoryPath); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        // Combining relative paths is handled well by the Combine() methods.
        //string CombineRelativePathUnchecked(string sourcePath, string relativePath, string directoryPath); // Directory separator is unchecked, sourcePath is unchecked for directory indication, and relative path is unchecked for root indication.
        //string CombineRelativePathSimple(string sourcePath, string relativePath, string directoryPath); // Directory separator is checked, sourcePath is checked for directory indication, and relative path is checked for root indication.
        //string CombineRelativePath(string sourcePath, string relativePath, string directorySeparator); // Directory separator is checked, sourcePath and relativePath are ensured.

        // Resolution.
        string ResolvePath(string unresolvedPath); // Done in: StringlyTypedPath
        // ?? Others, depending on file vs. directory output?

        // Combine.
        string CombineDirectoryIndicatedUnchecked(string directoryIndicatedPathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineDirectoryIndicatedChecked(string directoryIndicatedPathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineDirectoryIndicatedEnsured(string directoryIndicatedPathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineDirectoryIndicated(string directoryIndicatedPathSegment1, string pathSegment2); // Uses ensured. // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string CombineUnresolvedUnchecked(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineUnresolvedChecked(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineUnresolvedEnsured(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineTwoUnresolved(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineUnresolved(string directorySeparator, params string[] pathSegments); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineTwo(string directorySeparator, string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineUsingDirectorySeparator(string directorySeparator, params string[] pathSegments); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineTwo(string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string Combine(params string[] pathSegments); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string Combine(string pathSegment1, string pathSegment2); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string CombineWindows(params string[] pathSegments); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string CombineNonWindows(params string[] pathSegments); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string GetFilePathUnchecked(string directoryPath, string fileName, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetFilePathChecked(string directoryPath, string fileName, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetFilePathEnsured(string directoryPath, string fileName, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetFilePath(string directoryPath, string fileName, string directorySeparator); // Uses ensured. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetFilePath(string directoryPath, string fileName); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string GetDirectoryPathUnchecked(string directoryPath, string directoryName, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetDirectoryPathChecked(string directoryPath, string directoryName, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetDirectoryPathEnsured(string directoryPath, string directoryName, string directorySeparator); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetDirectoryPath(string directoryPath, string directoryName, string directorySeparator); // Uses ensured. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetDirectoryPath(string directoryPath, string directoryName); // Uses ensured. // Done in: StringlyTypedPath, StringlyTypedPathOperator

        // Separate.
        string[] GetPathSegmentsUnchecked(string path, string directorySeparator); // Directory separator is unchecked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string[] GetPathSegmentsChecked(string path, string directorySeparator); // Directory separator is checked, path is not. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string[] GetPathSegments(string path, string directorySeparator); // Uses -Checked(). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string[] GetPathParts(string path); // Uses both valid directory separators to split the path full into parts (not segments like the others). // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string[] GetAllPathParts(string path); // Gets all path parts, even empty ones if the path is directory or root indicated. Uses both valid directory separators to split the path full into parts (not segments like the others). // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string GetFileNamePathSegment(params string[] pathSegments); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string GetFileName(string filePath); // FilePath is checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetFileNameWithoutExtension(string filePath); // FilePath is checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetFileExtension(string filePath); // FilePath is checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetDirectoryPathForFilePath(string filePath); // FilePath is checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetDirectoryNameForFilePath(string filePath); // FilePath is checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string GetDirectoryNameForDirectoryPathChecked(string directoryPath); // DirectoryPath is checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetDirectoryNameForDirectoryPathEnsured(string directoryPath); // DirectoryPath is ensured. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetDirectoryNameForDirectoryPath(string directoryPath); // Uses ensured. // Done in: StringlyTypedPath, StringlyTypedPathOperator

        string GetParentDirectoryPathForDirectoryPathChecked(string directoryPath); // Directory path is checked. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetParentDirectoryPathForDirectoryPathEnsured(string directoryPath); // Directory path is ensured. // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetParentDirectoryPathForDirectoryPath(string directoryPath); // Uses ensured. // Done in: StringlyTypedPath, StringlyTypedPathOperator


        #region Exceptions

        string GetPathIsDirectoryIndicatedExceptionMessage(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        Exception GetPathIsDirectoryIndicatedException(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        ArgumentException GetPathIsDirectoryIndicatedArgumentException(string path, string parameterName); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetPathNotDirectoryIndicatedExceptionMessage(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        Exception GetPathNotDirectoryIndicatedException(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        ArgumentException GetPathNotDirectoryIndicatedArgumentException(string path, string parameterName); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetPathIsRootIndicatedExceptionMessage(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        Exception GetPathIsRootIndicatedException(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        ArgumentException GetPathIsRootIndicatedArgumentException(string path, string parameterName); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        string GetPathNotRootIndicatedExceptionMessage(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        Exception GetPathNotRootIndicatedException(string path); // Done in: StringlyTypedPath, StringlyTypedPathOperator
        ArgumentException GetPathNotRootIndicatedArgumentException(string path, string parameterName); // Done in: StringlyTypedPath, StringlyTypedPathOperator

        #endregion
    }
}
