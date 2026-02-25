namespace Battlehub.UIControls;

[Token(Token = "0x200004B")]
public class VirtualizingTreeViewItemDataBindingArgs : ItemDataBindingArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400015B")]
	private bool <HasChildren>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170000A6")]
	public bool HasChildren
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600032F")]
		 get { } //Length: 5
		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000330")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5F25F0", Offset = "0x5F17F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000331")]
	public VirtualizingTreeViewItemDataBindingArgs() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600032F")]
	public bool get_HasChildren() { }

	[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000330")]
	public void set_HasChildren(bool value) { }

}

