using CV.BE.API.Constants;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace CV.BE.API.Controllers
{
    public class APIRoute : RouteAttribute
    {
        public APIRoute([StringSyntax("Route")] string template) : base(ApplicationConstants.APIRoute + template)
        {
        }
    }
}
