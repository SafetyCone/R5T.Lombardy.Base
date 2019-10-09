using System;


namespace R5T.Lombardy
{
    public interface IStringlyTypedPathOperator
    {
        bool ExistsFilePath(string filePath);
        bool ExistsDirectoryPath(string directoryPath);

        void DeleteFilePath(string filePath);
        void DeleteDirectoryPath(string directoryPath, bool recursive = true);

        char GetTerminatingChar(string path);

        char DetectDirectorySeparatorChar(string path);
        bool TryDetectDirectorySeparatorChar(string path, out char directorySeparatorChar);
        string DetectDirectorySeparator(string path);
        bool TryDetectDirectorySeparator(string path, out string directorySeparator);

        // Classification.
        bool IsWindowsPathAssumeWindows(string path);
        bool IsWindowsPathStrict(string path);
        bool IsWindowsPath(string path);
        bool IsNonWindowsPathAssumeNonWindows(string path);
        bool IsNonWindowsPathStrict(string path);
        bool IsNonWindowsPath(string path);

        bool IsRootIndicatedPath(string path);
        bool IsNotRootIndicatedPath(string path);
        bool IsRelativeIndicatedPath(string path);
        bool IsRootedPath(string path);
        bool IsAbsolutePath(string path);
        bool IsRelativePath(string path);

        bool IsDirectoryIndicatedPath(string path);
        bool IsNotDirectoryIndicatedPath(string path);
        bool IsFileIndicatedPath(string path);
        bool IsDirectoryPath(string path);
        bool IsFilePath(string path);

        bool IsExistingDirectory(string path);
        bool IsExistingFile(string path);
        bool IsDirectory(string path);
        bool IsFile(string path);

        bool IsResolvedPath(string path);
        bool IsUnresolvedPath(string path);

        // Validate.
        void ValidateIsDirectoryIndicatedPath(string pathSegment);
        void ValidateIsDirectoryIndicatedPath(string pathSegment, string parameterName);
        void ValidateNotDirectoryIndicatedPath(string pathSegment);
        void ValidateNotDirectoryIndicatedPath(string pathSegment, string parameterName);
        void ValidateIsFileIndicatedPath(string pathSegment);
        void ValidateIsFileIndicatedPath(string pathSegment, string parameterName);
        void ValidateIsRootIndicatedPath(string pathSegment);
        void ValidateIsRootIndicatedPath(string pathSegment, string parameterName);
        void ValidateNotRootIndicatedPath(string pathSegment);
        void ValidateNotRootIndicatedPath(string pathSegment, string parameterName);

        // Ensure.
        string EnsureDirectorySeparatorUnchecked(string path, string directorySeparator);
        string EnsureDirectorySeparatorChecked(string path, string directorySeparator);
        string EnsureDirectorySeparator(string path, string directorySeparator);
        string EnsureWindowsDirectorySeparator(string path);
        string EnsureNonWindowsDirectorySeparator(string path);
        string EnsureWindowsPath(string path);
        string EnsureNonWindowsPath(string path);

        string EnsureRootIndicatedPath(string path, string directorySeparator);
        string EnsureRootIndicatedPath(string path);
        string EnsureNotRootIndicatedPath(string path);
        string EnsureRelativeIndicatedPath(string path);
        string EnsureRootedPath(string path);
        string EnsureAbsolutePath(string path);
        string EnsureRelativePath(string path);
        string EnsureRootedPathIsRootIndicated(string rootedPath, string directorySeparator);
        string EnsureRootedPathIsRootIndicated(string rootedPath);
        string EnsureRelativePathIsNotRootIndicated(string relativePath);

        string MakePathRootIndicatedUnchecked(string path, string directorySeparator);
        string MakePathRootIndicatedChecked(string path, string directorySeparator);
        string MakePathRootIndicated(string path, string directorySeparator);

        string EnsureDirectoryIndicatedPath(string path, string directorySeparator);
        string EnsureDirectoryIndicatedPath(string path);
        string EnsureNotDirectoryIndicatedPath(string path);
        string EnsureFileIndicatedPath(string path);
        string EnsureDirectoryPathIsDirectoryIndicated(string directoryPath, string directorySeparator);
        string EnsureDirectoryPathIsDirectoryIndicated(string directoryPath);
        string EnsureFilePathIsNotDirectoryIndicated(string filePath);

        string MakePathDirectoryIndicatedUnchecked(string path, string directorySeparator);
        string MakePathDirectoryIndicatedChecked(string path, string directorySeparator);
        string MakePathDirectoryIndicated(string path, string directorySeparator);

        string EnsureResolvedPath(string path);

        // Relative paths.
        string GetRelativePath(string sourcePath, string destinationPath);
        string GetRelativePathFileToFile(string sourceFilePath, string destinationFilePath);
        string GetRelativePathFileToDirectory(string sourceFilePath, string destinationDirectoryPath);
        string GetRelativePathDirectoryToFile(string sourceDirectoryPath, string destinationFilePath);
        string GetRelativePathDirectoryToDirectory(string sourceDirectoryPath, string destinationDirectoryPath);

        // Resolution.
        string ResolvePath(string unresolvedPath);

        // Combine.
        string CombineDirectoryIndicatedUnchecked(string directoryIndicatedPathSegment1, string pathSegment2);
        string CombineDirectoryIndicatedChecked(string directoryIndicatedPathSegment1, string pathSegment2);
        string CombineDirectoryIndicatedEnsured(string directoryIndicatedPathSegment1, string pathSegment2);
        string CombineDirectoryIndicated(string directoryIndicatedPathSegment1, string pathSegment2);

        string CombineUnresolvedUnchecked(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUnresolvedChecked(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUnresolvedEnsured(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineTwoUnresolved(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUnresolved(string directorySeparator, params string[] pathSegments);
        string CombineTwo(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUsingDirectorySeparator(string directorySeparator, params string[] pathSegments);
        string CombineTwo(string pathSegment1, string pathSegment2);
        string Combine(params string[] pathSegments);
        string Combine(string pathSegment1, string pathSegment2);

        string CombineWindows(params string[] pathSegments);
        string CombineNonWindows(params string[] pathSegments);

        string GetFilePathUnchecked(string directoryPath, string fileName, string directorySeparator);
        string GetFilePathChecked(string directoryPath, string fileName, string directorySeparator);
        string GetFilePathEnsured(string directoryPath, string fileName, string directorySeparator);
        string GetFilePath(string directoryPath, string fileName, string directorySeparator);
        string GetFilePath(string directoryPath, string fileName);

        string GetDirectoryPathUnchecked(string directoryPath, string directoryName, string directorySeparator);
        string GetDirectoryPathChecked(string directoryPath, string directoryName, string directorySeparator);
        string GetDirectoryPathEnsured(string directoryPath, string directoryName, string directorySeparator);
        string GetDirectoryPath(string directoryPath, string directoryName, string directorySeparator);
        string GetDirectoryPath(string directoryPath, string directoryName);

        // Separate.
        string[] GetPathSegmentsUnchecked(string path, string directorySeparator);
        string[] GetPathSegmentsChecked(string path, string directorySeparator);
        string[] GetPathSegments(string path, string directorySeparator);
        string[] GetPathParts(string path);
        string[] GetAllPathParts(string path);

        string GetFileNamePathSegment(params string[] pathSegments);

        string GetFileName(string filePath);
        string GetFileNameWithoutExtension(string filePath);
        string GetFileExtension(string filePath);
        string GetDirectoryPathForFilePath(string filePath);
        string GetDirectoryNameForFilePath(string filePath);

        string GetDirectoryNameForDirectoryPathChecked(string directoryPath);
        string GetDirectoryNameForDirectoryPathEnsured(string directoryPath);
        string GetDirectoryNameForDirectoryPath(string directoryPath);

        string GetParentDirectoryPathForDirectoryPathChecked(string directoryPath);
        string GetParentDirectoryPathForDirectoryPathEnsured(string directoryPath);
        string GetParentDirectoryPathForDirectoryPath(string directoryPath);


        #region Exceptions

        string GetPathIsDirectoryIndicatedExceptionMessage(string path);
        Exception GetPathIsDirectoryIndicatedException(string path);
        ArgumentException GetPathIsDirectoryIndicatedArgumentException(string path, string parameterName);
        string GetPathNotDirectoryIndicatedExceptionMessage(string path);
        Exception GetPathNotDirectoryIndicatedException(string path);
        ArgumentException GetPathNotDirectoryIndicatedArgumentException(string path, string parameterName);
        string GetPathIsRootIndicatedExceptionMessage(string path);
        Exception GetPathIsRootIndicatedException(string path);
        ArgumentException GetPathIsRootIndicatedArgumentException(string path, string parameterName);
        string GetPathNotRootIndicatedExceptionMessage(string path);
        Exception GetPathNotRootIndicatedException(string path);
        ArgumentException GetPathNotRootIndicatedArgumentException(string path, string parameterName);

        #endregion
    }
}
