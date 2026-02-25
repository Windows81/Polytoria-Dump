namespace UnityEngine.UIElements;

[Token(Token = "0x20000CF")]
public class GenericDropdownMenu : IGenericMenu
{
	[CompilerGenerated]
	[Token(Token = "0x20000D1")]
	private struct <>c__DisplayClass48_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000412")]
		public GenericDropdownMenu <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000413")]
		public int selectedIndex; //Field offset: 0x8

	}

	[Token(Token = "0x20000D0")]
	public class MenuItem
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400040E")]
		public string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400040F")]
		public VisualElement element; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000410")]
		public Action action; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000411")]
		public Action<Object> actionUserData; //Field offset: 0x28

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600068F")]
		public MenuItem() { }

	}

	[Token(Token = "0x40003F5")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003F6")]
	public static readonly string itemUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003F7")]
	public static readonly string itemContentUssClassName; //Field offset: 0x10
	[Token(Token = "0x40003F8")]
	public static readonly string labelUssClassName; //Field offset: 0x18
	[Token(Token = "0x40003F9")]
	public static readonly string containerInnerUssClassName; //Field offset: 0x20
	[Token(Token = "0x40003FA")]
	public static readonly string containerOuterUssClassName; //Field offset: 0x28
	[Token(Token = "0x40003FB")]
	public static readonly string checkmarkUssClassName; //Field offset: 0x30
	[Token(Token = "0x40003FC")]
	public static readonly string separatorUssClassName; //Field offset: 0x38
	[Token(Token = "0x40003FD")]
	public static readonly string contentWidthUssClassName; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003FE")]
	private List<MenuItem> m_Items; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003FF")]
	private VisualElement m_MenuContainer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000400")]
	private VisualElement m_OuterContainer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000401")]
	private ScrollView m_ScrollView; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000402")]
	private VisualElement m_PanelRootVisualContainer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000403")]
	private VisualElement m_TargetElement; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000404")]
	private Rect m_DesiredRect; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000405")]
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000406")]
	private float m_PositionTop; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000407")]
	private float m_PositionLeft; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000408")]
	private float m_ContentWidth; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000409")]
	private bool m_FitContentWidth; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x400040A")]
	private bool m_ShownAboveTarget; //Field offset: 0x65
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x66")]
	[Token(Token = "0x400040B")]
	private bool <isSingleSelectionDropdown>k__BackingField; //Field offset: 0x66
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x67")]
	[Token(Token = "0x400040C")]
	private bool <closeOnParentResize>k__BackingField; //Field offset: 0x67
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400040D")]
	private Vector2 m_MousePosition; //Field offset: 0x68

	[Token(Token = "0x170000F0")]
	internal bool closeOnParentResize
	{
		[Address(RVA = "0x1609250", Offset = "0x1608450", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000671")]
		internal get { } //Length: 5
		[Address(RVA = "0x1609290", Offset = "0x1608490", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000672")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000F1")]
	public VisualElement contentContainer
	{
		[Address(RVA = "0x1BE27E0", Offset = "0x1BE19E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000673")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000EF")]
	internal bool isSingleSelectionDropdown
	{
		[Address(RVA = "0x1609240", Offset = "0x1608440", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600066F")]
		internal get { } //Length: 5
		[Address(RVA = "0x1609280", Offset = "0x1608480", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000670")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x1BE2150", Offset = "0x1BE1350", Length = "0x322")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600068C")]
	private static GenericDropdownMenu() { }

	[Address(RVA = "0x1BE2480", Offset = "0x1BE1680", Length = "0x35B")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "CreateMenu", ReturnType = typeof(IGenericMenu))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_touchScrollBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScrollBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000674")]
	public GenericDropdownMenu() { }

	[Address(RVA = "0x1BE1E90", Offset = "0x1BE1090", Length = "0xAE")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "ChangeSelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600068D")]
	private void <Apply>g__UpdateSelectionDown|48_0(int newIndex, ref <>c__DisplayClass48_0 unnamed_param_1) { }

	[Address(RVA = "0x1BE1F40", Offset = "0x1BE1140", Length = "0xA3")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "ChangeSelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600068E")]
	private void <Apply>g__UpdateSelectionUp|48_1(int newIndex, ref <>c__DisplayClass48_0 unnamed_param_1) { }

	[Address(RVA = "0x1BDE600", Offset = "0x1BDD800", Length = "0x43A")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_userData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000685")]
	private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data = null) { }

	[Address(RVA = "0x1BDEA40", Offset = "0x1BDDC40", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(MenuItem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000683")]
	public override void AddItem(string itemName, bool isChecked, Action<Object> action, object data) { }

	[Address(RVA = "0x1BDE5C0", Offset = "0x1BDD7C0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(MenuItem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000682")]
	public override void AddItem(string itemName, bool isChecked, Action action) { }

	[Address(RVA = "0x1BDEA90", Offset = "0x1BDDC90", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000684")]
	public override void AddSeparator(string path) { }

	[Address(RVA = "0x1BDEE90", Offset = "0x1BDE090", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000678")]
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	[Address(RVA = "0x1BDEB50", Offset = "0x1BDDD50", Length = "0x318")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "GetSelectedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "Hide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "<Apply>g__UpdateSelectionUp|48_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass48_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "ChangeSelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "<Apply>g__UpdateSelectionDown|48_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass48_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000679")]
	private bool Apply(KeyboardNavigationOperation op) { }

	[Address(RVA = "0x1BDEED0", Offset = "0x1BDE0D0", Length = "0x12E")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "<Apply>g__UpdateSelectionDown|48_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass48_0&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "<Apply>g__UpdateSelectionUp|48_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass48_0&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000680")]
	private void ChangeSelectedIndex(int newIndex, int previousIndex) { }

	[Address(RVA = "0x1BDF000", Offset = "0x1BDE200", Length = "0xE21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Length), Member = "None", ReturnType = typeof(Length))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(StyleFontDefinition), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition)}, ReturnType = typeof(StyleFontDefinition))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(StyleFont), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(StyleFont))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFont", ReturnType = typeof(Font))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIDocument), Member = "FindRootUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(UIDocument))]
	[Calls(Type = typeof(VisualElement), Member = "GetRootVisualContainer", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	[Token(Token = "0x6000686")]
	public override void DropDown(Rect position, VisualElement targetElement, bool anchored = false) { }

	[Address(RVA = "0x1BDFE30", Offset = "0x1BDF030", Length = "0xBAB")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnContainerGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(AlignmentUtils), Member = "RoundToPanelPixelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BF20")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ScrollView), Member = "get_isVerticalScrollDisplayed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "None", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(StyleLength))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600068A")]
	private void EnsureVisibilityInParent() { }

	[Address(RVA = "0x1609250", Offset = "0x1608450", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000671")]
	internal bool get_closeOnParentResize() { }

	[Address(RVA = "0x1BE27E0", Offset = "0x1BE19E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000673")]
	public VisualElement get_contentContainer() { }

	[Address(RVA = "0x1609240", Offset = "0x1608440", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600066F")]
	internal bool get_isSingleSelectionDropdown() { }

	[Address(RVA = "0x1BE09E0", Offset = "0x1BDFBE0", Length = "0x67A")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnInitialDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "Children", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualElement>))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(String[])}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600068B")]
	private float GetLargestItemWidth() { }

	[Address(RVA = "0x1BE1060", Offset = "0x1BE0260", Length = "0x9D")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "UpdateSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000681")]
	private int GetSelectedIndex() { }

	[Address(RVA = "0x1BE1100", Offset = "0x1BE0300", Length = "0x13A")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnFocusOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusOutEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnParentResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnTargetElementDetachFromPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetachFromPanelEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000677")]
	private void Hide(bool giveFocusBack = false) { }

	[Address(RVA = "0x1BE1240", Offset = "0x1BE0440", Length = "0x405")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000675")]
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x1BE1650", Offset = "0x1BE0850", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[Token(Token = "0x6000688")]
	private void OnContainerGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1BE1660", Offset = "0x1BE0860", Length = "0x319")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000676")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x1BE1980", Offset = "0x1BE0B80", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "Hide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600067D")]
	private void OnFocusOut(FocusOutEvent evt) { }

	[Address(RVA = "0x1BE1AB0", Offset = "0x1BE0CB0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "GetLargestItemWidth", ReturnType = typeof(float))]
	[Token(Token = "0x6000689")]
	private void OnInitialDisplay(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1BE1AE0", Offset = "0x1BE0CE0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "Hide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600067E")]
	private void OnParentResized(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1BE1B00", Offset = "0x1BE0D00", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "UpdateSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "PreventCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067A")]
	private void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x1BE1C10", Offset = "0x1BE0E10", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "UpdateSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "PreventCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067B")]
	private void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x1BE1D20", Offset = "0x1BE0F20", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "GetSelectedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "Hide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "PreventCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600067C")]
	private void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x1BE1E80", Offset = "0x1BE1080", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "Hide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000687")]
	private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x1609290", Offset = "0x1608490", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000672")]
	internal void set_closeOnParentResize(bool value) { }

	[Address(RVA = "0x1609280", Offset = "0x1608480", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000670")]
	internal void set_isSingleSelectionDropdown(bool value) { }

	[Address(RVA = "0x1BE1FF0", Offset = "0x1BE11F0", Length = "0x157")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GenericDropdownMenu), Member = "GetSelectedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600067F")]
	private void UpdateSelection(VisualElement target) { }

}

