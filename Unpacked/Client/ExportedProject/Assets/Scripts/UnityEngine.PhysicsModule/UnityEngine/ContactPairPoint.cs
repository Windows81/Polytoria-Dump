namespace UnityEngine;

[IsReadOnly]
[Token(Token = "0x2000021")]
[UsedByNativeCode]
public struct ContactPairPoint
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005D")]
	internal readonly Vector3 m_Position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400005E")]
	internal readonly float m_Separation; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005F")]
	internal readonly Vector3 m_Normal; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000060")]
	internal readonly uint m_InternalFaceIndex0; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000061")]
	internal readonly Vector3 m_Impulse; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000062")]
	internal readonly uint m_InternalFaceIndex1; //Field offset: 0x2C

	[Token(Token = "0x17000064")]
	public Vector3 impulse
	{
		[Address(RVA = "0x561A40", Offset = "0x560C40", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000196")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000063")]
	public Vector3 normal
	{
		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000195")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000061")]
	public Vector3 position
	{
		[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000193")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000062")]
	public float separation
	{
		[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000194")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x561A40", Offset = "0x560C40", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000196")]
	public Vector3 get_impulse() { }

	[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000195")]
	public Vector3 get_normal() { }

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000193")]
	public Vector3 get_position() { }

	[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000194")]
	public float get_separation() { }

}

