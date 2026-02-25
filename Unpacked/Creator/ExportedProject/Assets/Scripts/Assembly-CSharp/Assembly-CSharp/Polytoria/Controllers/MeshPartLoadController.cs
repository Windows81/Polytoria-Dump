namespace Polytoria.Controllers;

[Token(Token = "0x200040D")]
public class MeshPartLoadController : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200040E")]
	private struct <GetMeshUrlAsync>d__17 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001117")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001118")]
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001119")]
		public int assetID; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400111A")]
		private HttpClient <client>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400111B")]
		private TaskAwaiter<HttpResponseMessage> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400111C")]
		private TaskAwaiter<String> <>u__2; //Field offset: 0x38

		[Address(RVA = "0x4C93C0", Offset = "0x4C85C0", Length = "0x900")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<GetMeshUrlAsync>d__17)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<GetMeshUrlAsync>d__17&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(HttpContent), Member = "ReadAsStringAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(HttpResponseMessage), Member = "EnsureSuccessStatusCode", ReturnType = typeof(HttpResponseMessage))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(HttpClient), Member = "GetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Application), Member = "get_version", ReturnType = typeof(string))]
		[Calls(Type = typeof(HttpHeaders), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpClient), Member = "get_DefaultRequestHeaders", ReturnType = typeof(HttpRequestHeaders))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HttpClient), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		[Token(Token = "0x6002B44")]
		private override void MoveNext() { }

		[Address(RVA = "0x4C9CD0", Offset = "0x4C8ED0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6002B45")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200040F")]
	private struct <ImportMeshAsync>d__18 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400111D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400111E")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400111F")]
		public MeshPartLoadController <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001120")]
		public string meshUrl; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001121")]
		public MeshPartLoadRequest request; //Field offset: 0x30
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4001122")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001123")]
		private GameObject <loadedObject>5__2; //Field offset: 0x50

		[Address(RVA = "0x4C9D40", Offset = "0x4C8F40", Length = "0x585")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GltfImportBase), Member = "InstantiateMainSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInstantiator), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Boolean>), typeof(<ImportMeshAsync>d__18)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Boolean>&), typeof(<ImportMeshAsync>d__18&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshPartLoadController), Member = "EnableRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(GltfImportBase), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ImportSettings), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GltfImport), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[Token(Token = "0x6002B46")]
		private override void MoveNext() { }

		[Address(RVA = "0x4CA2D0", Offset = "0x4C94D0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6002B47")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000410")]
	private struct <LoadMeshAsync>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001124")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001125")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001126")]
		public MeshPartLoadController <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001127")]
		public MeshPartLoadRequest request; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001128")]
		private GameObject <loadedObject>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4001129")]
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400112A")]
		private TaskAwaiter<GameObject> <>u__2; //Field offset: 0x50

		[Address(RVA = "0x4CBA70", Offset = "0x4CAC70", Length = "0x865")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshPartLoadController), Member = "EnableRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshPartLoadController), Member = "AttachLoadedObjectToMeshPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPartLoadRequest), typeof(GameObject)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshPartLoadController), Member = "AdjustLoadedObjectBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshPartLoadController), Member = "ClearExistingChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPart)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.MeshPartLoadController+<ImportMeshAsync>d__18"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ImportMeshAsync>d__18&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetMeshUrlAsync>d__17&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002B48")]
		private override void MoveNext() { }

		[Address(RVA = "0x4CC2E0", Offset = "0x4CB4E0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6002B49")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x400110F")]
	public static MeshPartLoadController Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001110")]
	private Queue<MeshPartLoadRequest> loadQueue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001111")]
	private GameObject meshStorage; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001112")]
	private bool loading; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4001113")]
	private ImportSettings importSettings; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4001114")]
	private InstantiationSettings instantiationSettings; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001115")]
	private GltfImport <Importer>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001116")]
	private ConsoleLogger logger; //Field offset: 0x50

	[Token(Token = "0x17000CE1")]
	public GltfImport Importer
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B33")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B34")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x4C5F40", Offset = "0x4C5140", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002B43")]
	public MeshPartLoadController() { }

	[Address(RVA = "0x4C4640", Offset = "0x4C3840", Length = "0x669")]
	[CalledBy(Type = typeof(<LoadMeshAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshPartLoadController), Member = "ProcessLoadedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPartLoadRequest), typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002B40")]
	private void AdjustLoadedObjectBounds(GameObject loadedObject) { }

	[Address(RVA = "0x4C4CB0", Offset = "0x4C3EB0", Length = "0x531")]
	[CalledBy(Type = typeof(<LoadMeshAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshPartLoadController), Member = "ProcessLoadedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPartLoadRequest), typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Material), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(MeshPart), Member = "UpdateColliders", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002B41")]
	private void AttachLoadedObjectToMeshPart(MeshPartLoadRequest request, GameObject loadedObject) { }

	[Address(RVA = "0x4C51F0", Offset = "0x4C43F0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002B35")]
	private void Awake() { }

	[Address(RVA = "0x4C5250", Offset = "0x4C4450", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshPartLoadController), Member = "EnableRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B3D")]
	private void CacheLoadedObject(int assetID, GameObject loadedObject) { }

	[Address(RVA = "0x4C53A0", Offset = "0x4C45A0", Length = "0x27B")]
	[CalledBy(Type = typeof(<LoadMeshAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshPartLoadController), Member = "ProcessLoadedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPartLoadRequest), typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002B3F")]
	private void ClearExistingChildren(MeshPart meshPart) { }

	[Address(RVA = "0x4C5620", Offset = "0x4C4820", Length = "0xA8")]
	[CalledBy(Type = typeof(<ImportMeshAsync>d__18), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<LoadMeshAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshPartLoadController), Member = "FindInCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(MeshPartLoadController), Member = "CacheLoadedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002B42")]
	private void EnableRenderers(GameObject obj, bool enabled) { }

	[Address(RVA = "0x4C56D0", Offset = "0x4C48D0", Length = "0x106")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(MeshPartLoadController), Member = "EnableRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002B3A")]
	private GameObject FindInCache(int assetID) { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B33")]
	public GltfImport get_Importer() { }

	[Address(RVA = "0x4C57E0", Offset = "0x4C49E0", Length = "0xEA")]
	[AsyncStateMachine(typeof(<GetMeshUrlAsync>d__17))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetMeshUrlAsync>d__17)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetMeshUrlAsync>d__17&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B3B")]
	private Task<String> GetMeshUrlAsync(int assetID) { }

	[Address(RVA = "0x4C58D0", Offset = "0x4C4AD0", Length = "0x155")]
	[AsyncStateMachine(typeof(<ImportMeshAsync>d__18))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ImportMeshAsync>d__18)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ImportMeshAsync>d__18&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B3C")]
	private Task<GameObject> ImportMeshAsync(MeshPartLoadRequest request, string meshUrl) { }

	[Address(RVA = "0x4C5B40", Offset = "0x4C4D40", Length = "0x69")]
	[CalledBy(Type = typeof(MeshPart), Member = "set_AssetID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshPart), Member = "LoadMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Queue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002B37")]
	public void LoadMesh(MeshPartLoadRequest request) { }

	[Address(RVA = "0x4C5A30", Offset = "0x4C4C30", Length = "0x10F")]
	[AsyncStateMachine(typeof(<LoadMeshAsync>d__15))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadMeshAsync>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadMeshAsync>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B39")]
	private Task LoadMeshAsync(MeshPartLoadRequest request) { }

	[Address(RVA = "0x4C5BB0", Offset = "0x4C4DB0", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshPartLoadController), Member = "ClearExistingChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshPartLoadController), Member = "AdjustLoadedObjectBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshPartLoadController), Member = "AttachLoadedObjectToMeshPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPartLoadRequest), typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002B3E")]
	private void ProcessLoadedObject(MeshPartLoadRequest request, GameObject loadedObject) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B34")]
	protected void set_Importer(GltfImport value) { }

	[Address(RVA = "0x4C5D10", Offset = "0x4C4F10", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GltfImport), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B36")]
	private void Start() { }

	[Address(RVA = "0x4C5DD0", Offset = "0x4C4FD0", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Queue`1), Member = "Dequeue", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadMeshAsync>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadMeshAsync>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B38")]
	private void Update() { }

}

