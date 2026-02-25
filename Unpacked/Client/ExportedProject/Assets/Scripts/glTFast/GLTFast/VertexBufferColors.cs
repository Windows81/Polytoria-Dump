namespace GLTFast;

[Token(Token = "0x200005D")]
internal class VertexBufferColors : VertexBufferColorsBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B1")]
	private NativeArray<float4> m_Data; //Field offset: 0x18

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017E")]
	public VertexBufferColors(ICodeLogger logger = null) { }

	[Address(RVA = "0x1086400", Offset = "0x1085600", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000180")]
	public virtual void AddDescriptors(VertexAttributeDescriptor[] dst, int offset, int stream) { }

	[Address(RVA = "0x1086470", Offset = "0x1085670", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000181")]
	public virtual void ApplyOnMesh(Mesh msh, int stream, MeshUpdateFlags flags = 15) { }

	[Address(RVA = "0x1086510", Offset = "0x1085710", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6000182")]
	public virtual void Dispose() { }

	[Address(RVA = "0x1086570", Offset = "0x1085770", Length = "0x6ED")]
	[CalledBy(Type = typeof(VertexBufferColors), Member = "ScheduleVertexColorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRgbaUInt8ToRGBAFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRgbaUInt8ToRGBAFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRgbUInt16ToRGBAFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRgbUInt16ToRGBAFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRgbUInt8ToRGBAFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRgbUInt8ToRGBAFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRGBAFloatToRGBAFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRGBAFloatToRGBAFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRgbaUInt16ToRGBAFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRgbaUInt16ToRGBAFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRGBFloatToRGBAFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertColorsRGBFloatToRGBAFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000183")]
	private Nullable<JobHandle> GetColors32Job(Void* input, GltfComponentType inputType, GltfAccessorAttributeType attributeType, int inputByteStride, NativeArray<float4> output) { }

	[Address(RVA = "0x1086C60", Offset = "0x1085E60", Length = "0x377")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEnum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), "TEnum&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VertexBufferColors), Member = "GetColors32Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(GltfComponentType), typeof(GltfAccessorAttributeType), typeof(int), typeof(Unity.Collections.NativeArray`1<Unity.Mathematics.float4>)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(NativeSlice`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600017F")]
	public virtual bool ScheduleVertexColorJob(IGltfBuffers buffers, int colorAccessorIndex, NativeSlice<JobHandle> handles) { }

}

