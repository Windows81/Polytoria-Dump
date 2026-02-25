namespace UnityEngine;

[Token(Token = "0x200000A")]
public struct JointSpring
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000021")]
	public float spring; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000022")]
	public float damper; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000023")]
	public float targetPosition; //Field offset: 0x8

}

