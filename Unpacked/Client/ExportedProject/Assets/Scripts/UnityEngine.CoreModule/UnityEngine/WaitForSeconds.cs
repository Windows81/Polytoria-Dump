namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x200016F")]
public sealed class WaitForSeconds : YieldInstruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A0")]
	internal float m_Seconds; //Field offset: 0x10

	[Address(RVA = "0x19799B0", Offset = "0x1978BB0", Length = "0x28")]
	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A6D")]
	public WaitForSeconds(float seconds) { }

}

