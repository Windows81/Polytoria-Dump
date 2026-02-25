namespace Mirror;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x200000A")]
public class TargetRpcAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002F")]
	public int channel; //Field offset: 0x10

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public TargetRpcAttribute() { }

}

