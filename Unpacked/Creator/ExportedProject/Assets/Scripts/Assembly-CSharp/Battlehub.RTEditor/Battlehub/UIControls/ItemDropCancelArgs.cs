namespace Battlehub.UIControls;

[Token(Token = "0x2000026")]
public class ItemDropCancelArgs : ItemDropArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000063")]
	private bool <Cancel>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x1700004D")]
	public bool Cancel
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000105")]
		 get { } //Length: 5
		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000106")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5C70B0", Offset = "0x5C62B0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ItemDropArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(ItemDropAction), typeof(bool), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000107")]
	public ItemDropCancelArgs(Object[] dragItems, object dropTarget, ItemDropAction action, bool isExternal, PointerEventData pointerEventData) { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000105")]
	public bool get_Cancel() { }

	[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000106")]
	public void set_Cancel(bool value) { }

}

