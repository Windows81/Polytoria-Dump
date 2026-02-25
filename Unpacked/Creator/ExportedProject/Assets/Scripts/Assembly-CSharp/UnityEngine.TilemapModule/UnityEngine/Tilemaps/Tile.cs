namespace UnityEngine.Tilemaps;

[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
[RequiredByNativeCode]
[Token(Token = "0x2000003")]
public class Tile : TileBase
{
	[Token(Token = "0x2000004")]
	internal enum ColliderType
	{
		None = 0,
		Sprite = 1,
		Grid = 2,
	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000006")]
	private Sprite m_Sprite; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000007")]
	private Color m_Color; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000008")]
	private Matrix4x4 m_Transform; //Field offset: 0x30
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000009")]
	private GameObject m_InstancedGameObject; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400000A")]
	private TileFlags m_Flags; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	private ColliderType m_ColliderType; //Field offset: 0x7C

	[Token(Token = "0x17000006")]
	public ColliderType colliderType
	{
		[Address(RVA = "0x1A75C50", Offset = "0x1A74E50", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000010")]
		 get { } //Length: 6
		[Address(RVA = "0x504750", Offset = "0x503950", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000011")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000002")]
	public Color color
	{
		[Address(RVA = "0x1A75C60", Offset = "0x1A74E60", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000008")]
		 get { } //Length: 11
		[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000009")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000005")]
	public TileFlags flags
	{
		[Address(RVA = "0x1A75C70", Offset = "0x1A74E70", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000E")]
		 get { } //Length: 6
		[Address(RVA = "0x504780", Offset = "0x503980", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000004")]
	public GameObject gameObject
	{
		[Address(RVA = "0x19AA900", Offset = "0x19A9B00", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000C")]
		 get { } //Length: 7
		[Address(RVA = "0x5ECDD0", Offset = "0x5EBFD0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000001")]
	public Sprite sprite
	{
		[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
		[CallerCount(Count = 73)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		 get { } //Length: 7
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000007")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000003")]
	public Matrix4x4 transform
	{
		[Address(RVA = "0x1A75C80", Offset = "0x1A74E80", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600000A")]
		 get { } //Length: 35
		[Address(RVA = "0x1A75CB0", Offset = "0x1A74EB0", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600000B")]
		 set { } //Length: 32
	}

	[Address(RVA = "0x1A75BD0", Offset = "0x1A74DD0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000013")]
	public Tile() { }

	[Address(RVA = "0x1A75C50", Offset = "0x1A74E50", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000010")]
	public ColliderType get_colliderType() { }

	[Address(RVA = "0x1A75C60", Offset = "0x1A74E60", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000008")]
	public Color get_color() { }

	[Address(RVA = "0x1A75C70", Offset = "0x1A74E70", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public TileFlags get_flags() { }

	[Address(RVA = "0x19AA900", Offset = "0x19A9B00", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	public GameObject get_gameObject() { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x1A75C80", Offset = "0x1A74E80", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000A")]
	public Matrix4x4 get_transform() { }

	[Address(RVA = "0x1A75A70", Offset = "0x1A74C70", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000012")]
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	[Address(RVA = "0x504750", Offset = "0x503950", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000011")]
	public void set_colliderType(ColliderType value) { }

	[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public void set_color(Color value) { }

	[Address(RVA = "0x504780", Offset = "0x503980", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public void set_flags(TileFlags value) { }

	[Address(RVA = "0x5ECDD0", Offset = "0x5EBFD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public void set_gameObject(GameObject value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x1A75CB0", Offset = "0x1A74EB0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000B")]
	public void set_transform(Matrix4x4 value) { }

}

