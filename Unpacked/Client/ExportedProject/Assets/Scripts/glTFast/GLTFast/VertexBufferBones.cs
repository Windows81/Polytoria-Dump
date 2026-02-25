namespace GLTFast;

[Token(Token = "0x200005B")]
internal class VertexBufferBones : VertexBufferBonesBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001AF")]
	private NativeArray<VBones> m_Data; //Field offset: 0x18

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000172")]
	public VertexBufferBones(ICodeLogger logger) { }

	[Address(RVA = "0x1085670", Offset = "0x1084870", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000174")]
	public virtual void AddDescriptors(VertexAttributeDescriptor[] dst, int offset, int stream) { }

	[Address(RVA = "0x1085740", Offset = "0x1084940", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000175")]
	public virtual void ApplyOnMesh(Mesh msh, int stream, MeshUpdateFlags flags = 15) { }

	[Address(RVA = "0x10857E0", Offset = "0x10849E0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6000176")]
	public virtual void Dispose() { }

	[Address(RVA = "0x1085840", Offset = "0x1084A40", Length = "0x27D")]
	[CalledBy(Type = typeof(VertexBufferBones), Member = "ScheduleVertexBonesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertBoneJointsUInt8ToUInt32Job)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertBoneJointsUInt8ToUInt32Job), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000178")]
	private static Nullable<JobHandle> GetJointsJob(Void* input, int count, GltfComponentType inputType, int inputByteStride, uint4* output, int outputByteStride, ICodeLogger logger) { }

	[Address(RVA = "0x1085AC0", Offset = "0x1084CC0", Length = "0x366")]
	[CalledBy(Type = typeof(VertexBufferBones), Member = "ScheduleVertexBonesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertBoneWeightsUInt8ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertBoneWeightsUInt8ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertBoneWeightsUInt16ToFloatInterleavedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertBoneWeightsUInt16ToFloatInterleavedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000177")]
	private Nullable<JobHandle> GetWeightsJob(Void* input, int count, GltfComponentType inputType, int inputByteStride, float4* output, int outputByteStride) { }

	[Address(RVA = "0x1085E30", Offset = "0x1085030", Length = "0x5C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexBufferBones), Member = "GetWeightsJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(GltfComponentType), typeof(int), typeof(float4*), typeof(int)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortAndNormalizeBoneWeightsJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortAndNormalizeBoneWeightsJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(QualitySettings), Member = "get_skinWeights", ReturnType = typeof(SkinWeights))]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(VertexBufferBones), Member = "GetJointsJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(GltfComponentType), typeof(int), typeof(uint4*), typeof(int), typeof(ICodeLogger)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000173")]
	public virtual Nullable<JobHandle> ScheduleVertexBonesJob(IGltfBuffers buffers, int weightsAccessorIndex, int jointsAccessorIndex) { }

}

