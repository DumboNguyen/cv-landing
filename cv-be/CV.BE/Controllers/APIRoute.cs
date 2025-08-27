using CV.BE.Constants;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace CV.BE.Controllers
{
    public class APIRoute : RouteAttribute
    {
        public APIRoute([StringSyntax("Route")] string template) : base(ApplicationConstants.APIRoute + template)
        {
        }
    }
}
