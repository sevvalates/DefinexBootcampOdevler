namespace AttributeClassLibrary
{
    // [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class ZorunluAlanAttribute : Attribute
    {

    }
}
