namespace GLTFast;

[Token(Token = "0x2000047")]
internal class MorphTargetContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000176")]
	private Vector3[] m_Positions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000177")]
	private Vector3[] m_Normals; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000178")]
	private Vector3[] m_Tangents; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000179")]
	private GCHandle m_PositionsHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017A")]
	private GCHandle m_NormalsHandle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017B")]
	private GCHandle m_TangentsHandle; //Field offset: 0x38

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000137")]
	public MorphTargetContext() { }

	[Address(RVA = "0x1076C60", Offset = "0x1075E60", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "AddBlendShapeFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(Vector3[]), typeof(Vector3[]), typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000135")]
	public void AddToMesh(Mesh mesh, string name) { }

	[Address(RVA = "0x1076CB0", Offset = "0x1075EB0", Length = "0x7C")]
	[CalledBy(Type = "GLTFast.MorphTargetsContext+<ApplyOnMeshAndDispose>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000136")]
	public void Dispose() { }

	[Address(RVA = "0x1076D30", Offset = "0x1075F30", Length = "0xFA3")]
	[CalledBy(Type = typeof(MorphTargetsContext), Member = "AddMorphTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int), typeof(int), typeof(ICodeLogger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(VertexBufferConfigBase), Member = "GetVector3SparseJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(int), typeof(GltfComponentType), typeof(GltfComponentType), typeof(float3*), typeof(int), typeof(Nullable`1<JobHandle>&), typeof(bool)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(VertexBufferConfigBase), Member = "GetVector3Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(GltfComponentType), typeof(int), typeof(float3*), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(System.Nullable`1<Unity.Jobs.JobHandle>))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 34)]
	[Token(Token = "0x6000134")]
	public Nullable<JobHandle> ScheduleMorphTargetJobs(IGltfBuffers buffers, int positionAccessorIndex, int normalAccessorIndex, int tangentAccessorIndex, ICodeLogger logger) { }

}

