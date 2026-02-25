namespace SimpleFileBrowser;

[CreateAssetMenu(fileName = "UI Skin", menuName = "yasirkula/SimpleFileBrowser/UI Skin", order = 111)]
[Token(Token = "0x2000024")]
public class UISkin : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E4")]
	private int m_version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Header("General")]
	[SerializeField]
	[Token(Token = "0x40000E5")]
	private Font m_font; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000E6")]
	private int m_fontSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Header("File Browser Window")]
	[SerializeField]
	[Token(Token = "0x40000E7")]
	private Color m_windowColor; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40000E8")]
	private Color m_filesListColor; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40000E9")]
	private Color m_filesVerticalSeparatorColor; //Field offset: 0x4C
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x40000EA")]
	private Color m_titleBackgroundColor; //Field offset: 0x5C
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x40000EB")]
	private Color m_titleTextColor; //Field offset: 0x6C
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x40000EC")]
	private Color m_windowResizeGizmoColor; //Field offset: 0x7C
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	[Token(Token = "0x40000ED")]
	private Color m_headerButtonsColor; //Field offset: 0x8C
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40000EE")]
	private Sprite m_windowResizeGizmo; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x40000EF")]
	private Sprite m_headerBackButton; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x40000F0")]
	private Sprite m_headerForwardButton; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x40000F1")]
	private Sprite m_headerUpButton; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x40000F2")]
	private Sprite m_headerContextMenuButton; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Header("Input Fields")]
	[SerializeField]
	[Token(Token = "0x40000F3")]
	private Color m_inputFieldNormalBackgroundColor; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x40000F4")]
	private Color m_inputFieldInvalidBackgroundColor; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x40000F5")]
	private Color m_inputFieldTextColor; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x40000F6")]
	private Color m_inputFieldPlaceholderTextColor; //Field offset: 0xF8
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x40000F7")]
	private Color m_inputFieldSelectedTextColor; //Field offset: 0x108
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x40000F8")]
	private Color m_inputFieldCaretColor; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x40000F9")]
	private Sprite m_inputFieldBackground; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Header("Buttons")]
	[SerializeField]
	[Token(Token = "0x40000FA")]
	private Color m_buttonColor; //Field offset: 0x130
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x40000FB")]
	private Color m_buttonTextColor; //Field offset: 0x140
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x40000FC")]
	private Sprite m_buttonBackground; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Header("Dropdowns")]
	[SerializeField]
	[Token(Token = "0x40000FD")]
	private Color m_dropdownColor; //Field offset: 0x158
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x40000FE")]
	private Color m_dropdownTextColor; //Field offset: 0x168
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x40000FF")]
	private Color m_dropdownArrowColor; //Field offset: 0x178
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x4000100")]
	private Color m_dropdownCheckmarkColor; //Field offset: 0x188
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	[Token(Token = "0x4000101")]
	private Sprite m_dropdownBackground; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	[Token(Token = "0x4000102")]
	private Sprite m_dropdownArrow; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	[Token(Token = "0x4000103")]
	private Sprite m_dropdownCheckmark; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Header("Toggles")]
	[SerializeField]
	[Token(Token = "0x4000104")]
	private Color m_toggleColor; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x4000105")]
	private Color m_toggleTextColor; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x4000106")]
	private Color m_toggleCheckmarkColor; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x4000107")]
	private Sprite m_toggleBackground; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	[Token(Token = "0x4000108")]
	private Sprite m_toggleCheckmark; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Header("Scrollbars")]
	[SerializeField]
	[Token(Token = "0x4000109")]
	private Color m_scrollbarBackgroundColor; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x200")]
	[SerializeField]
	[Token(Token = "0x400010A")]
	private Color m_scrollbarColor; //Field offset: 0x200
	[FieldOffset(Offset = "0x210")]
	[Header("Files")]
	[SerializeField]
	[Token(Token = "0x400010B")]
	private float m_fileHeight; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[SerializeField]
	[Token(Token = "0x400010C")]
	private float m_fileIconsPadding; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[SerializeField]
	[Token(Token = "0x400010D")]
	private Color m_fileNormalBackgroundColor; //Field offset: 0x218
	[FieldOffset(Offset = "0x228")]
	[SerializeField]
	[Token(Token = "0x400010E")]
	private Color m_fileAlternatingBackgroundColor; //Field offset: 0x228
	[FieldOffset(Offset = "0x238")]
	[SerializeField]
	[Token(Token = "0x400010F")]
	private Color m_fileHoveredBackgroundColor; //Field offset: 0x238
	[FieldOffset(Offset = "0x248")]
	[SerializeField]
	[Token(Token = "0x4000110")]
	private Color m_fileSelectedBackgroundColor; //Field offset: 0x248
	[FieldOffset(Offset = "0x258")]
	[SerializeField]
	[Token(Token = "0x4000111")]
	private Color m_fileNormalTextColor; //Field offset: 0x258
	[FieldOffset(Offset = "0x268")]
	[SerializeField]
	[Token(Token = "0x4000112")]
	private Color m_fileSelectedTextColor; //Field offset: 0x268
	[FieldOffset(Offset = "0x278")]
	[Header("File Icons")]
	[SerializeField]
	[Token(Token = "0x4000113")]
	private Sprite m_folderIcon; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	[Token(Token = "0x4000114")]
	private Sprite m_driveIcon; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x4000115")]
	private Sprite m_defaultFileIcon; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	[Token(Token = "0x4000116")]
	private FiletypeIcon[] m_filetypeIcons; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000117")]
	private bool initializedFiletypeIcons; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000118")]
	private Dictionary<String, Sprite> filetypeToIcon; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000119")]
	private bool m_allIconExtensionsHaveSingleSuffix; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	[Token(Token = "0x400011A")]
	private Sprite m_fileMultiSelectionToggleOffIcon; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	[Token(Token = "0x400011B")]
	private Sprite m_fileMultiSelectionToggleOnIcon; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[Header("Context Menu")]
	[SerializeField]
	[Token(Token = "0x400011C")]
	private Color m_contextMenuBackgroundColor; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	[Token(Token = "0x400011D")]
	private Color m_contextMenuTextColor; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	[Token(Token = "0x400011E")]
	private Color m_contextMenuSeparatorColor; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2F0")]
	[Header("Delete Confirmation Panel")]
	[SerializeField]
	[Token(Token = "0x400011F")]
	private Color m_deletePanelBackgroundColor; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x300")]
	[SerializeField]
	[Token(Token = "0x4000120")]
	private Color m_deletePanelTextColor; //Field offset: 0x300
	[FieldOffset(Offset = "0x310")]
	[SerializeField]
	[Token(Token = "0x4000121")]
	private Sprite m_deletePanelBackground; //Field offset: 0x310

	[Token(Token = "0x17000061")]
	public bool AllIconExtensionsHaveSingleSuffix
	{
		[Address(RVA = "0x1551BC0", Offset = "0x1550DC0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
		[Token(Token = "0x6000191")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000046")]
	public Sprite ButtonBackground
	{
		[Address(RVA = "0x3D66C0", Offset = "0x3D58C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015B")]
		 get { } //Length: 8
		[Address(RVA = "0x1551DC0", Offset = "0x1550FC0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600015C")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000044")]
	public Color ButtonColor
	{
		[Address(RVA = "0x424B60", Offset = "0x423D60", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000157")]
		 get { } //Length: 14
		[Address(RVA = "0x1551E50", Offset = "0x1551050", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000158")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000045")]
	public Color ButtonTextColor
	{
		[Address(RVA = "0x1551C00", Offset = "0x1550E00", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000159")]
		 get { } //Length: 14
		[Address(RVA = "0x1551ED0", Offset = "0x15510D0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600015A")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000064")]
	public Color ContextMenuBackgroundColor
	{
		[Address(RVA = "0x1551C10", Offset = "0x1550E10", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000196")]
		 get { } //Length: 14
		[Address(RVA = "0x1551F50", Offset = "0x1551150", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000197")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000066")]
	public Color ContextMenuSeparatorColor
	{
		[Address(RVA = "0x1551C20", Offset = "0x1550E20", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600019A")]
		 get { } //Length: 14
		[Address(RVA = "0x1551FD0", Offset = "0x15511D0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600019B")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000065")]
	public Color ContextMenuTextColor
	{
		[Address(RVA = "0x1551C30", Offset = "0x1550E30", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000198")]
		 get { } //Length: 14
		[Address(RVA = "0x1552050", Offset = "0x1551250", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000199")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700005F")]
	public Sprite DefaultFileIcon
	{
		[Address(RVA = "0x154CB50", Offset = "0x154BD50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600018D")]
		 get { } //Length: 8
		[Address(RVA = "0x15520D0", Offset = "0x15512D0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600018E")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000069")]
	public Sprite DeletePanelBackground
	{
		[Address(RVA = "0x1551C50", Offset = "0x1550E50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 8
		[Address(RVA = "0x15521E0", Offset = "0x15513E0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001A1")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000067")]
	public Color DeletePanelBackgroundColor
	{
		[Address(RVA = "0x1551C40", Offset = "0x1550E40", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600019C")]
		 get { } //Length: 14
		[Address(RVA = "0x1552160", Offset = "0x1551360", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600019D")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000068")]
	public Color DeletePanelTextColor
	{
		[Address(RVA = "0x1551C60", Offset = "0x1550E60", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600019E")]
		 get { } //Length: 14
		[Address(RVA = "0x1552270", Offset = "0x1551470", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600019F")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700005E")]
	public Sprite DriveIcon
	{
		[Address(RVA = "0x1551C70", Offset = "0x1550E70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600018B")]
		 get { } //Length: 8
		[Address(RVA = "0x15522F0", Offset = "0x15514F0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600018C")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700004C")]
	public Sprite DropdownArrow
	{
		[Address(RVA = "0x3D6750", Offset = "0x3D5950", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000167")]
		 get { } //Length: 8
		[Address(RVA = "0x1552400", Offset = "0x1551600", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000168")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000049")]
	public Color DropdownArrowColor
	{
		[Address(RVA = "0x1551C80", Offset = "0x1550E80", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000161")]
		 get { } //Length: 14
		[Address(RVA = "0x1552380", Offset = "0x1551580", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000162")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700004B")]
	public Sprite DropdownBackground
	{
		[Address(RVA = "0x3D6500", Offset = "0x3D5700", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000165")]
		 get { } //Length: 8
		[Address(RVA = "0x1552490", Offset = "0x1551690", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000166")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700004D")]
	public Sprite DropdownCheckmark
	{
		[Address(RVA = "0x3D67E0", Offset = "0x3D59E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000169")]
		 get { } //Length: 8
		[Address(RVA = "0x15525A0", Offset = "0x15517A0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600016A")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700004A")]
	public Color DropdownCheckmarkColor
	{
		[Address(RVA = "0x1551C90", Offset = "0x1550E90", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000163")]
		 get { } //Length: 14
		[Address(RVA = "0x1552520", Offset = "0x1551720", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000164")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000047")]
	public Color DropdownColor
	{
		[Address(RVA = "0x424B90", Offset = "0x423D90", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015D")]
		 get { } //Length: 14
		[Address(RVA = "0x1552630", Offset = "0x1551830", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600015E")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000048")]
	public Color DropdownTextColor
	{
		[Address(RVA = "0x1551CA0", Offset = "0x1550EA0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600015F")]
		 get { } //Length: 14
		[Address(RVA = "0x15526B0", Offset = "0x15518B0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000160")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000058")]
	public Color FileAlternatingBackgroundColor
	{
		[Address(RVA = "0x1551CB0", Offset = "0x1550EB0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600017F")]
		 get { } //Length: 14
		[Address(RVA = "0x1552730", Offset = "0x1551930", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000180")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000055")]
	public float FileHeight
	{
		[Address(RVA = "0x468BA0", Offset = "0x467DA0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000179")]
		 get { } //Length: 9
		[Address(RVA = "0x15527B0", Offset = "0x15519B0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600017A")]
		 set { } //Length: 27
	}

	[Token(Token = "0x17000059")]
	public Color FileHoveredBackgroundColor
	{
		[Address(RVA = "0x49B720", Offset = "0x49A920", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000181")]
		 get { } //Length: 14
		[Address(RVA = "0x15527D0", Offset = "0x15519D0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000182")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000056")]
	public float FileIconsPadding
	{
		[Address(RVA = "0x468B80", Offset = "0x467D80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017B")]
		 get { } //Length: 9
		[Address(RVA = "0x1552850", Offset = "0x1551A50", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600017C")]
		 set { } //Length: 27
	}

	[Token(Token = "0x17000062")]
	public Sprite FileMultiSelectionToggleOffIcon
	{
		[Address(RVA = "0x1551CC0", Offset = "0x1550EC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000192")]
		 get { } //Length: 8
		[Address(RVA = "0x1552870", Offset = "0x1551A70", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000193")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000063")]
	public Sprite FileMultiSelectionToggleOnIcon
	{
		[Address(RVA = "0x1551CD0", Offset = "0x1550ED0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000194")]
		 get { } //Length: 8
		[Address(RVA = "0x1552900", Offset = "0x1551B00", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000195")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000057")]
	public Color FileNormalBackgroundColor
	{
		[Address(RVA = "0x468B90", Offset = "0x467D90", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017D")]
		 get { } //Length: 14
		[Address(RVA = "0x1552990", Offset = "0x1551B90", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600017E")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700005B")]
	public Color FileNormalTextColor
	{
		[Address(RVA = "0x49B710", Offset = "0x49A910", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000185")]
		 get { } //Length: 14
		[Address(RVA = "0x1552A10", Offset = "0x1551C10", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000186")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700005A")]
	public Color FileSelectedBackgroundColor
	{
		[Address(RVA = "0x1551CE0", Offset = "0x1550EE0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000183")]
		 get { } //Length: 14
		[Address(RVA = "0x1552A90", Offset = "0x1551C90", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000184")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700005C")]
	public Color FileSelectedTextColor
	{
		[Address(RVA = "0x1551CF0", Offset = "0x1550EF0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000187")]
		 get { } //Length: 14
		[Address(RVA = "0x1552B10", Offset = "0x1551D10", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000188")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000032")]
	public Color FilesListColor
	{
		[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000133")]
		 get { } //Length: 11
		[Address(RVA = "0x1552B90", Offset = "0x1551D90", Length = "0x79")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000134")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000033")]
	public Color FilesVerticalSeparatorColor
	{
		[Address(RVA = "0x3B91B0", Offset = "0x3B83B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000135")]
		 get { } //Length: 11
		[Address(RVA = "0x1552C10", Offset = "0x1551E10", Length = "0x79")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000136")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000060")]
	public FiletypeIcon[] FiletypeIcons
	{
		[Address(RVA = "0x154CF80", Offset = "0x154C180", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600018F")]
		 get { } //Length: 8
		[Address(RVA = "0x1552C90", Offset = "0x1551E90", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000190")]
		 set { } //Length: 53
	}

	[Token(Token = "0x1700005D")]
	public Sprite FolderIcon
	{
		[Address(RVA = "0x1551D00", Offset = "0x1550F00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000189")]
		 get { } //Length: 8
		[Address(RVA = "0x1552CD0", Offset = "0x1551ED0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600018A")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700002F")]
	public Font Font
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600012D")]
		 get { } //Length: 5
		[Address(RVA = "0x1552D70", Offset = "0x1551F70", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600012E")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000030")]
	public int FontSize
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600012F")]
		 get { } //Length: 4
		[Address(RVA = "0x1552D60", Offset = "0x1551F60", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000130")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000039")]
	public Sprite HeaderBackButton
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000141")]
		 get { } //Length: 8
		[Address(RVA = "0x1552DF0", Offset = "0x1551FF0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000142")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000037")]
	public Color HeaderButtonsColor
	{
		[Address(RVA = "0x1551D10", Offset = "0x1550F10", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600013D")]
		 get { } //Length: 14
		[Address(RVA = "0x1552E80", Offset = "0x1552080", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600013E")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700003C")]
	public Sprite HeaderContextMenuButton
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000147")]
		 get { } //Length: 8
		[Address(RVA = "0x1552F00", Offset = "0x1552100", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000148")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700003A")]
	public Sprite HeaderForwardButton
	{
		[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000143")]
		 get { } //Length: 8
		[Address(RVA = "0x1552F90", Offset = "0x1552190", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000144")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700003B")]
	public Sprite HeaderUpButton
	{
		[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000145")]
		 get { } //Length: 8
		[Address(RVA = "0x1553020", Offset = "0x1552220", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000146")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000043")]
	public Sprite InputFieldBackground
	{
		[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000155")]
		 get { } //Length: 8
		[Address(RVA = "0x15530B0", Offset = "0x15522B0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000156")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000042")]
	public Color InputFieldCaretColor
	{
		[Address(RVA = "0x424BD0", Offset = "0x423DD0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000153")]
		 get { } //Length: 14
		[Address(RVA = "0x1553140", Offset = "0x1552340", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000154")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700003E")]
	public Color InputFieldInvalidBackgroundColor
	{
		[Address(RVA = "0x1551D20", Offset = "0x1550F20", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600014B")]
		 get { } //Length: 14
		[Address(RVA = "0x15531C0", Offset = "0x15523C0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600014C")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700003D")]
	public Color InputFieldNormalBackgroundColor
	{
		[Address(RVA = "0x1551D30", Offset = "0x1550F30", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000149")]
		 get { } //Length: 14
		[Address(RVA = "0x1553240", Offset = "0x1552440", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600014A")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000040")]
	public Color InputFieldPlaceholderTextColor
	{
		[Address(RVA = "0x3D6810", Offset = "0x3D5A10", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014F")]
		 get { } //Length: 14
		[Address(RVA = "0x15532C0", Offset = "0x15524C0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000150")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000041")]
	public Color InputFieldSelectedTextColor
	{
		[Address(RVA = "0x1551D40", Offset = "0x1550F40", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000151")]
		 get { } //Length: 14
		[Address(RVA = "0x1553340", Offset = "0x1552540", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000152")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700003F")]
	public Color InputFieldTextColor
	{
		[Address(RVA = "0x1551D50", Offset = "0x1550F50", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014D")]
		 get { } //Length: 14
		[Address(RVA = "0x15533C0", Offset = "0x15525C0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600014E")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000053")]
	public Color ScrollbarBackgroundColor
	{
		[Address(RVA = "0x1551D60", Offset = "0x1550F60", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000175")]
		 get { } //Length: 14
		[Address(RVA = "0x1553440", Offset = "0x1552640", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000176")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000054")]
	public Color ScrollbarColor
	{
		[Address(RVA = "0x1551D70", Offset = "0x1550F70", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000177")]
		 get { } //Length: 14
		[Address(RVA = "0x15534C0", Offset = "0x15526C0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000178")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000034")]
	public Color TitleBackgroundColor
	{
		[Address(RVA = "0x3EAB20", Offset = "0x3E9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000137")]
		 get { } //Length: 11
		[Address(RVA = "0x1553540", Offset = "0x1552740", Length = "0x79")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000138")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000035")]
	public Color TitleTextColor
	{
		[Address(RVA = "0x3B4340", Offset = "0x3B3540", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000139")]
		 get { } //Length: 11
		[Address(RVA = "0x15535C0", Offset = "0x15527C0", Length = "0x79")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600013A")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000051")]
	public Sprite ToggleBackground
	{
		[Address(RVA = "0x1551D80", Offset = "0x1550F80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000171")]
		 get { } //Length: 8
		[Address(RVA = "0x1553640", Offset = "0x1552840", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000172")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000052")]
	public Sprite ToggleCheckmark
	{
		[Address(RVA = "0x1551DA0", Offset = "0x1550FA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000173")]
		 get { } //Length: 8
		[Address(RVA = "0x1553750", Offset = "0x1552950", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000174")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000050")]
	public Color ToggleCheckmarkColor
	{
		[Address(RVA = "0x1551D90", Offset = "0x1550F90", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600016F")]
		 get { } //Length: 14
		[Address(RVA = "0x15536D0", Offset = "0x15528D0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000170")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700004E")]
	public Color ToggleColor
	{
		[Address(RVA = "0x49DA00", Offset = "0x49CC00", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016B")]
		 get { } //Length: 14
		[Address(RVA = "0x15537E0", Offset = "0x15529E0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600016C")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700004F")]
	public Color ToggleTextColor
	{
		[Address(RVA = "0x1551DB0", Offset = "0x1550FB0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600016D")]
		 get { } //Length: 14
		[Address(RVA = "0x1553860", Offset = "0x1552A60", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600016E")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700002E")]
	public int Version
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600012B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000031")]
	public Color WindowColor
	{
		[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000131")]
		 get { } //Length: 11
		[Address(RVA = "0x15538E0", Offset = "0x1552AE0", Length = "0x79")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000132")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000038")]
	public Sprite WindowResizeGizmo
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013F")]
		 get { } //Length: 8
		[Address(RVA = "0x15539E0", Offset = "0x1552BE0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000140")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000036")]
	public Color WindowResizeGizmoColor
	{
		[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013B")]
		 get { } //Length: 11
		[Address(RVA = "0x1553960", Offset = "0x1552B60", Length = "0x79")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600013C")]
		 set { } //Length: 121
	}

	[Address(RVA = "0x1551A00", Offset = "0x1550C00", Length = "0x1BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60001AA")]
	public UISkin() { }

	[Address(RVA = "0x1550D60", Offset = "0x154FF60", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001A7")]
	public void ApplyTo(Scrollbar scrollbar) { }

	[Address(RVA = "0x1550BF0", Offset = "0x154FDF0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A2")]
	public void ApplyTo(Text text, Color textColor) { }

	[Address(RVA = "0x1550E20", Offset = "0x1550020", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60001A6")]
	public void ApplyTo(Toggle toggle) { }

	[Address(RVA = "0x1550FC0", Offset = "0x15501C0", Length = "0x233")]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_selectionColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_caretColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60001A3")]
	public void ApplyTo(InputField inputField) { }

	[Address(RVA = "0x1551200", Offset = "0x1550400", Length = "0x343")]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x60001A5")]
	public void ApplyTo(Dropdown dropdown) { }

	[Address(RVA = "0x1550C60", Offset = "0x154FE60", Length = "0xFC")]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserDeleteConfirmationPanel), Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001A4")]
	public void ApplyTo(Button button) { }

	[Address(RVA = "0x1551BC0", Offset = "0x1550DC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Token(Token = "0x6000191")]
	public bool get_AllIconExtensionsHaveSingleSuffix() { }

	[Address(RVA = "0x3D66C0", Offset = "0x3D58C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015B")]
	public Sprite get_ButtonBackground() { }

	[Address(RVA = "0x424B60", Offset = "0x423D60", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000157")]
	public Color get_ButtonColor() { }

	[Address(RVA = "0x1551C00", Offset = "0x1550E00", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000159")]
	public Color get_ButtonTextColor() { }

	[Address(RVA = "0x1551C10", Offset = "0x1550E10", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000196")]
	public Color get_ContextMenuBackgroundColor() { }

	[Address(RVA = "0x1551C20", Offset = "0x1550E20", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600019A")]
	public Color get_ContextMenuSeparatorColor() { }

	[Address(RVA = "0x1551C30", Offset = "0x1550E30", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000198")]
	public Color get_ContextMenuTextColor() { }

	[Address(RVA = "0x154CB50", Offset = "0x154BD50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018D")]
	public Sprite get_DefaultFileIcon() { }

	[Address(RVA = "0x1551C50", Offset = "0x1550E50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A0")]
	public Sprite get_DeletePanelBackground() { }

	[Address(RVA = "0x1551C40", Offset = "0x1550E40", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019C")]
	public Color get_DeletePanelBackgroundColor() { }

	[Address(RVA = "0x1551C60", Offset = "0x1550E60", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019E")]
	public Color get_DeletePanelTextColor() { }

	[Address(RVA = "0x1551C70", Offset = "0x1550E70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600018B")]
	public Sprite get_DriveIcon() { }

	[Address(RVA = "0x3D6750", Offset = "0x3D5950", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000167")]
	public Sprite get_DropdownArrow() { }

	[Address(RVA = "0x1551C80", Offset = "0x1550E80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000161")]
	public Color get_DropdownArrowColor() { }

	[Address(RVA = "0x3D6500", Offset = "0x3D5700", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000165")]
	public Sprite get_DropdownBackground() { }

	[Address(RVA = "0x3D67E0", Offset = "0x3D59E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000169")]
	public Sprite get_DropdownCheckmark() { }

	[Address(RVA = "0x1551C90", Offset = "0x1550E90", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000163")]
	public Color get_DropdownCheckmarkColor() { }

	[Address(RVA = "0x424B90", Offset = "0x423D90", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015D")]
	public Color get_DropdownColor() { }

	[Address(RVA = "0x1551CA0", Offset = "0x1550EA0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600015F")]
	public Color get_DropdownTextColor() { }

	[Address(RVA = "0x1551CB0", Offset = "0x1550EB0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600017F")]
	public Color get_FileAlternatingBackgroundColor() { }

	[Address(RVA = "0x468BA0", Offset = "0x467DA0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000179")]
	public float get_FileHeight() { }

	[Address(RVA = "0x49B720", Offset = "0x49A920", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000181")]
	public Color get_FileHoveredBackgroundColor() { }

	[Address(RVA = "0x468B80", Offset = "0x467D80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017B")]
	public float get_FileIconsPadding() { }

	[Address(RVA = "0x1551CC0", Offset = "0x1550EC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000192")]
	public Sprite get_FileMultiSelectionToggleOffIcon() { }

	[Address(RVA = "0x1551CD0", Offset = "0x1550ED0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000194")]
	public Sprite get_FileMultiSelectionToggleOnIcon() { }

	[Address(RVA = "0x468B90", Offset = "0x467D90", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017D")]
	public Color get_FileNormalBackgroundColor() { }

	[Address(RVA = "0x49B710", Offset = "0x49A910", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000185")]
	public Color get_FileNormalTextColor() { }

	[Address(RVA = "0x1551CE0", Offset = "0x1550EE0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000183")]
	public Color get_FileSelectedBackgroundColor() { }

	[Address(RVA = "0x1551CF0", Offset = "0x1550EF0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000187")]
	public Color get_FileSelectedTextColor() { }

	[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000133")]
	public Color get_FilesListColor() { }

	[Address(RVA = "0x3B91B0", Offset = "0x3B83B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000135")]
	public Color get_FilesVerticalSeparatorColor() { }

	[Address(RVA = "0x154CF80", Offset = "0x154C180", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018F")]
	public FiletypeIcon[] get_FiletypeIcons() { }

	[Address(RVA = "0x1551D00", Offset = "0x1550F00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000189")]
	public Sprite get_FolderIcon() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012D")]
	public Font get_Font() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012F")]
	public int get_FontSize() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000141")]
	public Sprite get_HeaderBackButton() { }

	[Address(RVA = "0x1551D10", Offset = "0x1550F10", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600013D")]
	public Color get_HeaderButtonsColor() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000147")]
	public Sprite get_HeaderContextMenuButton() { }

	[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000143")]
	public Sprite get_HeaderForwardButton() { }

	[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000145")]
	public Sprite get_HeaderUpButton() { }

	[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000155")]
	public Sprite get_InputFieldBackground() { }

	[Address(RVA = "0x424BD0", Offset = "0x423DD0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000153")]
	public Color get_InputFieldCaretColor() { }

	[Address(RVA = "0x1551D20", Offset = "0x1550F20", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600014B")]
	public Color get_InputFieldInvalidBackgroundColor() { }

	[Address(RVA = "0x1551D30", Offset = "0x1550F30", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000149")]
	public Color get_InputFieldNormalBackgroundColor() { }

	[Address(RVA = "0x3D6810", Offset = "0x3D5A10", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014F")]
	public Color get_InputFieldPlaceholderTextColor() { }

	[Address(RVA = "0x1551D40", Offset = "0x1550F40", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000151")]
	public Color get_InputFieldSelectedTextColor() { }

	[Address(RVA = "0x1551D50", Offset = "0x1550F50", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014D")]
	public Color get_InputFieldTextColor() { }

	[Address(RVA = "0x1551D60", Offset = "0x1550F60", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000175")]
	public Color get_ScrollbarBackgroundColor() { }

	[Address(RVA = "0x1551D70", Offset = "0x1550F70", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000177")]
	public Color get_ScrollbarColor() { }

	[Address(RVA = "0x3EAB20", Offset = "0x3E9D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000137")]
	public Color get_TitleBackgroundColor() { }

	[Address(RVA = "0x3B4340", Offset = "0x3B3540", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000139")]
	public Color get_TitleTextColor() { }

	[Address(RVA = "0x1551D80", Offset = "0x1550F80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000171")]
	public Sprite get_ToggleBackground() { }

	[Address(RVA = "0x1551DA0", Offset = "0x1550FA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000173")]
	public Sprite get_ToggleCheckmark() { }

	[Address(RVA = "0x1551D90", Offset = "0x1550F90", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600016F")]
	public Color get_ToggleCheckmarkColor() { }

	[Address(RVA = "0x49DA00", Offset = "0x49CC00", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016B")]
	public Color get_ToggleColor() { }

	[Address(RVA = "0x1551DB0", Offset = "0x1550FB0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600016D")]
	public Color get_ToggleTextColor() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012B")]
	public int get_Version() { }

	[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000131")]
	public Color get_WindowColor() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013F")]
	public Sprite get_WindowResizeGizmo() { }

	[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013B")]
	public Color get_WindowResizeGizmoColor() { }

	[Address(RVA = "0x1551550", Offset = "0x1550750", Length = "0x1EB")]
	[CalledBy(Type = typeof(FileBrowser), Member = "SimpleFileBrowser.IListViewAdapter.SetItemContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(FileBrowserDeleteConfirmationPanel), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowser), typeof(System.Collections.Generic.List`1<SimpleFileBrowser.FileSystemEntry>), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(OnDeletionConfirmed)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A8")]
	public Sprite GetIconForFileEntry(FileSystemEntry fileInfo, bool extensionMayHaveMultipleSuffixes) { }

	[Address(RVA = "0x1551740", Offset = "0x1550940", Length = "0x281")]
	[CalledBy(Type = typeof(FileBrowser), Member = "get_AllExtensionsHaveSingleSuffix", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SimpleFileBrowser.IListViewAdapter.SetItemContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(FileBrowserDeleteConfirmationPanel), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowser), typeof(System.Collections.Generic.List`1<SimpleFileBrowser.FileSystemEntry>), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(OnDeletionConfirmed)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UISkin), Member = "get_AllIconExtensionsHaveSingleSuffix", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UISkin), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry), typeof(bool)}, ReturnType = typeof(Sprite))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A9")]
	private void InitializeFiletypeIcons() { }

	[Address(RVA = "0x15519D0", Offset = "0x1550BD0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContextMenu("Refresh UI")]
	[Token(Token = "0x600012C")]
	private void Invalidate() { }

	[Address(RVA = "0x1551DC0", Offset = "0x1550FC0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600015C")]
	public void set_ButtonBackground(Sprite value) { }

	[Address(RVA = "0x1551E50", Offset = "0x1551050", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000158")]
	public void set_ButtonColor(Color value) { }

	[Address(RVA = "0x1551ED0", Offset = "0x15510D0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600015A")]
	public void set_ButtonTextColor(Color value) { }

	[Address(RVA = "0x1551F50", Offset = "0x1551150", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000197")]
	public void set_ContextMenuBackgroundColor(Color value) { }

	[Address(RVA = "0x1551FD0", Offset = "0x15511D0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600019B")]
	public void set_ContextMenuSeparatorColor(Color value) { }

	[Address(RVA = "0x1552050", Offset = "0x1551250", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000199")]
	public void set_ContextMenuTextColor(Color value) { }

	[Address(RVA = "0x15520D0", Offset = "0x15512D0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600018E")]
	public void set_DefaultFileIcon(Sprite value) { }

	[Address(RVA = "0x15521E0", Offset = "0x15513E0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001A1")]
	public void set_DeletePanelBackground(Sprite value) { }

	[Address(RVA = "0x1552160", Offset = "0x1551360", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600019D")]
	public void set_DeletePanelBackgroundColor(Color value) { }

	[Address(RVA = "0x1552270", Offset = "0x1551470", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600019F")]
	public void set_DeletePanelTextColor(Color value) { }

	[Address(RVA = "0x15522F0", Offset = "0x15514F0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600018C")]
	public void set_DriveIcon(Sprite value) { }

	[Address(RVA = "0x1552400", Offset = "0x1551600", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000168")]
	public void set_DropdownArrow(Sprite value) { }

	[Address(RVA = "0x1552380", Offset = "0x1551580", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000162")]
	public void set_DropdownArrowColor(Color value) { }

	[Address(RVA = "0x1552490", Offset = "0x1551690", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000166")]
	public void set_DropdownBackground(Sprite value) { }

	[Address(RVA = "0x15525A0", Offset = "0x15517A0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600016A")]
	public void set_DropdownCheckmark(Sprite value) { }

	[Address(RVA = "0x1552520", Offset = "0x1551720", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000164")]
	public void set_DropdownCheckmarkColor(Color value) { }

	[Address(RVA = "0x1552630", Offset = "0x1551830", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600015E")]
	public void set_DropdownColor(Color value) { }

	[Address(RVA = "0x15526B0", Offset = "0x15518B0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000160")]
	public void set_DropdownTextColor(Color value) { }

	[Address(RVA = "0x1552730", Offset = "0x1551930", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000180")]
	public void set_FileAlternatingBackgroundColor(Color value) { }

	[Address(RVA = "0x15527B0", Offset = "0x15519B0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600017A")]
	public void set_FileHeight(float value) { }

	[Address(RVA = "0x15527D0", Offset = "0x15519D0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000182")]
	public void set_FileHoveredBackgroundColor(Color value) { }

	[Address(RVA = "0x1552850", Offset = "0x1551A50", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600017C")]
	public void set_FileIconsPadding(float value) { }

	[Address(RVA = "0x1552870", Offset = "0x1551A70", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000193")]
	public void set_FileMultiSelectionToggleOffIcon(Sprite value) { }

	[Address(RVA = "0x1552900", Offset = "0x1551B00", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000195")]
	public void set_FileMultiSelectionToggleOnIcon(Sprite value) { }

	[Address(RVA = "0x1552990", Offset = "0x1551B90", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600017E")]
	public void set_FileNormalBackgroundColor(Color value) { }

	[Address(RVA = "0x1552A10", Offset = "0x1551C10", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000186")]
	public void set_FileNormalTextColor(Color value) { }

	[Address(RVA = "0x1552A90", Offset = "0x1551C90", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000184")]
	public void set_FileSelectedBackgroundColor(Color value) { }

	[Address(RVA = "0x1552B10", Offset = "0x1551D10", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000188")]
	public void set_FileSelectedTextColor(Color value) { }

	[Address(RVA = "0x1552B90", Offset = "0x1551D90", Length = "0x79")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000134")]
	public void set_FilesListColor(Color value) { }

	[Address(RVA = "0x1552C10", Offset = "0x1551E10", Length = "0x79")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000136")]
	public void set_FilesVerticalSeparatorColor(Color value) { }

	[Address(RVA = "0x1552C90", Offset = "0x1551E90", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000190")]
	public void set_FiletypeIcons(FiletypeIcon[] value) { }

	[Address(RVA = "0x1552CD0", Offset = "0x1551ED0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600018A")]
	public void set_FolderIcon(Sprite value) { }

	[Address(RVA = "0x1552D70", Offset = "0x1551F70", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600012E")]
	public void set_Font(Font value) { }

	[Address(RVA = "0x1552D60", Offset = "0x1551F60", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000130")]
	public void set_FontSize(int value) { }

	[Address(RVA = "0x1552DF0", Offset = "0x1551FF0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000142")]
	public void set_HeaderBackButton(Sprite value) { }

	[Address(RVA = "0x1552E80", Offset = "0x1552080", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600013E")]
	public void set_HeaderButtonsColor(Color value) { }

	[Address(RVA = "0x1552F00", Offset = "0x1552100", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000148")]
	public void set_HeaderContextMenuButton(Sprite value) { }

	[Address(RVA = "0x1552F90", Offset = "0x1552190", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000144")]
	public void set_HeaderForwardButton(Sprite value) { }

	[Address(RVA = "0x1553020", Offset = "0x1552220", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000146")]
	public void set_HeaderUpButton(Sprite value) { }

	[Address(RVA = "0x15530B0", Offset = "0x15522B0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000156")]
	public void set_InputFieldBackground(Sprite value) { }

	[Address(RVA = "0x1553140", Offset = "0x1552340", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000154")]
	public void set_InputFieldCaretColor(Color value) { }

	[Address(RVA = "0x15531C0", Offset = "0x15523C0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600014C")]
	public void set_InputFieldInvalidBackgroundColor(Color value) { }

	[Address(RVA = "0x1553240", Offset = "0x1552440", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600014A")]
	public void set_InputFieldNormalBackgroundColor(Color value) { }

	[Address(RVA = "0x15532C0", Offset = "0x15524C0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000150")]
	public void set_InputFieldPlaceholderTextColor(Color value) { }

	[Address(RVA = "0x1553340", Offset = "0x1552540", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000152")]
	public void set_InputFieldSelectedTextColor(Color value) { }

	[Address(RVA = "0x15533C0", Offset = "0x15525C0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600014E")]
	public void set_InputFieldTextColor(Color value) { }

	[Address(RVA = "0x1553440", Offset = "0x1552640", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000176")]
	public void set_ScrollbarBackgroundColor(Color value) { }

	[Address(RVA = "0x15534C0", Offset = "0x15526C0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000178")]
	public void set_ScrollbarColor(Color value) { }

	[Address(RVA = "0x1553540", Offset = "0x1552740", Length = "0x79")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000138")]
	public void set_TitleBackgroundColor(Color value) { }

	[Address(RVA = "0x15535C0", Offset = "0x15527C0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600013A")]
	public void set_TitleTextColor(Color value) { }

	[Address(RVA = "0x1553640", Offset = "0x1552840", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000172")]
	public void set_ToggleBackground(Sprite value) { }

	[Address(RVA = "0x1553750", Offset = "0x1552950", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000174")]
	public void set_ToggleCheckmark(Sprite value) { }

	[Address(RVA = "0x15536D0", Offset = "0x15528D0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000170")]
	public void set_ToggleCheckmarkColor(Color value) { }

	[Address(RVA = "0x15537E0", Offset = "0x15529E0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600016C")]
	public void set_ToggleColor(Color value) { }

	[Address(RVA = "0x1553860", Offset = "0x1552A60", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600016E")]
	public void set_ToggleTextColor(Color value) { }

	[Address(RVA = "0x15538E0", Offset = "0x1552AE0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000132")]
	public void set_WindowColor(Color value) { }

	[Address(RVA = "0x15539E0", Offset = "0x1552BE0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000140")]
	public void set_WindowResizeGizmo(Sprite value) { }

	[Address(RVA = "0x1553960", Offset = "0x1552B60", Length = "0x79")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600013C")]
	public void set_WindowResizeGizmoColor(Color value) { }

}

