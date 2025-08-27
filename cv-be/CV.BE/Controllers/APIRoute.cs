using CV.BE.Web.Constants;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace CV.BE.Web.Controllers
{
    public class APIRoute : RouteAttribute
    {
        public APIRoute([StringSyntax("Route")] string template) : base(ApplicationConstants.APIRoute + template)
        {
        }
    }
}
