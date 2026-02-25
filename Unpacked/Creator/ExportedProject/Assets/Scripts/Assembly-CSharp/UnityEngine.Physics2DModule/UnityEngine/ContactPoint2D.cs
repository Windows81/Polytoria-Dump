namespace UnityEngine;

[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
[RequiredByNativeCode(Optional = False, GenerateProxy = True)]
[Token(Token = "0x2000007")]
public struct ContactPoint2D
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("point")]
	[Token(Token = "0x400001C")]
	private Vector2 m_Point; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("normal")]
	[Token(Token = "0x400001D")]
	private Vector2 m_Normal; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("relativeVelocity")]
	[Token(Token = "0x400001E")]
	private Vector2 m_RelativeVelocity; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("friction")]
	[Token(Token = "0x400001F")]
	private float m_Friction; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("bounciness")]
	[Token(Token = "0x4000020")]
	private float m_Bounciness; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("separation")]
	[Token(Token = "0x4000021")]
	private float m_Separation; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[NativeName("normalImpulse")]
	[Token(Token = "0x4000022")]
	private float m_NormalImpulse; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[NativeName("tangentImpulse")]
	[Token(Token = "0x4000023")]
	private float m_TangentImpulse; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[NativeName("collider")]
	[Token(Token = "0x4000024")]
	private int m_Collider; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[NativeName("otherCollider")]
	[Token(Token = "0x4000025")]
	private int m_OtherCollider; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[NativeName("rigidbody")]
	[Token(Token = "0x4000026")]
	private int m_Rigidbody; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[NativeName("otherRigidbody")]
	[Token(Token = "0x4000027")]
	private int m_OtherRigidbody; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[NativeName("enabled")]
	[Token(Token = "0x4000028")]
	private int m_Enabled; //Field offset: 0x3C

}

