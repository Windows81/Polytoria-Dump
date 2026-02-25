namespace RLD;

[Token(Token = "0x2000156")]
public class EditorToolbar
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000629")]
	private Color _activeTabColor; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400062A")]
	private int _numTabsPerRow; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400062B")]
	private EditorToolbarTab[] _tabs; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400062C")]
	private int _activeTabIndex; //Field offset: 0x30

	[Token(Token = "0x17000545")]
	public EditorToolbarTab ActiveTab
	{
		[Address(RVA = "0x53F5B0", Offset = "0x53E7B0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000F89")]
		 get { } //Length: 43
	}

	[Token(Token = "0x17000546")]
	public Color ActiveTabColor
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F8A")]
		 get { } //Length: 11
		[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F8B")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000544")]
	public int ActiveTabIndex
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F88")]
		 get { } //Length: 174
	}

	[Token(Token = "0x17000548")]
	public int NumTabs
	{
		[Address(RVA = "0x525B50", Offset = "0x524D50", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F8E")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000547")]
	public int NumTabsPerRow
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F8C")]
		 get { } //Length: 4
		[Address(RVA = "0x53F5E0", Offset = "0x53E7E0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000F8D")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x53F540", Offset = "0x53E740", Length = "0x69")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F8F")]
	public EditorToolbar(EditorToolbarTab[] tabs, int numTabsPerRow, Color activeTabColor) { }

	[Address(RVA = "0x53F5B0", Offset = "0x53E7B0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000F89")]
	public EditorToolbarTab get_ActiveTab() { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8A")]
	public Color get_ActiveTabColor() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F88")]
	public int get_ActiveTabIndex() { }

	[Address(RVA = "0x525B50", Offset = "0x524D50", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8E")]
	public int get_NumTabs() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8C")]
	public int get_NumTabsPerRow() { }

	[Address(RVA = "0x53F510", Offset = "0x53E710", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F90")]
	public EditorToolbarTab GetTabByIndex(int tabIndex) { }

	[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8B")]
	public void set_ActiveTabColor(Color value) { }

	[Address(RVA = "0x53F5E0", Offset = "0x53E7E0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000F8D")]
	public void set_NumTabsPerRow(int value) { }

}

