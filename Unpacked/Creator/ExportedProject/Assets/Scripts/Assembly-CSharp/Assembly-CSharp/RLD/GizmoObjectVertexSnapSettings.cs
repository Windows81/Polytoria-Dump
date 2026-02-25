namespace RLD;

[Token(Token = "0x200004B")]
public class GizmoObjectVertexSnapSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400013A")]
	private int _snapDestinationLayers; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400013B")]
	private bool _canSnapToGrid; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[SerializeField]
	[Token(Token = "0x400013C")]
	private bool _canSnapToObjectVerts; //Field offset: 0x2D

	[Token(Token = "0x1700009F")]
	public bool CanSnapToGrid
	{
		[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023F")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000240")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A0")]
	public bool CanSnapToObjectVerts
	{
		[Address(RVA = "0x3BAA10", Offset = "0x3B9C10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000241")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAA30", Offset = "0x3B9C30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000242")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009E")]
	public int SnapDestinationLayers
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023D")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023E")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3BA9E0", Offset = "0x3B9BE0", Length = "0x14")]
	[CalledBy(Type = typeof(MoveGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000246")]
	public GizmoObjectVertexSnapSettings() { }

	[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023F")]
	public bool get_CanSnapToGrid() { }

	[Address(RVA = "0x3BAA10", Offset = "0x3B9C10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000241")]
	public bool get_CanSnapToObjectVerts() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023D")]
	public int get_SnapDestinationLayers() { }

	[Address(RVA = "0x3BA960", Offset = "0x3B9B60", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000243")]
	public bool IsLayerSnapDestination(int objectLayer) { }

	[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000240")]
	public void set_CanSnapToGrid(bool value) { }

	[Address(RVA = "0x3BAA30", Offset = "0x3B9C30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000242")]
	public void set_CanSnapToObjectVerts(bool value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023E")]
	public void set_SnapDestinationLayers(int value) { }

	[Address(RVA = "0x3BA970", Offset = "0x3B9B70", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayerEx), Member = "ClearLayerBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LayerEx), Member = "SetLayerBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000244")]
	public void SetLayerSnapDestination(int objectLayer, bool isSnapDestination) { }

	[Address(RVA = "0x3BA9B0", Offset = "0x3B9BB0", Length = "0x27")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000245")]
	public void Transfer(GizmoObjectVertexSnapSettings destination) { }

}

