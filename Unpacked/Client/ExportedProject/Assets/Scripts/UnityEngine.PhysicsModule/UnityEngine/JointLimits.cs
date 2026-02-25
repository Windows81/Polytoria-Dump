namespace UnityEngine;

[Token(Token = "0x200000B")]
public struct JointLimits
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000024")]
	private float m_Min; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000025")]
	private float m_Max; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000026")]
	private float m_Bounciness; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000027")]
	private float m_BounceMinVelocity; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000028")]
	private float m_ContactDistance; //Field offset: 0x10
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[FieldOffset(Offset = "0x14")]
	[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", True)]
	[Token(Token = "0x4000029")]
	public float minBounce; //Field offset: 0x14
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[FieldOffset(Offset = "0x18")]
	[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", True)]
	[Token(Token = "0x400002A")]
	public float maxBounce; //Field offset: 0x18

}

