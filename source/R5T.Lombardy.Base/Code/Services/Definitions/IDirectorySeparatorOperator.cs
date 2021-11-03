using System;

using R5T.T0064;


namespace R5T.Lombardy
{
    [ServiceDefinitionMarker]
    public interface IDirectorySeparatorOperator : IServiceDefinition
    {
        char InvalidDirectorySeparatorChar { get; }
        char WindowsDirectorySeparatorChar { get; }
        char NonWindowsDirectorySeparatorChar { get; }
        char ExecutingMachineDefaultDirectorySeparatorChar { get; }
        char PlatformDefaultDirectorySeparatorChar { get; }
        char DefaultDirectorySeparatorChar { get; set; }

        string InvalidDirectorySeparator { get; }
        string WindowsDirectorySeparator { get; }
        string NonWindowsDirectorySeparator { get; }
        string ExecutingMachineDefaultDirectorySeparator { get; }
        string PlatformDefaultDirectorySeparator { get; }
        string DefaultDirectorySeparator { get; set; }


        void ResetDefaultDirectorySeparator();

        //char GetDirectorySeparatorCharForPlatform(Platform platform);
        //string GetDirectorySeparatorForPlatform(Platform platform);
        //Platform GetPlatformForDirectorySeparator(char directorySeparator);
        //Platform GetPlatformForDirectorySeparator(string directorySeparator);

        char GetDirectorySeparatorStringToCharUnchecked(string directorySeparator);
        char GetDirectorySeparatorStringToChar(string directorySeparator);
        string GetDirectorySeparatorCharToStringUnchecked(char directorySeparatorChar);
        string GetDirectorySeparatorCharToString(char directorySeparatorChar);

        bool IsInvalid(char directorySeparator);
        bool IsValid(char directorySeparator);
        void Validate(char directorySeparator);
        void Validate(char directorySeparator, string argumentName);
        void ValidateWindows(char directorySeparator);
        void ValidateWindows(char directorySeparator, string argumentName);
        void ValidateNonWindows(char directorySeparator);
        void ValidateNonWindows(char directorySeparator, string argumentName);
        bool IsDirectorySeparator(char possibleDirectorySeparator);
        bool IsDirectorySeparator(char value, char possibleDirectorySeparator);
        bool IsWindowsDirectorySeparator(char directorySeparator);
        bool IsNonWindowsDirectorySeparator(char directorySeparator);

        bool IsInvalid(string directorySeparator);
        bool IsValid(string directorySeparator);
        void Validate(string directorySeparator);
        void Validate(string directorySeparator, string argumentName);
        void ValidateWindows(string directorySeparator);
        void ValidateWindows(string directorySeparator, string argumentName);
        void ValidateNonWindows(string directorySeparator);
        void ValidateNonWindows(string directorySeparator, string argumentName);
        bool IsDirectorySeparator(string possibleDirectorySeparator);
        bool IsDirectorySeparator(string value, string possibleDirectorySeparator);
        bool IsWindowsDirectorySeparator(string directorySeparator);
        bool IsNonWindowsDirectorySeparator(string directorySeparator);

        char GetAlternateDirectorySeparatorUnchecked(char directorySeparator);
        char GetAlternateDirectorySeparator(char directorySeparator);

        string GetAlternateDirectorySeparatorUnchecked(string directorySeparator);
        string GetAlternateDirectorySeparator(string directorySeparator);

        bool TryDetectDirectorySeparator(string pathSegment, out string directorySeparator, string defaultDirectorySeparator);
        bool TryDetectDirectorySeparatorOrInvalid(string pathSegment, out string directorySeparator);
        bool TryDetectDirectorySeparatorOrDefault(string pathSegment, out string directorySeparator);
        bool TryDetectDirectorySeparator(string pathSegment, out string directorySeparator);
        string DetectDirectorySeparator(string pathSegment);
        string DetectDirectorySeparatorOrDefault(string pathSegment);
        string DetectDirectorySeparatorOrDefault(string pathSegment, string defaultDirectorySeparator);
        string DetectDirectorySeparatorOrWindows(string pathSegment);
        string DetectDirectorySeparatorOrNonWindows(string pathSegment);

        bool IsDirectorySeparatorDetected(string pathSegment);
        bool IsDirectorySeparatorDetectedUnchecked(string pathSegment, string directorySeparator);
        bool IsDirectorySeparatorDetected(string pathSegment, string directorySeparator);
        bool IsWindowsDirectorySeparatorDetected(string pathSegment);
        bool IsWindowsDirectorySeparatorDetectedAssumeWindows(string pathSegment);
        bool IsNonWindowsDirectorySeparatorDetected(string pathSegment);
        bool IsNonWindowsDirectorySeparatorDetectedAssumeNonWindows(string pathSegment);
        bool IsMixedDirectorySeparatorsDetected(string pathSegment);

        bool ContainsDirectorySeparator(string pathSegment);
        bool ContainsDirectorySeparatorUnchecked(string pathSegment, string directorySeparator);
        bool ContainsDirectorySeparator(string pathSegment, string directorySeparator);
        bool ContainsWindowsDirectorySeparator(string pathSegment);
        bool ContainsNonWindowsDirectorySeparator(string pathSegment);
        bool ContainsMixedDirectorySeparator(string pathSegment);

        bool TryGetDominantDirectorySeparator(string pathSegment, out string dominantDirectorySeparator);
        string GetDominantDirectorySeparator(string pathSegment);
        //bool TryGetDominantDirectorySeparatorPlatform(string pathSegment, out Platform platform);
        //Platform GetDominantDirectorySeparatorPlatform(string pathSegment);

        string GetInvalidDirectorySeparatorExceptionMessage(string invalidDirectorySeparator);
        Exception GetInvalidDirectorySeparatorException(string invalidDirectorySeparator);
        ArgumentException GetInvalidDirectorySeparatorArgumentException(string invalidDirectorySeparator, string parameterName);
        string GetWindowsDirectorySeparatorExpectedExceptionMessage(string notWindowsDirectorySeparator);
        Exception GetWindowsDirectorySeparatorExpectedException(string notWindowsDirectorySeparator);
        ArgumentException GetWindowsDirectorySeparatorExpectedArgumentException(string found, string parameterName);
        string GetNonWindowsDirectorySeparatorExpectedExceptionMessage(string notNonWindowsDirectorySeparator);
        Exception GetNonWindowsDirectorySeparatorExpectedException(string notNonWindowsDirectorySeparator);
        ArgumentException GetNonWindowsDirectorySeparatorExpectedArgumentException(string found, string parameterName);
        string GetUnableToDetectDirectorySeparatorExceptionMessage(string pathSegment);
        Exception GetUnableToDetectDirectorySeparatorException(string pathSegment);
        ArgumentException GetUnableToDetectDirectorySeparatorArgumentException(string pathSegment, string parameterName);
    }
}
