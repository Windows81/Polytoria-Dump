namespace UnityEngine;

[AttributeUsage(AttributeTargets::Parameter (2048), AllowMultiple = False)]
[Token(Token = "0x2000004")]
[VisibleToOtherModules]
internal class WritableAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public WritableAttribute() { }

}

