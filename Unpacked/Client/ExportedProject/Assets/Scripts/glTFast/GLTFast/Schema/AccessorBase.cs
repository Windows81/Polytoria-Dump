namespace GLTFast.Schema;

[Token(Token = "0x200007C")]
public abstract class AccessorBase : NamedObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000214")]
	public int bufferView; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000215")]
	public int byteOffset; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000216")]
	public GltfComponentType componentType; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000217")]
	public bool normalized; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000218")]
	public int count; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Obsolete("Use GetAttributeType and SetAttributeType for access.")]
	[Token(Token = "0x4000219")]
	public string type; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400021A")]
	private GltfAccessorAttributeType m_TypeEnum; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400021B")]
	public Single[] max; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400021C")]
	public Single[] min; //Field offset: 0x48

	[Token(Token = "0x17000031")]
	public bool IsSparse
	{
		[Address(RVA = "0x1072F90", Offset = "0x1072190", Length = "0x22")]
		[CalledBy(Type = typeof(GltfImportBase), Member = "GetIndicesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(Int32[]&), typeof(Nullable`1<JobHandle>&), typeof(GCHandle&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GltfImportBase), Member = "GetMatricesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Matrix4x4>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GltfImportBase), Member = "GetVector3Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Vector3>&), typeof(Nullable`1<JobHandle>&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GltfImportBase), Member = "GetVector4Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Quaternion>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GltfImportBase), Member = "GetScalarJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(Nullable`1<NativeArray`1<Single>>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VertexBufferConfig`1), Member = "ScheduleVertexJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int), typeof(int), typeof(Int32[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
		[CalledBy(Type = typeof(VertexBufferTexCoords`1), Member = "ScheduleVertexUVJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(Int32[]), typeof(int), typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001B1")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000030")]
	public abstract AccessorSparseBase Sparse
	{
		[Token(Token = "0x60001AD")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1072F80", Offset = "0x1072180", Length = "0xE")]
	[CalledBy(Type = typeof(AccessorBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001B2")]
	protected AccessorBase() { }

	[Address(RVA = "0x1072F90", Offset = "0x1072190", Length = "0x22")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetIndicesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(Int32[]&), typeof(Nullable`1<JobHandle>&), typeof(GCHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetMatricesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Matrix4x4>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetVector3Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Vector3>&), typeof(Nullable`1<JobHandle>&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetVector4Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Quaternion>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetScalarJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(Nullable`1<NativeArray`1<Single>>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexBufferConfig`1), Member = "ScheduleVertexJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int), typeof(int), typeof(Int32[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[CalledBy(Type = typeof(VertexBufferTexCoords`1), Member = "ScheduleVertexUVJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(Int32[]), typeof(int), typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B1")]
	public bool get_IsSparse() { }

	[Token(Token = "0x60001AD")]
	public abstract AccessorSparseBase get_Sparse() { }

	[Address(RVA = "0x1072880", Offset = "0x1071A80", Length = "0xBD")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEnum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), "TEnum&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001AC")]
	public GltfAccessorAttributeType GetAttributeType() { }

	[Address(RVA = "0x1072940", Offset = "0x1071B40", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AF")]
	public static int GetComponentTypeSize(GltfComponentType componentType) { }

	[Address(RVA = "0x1072A30", Offset = "0x1071C30", Length = "0x538")]
	[CalledBy(Type = typeof(VertexBufferConfig`1), Member = "ScheduleVertexJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int), typeof(int), typeof(Int32[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float3), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B0")]
	public Nullable<Bounds> TryGetBounds() { }

	[Token(Token = "0x60001AE")]
	internal abstract void UnsetSparse() { }

}

