namespace GLTFast;

[Token(Token = "0x2000011")]
public class GltfAsset : GltfAssetBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000012")]
	private struct <Load>d__29 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000037")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000039")]
		public ICodeLogger logger; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400003A")]
		public GltfAsset <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400003B")]
		public string gltfUrl; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400003C")]
		public IDownloadProvider downloadProvider; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400003D")]
		public IDeferAgent deferAgent; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400003E")]
		public IMaterialGenerator materialGenerator; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400003F")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000040")]
		private TaskAwaiter <>u__2; //Field offset: 0x58

		[Address(RVA = "0x106FAE0", Offset = "0x106ECE0", Length = "0x735")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GltfAssetBase+<Instantiate>d__15"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Instantiate>d__15&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GltfAssetBase+<Load>d__14"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__14&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600004C")]
		private override void MoveNext() { }

		[Address(RVA = "0x1070220", Offset = "0x106F420", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x600004D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000013")]
	private struct <Start>d__28 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000041")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000042")]
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000043")]
		public GltfAsset <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000044")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x10710A0", Offset = "0x10702A0", Length = "0x22E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_streamingAssetsPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Boolean>), typeof(<Start>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Boolean>&), typeof(<Start>d__28&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600004E")]
		private override void MoveNext() { }

		[Address(RVA = "0x10712D0", Offset = "0x10704D0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600004F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000030")]
	[Tooltip("URL to load the glTF from. Loading local file paths works by prefixing them with \"file://\"")]
	private string url; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000031")]
	[Tooltip("Automatically load at start.")]
	private bool loadOnStartup; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000032")]
	[Tooltip("Override scene to load (-1 loads glTFs default scene)")]
	private int sceneId; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000033")]
	[Tooltip("If true, the first animation clip starts playing right after instantiation")]
	private bool playAutomatically; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[SerializeField]
	[Token(Token = "0x4000034")]
	[Tooltip("If checked, url is treated as relative StreamingAssets path.")]
	private bool streamingAsset; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000035")]
	private InstantiationSettings instantiationSettings; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000036")]
	private GameObjectSceneInstance <SceneInstance>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x1700000C")]
	public string FullUrl
	{
		[Address(RVA = "0x1060090", Offset = "0x105F290", Length = "0x96")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_streamingAssetsPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000044")]
		 get { } //Length: 150
	}

	[Token(Token = "0x1700000A")]
	public InstantiationSettings InstantiationSettings
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000040")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000041")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000006")]
	public bool LoadOnStartup
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003A")]
		 get { } //Length: 5
		[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public bool PlayAutomatically
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000007")]
	protected int SceneId
	{
		[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000B")]
	public GameObjectSceneInstance SceneInstance
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000042")]
		 get { } //Length: 5
		[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000009")]
	public bool StreamingAsset
	{
		[Address(RVA = "0x347A20", Offset = "0x346C20", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003E")]
		 get { } //Length: 5
		[Address(RVA = "0x347A40", Offset = "0x346C40", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000005")]
	public string Url
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000038")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000039")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1060070", Offset = "0x105F270", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	public GltfAsset() { }

	[Address(RVA = "0x105F640", Offset = "0x105E840", Length = "0x175")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GltfAssetBase+<Load>d__14"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[DebuggerHidden]
	[DeduplicatedMethod]
	[Token(Token = "0x600004B")]
	private Task<Boolean> <>n__0(string gltfUrl, IDownloadProvider downloadProvider, IDeferAgent deferAgent, IMaterialGenerator materialGenerator, ICodeLogger logger) { }

	[Address(RVA = "0x105F9C0", Offset = "0x105EBC0", Length = "0x24D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000049")]
	public virtual void ClearScenes() { }

	[Address(RVA = "0x1060090", Offset = "0x105F290", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_streamingAssetsPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000044")]
	public string get_FullUrl() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	public InstantiationSettings get_InstantiationSettings() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	public bool get_LoadOnStartup() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003D")]
	public bool get_PlayAutomatically() { }

	[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003C")]
	protected int get_SceneId() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000042")]
	public GameObjectSceneInstance get_SceneInstance() { }

	[Address(RVA = "0x347A20", Offset = "0x346C20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003E")]
	public bool get_StreamingAsset() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public string get_Url() { }

	[Address(RVA = "0x105FC10", Offset = "0x105EE10", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InstantiationSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000047")]
	protected virtual IInstantiator GetDefaultInstantiator(ICodeLogger logger) { }

	[Address(RVA = "0x105FD20", Offset = "0x105EF20", Length = "0x174")]
	[AsyncStateMachine(typeof(<Load>d__29))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__29)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__29&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	public virtual Task<Boolean> Load(string gltfUrl, IDownloadProvider downloadProvider = null, IDeferAgent deferAgent = null, IMaterialGenerator materialGenerator = null, ICodeLogger logger = null) { }

	[Address(RVA = "0x105FEA0", Offset = "0x105F0A0", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Animation), Member = "Play", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GltfImportBase), Member = "get_DefaultSceneIndex", ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000048")]
	protected virtual void PostInstantiation(IInstantiator instantiator, bool success) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public void set_InstantiationSettings(InstantiationSettings value) { }

	[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	public void set_LoadOnStartup(bool value) { }

	[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	protected void set_SceneInstance(GameObjectSceneInstance value) { }

	[Address(RVA = "0x347A40", Offset = "0x346C40", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003F")]
	public void set_StreamingAsset(bool value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public void set_Url(string value) { }

	[Address(RVA = "0x105FFC0", Offset = "0x105F1C0", Length = "0xA3")]
	[AsyncStateMachine(typeof(<Start>d__28))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Start>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Start>d__28&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000045")]
	protected override void Start() { }

}

