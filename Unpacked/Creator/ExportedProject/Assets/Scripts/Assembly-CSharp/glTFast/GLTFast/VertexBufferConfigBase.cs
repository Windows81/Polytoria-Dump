namespace GLTFast;

[Token(Token = "0x2000060")]
internal abstract class VertexBufferConfigBase
{
	[Token(Token = "0x40001C1")]
	public const Allocator defaultAllocator = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C2")]
	public bool calculateNormals; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40001C3")]
	public bool calculateTangents; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C4")]
	protected VertexAttributeDescriptor[] m_Descriptors; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C5")]
	protected ICodeLogger m_Logger; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C6")]
	private Nullable<Bounds> <Bounds>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x1700002C")]
	public Nullable<Bounds> Bounds
	{
		[Address(RVA = "0x1087C70", Offset = "0x1086E70", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600018A")]
		 get { } //Length: 27
		[Address(RVA = "0x1087C90", Offset = "0x1086E90", Length = "0x18")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600018B")]
		 set { } //Length: 24
	}

	[Token(Token = "0x1700002D")]
	public abstract int VertexCount
	{
		[Token(Token = "0x600018F")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2C33D0", Offset = "0x2C25D0", Length = "0x31")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018C")]
	protected VertexBufferConfigBase(ICodeLogger logger) { }

	[Token(Token = "0x600018E")]
	public abstract void ApplyOnMesh(Mesh msh, MeshUpdateFlags flags = 15) { }

	[Token(Token = "0x6000190")]
	public abstract void Dispose() { }

	[Address(RVA = "0x1087C70", Offset = "0x1086E70", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600018A")]
	public Nullable<Bounds> get_Bounds() { }

	[Token(Token = "0x600018F")]
	public abstract int get_VertexCount() { }

	[Address(RVA = "0x1086FE0", Offset = "0x10861E0", Length = "0x366")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertTangentsInt8ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertTangentsInt8ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertTangentsInt16ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertTangentsInt16ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertTangentsFloatToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertTangentsFloatToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000192")]
	protected Nullable<JobHandle> GetTangentsJob(Void* input, int count, GltfComponentType inputType, int inputByteStride, float4* output, int outputByteStride, bool normalized = false) { }

	[Address(RVA = "0x1087350", Offset = "0x1086550", Length = "0x6E2")]
	[CalledBy(Type = typeof(MorphTargetContext), Member = "ScheduleMorphTargetJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int), typeof(int), typeof(ICodeLogger)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsInt8ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsInt8ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsUInt16ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsUInt16ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsUInt16ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsUInt16ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertNormalsInt16ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertNormalsInt16ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertVector3Int16ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertVector3Int16ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsInt16ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsInt16ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertNormalsInt8ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertNormalsInt8ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertVector3FloatToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertVector3FloatToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsUInt8ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsUInt8ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsUInt8ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertPositionsUInt8ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertVector3Int8ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertVector3Int8ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Token(Token = "0x6000191")]
	public static Nullable<JobHandle> GetVector3Job(Void* input, int count, GltfComponentType inputType, int inputByteStride, float3* output, int outputByteStride, bool normalized = false, bool ensureUnitLength = true) { }

	[Address(RVA = "0x1087A40", Offset = "0x1086C40", Length = "0xB0")]
	[CalledBy(Type = typeof(MorphTargetContext), Member = "ScheduleMorphTargetJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int), typeof(int), typeof(ICodeLogger)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CachedFunction), Member = "GetIndexConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GltfComponentType)}, ReturnType = typeof(Unity.Burst.FunctionPointer`1<GLTFast.Jobs.CachedFunction+GetIndexDelegate>))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000193")]
	public static Nullable<JobHandle> GetVector3SparseJob(Void* indexBuffer, Void* valueBuffer, int sparseCount, GltfComponentType indexType, GltfComponentType valueType, float3* output, int outputByteStride, ref Nullable<JobHandle>& dependsOn, bool normalized = false) { }

	[Token(Token = "0x600018D")]
	public abstract Nullable<JobHandle> ScheduleVertexJobs(IGltfBuffers buffers, int positionAccessorIndex, int normalAccessorIndex, int tangentAccessorIndex, Int32[] uvAccessorIndices, int colorAccessorIndex, int weightsAccessorIndex, int jointsAccessorIndex) { }

	[Address(RVA = "0x1087C90", Offset = "0x1086E90", Length = "0x18")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600018B")]
	protected void set_Bounds(Nullable<Bounds> value) { }

}

