using Nancy;

namespace AspNetSelfHostDemo
{
    public class NancyDemo : NancyModule
    {
        public NancyDemo()
        {
            Get["/nancy/demo"] = _ => "Go world.";
        }
    }
}
