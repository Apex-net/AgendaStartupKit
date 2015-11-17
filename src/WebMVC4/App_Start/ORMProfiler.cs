[assembly: WebActivatorEx.PostApplicationStartMethod(
    typeof(WebMVC4.App_Start.ORMProfilerPackage), "PostStart")]

// ReSharper disable once CheckNamespace
namespace WebMVC4.App_Start
{
    using SD.Tools.OrmProfiler.Interceptor;

    public static class ORMProfilerPackage
    {
        public static void PostStart()
        {
            InterceptorCore.Initialize("WebMVC4");
        }
    }
}
