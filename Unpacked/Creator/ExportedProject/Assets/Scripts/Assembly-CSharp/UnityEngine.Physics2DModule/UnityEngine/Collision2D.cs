namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x2000006")]
public class Collision2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000013")]
	internal int m_Collider; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000014")]
	internal int m_OtherCollider; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000015")]
	internal int m_Rigidbody; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000016")]
	internal int m_OtherRigidbody; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000017")]
	internal Vector2 m_RelativeVelocity; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000018")]
	internal int m_Enabled; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000019")]
	internal int m_ContactCount; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001A")]
	internal ContactPoint2D[] m_ReusedContacts; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400001B")]
	internal ContactPoint2D[] m_LegacyContacts; //Field offset: 0x38

}

