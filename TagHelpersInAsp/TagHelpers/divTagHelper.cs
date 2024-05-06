using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersInAsp.TagHelpers
{
    [HtmlTargetElement("div",Attributes ="BorderCustomColor")] //یعنی زمانی این تگ هلپر فعال بشه که یک دیو این اسم رو داشته باشه
    public class divTagHelper : TagHelper
    {
        public string BorderCustomColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.Add("class", $"border border-{BorderCustomColor} border-5 rounded");

            output.PreElement.Append("(PreElement)");
            output.PostElement.Append("(PostElement)");

            output.PreContent.Append("(PreContent)");
            output.PostContent.Append("(PostContent)");
        }
    }
}
