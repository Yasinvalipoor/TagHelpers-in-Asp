using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersInAsp.TagHelpers
{
    [HtmlTargetElement("alert")] //به این صورت در کد نوشته میشه
    public class alertTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div"; //چیزی که در اصل رندر میشه
            output.Attributes.Add("class", "alert alert-success");
            output.Attributes.Add("role", "alert");

            TagBuilder h4 = new TagBuilder("h4");
            h4.InnerHtml.Append("Well done!");
            h4.Attributes.Add("class", "alert-heading");
            output.PreContent.AppendHtml(h4);

            TagBuilder p = new TagBuilder("p");
            p.InnerHtml.Append("Aww yeah, you successfully read this important alert message. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.");
            //p.Attributes.Add("class", "alert-heading");
            output.PreContent.AppendHtml(p);

            TagBuilder hr = new TagBuilder("hr");
            output.PreContent.AppendHtml(hr);

            TagBuilder p1 = new TagBuilder("p");
            p1.InnerHtml.Append("Whenever you need to, be sure to use margin utilities to keep things nice and tidy.");
            p1.Attributes.Add("class","mb-0");
            output.PreContent.AppendHtml(p1);
        }
    }
}
