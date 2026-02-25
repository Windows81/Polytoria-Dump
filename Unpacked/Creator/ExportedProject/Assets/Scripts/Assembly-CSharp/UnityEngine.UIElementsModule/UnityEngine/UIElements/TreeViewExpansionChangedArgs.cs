namespace UnityEngine.UIElements;

[Token(Token = "0x2000080")]
public class TreeViewExpansionChangedArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002C6")]
	private int <id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002C7")]
	private bool <isExpanded>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x40002C8")]
	private bool <isAppliedToAllChildren>k__BackingField; //Field offset: 0x15

	[Token(Token = "0x170000B7")]
	public int id
	{
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B9")]
	public bool isAppliedToAllChildren
	{
		[Address(RVA = "0x59B010", Offset = "0x59A210", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B8")]
	public bool isExpanded
	{
		[Address(RVA = "0x59B020", Offset = "0x59A220", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CB")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CD")]
	public TreeViewExpansionChangedArgs() { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CA")]
	public void set_id(int value) { }

	[Address(RVA = "0x59B010", Offset = "0x59A210", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CC")]
	public void set_isAppliedToAllChildren(bool value) { }

	[Address(RVA = "0x59B020", Offset = "0x59A220", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CB")]
	public void set_isExpanded(bool value) { }

}

