using System.Reflection;

namespace App1.Extensions;

public static class ResourceDictionaryLoader
{
    public static ResourceDictionary Scoped(this ResourceDictionary dictionary, string resourcePath, Assembly? containingAssembly = null)
    {
        var uri = new Uri(resourcePath, UriKind.Relative);
        var assembly = containingAssembly ?? Assembly.GetCallingAssembly();
        
        var resource = new ResourceDictionary();
        resource.SetAndLoadSource(uri, resourcePath, assembly, null);

        dictionary.Add(resource);
        return dictionary;
    }
}