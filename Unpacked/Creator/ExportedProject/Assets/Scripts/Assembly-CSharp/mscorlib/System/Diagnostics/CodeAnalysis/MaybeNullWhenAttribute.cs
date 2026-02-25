namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = False)]
[Token(Token = "0x200058A")]
public sealed class MaybeNullWhenAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001795")]
	private readonly bool <ReturnValue>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600286E")]
	public MaybeNullWhenAttribute(bool returnValue) { }

}

