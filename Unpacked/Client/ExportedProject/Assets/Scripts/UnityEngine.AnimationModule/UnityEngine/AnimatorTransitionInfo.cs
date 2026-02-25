namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000012")]
public struct AnimatorTransitionInfo
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("fullPathHash")]
	[Token(Token = "0x4000038")]
	private int m_FullPath; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("userNameHash")]
	[Token(Token = "0x4000039")]
	private int m_UserName; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("nameHash")]
	[Token(Token = "0x400003A")]
	private int m_Name; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("hasFixedDuration")]
	[Token(Token = "0x400003B")]
	private bool m_HasFixedDuration; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("duration")]
	[Token(Token = "0x400003C")]
	private float m_Duration; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[NativeName("normalizedTime")]
	[Token(Token = "0x400003D")]
	private float m_NormalizedTime; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[NativeName("anyState")]
	[Token(Token = "0x400003E")]
	private bool m_AnyState; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("transitionType")]
	[Token(Token = "0x400003F")]
	private int m_TransitionType; //Field offset: 0x1C

	[Token(Token = "0x1700000E")]
	public int fullPathHash
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000051")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000051")]
	public int get_fullPathHash() { }

}

