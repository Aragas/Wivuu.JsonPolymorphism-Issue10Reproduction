using System.Text.Json.Serialization;

namespace Issue10Reproduction.Library2
{
    public enum NestedClassDiscriminator
    {
        Test1,
        Test2,
    }
    public abstract partial record NestedClass([JsonDiscriminator] NestedClassDiscriminator EventType);
    public record Test1NestedClass(string Arg1) : NestedClass(NestedClassDiscriminator.Test1);
    public record Test2NestedClass(string Arg1) : NestedClass(NestedClassDiscriminator.Test2);
}
