namespace Battlehub.UIControls;

[Token(Token = "0x2000043")]
public class VirtualizingItemsControlInputProvider : InputProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000140")]
	public KeyCode MultiselectKey; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000141")]
	public KeyCode RangeselectKey; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000142")]
	public KeyCode SelectAllKey; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000143")]
	public KeyCode DeleteKey; //Field offset: 0x2C

	[Token(Token = "0x17000092")]
	public virtual bool IsDeleteButtonDown
	{
		[Address(RVA = "0x5EE550", Offset = "0x5ED750", Length = "0xA")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002EC")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000091")]
	public virtual bool IsFunctional2ButtonPressed
	{
		[Address(RVA = "0x5EE560", Offset = "0x5ED760", Length = "0xA")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002EB")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000090")]
	public virtual bool IsFunctionalButtonPressed
	{
		[Address(RVA = "0x5EE570", Offset = "0x5ED770", Length = "0xA")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002EA")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000093")]
	public virtual bool IsSelectAllButtonDown
	{
		[Address(RVA = "0x5EE580", Offset = "0x5ED780", Length = "0xA")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002ED")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x5EE520", Offset = "0x5ED720", Length = "0x23")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002EE")]
	public VirtualizingItemsControlInputProvider() { }

	[Address(RVA = "0x5EE550", Offset = "0x5ED750", Length = "0xA")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002EC")]
	public virtual bool get_IsDeleteButtonDown() { }

	[Address(RVA = "0x5EE560", Offset = "0x5ED760", Length = "0xA")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002EB")]
	public virtual bool get_IsFunctional2ButtonPressed() { }

	[Address(RVA = "0x5EE570", Offset = "0x5ED770", Length = "0xA")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002EA")]
	public virtual bool get_IsFunctionalButtonPressed() { }

	[Address(RVA = "0x5EE580", Offset = "0x5ED780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002ED")]
	public virtual bool get_IsSelectAllButtonDown() { }

}

