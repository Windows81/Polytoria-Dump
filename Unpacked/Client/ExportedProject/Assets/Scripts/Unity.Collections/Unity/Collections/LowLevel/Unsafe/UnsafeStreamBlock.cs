namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200004F")]
internal struct UnsafeStreamBlock
{
	[CompilerGenerated]
	[Token(Token = "0x2000050")]
	[UnsafeValueType]
	internal struct <Data>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B5")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B3")]
	internal UnsafeStreamBlock* Next; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FixedBuffer(typeof(byte), 1)]
	[Token(Token = "0x40000B4")]
	internal <Data>e__FixedBuffer Data; //Field offset: 0x8

}

