namespace Battlehub.UIControls.MenuControl;

[Token(Token = "0x2000055")]
public class MenuItemValidationArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000181")]
	private bool <IsValid>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000182")]
	private bool <HasChildren>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000183")]
	private bool <IsVisible>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000184")]
	private string <Command>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000C1")]
	public private string Command
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003B5")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003B6")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BF")]
	public bool HasChildren
	{
		[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003B1")]
		 get { } //Length: 5
		[Address(RVA = "0x3CE380", Offset = "0x3CD580", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003B2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000BE")]
	public bool IsValid
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003AF")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003B0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000C0")]
	public bool IsVisible
	{
		[Address(RVA = "0x5E9D30", Offset = "0x5E8F30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003B3")]
		 get { } //Length: 5
		[Address(RVA = "0x5E9D40", Offset = "0x5E8F40", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60003B4")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5E9CE0", Offset = "0x5E8EE0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003B7")]
	public MenuItemValidationArgs(string command, bool hasChildren) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B5")]
	public string get_Command() { }

	[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B1")]
	public bool get_HasChildren() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003AF")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5E9D30", Offset = "0x5E8F30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B3")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B6")]
	private void set_Command(string value) { }

	[Address(RVA = "0x3CE380", Offset = "0x3CD580", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B2")]
	public void set_HasChildren(bool value) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B0")]
	public void set_IsValid(bool value) { }

	[Address(RVA = "0x5E9D40", Offset = "0x5E8F40", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60003B4")]
	public void set_IsVisible(bool value) { }

}

