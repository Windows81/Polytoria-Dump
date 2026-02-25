namespace Unity.Burst;

[AttributeUsage(192)]
[Token(Token = "0x200005F")]
public class BurstDiscardAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F4")]
	public BurstDiscardAttribute() { }

}

