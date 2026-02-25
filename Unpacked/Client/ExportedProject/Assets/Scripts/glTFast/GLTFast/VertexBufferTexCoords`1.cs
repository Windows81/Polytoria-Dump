namespace GLTFast;

[Token(Token = "0x2000062")]
internal class VertexBufferTexCoords : VertexBufferTexCoordsBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C9")]
	private NativeArray<T> m_Data; //Field offset: 0x0

	[Address(RVA = "0x928660", Offset = "0x927860", Length = "0x4C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019B")]
	public VertexBufferTexCoords`1(ICodeLogger logger) { }

	[Address(RVA = "0x925BF0", Offset = "0x924DF0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019D")]
	public virtual void AddDescriptors(VertexAttributeDescriptor[] dst, ref int offset, int stream) { }

	[Address(RVA = "0x925DA0", Offset = "0x924FA0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VTexCoord1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<GLTFast.Vertex.VTexCoord1>), typeof(int), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600019E")]
	public virtual void ApplyOnMesh(Mesh msh, int stream, MeshUpdateFlags flags = 15) { }

	[Address(RVA = "0x925E80", Offset = "0x925080", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600019F")]
	public virtual void Dispose() { }

	[Address(RVA = "0x925EA0", Offset = "0x9250A0", Length = "0x66C")]
	[CalledBy(Type = typeof(VertexBufferTexCoords`1), Member = "ScheduleVertexUVJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(Int32[]), typeof(int), typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsInt16ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsInt16ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsFloatToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsFloatToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsUInt16ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsUInt16ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsUInt16ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsUInt16ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsInt16ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsInt16ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsUInt8ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsUInt8ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsInt8ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsInt8ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsInt8ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsInt8ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsUInt8ToFloatInterleavedNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertUVsUInt8ToFloatInterleavedNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A0")]
	private Nullable<JobHandle> GetUvsJob(Void* input, int count, GltfComponentType inputType, int inputByteStride, float2* output, int outputByteStride, bool normalized = false) { }

	[Address(RVA = "0x928300", Offset = "0x927500", Length = "0x35D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexBufferTexCoords`1), Member = "GetUvsJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(GltfComponentType), typeof(int), typeof(float2*), typeof(int), typeof(bool)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(AccessorBase), Member = "get_IsSparse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(NativeSlice`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019C")]
	public virtual bool ScheduleVertexUVJobs(IGltfBuffers buffers, Int32[] uvAccessorIndices, int vertexCount, NativeSlice<JobHandle> handles) { }

}

