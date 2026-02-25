namespace UnityEngine.UIElements;

[Token(Token = "0x2000176")]
internal struct CountingBloomFilter
{
	[CompilerGenerated]
	[Token(Token = "0x2000177")]
	[UnsafeValueType]
	internal struct <m_Counters>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000745")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 16384)]
	[Token(Token = "0x4000744")]
	private <m_Counters>e__FixedBuffer m_Counters; //Field offset: 0x0

	[Address(RVA = "0x1C30F40", Offset = "0x1C30140", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B3F")]
	private void AdjustSlot(uint index, bool increment) { }

	[Address(RVA = "0x1C30F70", Offset = "0x1C30170", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B45")]
	public bool ContainsHash(uint hash) { }

	[Address(RVA = "0x1C30FA0", Offset = "0x1C301A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B40")]
	private uint Hash1(uint hash) { }

	[Address(RVA = "0x1C30FB0", Offset = "0x1C301B0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B41")]
	private uint Hash2(uint hash) { }

	[Address(RVA = "0x1C30FC0", Offset = "0x1C301C0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B43")]
	public void InsertHash(uint hash) { }

	[Address(RVA = "0x1C30FF0", Offset = "0x1C301F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B42")]
	private bool IsSlotEmpty(uint index) { }

	[Address(RVA = "0x1C31000", Offset = "0x1C30200", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B44")]
	public void RemoveHash(uint hash) { }

}

