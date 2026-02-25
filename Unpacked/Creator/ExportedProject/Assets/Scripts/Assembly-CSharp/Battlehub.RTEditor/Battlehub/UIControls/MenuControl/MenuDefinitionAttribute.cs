namespace Battlehub.UIControls.MenuControl;

[Token(Token = "0x200005A")]
public class MenuDefinitionAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400019B")]
	private int <Order>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000CA")]
	public private int Order
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D7")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D8")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D9")]
	public MenuDefinitionAttribute(int order = 0) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D7")]
	public int get_Order() { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D8")]
	private void set_Order(int value) { }

}

