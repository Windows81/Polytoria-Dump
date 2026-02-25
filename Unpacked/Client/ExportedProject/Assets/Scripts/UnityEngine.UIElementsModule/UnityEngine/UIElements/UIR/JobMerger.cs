namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000571")]
internal class JobMerger : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012D0")]
	private NativeArray<JobHandle> m_Jobs; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012D1")]
	private int m_JobCount; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40012D2")]
	private bool <disposed>k__BackingField; //Field offset: 0x24

	[Token(Token = "0x170009E4")]
	protected private bool disposed
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026FA")]
		 get { } //Length: 5
		[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026FB")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1B83E30", Offset = "0x1B83030", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026F7")]
	public JobMerger(int capacity) { }

	[Address(RVA = "0x1B83C20", Offset = "0x1B82E20", Length = "0x80")]
	[CalledBy(Type = typeof(MeshGenerationDeferrer), Member = "ProcessDeferredWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Token(Token = "0x60026F8")]
	public void Add(JobHandle job) { }

	[Address(RVA = "0x1B83D00", Offset = "0x1B82F00", Length = "0x7F")]
	[CalledBy(Type = typeof(JobManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JobManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationDeferrer), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationDeferrer), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60026FC")]
	public override void Dispose() { }

	[Address(RVA = "0x1B83CA0", Offset = "0x1B82EA0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x60026FD")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026FA")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1B83D80", Offset = "0x1B82F80", Length = "0xA6")]
	[CalledBy(Type = typeof(MeshGenerationDeferrer), Member = "ProcessDeferredWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Token(Token = "0x60026F9")]
	public JobHandle MergeAndReset() { }

	[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026FB")]
	private void set_disposed(bool value) { }

}

