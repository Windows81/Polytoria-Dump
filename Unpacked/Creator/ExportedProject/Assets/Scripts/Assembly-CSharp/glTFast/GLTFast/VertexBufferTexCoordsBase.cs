namespace GLTFast;

[Token(Token = "0x2000061")]
internal abstract class VertexBufferTexCoordsBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C7")]
	protected ICodeLogger m_Logger; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C8")]
	private int <UVSetCount>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700002E")]
	public int UVSetCount
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000195")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000196")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000194")]
	protected VertexBufferTexCoordsBase(ICodeLogger logger) { }

	[Token(Token = "0x6000198")]
	public abstract void AddDescriptors(VertexAttributeDescriptor[] dst, ref int offset, int stream) { }

	[Token(Token = "0x6000199")]
	public abstract void ApplyOnMesh(Mesh msh, int stream, MeshUpdateFlags flags = 15) { }

	[Token(Token = "0x600019A")]
	public abstract void Dispose() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000195")]
	public int get_UVSetCount() { }

	[Token(Token = "0x6000197")]
	public abstract bool ScheduleVertexUVJobs(IGltfBuffers buffers, Int32[] uvAccessorIndices, int vertexCount, NativeSlice<JobHandle> handles) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000196")]
	protected void set_UVSetCount(int value) { }

}

