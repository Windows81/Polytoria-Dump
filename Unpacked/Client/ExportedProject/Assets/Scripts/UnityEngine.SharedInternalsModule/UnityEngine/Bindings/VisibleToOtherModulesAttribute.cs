namespace UnityEngine.Bindings;

[AttributeUsage(5628, Inherited = False)]
[Token(Token = "0x2000008")]
[VisibleToOtherModules]
internal class VisibleToOtherModulesAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public VisibleToOtherModulesAttribute() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public VisibleToOtherModulesAttribute(String[] modules) { }

}

