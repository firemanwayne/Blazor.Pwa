using System;

namespace Shared.Exceptions
{
    internal class FileNameMissingExtensionException : Exception
    {
        public FileNameMissingExtensionException() : base("The file name provided is missing the extension")
        { }
    }
}