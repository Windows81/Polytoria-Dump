namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000584")]
internal class OpacityIdAccelerator : IDisposable
{
	[Token(Token = "0x2000585")]
	private struct OpacityIdUpdateJob : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableContainerSafetyRestriction]
		[Token(Token = "0x400134D")]
		public NativeSlice<Vertex> oldVerts; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[NativeDisableContainerSafetyRestriction]
		[Token(Token = "0x400134E")]
		public NativeSlice<Vertex> newVerts; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400134F")]
		public Color32 opacityData; //Field offset: 0x20

		[Address(RVA = "0x1B90690", Offset = "0x1B8F890", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vertex))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vertex)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002766")]
		public override void Execute(int i) { }

	}

	[Token(Token = "0x4001348")]
	private const int k_VerticesPerBatch = 128; //Field offset: 0x0
	[Token(Token = "0x4001349")]
	private const int k_JobLimit = 256; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400134A")]
	private NativeArray<JobHandle> m_Jobs; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400134B")]
	private int m_NextJobIndex; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400134C")]
	private bool <disposed>k__BackingField; //Field offset: 0x24

	[Token(Token = "0x170009EF")]
	protected private bool disposed
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002761")]
		 get { } //Length: 5
		[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002762")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1B90620", Offset = "0x1B8F820", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002765")]
	public OpacityIdAccelerator() { }

	[Address(RVA = "0x1B90370", Offset = "0x1B8F570", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Token(Token = "0x6002760")]
	public void CompleteJobs() { }

	[Address(RVA = "0x1B90420", Offset = "0x1B8F620", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpacityIdUpdateJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpacityIdUpdateJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
	[Token(Token = "0x600275F")]
	public void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	[Address(RVA = "0x1B90550", Offset = "0x1B8F750", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002763")]
	public override void Dispose() { }

	[Address(RVA = "0x1B905C0", Offset = "0x1B8F7C0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6002764")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002761")]
	protected bool get_disposed() { }

	[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002762")]
	private void set_disposed(bool value) { }

}

