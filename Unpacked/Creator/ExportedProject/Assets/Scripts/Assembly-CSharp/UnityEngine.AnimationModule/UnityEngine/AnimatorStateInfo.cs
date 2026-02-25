namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000011")]
public struct AnimatorStateInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002F")]
	private int m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000030")]
	private int m_Path; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000031")]
	private int m_FullPath; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000032")]
	private float m_NormalizedTime; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000033")]
	private float m_Length; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000034")]
	private float m_Speed; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000035")]
	private float m_SpeedMultiplier; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000036")]
	private int m_Tag; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000037")]
	private int m_Loop; //Field offset: 0x20

	[Token(Token = "0x1700000C")]
	public int fullPathHash
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000D")]
	public float normalizedTime
	{
		[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000050")]
		 get { } //Length: 8
	}

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004F")]
	public int get_fullPathHash() { }

	[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000050")]
	public float get_normalizedTime() { }

}

