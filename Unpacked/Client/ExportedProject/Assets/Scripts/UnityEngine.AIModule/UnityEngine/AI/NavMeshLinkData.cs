namespace UnityEngine.AI;

[Token(Token = "0x2000008")]
public struct NavMeshLinkData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000007")]
	private Vector3 m_StartPosition; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000008")]
	private Vector3 m_EndPosition; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000009")]
	private float m_CostModifier; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400000A")]
	private int m_Bidirectional; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000B")]
	private float m_Width; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400000C")]
	private int m_Area; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000D")]
	private int m_AgentTypeID; //Field offset: 0x28

	[Token(Token = "0x17000015")]
	public int agentTypeID
	{
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000033")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	public int area
	{
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000032")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000012")]
	public bool bidirectional
	{
		[Address(RVA = "0x19015A0", Offset = "0x19007A0", Length = "0x9")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "AddLink", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000030")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000011")]
	public float costModifier
	{
		[Address(RVA = "0x2C1220", Offset = "0x2C0420", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000010")]
	public Vector3 endPosition
	{
		[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700000F")]
	public Vector3 startPosition
	{
		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000013")]
	public float width
	{
		[Address(RVA = "0x41BDA0", Offset = "0x41AFA0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000031")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	public void set_agentTypeID(int value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	public void set_area(int value) { }

	[Address(RVA = "0x19015A0", Offset = "0x19007A0", Length = "0x9")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "AddLink", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000030")]
	public void set_bidirectional(bool value) { }

	[Address(RVA = "0x2C1220", Offset = "0x2C0420", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	public void set_costModifier(float value) { }

	[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public void set_endPosition(Vector3 value) { }

	[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public void set_startPosition(Vector3 value) { }

	[Address(RVA = "0x41BDA0", Offset = "0x41AFA0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000031")]
	public void set_width(float value) { }

}

