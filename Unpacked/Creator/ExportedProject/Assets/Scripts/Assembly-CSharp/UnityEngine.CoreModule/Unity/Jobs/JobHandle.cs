namespace Unity.Jobs;

[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
[Token(Token = "0x2000011")]
public struct JobHandle : IEquatable<JobHandle>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000C")]
	internal ulong jobGroup; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400000D")]
	internal int version; //Field offset: 0x8

	[Token(Token = "0x17000001")]
	public bool IsCompleted
	{
		[Address(RVA = "0x192C890", Offset = "0x192BA90", Length = "0x33")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001C")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x192C790", Offset = "0x192B990", Length = "0x6A")]
	[CalledBy(Type = "GLTFast.VertexBufferBones", Member = "ScheduleVertexBonesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.IGltfBuffers", typeof(int), typeof(int)}, ReturnType = "System.Nullable`1<JobHandle>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[Address(RVA = "0x192C620", Offset = "0x192B820", Length = "0xA2")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobMerger", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.OpacityIdAccelerator", Member = "CreateJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<Vertex>", "Unity.Collections.NativeSlice`1<Vertex>", typeof(Color32), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager+VisualChangesProcessor", Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderData", "UnityEngine.UIElements.UIR.RenderTreeManager", "UnityEngine.UIElements.UIR.MeshHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.MorphTargetsContext", Member = "GetJobHandle", ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "GLTFast.MorphTargetContext", Member = "ScheduleMorphTargetJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.IGltfBuffers", typeof(int), typeof(int), typeof(int), "GLTFast.Logging.ICodeLogger"}, ReturnType = "System.Nullable`1<JobHandle>")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs) { }

	[Address(RVA = "0x192C6D0", Offset = "0x192B8D0", Length = "0xBE")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobMerger", Member = "MergeAndReset", ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.OpacityIdAccelerator", Member = "CompleteJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTree", Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.ChainBuilderStats&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs) { }

	[Address(RVA = "0x192C510", Offset = "0x192B710", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000023")]
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	[Address(RVA = "0x192C4B0", Offset = "0x192B6B0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

	[Address(RVA = "0x192C5C0", Offset = "0x192B7C0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000024")]
	internal static JobHandle CombineDependenciesInternalPtr(Void* jobs, int count) { }

	[Address(RVA = "0x192C570", Offset = "0x192B770", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	private static void CombineDependenciesInternalPtr_Injected(Void* jobs, int count, out JobHandle ret) { }

	[Address(RVA = "0x192C800", Offset = "0x192BA00", Length = "0x3F")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerationDeferrer", Member = "ProcessDeferredWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.OpacityIdAccelerator", Member = "CompleteJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTree", Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.ChainBuilderStats&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.PrimitiveCreateContext+<CreatePrimitive>d__11", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	public void Complete() { }

	[Address(RVA = "0x192C840", Offset = "0x192BA40", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000025")]
	public override bool Equals(JobHandle other) { }

	[Address(RVA = "0x192C890", Offset = "0x192BA90", Length = "0x33")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x192C8D0", Offset = "0x192BAD0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.OpacityIdAccelerator", Member = "CreateJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<Vertex>", "Unity.Collections.NativeSlice`1<Vertex>", typeof(Color32), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager+VisualChangesProcessor", Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderData", "UnityEngine.UIElements.UIR.RenderTreeManager", "UnityEngine.UIElements.UIR.MeshHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BatchRendererGroup), Member = "InvokeOnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchRendererCullingOutput&), typeof(LODParameters&), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<CreatePrimitiveContexts>d__143", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x600001D")]
	public static void ScheduleBatchedJobs() { }

	[Address(RVA = "0x192C850", Offset = "0x192BA50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600001E")]
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[Address(RVA = "0x192C890", Offset = "0x192BA90", Length = "0x33")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeMethod("ScheduleBatchedScriptingJobsAndIsCompleted", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600001F")]
	private static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job) { }

}

