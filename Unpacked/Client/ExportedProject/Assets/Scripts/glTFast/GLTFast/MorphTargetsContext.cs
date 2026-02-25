namespace GLTFast;

[Token(Token = "0x2000045")]
internal class MorphTargetsContext
{
	[CompilerGenerated]
	[Token(Token = "0x2000046")]
	private struct <ApplyOnMeshAndDispose>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000170")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000172")]
		public MorphTargetsContext <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000173")]
		public Mesh mesh; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000174")]
		private int <index>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000175")]
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x107AEA0", Offset = "0x107A0A0", Length = "0x2C2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Mesh), Member = "AddBlendShapeFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(Vector3[]), typeof(Vector3[]), typeof(Vector3[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MorphTargetContext), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6000132")]
		private override void MoveNext() { }

		[Address(RVA = "0x107B170", Offset = "0x107A370", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000133")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016B")]
	private MorphTargetContext[] m_Contexts; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016C")]
	private NativeArray<JobHandle> m_Handles; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400016D")]
	private int m_CurrentIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400016E")]
	private String[] m_MeshTargetNames; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400016F")]
	private IDeferAgent m_DeferAgent; //Field offset: 0x38

	[Address(RVA = "0x1078150", Offset = "0x1077350", Length = "0xE0")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "CreateMorphTargetsContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPrimitiveBase), typeof(String[])}, ReturnType = typeof(MorphTargetsContext))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600012E")]
	public MorphTargetsContext(int morphTargetCount, String[] meshTargetNames, IDeferAgent deferAgent) { }

	[Address(RVA = "0x1077E30", Offset = "0x1077030", Length = "0x186")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "CreateMorphTargetsContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPrimitiveBase), typeof(String[])}, ReturnType = typeof(MorphTargetsContext))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MorphTargetContext), Member = "ScheduleMorphTargetJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int), typeof(int), typeof(ICodeLogger)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600012F")]
	public bool AddMorphTarget(IGltfBuffers buffers, int positionAccessorIndex, int normalAccessorIndex, int tangentAccessorIndex, ICodeLogger logger) { }

	[Address(RVA = "0x1077FC0", Offset = "0x10771C0", Length = "0xF1")]
	[AsyncStateMachine(typeof(<ApplyOnMeshAndDispose>d__8))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ApplyOnMeshAndDispose>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ApplyOnMeshAndDispose>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000131")]
	public Task ApplyOnMeshAndDispose(Mesh mesh) { }

	[Address(RVA = "0x10780C0", Offset = "0x10772C0", Length = "0x8B")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000130")]
	public JobHandle GetJobHandle() { }

}

