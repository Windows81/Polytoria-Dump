namespace GLTFast;

[Token(Token = "0x200003C")]
internal interface IGltfBuffers
{

	[Token(Token = "0x6000107")]
	public void GetAccessor(int index, out AccessorBase accessor, out Void* data, out int byteStride) { }

	[Token(Token = "0x6000108")]
	public void GetAccessorSparseIndices(AccessorSparseIndices sparseIndices, out Void* data) { }

	[Token(Token = "0x6000109")]
	public void GetAccessorSparseValues(AccessorSparseValues sparseValues, out Void* data) { }

}

