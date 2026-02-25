namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000577")]
internal class MeshGenerationDeferrer : IDisposable
{
	[Token(Token = "0x2000578")]
	private struct CallbackInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012E4")]
		public MeshGenerationCallback callback; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40012E5")]
		public object userData; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012DB")]
	private Queue<CallbackInfo> m_Fork; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012DC")]
	private Queue<CallbackInfo> m_WorkThenFork; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012DD")]
	private Queue<CallbackInfo> m_Work; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012DE")]
	private Queue<CallbackInfo> m_JobDependentFork; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012DF")]
	private Queue<CallbackInfo> m_JobDependentWorkThenFork; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40012E0")]
	private Queue<CallbackInfo> m_JobDependentWork; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40012E1")]
	private Queue<JobHandle> m_Dependencies; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40012E2")]
	private JobMerger m_DependencyMerger; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40012E3")]
	private bool <disposed>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x170009E6")]
	protected private bool disposed
	{
		[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002710")]
		 get { } //Length: 5
		[Address(RVA = "0x3EB960", Offset = "0x3EAB60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002711")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1B84670", Offset = "0x1B83870", Length = "0x276")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x6002714")]
	public MeshGenerationDeferrer() { }

	[Address(RVA = "0x1B83ED0", Offset = "0x1B830D0", Length = "0x1B9")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = "ScheduleJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Queue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270D")]
	public void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent) { }

	[Address(RVA = "0x1B84090", Offset = "0x1B83290", Length = "0x5E")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = "ScheduleJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<Unity.Jobs.JobHandle>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270C")]
	public void AddMeshGenerationJob(JobHandle jobHandle) { }

	[Address(RVA = "0x1B840F0", Offset = "0x1B832F0", Length = "0x7B")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JobMerger), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002712")]
	public override void Dispose() { }

	[Address(RVA = "0x1B84170", Offset = "0x1B83370", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobMerger), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002713")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002710")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1B841C0", Offset = "0x1B833C0", Length = "0xFC")]
	[CalledBy(Type = typeof(MeshGenerationDeferrer), Member = "ProcessDeferredWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600270F")]
	private static void Invoke(CallbackInfo ci, MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B842C0", Offset = "0x1B834C0", Length = "0x3A6")]
	[CalledBy(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Queue`1), Member = "Dequeue", ReturnType = "T")]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackInfo), typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<Unity.Jobs.JobHandle>), Member = "Dequeue", ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobMerger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobMerger), Member = "MergeAndReset", ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270E")]
	public void ProcessDeferredWork(MeshGenerationContext meshGenerationContext) { }

	[Address(RVA = "0x3EB960", Offset = "0x3EAB60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002711")]
	private void set_disposed(bool value) { }

}

