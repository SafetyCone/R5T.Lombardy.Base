using System;

using R5T.T0064;


namespace R5T.Lombardy
{
    [ServiceDefinitionMarker]
    public interface IFileNameOperator : IServiceDefinition
    {
        char DefaultFileNameSegmentSeparatorChar { get; }
        string DefaultFileNameSegmentSeparator { get; }

        // Combine.
        string GetFileName(string fileNameWithoutExtension, string fileExtension);

        // Separate.
        string[] GetFileNameSegments(string fileName, string fileNameSegmentSeparator);

        string GetFileNameWithoutExtension(string fileName);
        string GetFileExtension(string fileName);

        // Miscellaneous.
        string GetRandomFileNameWithoutExtension();
        string GetRandomFileName();
        string GetRandomFileName(string fileExtension);
        string GetGUIDedFileNameWithoutExtension();
        string GetGUIDedFileName();
        string GetGUIDedFileName(string fileExtension);
    }
}
