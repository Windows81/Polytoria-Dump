namespace GLTFast;

[Token(Token = "0x200005C")]
internal abstract class VertexBufferColorsBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B0")]
	protected ICodeLogger m_Logger; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017D")]
	protected VertexBufferColorsBase(ICodeLogger logger) { }

	[Token(Token = "0x600017A")]
	public abstract void AddDescriptors(VertexAttributeDescriptor[] dst, int offset, int stream) { }

	[Token(Token = "0x600017B")]
	public abstract void ApplyOnMesh(Mesh msh, int stream, MeshUpdateFlags flags = 15) { }

	[Token(Token = "0x600017C")]
	public abstract void Dispose() { }

	[Token(Token = "0x6000179")]
	public abstract bool ScheduleVertexColorJob(IGltfBuffers buffers, int colorAccessorIndex, NativeSlice<JobHandle> handles) { }

}

