namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x200000F")]
public class ControllerColliderHit
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002B")]
	internal CharacterController m_Controller; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002C")]
	internal Collider m_Collider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002D")]
	internal Vector3 m_Point; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400002E")]
	internal Vector3 m_Normal; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400002F")]
	internal Vector3 m_MoveDirection; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000030")]
	internal float m_MoveLength; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000031")]
	internal int m_Push; //Field offset: 0x48

}

