using Microsoft.AspNetCore.Http;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSample
{
    public static class LogEnricher
    {
        public static void EnrichFromRequest(IDiagnosticContext diagnosticContext, HttpContext httpContext)
        {
            diagnosticContext.Set("ClientIP", httpContext.Connection.RemoteIpAddress.ToString());
            diagnosticContext.Set("UserAgent", httpContext.Request.Headers["User-Agent"].FirstOrDefault());
            // diagnosticContext.Set("Resource", httpContext.GetMetricsCurrentResourceName());
        }
    }
}
