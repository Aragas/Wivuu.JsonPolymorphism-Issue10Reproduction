using Issue10Reproduction.Library2;

using System;
using System.Text.Json.Serialization;

namespace Issue10Reproduction.Library1
{
    public partial class ContextHolder
    {
        // Using
        // [JsonSerializable(typeof(ParentClass))]
        // Won't serialize the derived fields like Arg1 and Arg2
        [JsonSerializable(typeof(Test1ParentClass))]
        internal partial class JsonContext : JsonSerializerContext { }
    }

    internal enum ParentClassDisctiminator
    {
        Test1,
        Test2,
    }

    internal abstract record ParentClass(ParentClassDisctiminator Type, long Timestamp);
    internal sealed record Test1ParentClass(string Arg1, NestedClass Arg2) : ParentClass(ParentClassDisctiminator.Test1, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
}
