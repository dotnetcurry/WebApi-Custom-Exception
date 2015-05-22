using System;

namespace WEBAPI_Execption.CustomFilterRepo
{
    /// <summary>
    /// The base Exception Class
    /// </summary>
    public class ProcessException : Exception
    {
        public ProcessException(string message)
            : base(message)
        {

        }
    }
}