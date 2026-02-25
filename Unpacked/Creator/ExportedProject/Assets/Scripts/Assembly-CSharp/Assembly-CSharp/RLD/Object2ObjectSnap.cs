namespace RLD;

[Token(Token = "0x2000277")]
public static class Object2ObjectSnap
{
	[CompilerGenerated]
	[Token(Token = "0x200027D")]
	private sealed class <>c
	{
		[Token(Token = "0x40009CE")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40009CF")]
		public static Comparison<SnapSortData> <>9__14_0; //Field offset: 0x8
		[Token(Token = "0x40009D0")]
		public static Comparison<SnapSortData> <>9__14_1; //Field offset: 0x10

		[Address(RVA = "0x5C3B70", Offset = "0x5C2D70", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60018B0")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018B1")]
		public <>c() { }

		[Address(RVA = "0x5C3A60", Offset = "0x5C2C60", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Token(Token = "0x60018B2")]
		internal int <CalculateSnapResult>b__14_0(SnapSortData s0, SnapSortData s1) { }

		[Address(RVA = "0x5C3A80", Offset = "0x5C2C80", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Token(Token = "0x60018B3")]
		internal int <CalculateSnapResult>b__14_1(SnapSortData s0, SnapSortData s1) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200027E")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009D1")]
		public GameObject root; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009D2")]
		public Config snapConfig; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40009D3")]
		public Predicate<GameObject> <>9__2; //Field offset: 0x38

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018B4")]
		public <>c__DisplayClass14_0() { }

		[Address(RVA = "0x5C3AA0", Offset = "0x5C2CA0", Length = "0xCC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
		[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60018B5")]
		internal bool <CalculateSnapResult>b__2(GameObject item) { }

	}

	[Token(Token = "0x200027B")]
	internal struct Config
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C0")]
		private float _areaMatchEps; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40009C1")]
		public List<GameObject> IgnoreDestObjects; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009C2")]
		public int DestinationLayers; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40009C3")]
		public float SnapRadius; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009C4")]
		public Prefs Prefs; //Field offset: 0x18

		[Token(Token = "0x17000837")]
		public float AreaMatchEps
		{
			[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
			[CallerCount(Count = 6)]
			[DeduplicatedMethod]
			[Token(Token = "0x60018AE")]
			 get { } //Length: 5
			[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
			[CallerCount(Count = 21)]
			[DeduplicatedMethod]
			[Token(Token = "0x60018AF")]
			 set { } //Length: 12
		}

		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018AE")]
		public float get_AreaMatchEps() { }

		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018AF")]
		public void set_AreaMatchEps(float value) { }

	}

	[Flags]
	[Token(Token = "0x2000278")]
	internal enum Prefs
	{
		None = 0,
		TryMatchArea = 1,
		All = 1,
	}

	[Token(Token = "0x2000279")]
	internal enum SnapFailReson
	{
		None = 0,
		MaxObjectsExceeded = 1,
		InvalidSourceObjects = 2,
		NoDestinationFound = 3,
	}

	[Token(Token = "0x200027A")]
	internal struct SnapResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009BB")]
		private bool _success; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40009BC")]
		private Vector3 _snapPivot; //Field offset: 0x4
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009BD")]
		private Vector3 _snapDestination; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40009BE")]
		private float _snapDistance; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009BF")]
		private SnapFailReson _failReason; //Field offset: 0x20

		[Token(Token = "0x17000836")]
		public SnapFailReson FailReason
		{
			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60018AB")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000834")]
		public Vector3 SnapDestination
		{
			[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60018A9")]
			 get { } //Length: 19
		}

		[Token(Token = "0x17000835")]
		public float SnapDistance
		{
			[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60018AA")]
			 get { } //Length: 6
		}

		[Token(Token = "0x17000833")]
		public Vector3 SnapPivot
		{
			[Address(RVA = "0x5C0CD0", Offset = "0x5BFED0", Length = "0x13")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60018A8")]
			 get { } //Length: 19
		}

		[Token(Token = "0x17000832")]
		public bool Success
		{
			[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[Token(Token = "0x60018A7")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x5C0C30", Offset = "0x5BFE30", Length = "0x99")]
		[CalledBy(Type = typeof(Object2ObjectSnap), Member = "CalculateSnapResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Config)}, ReturnType = typeof(SnapResult))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60018AC")]
		public SnapResult(SnapFailReson failReson) { }

		[Address(RVA = "0x5C0C00", Offset = "0x5BFE00", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60018AD")]
		public SnapResult(Vector3 snapPivot, Vector3 snapDestination, float snapDistance) { }

		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018AB")]
		public SnapFailReson get_FailReason() { }

		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018A9")]
		public Vector3 get_SnapDestination() { }

		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018AA")]
		public float get_SnapDistance() { }

		[Address(RVA = "0x5C0CD0", Offset = "0x5BFED0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018A8")]
		public Vector3 get_SnapPivot() { }

		[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018A7")]
		public bool get_Success() { }

	}

	[Token(Token = "0x200027C")]
	private struct SnapSortData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C5")]
		public GameObject SrcObject; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40009C6")]
		public GameObject DestObject; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009C7")]
		public BoxFace SrcSnapFace; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40009C8")]
		public BoxFace DestSnapFace; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009C9")]
		public bool FaceAreasMatch; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40009CA")]
		public float FaceAreaDiff; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009CB")]
		public Vector3 SnapPivot; //Field offset: 0x20
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40009CC")]
		public Vector3 SnapDest; //Field offset: 0x2C
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40009CD")]
		public float SnapDistance; //Field offset: 0x38

	}

	[Token(Token = "0x40009B0")]
	private static List<GameObject> _nearbyObjectBuffer; //Field offset: 0x0
	[Token(Token = "0x40009B1")]
	private static Config _defaultConfig; //Field offset: 0x8

	[Token(Token = "0x17000831")]
	public static Config DefaultConfig
	{
		[Address(RVA = "0x5B6500", Offset = "0x5B5700", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60018A3")]
		 get { } //Length: 99
	}

	[Token(Token = "0x17000830")]
	public static int MaxSourceObjects
	{
		[Address(RVA = "0x5B6570", Offset = "0x5B5770", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018A1")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B6420", Offset = "0x5B5620", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018A2")]
	private static Object2ObjectSnap() { }

	[Address(RVA = "0x5B4A80", Offset = "0x5B3C80", Length = "0x153A")]
	[CalledBy(Type = typeof(Object2ObjectSnap), Member = "Snap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Config)}, ReturnType = typeof(SnapResult))]
	[CalledBy(Type = typeof(Object2ObjectSnap), Member = "Snap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Config)}, ReturnType = typeof(SnapResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig), typeof(GameObjectType)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(OBB), Member = "GetInvalid", ReturnType = typeof(OBB))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTScene), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object2ObjectSnapDataDb), Member = "GetObject2ObjectSnapData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Object2ObjectSnapData))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(OBB), Member = "GetCenterAndCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(Object2ObjectSnapData), Member = "GetWorldSnapAreaBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxFace)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800219F0")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object2ObjectSnapData), Member = "GetWorldSnapAreaDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxFace)}, ReturnType = typeof(BoxFaceAreaDesc))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetGameObjectType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObjectType))]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxMath), Member = "get_AllBoxFaces", ReturnType = typeof(System.Collections.Generic.List`1<RLD.BoxFace>))]
	[Calls(Type = typeof(SnapResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SnapFailReson)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetSpriteObjectsInHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetMeshObjectsInHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetAllChildrenAndSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60018A6")]
	public static SnapResult CalculateSnapResult(GameObject root, Config snapConfig) { }

	[Address(RVA = "0x5B6500", Offset = "0x5B5700", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60018A3")]
	public static Config get_DefaultConfig() { }

	[Address(RVA = "0x5B6570", Offset = "0x5B5770", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018A1")]
	public static int get_MaxSourceObjects() { }

	[Address(RVA = "0x5B60B0", Offset = "0x5B52B0", Length = "0x360")]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "SnapTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object2ObjectSnap), Member = "CalculateSnapResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Config)}, ReturnType = typeof(SnapResult))]
	[Calls(Type = typeof(ObjectSnap), Member = "Snap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60018A4")]
	public static SnapResult Snap(List<GameObject> roots, Config snapConfig) { }

	[Address(RVA = "0x5B5FC0", Offset = "0x5B51C0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object2ObjectSnap), Member = "CalculateSnapResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Config)}, ReturnType = typeof(SnapResult))]
	[Calls(Type = typeof(ObjectSnap), Member = "Snap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x60018A5")]
	public static SnapResult Snap(GameObject root, Config snapConfig) { }

}

