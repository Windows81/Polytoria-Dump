namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
[Token(Token = "0x2000005")]
public struct NavMeshHit
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	private Vector3 m_Position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000002")]
	private Vector3 m_Normal; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000003")]
	private float m_Distance; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000004")]
	private int m_Mask; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000005")]
	private int m_Hit; //Field offset: 0x20

	[Token(Token = "0x17000009")]
	public Vector3 position
	{
		[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000020")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000020")]
	public Vector3 get_position() { }

}

