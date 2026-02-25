namespace JetBrains.Annotations;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x2000064")]
public sealed class PureAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FD")]
	public PureAttribute() { }

}

