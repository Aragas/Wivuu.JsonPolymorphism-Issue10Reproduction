using Issue10Reproduction.Library2;

using System.Text.Json.Serialization;

namespace Issue10Reproduction.Library1
{
    public partial class ContextHolder
    {
        [JsonSerializable(typeof(Test1ParentClass))]
        internal partial class JsonContext : JsonSerializerContext { }
    }

    internal sealed record Test1ParentClass(string Arg1, NestedClass Arg2);
}
