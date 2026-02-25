namespace SimpleFileBrowser;

[Token(Token = "0x2000019")]
public class FileBrowserItem : ListItem, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x40000B8")]
	private const float DOUBLE_CLICK_TIME = 0.5; //Field offset: 0x0
	[Token(Token = "0x40000B9")]
	private const float TOGGLE_MULTI_SELECTION_HOLD_TIME = 0.5; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000BA")]
	protected FileBrowser fileBrowser; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000BB")]
	private Image background; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40000BC")]
	private Image icon; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40000BD")]
	private Image multiSelectionToggle; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40000BE")]
	private Text nameText; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000BF")]
	private bool isSelected; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x40000C0")]
	private bool isHidden; //Field offset: 0x61
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000C1")]
	private UISkin skin; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000C2")]
	private float pressTime; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40000C3")]
	private float prevClickTime; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000C4")]
	private RectTransform m_transform; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000C5")]
	private bool <IsDirectory>k__BackingField; //Field offset: 0x80

	[Token(Token = "0x17000022")]
	public Image Icon
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000025")]
	public private bool IsDirectory
	{
		[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 8
		[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E7")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000024")]
	public string Name
	{
		[Address(RVA = "0x1541EF0", Offset = "0x15410F0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000023")]
	public RectTransform TransformComponent
	{
		[Address(RVA = "0x1541F20", Offset = "0x1541120", Length = "0xD2")]
		[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinksInternal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 210
	}

	[Address(RVA = "0x1541EE0", Offset = "0x15410E0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F3")]
	public FileBrowserItem() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E3")]
	public Image get_Icon() { }

	[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E6")]
	public bool get_IsDirectory() { }

	[Address(RVA = "0x1541EF0", Offset = "0x15410F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E5")]
	public string get_Name() { }

	[Address(RVA = "0x1541F20", Offset = "0x1541120", Length = "0xD2")]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinksInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60000E4")]
	public RectTransform get_TransformComponent() { }

	[Address(RVA = "0x1541400", Offset = "0x1540600", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "OnContextMenuTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000EB")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x1541500", Offset = "0x1540700", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000EC")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x1541530", Offset = "0x1540730", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000EE")]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x1541580", Offset = "0x1540780", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000EF")]
	public override void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x15415F0", Offset = "0x15407F0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000ED")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x1541650", Offset = "0x1540850", Length = "0x184")]
	[CalledBy(Type = typeof(FileBrowser), Member = "SimpleFileBrowser.IListViewAdapter.CreateItem", ReturnType = typeof(ListItem))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "SetFileBrowser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowser), typeof(UISkin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F2")]
	public void OnSkinRefreshed(UISkin skin, bool isInitialized = true) { }

	[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E7")]
	private void set_IsDirectory(bool value) { }

	[Address(RVA = "0x1541820", Offset = "0x1540A20", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E9")]
	public void SetFile(Sprite icon, string name, bool isDirectory) { }

	[Address(RVA = "0x15417E0", Offset = "0x15409E0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000E8")]
	public void SetFileBrowser(FileBrowser fileBrowser, UISkin skin) { }

	[Address(RVA = "0x1541890", Offset = "0x1540A90", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60000F1")]
	public void SetHidden(bool isHidden) { }

	[Address(RVA = "0x15419C0", Offset = "0x1540BC0", Length = "0x4B4")]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SimpleFileBrowser.IListViewAdapter.SetItemContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60000F0")]
	public void SetSelected(bool isSelected) { }

	[Address(RVA = "0x1541E80", Offset = "0x1541080", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(FileBrowser), Member = "OnItemHeld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000EA")]
	private void Update() { }

}

