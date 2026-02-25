namespace Unity.Properties;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x200000B")]
public class DontCreatePropertyAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	public DontCreatePropertyAttribute() { }

}

