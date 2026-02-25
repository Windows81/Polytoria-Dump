namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200012C")]
[UsedByNativeCode]
public class DefaultExecutionOrder : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000520")]
	private int m_Order; //Field offset: 0x10

	[Token(Token = "0x17000179")]
	public int order
	{
		[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
		[CallerCount(Count = 58)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008E5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E4")]
	public DefaultExecutionOrder(int order) { }

	[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
	[CallerCount(Count = 58)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E5")]
	public int get_order() { }

}

