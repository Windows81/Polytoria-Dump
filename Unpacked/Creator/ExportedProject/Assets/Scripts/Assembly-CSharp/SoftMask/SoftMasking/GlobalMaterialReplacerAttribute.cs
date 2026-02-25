namespace SoftMasking;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x2000008")]
public class GlobalMaterialReplacerAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000016")]
	public GlobalMaterialReplacerAttribute() { }

}

