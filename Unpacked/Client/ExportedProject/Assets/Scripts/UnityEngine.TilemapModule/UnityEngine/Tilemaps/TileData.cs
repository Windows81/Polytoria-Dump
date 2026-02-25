namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
[Token(Token = "0x200000C")]
public struct TileData
{
	[Token(Token = "0x400002E")]
	internal static readonly TileData Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000028")]
	private int m_Sprite; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000029")]
	private Color m_Color; //Field offset: 0x4
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400002A")]
	private Matrix4x4 m_Transform; //Field offset: 0x14
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400002B")]
	private int m_GameObject; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400002C")]
	private TileFlags m_Flags; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400002D")]
	private ColliderType m_ColliderType; //Field offset: 0x5C

	[Token(Token = "0x1700000D")]
	public ColliderType colliderType
	{
		[Address(RVA = "0x599430", Offset = "0x598630", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000039")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public Color color
	{
		[Address(RVA = "0x18A2AE0", Offset = "0x18A1CE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000035")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000C")]
	public TileFlags flags
	{
		[Address(RVA = "0x599420", Offset = "0x598620", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000038")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000B")]
	public GameObject gameObject
	{
		[Address(RVA = "0x1A75930", Offset = "0x1A74B30", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000037")]
		 set { } //Length: 132
	}

	[Token(Token = "0x17000008")]
	public Sprite sprite
	{
		[Address(RVA = "0x1A759C0", Offset = "0x1A74BC0", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000034")]
		 set { } //Length: 130
	}

	[Token(Token = "0x1700000A")]
	public Matrix4x4 transform
	{
		[Address(RVA = "0x1A75A50", Offset = "0x1A74C50", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000036")]
		 set { } //Length: 32
	}

	[Address(RVA = "0x1A757F0", Offset = "0x1A749F0", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600003B")]
	private static TileData() { }

	[Address(RVA = "0x1A756C0", Offset = "0x1A748C0", Length = "0x12B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600003A")]
	private static TileData CreateDefault() { }

	[Address(RVA = "0x599430", Offset = "0x598630", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public void set_colliderType(ColliderType value) { }

	[Address(RVA = "0x18A2AE0", Offset = "0x18A1CE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public void set_color(Color value) { }

	[Address(RVA = "0x599420", Offset = "0x598620", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public void set_flags(TileFlags value) { }

	[Address(RVA = "0x1A75930", Offset = "0x1A74B30", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000037")]
	public void set_gameObject(GameObject value) { }

	[Address(RVA = "0x1A759C0", Offset = "0x1A74BC0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000034")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x1A75A50", Offset = "0x1A74C50", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000036")]
	public void set_transform(Matrix4x4 value) { }

}

