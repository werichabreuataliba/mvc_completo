using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Extensions
{
    [HtmlTargetElement("*", Attributes="supress-by-claim-name")]
    [HtmlTargetElement("*", Attributes = "supress-by-claim-value")]
    public class ApagaElementloByClaimTagHelper: TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApagaElementloByClaimTagHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HtmlAttributeName("supress-by-claim-name")]
        public string IdentityClaimName { get; set; }

        [HtmlAttributeName("supress-by-claim-value")]
        public string IdentityClaimValue { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output == null)
                throw new ArgumentException(nameof(context));
            if (context == null)
                throw new ArgumentException(nameof(output));

            var temAcesso = CustomAuthorization.ValidarClaimUsuario(_httpContextAccessor.HttpContext, IdentityClaimName, IdentityClaimValue);

            if (temAcesso) return;

            output.SuppressOutput();
            base.Process(context, output);
        }
    }

    [HtmlTargetElement("a", Attributes ="disable-by-claim-name")]
    [HtmlTargetElement("a", Attributes = "disable-by-claim-name")]
    public class DesabilitaLinkByClaimTagHelper: TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DesabilitaLinkByClaimTagHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HtmlAttributeName("disable-by-claim-name")]
        public string IdentityClaimName { get; set; }

        [HtmlAttributeName("disable-by-claim-value")]
        public string IdentityClaimValue { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output == null)
                throw new ArgumentException(nameof(context));
            if (context == null)
                throw new ArgumentException(nameof(output));

            var temAcesso = CustomAuthorization.ValidarClaimUsuario(_httpContextAccessor.HttpContext, IdentityClaimName, IdentityClaimValue);

            if (temAcesso) return;

            output.Attributes.RemoveAll("href");
            output.Attributes.Add(new TagHelperAttribute("style", "cursor: not-allowed"));
            output.Attributes.Add(new TagHelperAttribute("title", "Você não tem permissão"));
        }
    }

    [HtmlTargetElement("*", Attributes = "suppress-by-action")]
    public class ApagaElementoByActionTagHelper: TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApagaElementoByActionTagHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HtmlAttributeName("suppress-by-action")]
        public string ActionName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output == null)
                throw new ArgumentException(nameof(context));
            if (context == null)
                throw new ArgumentException(nameof(output));

            var action = _httpContextAccessor.HttpContext.GetRouteData().Values["action"].ToString();

            if (ActionName.Contains(action)) return;

            output.SuppressOutput();
        }
    }
}
