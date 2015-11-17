[assembly: WebActivatorEx.PostApplicationStartMethod(
    typeof($rootnamespace$.App_Start.ORMProfilerPackage), "PostStart")]

// ReSharper disable once CheckNamespace
namespace $rootnamespace$.App_Start
{
    using SD.Tools.OrmProfiler.Interceptor;

    public static class ORMProfilerPackage
    {
        public static void PostStart()
        {
            InterceptorCore.Initialize("$assemblyname$");
        }
    }
}
