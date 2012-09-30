using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arbyter
{
    public enum ActionResult
    {
        Unknown,
        Success,
        Failure
    }
    public class ActionReport
    {
        
        public readonly int? FilesAffected;
        public readonly Exception Exception;
        public readonly ActionResult Result;

        public ActionReport(int? filesCopied, ActionResult result, Exception exception)
        {
            FilesAffected = filesCopied;
            Result = result;
            Exception = exception;
        }

    }
}
