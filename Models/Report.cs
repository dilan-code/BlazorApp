using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Report
    {
        public string Message  { get; private set; }
        public bool Success { get; private set; }
        public Report(string message, bool success = true)
        {
            Message = message;
            Success = success;
            Kit.Log($"Report: {message} - {(success ? "Success" : "Failed")}");
        }
    }
}
