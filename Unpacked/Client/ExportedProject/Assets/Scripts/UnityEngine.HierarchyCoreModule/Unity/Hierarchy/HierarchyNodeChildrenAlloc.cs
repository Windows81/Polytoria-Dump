namespace Unity.Hierarchy;

[Token(Token = "0x2000008")]
internal struct HierarchyNodeChildrenAlloc
{
	[CompilerGenerated]
	[Token(Token = "0x2000009")]
	[UnsafeValueType]
	internal struct <Reserved>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000016")]
		public int FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000011")]
	public HierarchyNode* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000012")]
	public int Size; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000013")]
	public int Capacity; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000014")]
	public int RemovedCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[FixedBuffer(typeof(int), 3)]
	[Token(Token = "0x4000015")]
	public <Reserved>e__FixedBuffer Reserved; //Field offset: 0x14

}

