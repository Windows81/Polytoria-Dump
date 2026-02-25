namespace GLTFast;

[Token(Token = "0x200005E")]
internal class VertexBufferConfig : VertexBufferConfigBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B2")]
	private NativeArray<VType> m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B3")]
	private bool m_HasNormals; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B4")]
	private bool m_HasTangents; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B5")]
	private bool m_HasColors; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B6")]
	private bool m_HasBones; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B7")]
	private VertexBufferTexCoordsBase m_TexCoords; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B8")]
	private VertexBufferColors m_Colors; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B9")]
	private VertexBufferBones m_Bones; //Field offset: 0x0

	[Token(Token = "0x1700002B")]
	public virtual int VertexCount
	{
		[Address(RVA = "0x925B70", Offset = "0x924D70", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000184")]
		 get { } //Length: 14
	}

	[Address(RVA = "0x925B60", Offset = "0x924D60", Length = "0x8")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000185")]
	public VertexBufferConfig`1(ICodeLogger logger) { }

	[Address(RVA = "0x9210D0", Offset = "0x9202D0", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexBufferConfig`1), Member = "CreateDescriptors", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VPos)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<GLTFast.Vertex.VPos>), typeof(int), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000188")]
	public virtual void ApplyOnMesh(Mesh msh, MeshUpdateFlags flags = 15) { }

	[Address(RVA = "0x921220", Offset = "0x920420", Length = "0x27B")]
	[CalledBy(Type = typeof(VertexBufferConfig`1), Member = "ApplyOnMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000187")]
	private void CreateDescriptors() { }

	[Address(RVA = "0x921C20", Offset = "0x920E20", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000189")]
	public virtual void Dispose() { }

	[Address(RVA = "0x925B70", Offset = "0x924D70", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000184")]
	public virtual int get_VertexCount() { }

	[Address(RVA = "0x924BE0", Offset = "0x923DE0", Length = "0x3F4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AccessorBase), Member = "TryGetBounds", ReturnType = typeof(System.Nullable`1<UnityEngine.Bounds>))]
	[Calls(Type = typeof(AccessorBase), Member = "get_IsSparse", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000186")]
	public virtual Nullable<JobHandle> ScheduleVertexJobs(IGltfBuffers buffers, int positionAccessorIndex, int normalAccessorIndex, int tangentAccessorIndex, Int32[] uvAccessorIndices, int colorAccessorIndex, int weightsAccessorIndex, int jointsAccessorIndex) { }

}

