namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = False)]
[Token(Token = "0x200058B")]
public sealed class NotNullWhenAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001796")]
	private readonly bool <ReturnValue>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600286F")]
	public NotNullWhenAttribute(bool returnValue) { }

}

