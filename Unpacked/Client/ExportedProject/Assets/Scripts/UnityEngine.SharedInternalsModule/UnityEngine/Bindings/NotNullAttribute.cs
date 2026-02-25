namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Parameter (2048))]
[Token(Token = "0x2000012")]
[VisibleToOtherModules]
internal class NotNullAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000028")]
	public NotNullAttribute() { }

}

