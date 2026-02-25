namespace RLD;

[Token(Token = "0x2000212")]
public class SceneOverlapFilter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000806")]
	private List<GameObjectType> _allowedObjectTypes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000807")]
	private List<GameObject> _ignoreObjects; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000808")]
	private int _layerMask; //Field offset: 0x20

	[Token(Token = "0x1700066B")]
	public List<GameObjectType> AllowedObjectTypes
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600143A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700066C")]
	public List<GameObject> IgnoreObjects
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600143B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700066D")]
	public int LayerMask
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600143C")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600143D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5A2560", Offset = "0x5A1760", Length = "0xC4")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600143F")]
	public SceneOverlapFilter() { }

	[Address(RVA = "0x5A2470", Offset = "0x5A1670", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObjectEx), Member = "GetGameObjectType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObjectType))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x6001440")]
	private bool <FilterOverlaps>b__10_0(GameObject item) { }

	[Address(RVA = "0x5A23D0", Offset = "0x5A15D0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600143E")]
	public void FilterOverlaps(List<GameObject> gameObjects) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600143A")]
	public List<GameObjectType> get_AllowedObjectTypes() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600143B")]
	public List<GameObject> get_IgnoreObjects() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600143C")]
	public int get_LayerMask() { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600143D")]
	public void set_LayerMask(int value) { }

}

