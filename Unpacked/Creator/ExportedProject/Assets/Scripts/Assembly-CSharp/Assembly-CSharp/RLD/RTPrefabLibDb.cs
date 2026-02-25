namespace RLD;

[ExecuteInEditMode]
[Token(Token = "0x20001ED")]
public class RTPrefabLibDb : MonoSingleton<RTPrefabLibDb>
{
	[CompilerGenerated]
	[Token(Token = "0x20001EE")]
	private sealed class <>c
	{
		[Token(Token = "0x400077D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400077E")]
		public static Comparison<RTPrefabLib> <>9__29_0; //Field offset: 0x8

		[Address(RVA = "0x58D800", Offset = "0x58CA00", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001314")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001315")]
		public <>c() { }

		[Address(RVA = "0x58D530", Offset = "0x58C730", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001316")]
		internal int <SortLibsByName>b__29_0(RTPrefabLib l0, RTPrefabLib l1) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001EF")]
	private sealed class <>c__DisplayClass44_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400077F")]
		public string libName; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001317")]
		public <>c__DisplayClass44_0() { }

		[Address(RVA = "0x58D640", Offset = "0x58C840", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001318")]
		internal bool <GetLibIndex>b__0(RTPrefabLib item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001F0")]
	private sealed class <>c__DisplayClass47_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000780")]
		public string libName; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001319")]
		public <>c__DisplayClass47_0() { }

		[Address(RVA = "0x58D640", Offset = "0x58C840", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600131A")]
		internal bool <GetLib>b__0(RTPrefabLib item) { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000773")]
	private string _newLibName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000774")]
	private Vector2 _prefabScrollPos; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000775")]
	private int _numPrefabsPerRow; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000776")]
	private PrefabLibDbPrefabSpawnedHander PrefabSpawned; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000777")]
	private EditorPrefabPreviewGen _editorPrefabPreviewGen; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000778")]
	private PrefabLibDbSettings _settings; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000779")]
	private RTPrefabLibDbUI _runtimeUI; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400077A")]
	private PrefabPreviewLookAndFeel _prefabPreviewLookAndFeel; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400077B")]
	private int _activeLibIndex; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400077C")]
	private List<RTPrefabLib> _libs; //Field offset: 0x68

	[Token(Token = "0x14000029")]
	public event PrefabLibDbPrefabSpawnedHander PrefabSpawned
	{
		[Address(RVA = "0x5848F0", Offset = "0x583AF0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60012EE")]
		 add { } //Length: 158
		[Address(RVA = "0x584AE0", Offset = "0x583CE0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60012EF")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170005EC")]
	public RTPrefabLib ActiveLib
	{
		[Address(RVA = "0x584990", Offset = "0x583B90", Length = "0x55")]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetActiveLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012F2")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170005EB")]
	public int ActiveLibIndex
	{
		[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012F1")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170005F1")]
	public EditorPrefabPreviewGen EditorPrefabPreviewGen
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012F7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005EF")]
	public bool HasRuntimeUI
	{
		[Address(RVA = "0x5849F0", Offset = "0x583BF0", Length = "0xA2")]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabRemovedFromLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(RTPrefab)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "CreateLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RTPrefabLib))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetLibName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetActiveLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnActiveLibDropDownChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabCreatedInLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(RTPrefab)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabLibCleared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "<Start>b__48_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60012F5")]
		 get { } //Length: 162
	}

	[Token(Token = "0x170005EA")]
	public int NumLibs
	{
		[Address(RVA = "0x584AA0", Offset = "0x583CA0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60012F0")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170005ED")]
	public PrefabPreviewLookAndFeel PrefabPreviewLookAndFeel
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012F3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005EE")]
	public RTPrefabLibDbUI RuntimeUI
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012F4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005F0")]
	public PrefabLibDbSettings Settings
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012F6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x584770", Offset = "0x583970", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EditorPrefabPreviewGen), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PrefabPreviewLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001312")]
	public RTPrefabLibDb() { }

	[Address(RVA = "0x583520", Offset = "0x582720", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "SyncWithLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001313")]
	private void <Start>b__48_0(int <p0>) { }

	[Address(RVA = "0x5848F0", Offset = "0x583AF0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60012EE")]
	public void add_PrefabSpawned(PrefabLibDbPrefabSpawnedHander value) { }

	[Address(RVA = "0x5829C0", Offset = "0x581BC0", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTActiveLibDropDown), Member = "SyncWithLibDb", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "ClearPreviews", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012FE")]
	public void Clear() { }

	[Address(RVA = "0x582AA0", Offset = "0x581CA0", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001305")]
	public bool Contains(string libName) { }

	[Address(RVA = "0x582BC0", Offset = "0x581DC0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001306")]
	public bool Contains(RTPrefabLib lib) { }

	[Address(RVA = "0x582C20", Offset = "0x581E20", Length = "0x29E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(RTPrefabLib), Member = "add_PrefabCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabCreatedInLibHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "SetActiveLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTActiveLibDropDown), Member = "SyncWithLibDb", ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTPrefabLib), Member = "add_PrefabRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabRemovedFromLibHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UniqueNameGen), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "GetAllLibNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RTPrefabLib), Member = "add_Cleared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabLibClearedHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60012F8")]
	public RTPrefabLib CreateLib(string libName) { }

	[Address(RVA = "0x584990", Offset = "0x583B90", Length = "0x55")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetActiveLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012F2")]
	public RTPrefabLib get_ActiveLib() { }

	[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012F1")]
	public int get_ActiveLibIndex() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012F7")]
	public EditorPrefabPreviewGen get_EditorPrefabPreviewGen() { }

	[Address(RVA = "0x5849F0", Offset = "0x583BF0", Length = "0xA2")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "<Start>b__48_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabCreatedInLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnActiveLibDropDownChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabLibCleared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetActiveLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetLibName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "CreateLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RTPrefabLib))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabRemovedFromLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Token(Token = "0x60012F5")]
	public bool get_HasRuntimeUI() { }

	[Address(RVA = "0x584AA0", Offset = "0x583CA0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012F0")]
	public int get_NumLibs() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012F3")]
	public PrefabPreviewLookAndFeel get_PrefabPreviewLookAndFeel() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012F4")]
	public RTPrefabLibDbUI get_RuntimeUI() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012F6")]
	public PrefabLibDbSettings get_Settings() { }

	[Address(RVA = "0x582EC0", Offset = "0x5820C0", Length = "0x1CD")]
	[CalledBy(Type = typeof(RTActiveLibDropDown), Member = "SyncWithLibDb", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "CreateLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RTPrefabLib))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetLibName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001307")]
	public List<String> GetAllLibNames() { }

	[Address(RVA = "0x583090", Offset = "0x582290", Length = "0x1BA")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "RemoveEmptyLibs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001303")]
	public List<RTPrefabLib> GetEmptyLibs() { }

	[Address(RVA = "0x583390", Offset = "0x582590", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600130B")]
	public RTPrefabLib GetLib(string libName) { }

	[Address(RVA = "0x5834C0", Offset = "0x5826C0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600130A")]
	public RTPrefabLib GetLib(int libIndex) { }

	[Address(RVA = "0x583330", Offset = "0x582530", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001309")]
	public int GetLibIndex(RTPrefabLib lib) { }

	[Address(RVA = "0x583250", Offset = "0x582450", Length = "0xD6")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetActiveLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001308")]
	public int GetLibIndex(string libName) { }

	[Address(RVA = "0x583520", Offset = "0x582720", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "SyncWithLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600130D")]
	private void OnActiveLibDropDownChanged() { }

	[Address(RVA = "0x5835E0", Offset = "0x5827E0", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600130E")]
	private void OnPrefabCreatedInLib(RTPrefabLib prefabLib, RTPrefab prefab) { }

	[Address(RVA = "0x5836C0", Offset = "0x5828C0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "ClearPreviews", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001310")]
	private void OnPrefabLibCleared(RTPrefabLib prefabLib) { }

	[Address(RVA = "0x583750", Offset = "0x582950", Length = "0x1DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(ObjectSpawnUtil), Member = "SpawnInFrontOfCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(Config)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(PostObjectSpawnAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostObjectSpawnAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001311")]
	private void OnPrefabPreviewButtonClicked(RTPrefab prefab) { }

	[Address(RVA = "0x583930", Offset = "0x582B30", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "SyncWithLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600130F")]
	private void OnPrefabRemovedFromLib(RTPrefabLib prefabLib, RTPrefab prefab) { }

	[Address(RVA = "0x583C20", Offset = "0x582E20", Length = "0x14E")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "RemoveEmptyLibs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001302")]
	public void Remove(List<RTPrefabLib> libs) { }

	[Address(RVA = "0x583BB0", Offset = "0x582DB0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001301")]
	public void Remove(RTPrefabLib lib) { }

	[Address(RVA = "0x583A20", Offset = "0x582C20", Length = "0x181")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.RTPrefabLib>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTActiveLibDropDown), Member = "SyncWithLibDb", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60012FF")]
	public void Remove(int libIndex) { }

	[Address(RVA = "0x5839F0", Offset = "0x582BF0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "GetLibIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001300")]
	public void Remove(string libName) { }

	[Address(RVA = "0x584AE0", Offset = "0x583CE0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60012EF")]
	public void remove_PrefabSpawned(PrefabLibDbPrefabSpawnedHander value) { }

	[Address(RVA = "0x5839C0", Offset = "0x582BC0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "GetEmptyLibs", ReturnType = typeof(System.Collections.Generic.List`1<RLD.RTPrefabLib>))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.RTPrefabLib>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001304")]
	public void RemoveEmptyLibs() { }

	[Address(RVA = "0x583DE0", Offset = "0x582FE0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "GetLibIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60012FD")]
	public void SetActiveLib(string libName) { }

	[Address(RVA = "0x583D70", Offset = "0x582F70", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60012FC")]
	public void SetActiveLib(RTPrefabLib lib) { }

	[Address(RVA = "0x583E10", Offset = "0x583010", Length = "0x123")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "CreateLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RTPrefabLib))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SortLibsByName", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTActiveLibDropDown), Member = "SetActiveLibIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_ActiveLib", ReturnType = typeof(RTPrefabLib))]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "SyncWithLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012FB")]
	public void SetActiveLib(int libIndex) { }

	[Address(RVA = "0x583F40", Offset = "0x583140", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "GetAllLibNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(UniqueNameGen), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTActiveLibDropDown), Member = "SyncWithLibDb", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012FA")]
	public bool SetLibName(RTPrefabLib lib, string newLibName) { }

	[Address(RVA = "0x584080", Offset = "0x583280", Length = "0x1BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "SetActiveLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012F9")]
	public void SortLibsByName() { }

	[Address(RVA = "0x584240", Offset = "0x583440", Length = "0x524")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "add_PrefabPreviewClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabPreviewClickedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "SyncWithLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RTActiveLibDropDown), Member = "SyncWithLibDb", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "get_HasRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTPrefabLib), Member = "add_Cleared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabLibClearedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabLib), Member = "add_PrefabRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabRemovedFromLibHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabLib), Member = "add_PrefabCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabCreatedInLibHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x600130C")]
	private void Start() { }

}

