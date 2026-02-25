namespace RLD;

[Token(Token = "0x2000214")]
public class SceneRaycastFilter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400080C")]
	private List<GameObjectType> _allowedObjectTypes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400080D")]
	private List<GameObject> _ignoreObjects; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400080E")]
	private int _layerMask; //Field offset: 0x20

	[Token(Token = "0x1700066E")]
	public List<GameObjectType> AllowedObjectTypes
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001441")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700066F")]
	public List<GameObject> IgnoreObjects
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001442")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000670")]
	public int LayerMask
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001443")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001444")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5A27E0", Offset = "0x5A19E0", Length = "0xC4")]
	[CalledBy(Type = typeof(PrefabSpawnSnap), Member = "OnInputDeviceMoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "GetSceneHitForGridSnap", ReturnType = typeof(SceneRaycastHit))]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "IdentifySitSurface", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeviceObjectGrabSession), Member = "IdentifyGrabSurface", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectSpawnUtil), Member = "SpawnInFrontOfCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(Config)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001446")]
	public SceneRaycastFilter() { }

	[Address(RVA = "0x5A26D0", Offset = "0x5A18D0", Length = "0x102")]
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
	[Token(Token = "0x6001447")]
	private bool <FilterHits>b__10_0(GameObjectRayHit item) { }

	[Address(RVA = "0x5A2630", Offset = "0x5A1830", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001445")]
	public void FilterHits(List<GameObjectRayHit> hits) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001441")]
	public List<GameObjectType> get_AllowedObjectTypes() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001442")]
	public List<GameObject> get_IgnoreObjects() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001443")]
	public int get_LayerMask() { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001444")]
	public void set_LayerMask(int value) { }

}

