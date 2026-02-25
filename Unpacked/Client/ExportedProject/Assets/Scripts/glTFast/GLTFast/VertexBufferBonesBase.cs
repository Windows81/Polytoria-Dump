namespace GLTFast;

[Token(Token = "0x200005A")]
internal abstract class VertexBufferBonesBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001AE")]
	protected ICodeLogger m_Logger; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016D")]
	protected VertexBufferBonesBase(ICodeLogger logger) { }

	[Token(Token = "0x600016F")]
	public abstract void AddDescriptors(VertexAttributeDescriptor[] dst, int offset, int stream) { }

	[Token(Token = "0x6000170")]
	public abstract void ApplyOnMesh(Mesh msh, int stream, MeshUpdateFlags flags = 15) { }

	[Token(Token = "0x6000171")]
	public abstract void Dispose() { }

	[Token(Token = "0x600016E")]
	public abstract Nullable<JobHandle> ScheduleVertexBonesJob(IGltfBuffers buffers, int weightsAccessorIndex, int jointsAccessorIndex) { }

}

