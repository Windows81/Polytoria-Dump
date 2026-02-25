namespace Battlehub.UIControls.MenuControl;

[Token(Token = "0x2000058")]
public class MenuItemInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000185")]
	public string Path; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000186")]
	public string Text; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000187")]
	public Sprite Icon; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000188")]
	public string Command; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000189")]
	public MenuItemEvent Action; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400018A")]
	public MenuItemValidationEvent Validate; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400018B")]
	public bool IsVisible; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x400018C")]
	public bool IsOn; //Field offset: 0x41

	[Address(RVA = "0x5E9CD0", Offset = "0x5E8ED0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003BA")]
	public MenuItemInfo() { }

}

