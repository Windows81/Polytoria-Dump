namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBuildSettings.h")]
[Token(Token = "0x2000010")]
public struct NavMeshBuildSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000029")]
	private int m_AgentTypeID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400002A")]
	private float m_AgentRadius; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400002B")]
	private float m_AgentHeight; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400002C")]
	private float m_AgentSlope; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002D")]
	private float m_AgentClimb; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400002E")]
	private float m_LedgeDropHeight; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002F")]
	private float m_MaxJumpAcrossDistance; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000030")]
	private float m_MinRegionArea; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000031")]
	private int m_OverrideVoxelSize; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000032")]
	private float m_VoxelSize; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000033")]
	private int m_OverrideTileSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000034")]
	private int m_TileSize; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000035")]
	private int m_BuildHeightMesh; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000036")]
	private uint m_MaxJobWorkers; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000037")]
	private int m_PreserveTilesOutsideBounds; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000038")]
	private NavMeshBuildDebugSettings m_Debug; //Field offset: 0x3C

	[Token(Token = "0x17000025")]
	public float agentRadius
	{
		[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000067")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000024")]
	public int agentTypeID
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000065")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000066")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700002B")]
	public bool buildHeightMesh
	{
		[Address(RVA = "0x1900110", Offset = "0x18FF310", Length = "0x9")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetBuildSettings", ReturnType = typeof(NavMeshBuildSettings))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600006D")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000026")]
	public float minRegionArea
	{
		[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000068")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000029")]
	public bool overrideTileSize
	{
		[Address(RVA = "0x1900120", Offset = "0x18FF320", Length = "0x9")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetBuildSettings", ReturnType = typeof(NavMeshBuildSettings))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600006B")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000027")]
	public bool overrideVoxelSize
	{
		[Address(RVA = "0x1900130", Offset = "0x18FF330", Length = "0x9")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetBuildSettings", ReturnType = typeof(NavMeshBuildSettings))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000069")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700002A")]
	public int tileSize
	{
		[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000028")]
	public float voxelSize
	{
		[Address(RVA = "0x1900140", Offset = "0x18FF340", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006A")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000067")]
	public float get_agentRadius() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000065")]
	public int get_agentTypeID() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000066")]
	public void set_agentTypeID(int value) { }

	[Address(RVA = "0x1900110", Offset = "0x18FF310", Length = "0x9")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetBuildSettings", ReturnType = typeof(NavMeshBuildSettings))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600006D")]
	public void set_buildHeightMesh(bool value) { }

	[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000068")]
	public void set_minRegionArea(float value) { }

	[Address(RVA = "0x1900120", Offset = "0x18FF320", Length = "0x9")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetBuildSettings", ReturnType = typeof(NavMeshBuildSettings))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600006B")]
	public void set_overrideTileSize(bool value) { }

	[Address(RVA = "0x1900130", Offset = "0x18FF330", Length = "0x9")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetBuildSettings", ReturnType = typeof(NavMeshBuildSettings))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000069")]
	public void set_overrideVoxelSize(bool value) { }

	[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006C")]
	public void set_tileSize(int value) { }

	[Address(RVA = "0x1900140", Offset = "0x18FF340", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006A")]
	public void set_voxelSize(float value) { }

}

