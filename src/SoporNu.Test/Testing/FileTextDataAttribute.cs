using System.Reflection;

using Xunit.Sdk;

namespace SoporNu.Test.Testing
{
    public sealed class FileTextDataAttribute(string path) : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if (File.Exists(path))
            {
                yield return new object[] { File.ReadAllText(path) };
            }
            else if (Directory.Exists(path))
            {
                foreach (var path in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories))
                {
                    yield return new object[] { File.ReadAllText(path) };
                }
            }
        }
    }
}