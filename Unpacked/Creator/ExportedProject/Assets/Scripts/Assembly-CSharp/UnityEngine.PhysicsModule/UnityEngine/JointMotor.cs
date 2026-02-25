namespace UnityEngine;

[Token(Token = "0x2000009")]
public struct JointMotor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001E")]
	private float m_TargetVelocity; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001F")]
	private float m_Force; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000020")]
	private int m_FreeSpin; //Field offset: 0x8

}

