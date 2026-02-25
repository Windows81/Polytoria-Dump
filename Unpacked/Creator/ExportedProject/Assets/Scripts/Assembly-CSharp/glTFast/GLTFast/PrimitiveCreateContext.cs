namespace GLTFast;

[Token(Token = "0x200004A")]
internal class PrimitiveCreateContext : PrimitiveCreateContextBase
{
	[CompilerGenerated]
	[Token(Token = "0x200004B")]
	private struct <CreatePrimitive>d__11 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000185")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<Nullable`1<MeshResult>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000187")]
		public PrimitiveCreateContext <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000188")]
		private Mesh <msh>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x107B890", Offset = "0x107AA90", Length = "0x8B4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mesh), Member = "RecalculateTangents", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<GLTFast.MeshResult>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<GLTFast.MeshResult>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<CreatePrimitive>d__11)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<CreatePrimitive>d__11&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<GLTFast.MeshResult>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<GLTFast.MeshResult>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Nullable`1<GLTFast.MeshResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshResult)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.MorphTargetsContext+<ApplyOnMeshAndDispose>d__8"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ApplyOnMeshAndDispose>d__8&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Mesh), Member = "set_bounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = "RecalculateNormals", ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = "SetSubMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SubMeshDescriptor), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = "set_subMeshCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = "SetIndexBufferParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IndexFormat)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600013F")]
		private override void MoveNext() { }

		[Address(RVA = "0x107C150", Offset = "0x107B350", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000140")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017F")]
	public VertexBufferConfigBase vertexData; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000180")]
	public JobHandle jobHandle; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000181")]
	private Int32[][] m_Indices; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000182")]
	private Int32[] m_PrimitiveIndices; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000183")]
	public GCHandle calculatedIndicesHandle; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000184")]
	public MeshTopology topology; //Field offset: 0x60

	[Token(Token = "0x17000026")]
	public virtual bool IsCompleted
	{
		[Address(RVA = "0x1078E80", Offset = "0x1078080", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600013C")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1078D80", Offset = "0x1077F80", Length = "0xF3")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000139")]
	public PrimitiveCreateContext(int meshIndex, int primitiveIndex, int subMeshCount, string meshName) { }

	[Address(RVA = "0x1078C00", Offset = "0x1077E00", Length = "0xEC")]
	[AsyncStateMachine(typeof(<CreatePrimitive>d__11))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<GLTFast.MeshResult>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreatePrimitive>d__11)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreatePrimitive>d__11&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<GLTFast.MeshResult>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<GLTFast.MeshResult>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600013D")]
	public virtual Task<Nullable`1<MeshResult>> CreatePrimitive() { }

	[Address(RVA = "0x1078CF0", Offset = "0x1077EF0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Token(Token = "0x600013E")]
	private void Dispose() { }

	[Address(RVA = "0x1078E80", Offset = "0x1078080", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600013C")]
	public virtual bool get_IsCompleted() { }

	[Address(RVA = "0x1078D10", Offset = "0x1077F10", Length = "0x3D")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "PreparePrimitiveIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(MeshPrimitiveBase), typeof(PrimitiveCreateContext&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600013A")]
	public void SetIndices(int subMesh, Int32[] indices) { }

	[Address(RVA = "0x1078D50", Offset = "0x1077F50", Length = "0x2B")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600013B")]
	public void SetPrimitiveIndex(int subMesh, int primitiveIndex) { }

}

