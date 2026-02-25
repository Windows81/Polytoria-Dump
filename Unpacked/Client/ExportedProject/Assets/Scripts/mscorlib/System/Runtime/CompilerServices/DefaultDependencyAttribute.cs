namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1))]
[Token(Token = "0x2000498")]
public sealed class DefaultDependencyAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001285")]
	private LoadHint loadHint; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020A1")]
	public DefaultDependencyAttribute(LoadHint loadHintArgument) { }

}

