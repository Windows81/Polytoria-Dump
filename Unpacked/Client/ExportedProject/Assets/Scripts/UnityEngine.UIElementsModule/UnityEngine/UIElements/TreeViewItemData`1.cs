namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000166")]
public struct TreeViewItemData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000710")]
	private readonly int <id>k__BackingField; //Field offset: 0x0
	[CreateProperty]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000711")]
	private readonly T m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000712")]
	private readonly IList<TreeViewItemData`1<T>> m_Children; //Field offset: 0x0

	[Token(Token = "0x170001E0")]
	public IEnumerable<TreeViewItemData`1<T>> children
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001DF")]
	public T data
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001DE")]
	public int id
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE5")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE7")]
	public IEnumerable<TreeViewItemData`1<T>> get_children() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE6")]
	public T get_data() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE5")]
	public int get_id() { }

}

