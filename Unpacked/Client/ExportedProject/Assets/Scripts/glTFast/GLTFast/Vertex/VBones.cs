namespace GLTFast.Vertex;

[Token(Token = "0x200006E")]
internal struct VBones
{
	[CompilerGenerated]
	[Token(Token = "0x200006F")]
	[UnsafeValueType]
	internal struct <joints>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F6")]
		public uint FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000070")]
	[UnsafeValueType]
	internal struct <weights>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F7")]
		public float FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(float), 4)]
	[Token(Token = "0x40001F4")]
	public <weights>e__FixedBuffer weights; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[FixedBuffer(typeof(uint), 4)]
	[Token(Token = "0x40001F5")]
	public <joints>e__FixedBuffer joints; //Field offset: 0x10

}

