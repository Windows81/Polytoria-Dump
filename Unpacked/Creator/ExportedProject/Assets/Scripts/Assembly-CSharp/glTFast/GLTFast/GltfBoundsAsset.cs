namespace GLTFast;

[Token(Token = "0x2000019")]
public class GltfBoundsAsset : GltfAsset
{
	[CompilerGenerated]
	[Token(Token = "0x200001A")]
	private struct <InstantiateScene>d__9 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000066")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000068")]
		public GltfBoundsAsset <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000069")]
		public ICodeLogger logger; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400006A")]
		public int sceneIndex; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400006B")]
		private GameObjectBoundsInstantiator <instantiator>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400006C")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x106BBA0", Offset = "0x106ADA0", Length = "0x452")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfBoundsAsset), Member = "SetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectBoundsInstantiator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GltfAssetBase+<InstantiateScene>d__17"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateScene>d__17&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000075")]
		private override void MoveNext() { }

		[Address(RVA = "0x106C000", Offset = "0x106B200", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000076")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001B")]
	private struct <Load>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400006E")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400006F")]
		public GltfBoundsAsset <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000070")]
		public IDownloadProvider downloadProvider; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000071")]
		public IDeferAgent deferAgent; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000072")]
		public IMaterialGenerator materialGenerator; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000073")]
		public ICodeLogger logger; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000074")]
		public string gltfUrl; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000075")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000076")]
		private GameObjectBoundsInstantiator <instantiator>5__2; //Field offset: 0x58

		[Address(RVA = "0x1070A10", Offset = "0x106FC10", Length = "0x614")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GltfImportBase), Member = "InstantiateMainSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInstantiator), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfBoundsAsset), Member = "SetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectBoundsInstantiator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "InstantiateSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInstantiator), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(GltfImportBase), Member = "get_DefaultSceneIndex", ReturnType = typeof(System.Nullable`1<System.Int32>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(GltfImportBase), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ImportSettings), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GltfImport), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000077")]
		private override void MoveNext() { }

		[Address(RVA = "0x1071030", Offset = "0x1070230", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000078")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000064")]
	private Bounds <Bounds>k__BackingField; //Field offset: 0x60
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000065")]
	[Tooltip("If true, a box collider encapsulating the glTF asset is created")]
	private bool createBoxCollider; //Field offset: 0x78

	[Token(Token = "0x17000014")]
	public private Bounds Bounds
	{
		[Address(RVA = "0x10606B0", Offset = "0x105F8B0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600006E")]
		 get { } //Length: 21
		[Address(RVA = "0x10606D0", Offset = "0x105F8D0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600006F")]
		private set { } //Length: 18
	}

	[Token(Token = "0x17000013")]
	public bool CreateBoxCollider
	{
		[Address(RVA = "0x5CE410", Offset = "0x5CD610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006C")]
		 get { } //Length: 5
		[Address(RVA = "0x10606F0", Offset = "0x105F8F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600006D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1060690", Offset = "0x105F890", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000074")]
	public GltfBoundsAsset() { }

	[Address(RVA = "0x10606B0", Offset = "0x105F8B0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600006E")]
	public Bounds get_Bounds() { }

	[Address(RVA = "0x5CE410", Offset = "0x5CD610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006C")]
	public bool get_CreateBoxCollider() { }

	[Address(RVA = "0x1060140", Offset = "0x105F340", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InstantiationSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000072")]
	protected virtual IInstantiator GetDefaultInstantiator(ICodeLogger logger) { }

	[Address(RVA = "0x1060250", Offset = "0x105F450", Length = "0x12E")]
	[AsyncStateMachine(typeof(<InstantiateScene>d__9))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateScene>d__9)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateScene>d__9&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000071")]
	public virtual Task<Boolean> InstantiateScene(int sceneIndex, ICodeLogger logger = null) { }

	[Address(RVA = "0x1060380", Offset = "0x105F580", Length = "0x174")]
	[AsyncStateMachine(typeof(<Load>d__8))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	public virtual Task<Boolean> Load(string gltfUrl, IDownloadProvider downloadProvider = null, IDeferAgent deferAgent = null, IMaterialGenerator materialGenerator = null, ICodeLogger logger = null) { }

	[Address(RVA = "0x10606D0", Offset = "0x105F8D0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600006F")]
	private void set_Bounds(Bounds value) { }

	[Address(RVA = "0x10606F0", Offset = "0x105F8F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600006D")]
	public void set_CreateBoxCollider(bool value) { }

	[Address(RVA = "0x1060500", Offset = "0x105F700", Length = "0x18A")]
	[CalledBy(Type = typeof(<InstantiateScene>d__9), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Load>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObjectBoundsInstantiator), Member = "CalculateBounds", ReturnType = typeof(System.Nullable`1<UnityEngine.Bounds>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(BoxCollider), Member = "set_center", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxCollider), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000073")]
	private void SetBounds(GameObjectBoundsInstantiator instantiator) { }

}

