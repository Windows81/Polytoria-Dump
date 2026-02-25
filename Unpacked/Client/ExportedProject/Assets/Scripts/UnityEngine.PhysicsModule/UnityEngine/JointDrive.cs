namespace UnityEngine;

[Token(Token = "0x2000008")]
public struct JointDrive
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001A")]
	private float m_PositionSpring; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001B")]
	private float m_PositionDamper; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001C")]
	private float m_MaximumForce; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400001D")]
	private int m_UseAcceleration; //Field offset: 0xC

}

