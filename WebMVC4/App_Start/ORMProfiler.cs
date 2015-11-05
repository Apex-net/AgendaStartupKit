[assembly: WebActivatorEx.PostApplicationStartMethod(
    typeof($safeprojectname$.App_Start.ORMProfilerPackage), "PostStart")]

// ReSharper disable once CheckNamespace
namespace $safeprojectname$.App_Start
{
    using SD.Tools.OrmProfiler.Interceptor;

    public static class ORMProfilerPackage
    {
        public static void PostStart()
        {
            InterceptorCore.Initialize("$safeprojectname$");
        }
    }
}
