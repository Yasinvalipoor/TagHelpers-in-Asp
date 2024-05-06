using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersInAsp.TagHelpers
{
    [HtmlTargetElement("p",Attributes = "TxtcustomBgColor")]
    public class pTagHelper : TagHelper
    {
        public string TxtcustomBgColor { get; set; } = "";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.Add("class",$"text-bg-{TxtcustomBgColor}");
        }
    }
}
