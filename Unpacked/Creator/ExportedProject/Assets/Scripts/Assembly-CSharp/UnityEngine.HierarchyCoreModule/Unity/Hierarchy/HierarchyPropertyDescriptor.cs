namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchyPropertyDescriptor.h")]
[Token(Token = "0x2000021")]
public struct HierarchyPropertyDescriptor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000052")]
	private int m_Size; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000053")]
	private HierarchyPropertyStorageType m_Type; //Field offset: 0x4

	[Token(Token = "0x1700001D")]
	public int Size
	{
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C2")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700001E")]
	public HierarchyPropertyStorageType Type
	{
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C3")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C2")]
	public void set_Size(int value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C3")]
	public void set_Type(HierarchyPropertyStorageType value) { }

}

