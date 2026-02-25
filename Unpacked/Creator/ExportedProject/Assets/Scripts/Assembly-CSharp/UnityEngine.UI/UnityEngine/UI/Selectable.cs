namespace UnityEngine.UI;

[AddComponentMenu("UI/Selectable", 35)]
[DisallowMultipleComponent]
[ExecuteAlways]
[SelectionBase]
[Token(Token = "0x2000069")]
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	[Token(Token = "0x200006B")]
	internal enum SelectionState
	{
		Normal = 0,
		Highlighted = 1,
		Pressed = 2,
		Selected = 3,
		Disabled = 4,
	}

	[Token(Token = "0x200006A")]
	internal enum Transition
	{
		None = 0,
		ColorTint = 1,
		SpriteSwap = 2,
		Animation = 3,
	}

	[Token(Token = "0x4000207")]
	protected static Selectable[] s_Selectables; //Field offset: 0x0
	[Token(Token = "0x4000208")]
	protected static int s_SelectableCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000209")]
	private bool m_EnableCalled; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("navigation")]
	[SerializeField]
	[Token(Token = "0x400020A")]
	private Navigation m_Navigation; //Field offset: 0x28
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("transition")]
	[SerializeField]
	[Token(Token = "0x400020B")]
	private Transition m_Transition; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[FormerlySerializedAs("colors")]
	[SerializeField]
	[Token(Token = "0x400020C")]
	private ColorBlock m_Colors; //Field offset: 0x54
	[FieldOffset(Offset = "0xB0")]
	[FormerlySerializedAs("spriteState")]
	[SerializeField]
	[Token(Token = "0x400020D")]
	private SpriteState m_SpriteState; //Field offset: 0xB0
	[FieldOffset(Offset = "0xD0")]
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	[Token(Token = "0x400020E")]
	private AnimationTriggers m_AnimationTriggers; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x400020F")]
	[Tooltip("Can the Selectable be interacted with?")]
	private bool m_Interactable; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[FormerlySerializedAs("highlightGraphic")]
	[FormerlySerializedAs("m_HighlightGraphic")]
	[SerializeField]
	[Token(Token = "0x4000210")]
	private Graphic m_TargetGraphic; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000211")]
	private bool m_GroupsAllowInteraction; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000212")]
	protected int m_CurrentIndex; //Field offset: 0xEC
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000213")]
	private bool <isPointerInside>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF1")]
	[Token(Token = "0x4000214")]
	private bool <isPointerDown>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF2")]
	[Token(Token = "0x4000215")]
	private bool <hasSelection>k__BackingField; //Field offset: 0xF2
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000216")]
	private readonly List<CanvasGroup> m_CanvasGroupCache; //Field offset: 0xF8

	[Token(Token = "0x17000118")]
	public static int allSelectableCount
	{
		[Address(RVA = "0x1CD5F30", Offset = "0x1CD5130", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600042A")]
		 get { } //Length: 78
	}

	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	[Token(Token = "0x17000119")]
	public static List<Selectable> allSelectables
	{
		[Address(RVA = "0x1CD6010", Offset = "0x1CD5210", Length = "0xFF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Token(Token = "0x600042B")]
		 get { } //Length: 255
	}

	[Token(Token = "0x17000117")]
	public static Selectable[] allSelectablesArray
	{
		[Address(RVA = "0x1CD5F80", Offset = "0x1CD5180", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000429")]
		 get { } //Length: 143
	}

	[Token(Token = "0x1700011E")]
	public AnimationTriggers animationTriggers
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000435")]
		 get { } //Length: 8
		[Address(RVA = "0x1CD62E0", Offset = "0x1CD54E0", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000436")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000125")]
	public Animator animator
	{
		[Address(RVA = "0x1CD6110", Offset = "0x1CD5310", Length = "0x39")]
		[CalledBy(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Token(Token = "0x6000444")]
		 get { } //Length: 57
	}

	[Token(Token = "0x1700011C")]
	public ColorBlock colors
	{
		[Address(RVA = "0x1CD6150", Offset = "0x1CD5350", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000431")]
		 get { } //Length: 62
		[Address(RVA = "0x1CD6340", Offset = "0x1CD5540", Length = "0x9A")]
		[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplyInputFieldColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplySelectableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock&), typeof(ColorBlock)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		[Token(Token = "0x6000432")]
		 set { } //Length: 154
	}

	[Token(Token = "0x17000126")]
	protected SelectionState currentSelectionState
	{
		[Address(RVA = "0x1CD6190", Offset = "0x1CD5390", Length = "0x64")]
		[CalledBy(Type = "UnityEngine.UI.Button+<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600044F")]
		 get { } //Length: 100
	}

	[Token(Token = "0x17000123")]
	private bool hasSelection
	{
		[Address(RVA = "0x1CD6200", Offset = "0x1CD5400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600043F")]
		private get { } //Length: 8
		[Address(RVA = "0x1CD63E0", Offset = "0x1CD55E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000440")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000124")]
	public Image image
	{
		[Address(RVA = "0x1CD6210", Offset = "0x1CD5410", Length = "0x75")]
		[CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scrollbar)}, ReturnType = typeof(void))]
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000442")]
		 get { } //Length: 117
		[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000443")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000120")]
	public bool interactable
	{
		[Address(RVA = "0x51DAF0", Offset = "0x51CCF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000439")]
		 get { } //Length: 8
		[Address(RVA = "0x1CD63F0", Offset = "0x1CD55F0", Length = "0x168")]
		[CallerCount(Count = 45)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600043A")]
		 set { } //Length: 360
	}

	[Token(Token = "0x17000122")]
	private bool isPointerDown
	{
		[Address(RVA = "0x1B9DDF0", Offset = "0x1B9CFF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600043D")]
		private get { } //Length: 8
		[Address(RVA = "0x1B9DE80", Offset = "0x1B9D080", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600043E")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000121")]
	private bool isPointerInside
	{
		[Address(RVA = "0x1CD6290", Offset = "0x1CD5490", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600043B")]
		private get { } //Length: 8
		[Address(RVA = "0x1CD6560", Offset = "0x1CD5760", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600043C")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700011A")]
	public Navigation navigation
	{
		[Address(RVA = "0x1CD62A0", Offset = "0x1CD54A0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600042D")]
		 get { } //Length: 29
		[Address(RVA = "0x1CD6570", Offset = "0x1CD5770", Length = "0x76")]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation&), typeof(Navigation)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		[Token(Token = "0x600042E")]
		 set { } //Length: 118
	}

	[Token(Token = "0x1700011D")]
	public SpriteState spriteState
	{
		[Address(RVA = "0x1CD62C0", Offset = "0x1CD54C0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000433")]
		 get { } //Length: 25
		[Address(RVA = "0x1CD65F0", Offset = "0x1CD57F0", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState&), typeof(SpriteState)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		[Token(Token = "0x6000434")]
		 set { } //Length: 110
	}

	[Token(Token = "0x1700011F")]
	public Graphic targetGraphic
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000437")]
		 get { } //Length: 8
		[Address(RVA = "0x1CD6660", Offset = "0x1CD5860", Length = "0x5B")]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000438")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700011B")]
	public Transition transition
	{
		[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042F")]
		 get { } //Length: 4
		[Address(RVA = "0x1CD66C0", Offset = "0x1CD58C0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		[Token(Token = "0x6000430")]
		 set { } //Length: 86
	}

	[Address(RVA = "0x1CD5D20", Offset = "0x1CD4F20", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000467")]
	private static Selectable() { }

	[Address(RVA = "0x1CD5DA0", Offset = "0x1CD4FA0", Length = "0x181")]
	[CalledBy(Type = typeof(Toggle), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.BoxSlider", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AnimationTriggers), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000441")]
	protected Selectable() { }

	[Address(RVA = "0x1CD3860", Offset = "0x1CD2A60", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600042C")]
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	[Address(RVA = "0x1CD3930", Offset = "0x1CD2B30", Length = "0x92")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000445")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1CD39D0", Offset = "0x1CD2BD0", Length = "0x96")]
	[CalledBy(Type = typeof(Selectable), Member = "InstantClearState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_overrideSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045B")]
	private void DoSpriteSwap(Sprite newSprite) { }

	[Address(RVA = "0x1CD3A70", Offset = "0x1CD2C70", Length = "0x284")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "StartColorTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000451")]
	protected override void DoStateTransition(SelectionState state, bool instant) { }

	[Address(RVA = "0x1CD3D00", Offset = "0x1CD2F00", Length = "0x6B")]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600045F")]
	private void EvaluateAndTransitionToSelectionState() { }

	[Address(RVA = "0x1CD40F0", Offset = "0x1CD32F0", Length = "0x6B6")]
	[CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "GetPointOnRectEdge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000452")]
	public Selectable FindSelectable(Vector3 dir) { }

	[Address(RVA = "0x1CD3D70", Offset = "0x1CD2F70", Length = "0xDD")]
	[CalledBy(Type = typeof(Scrollbar), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Slider), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000458")]
	public override Selectable FindSelectableOnDown() { }

	[Address(RVA = "0x1CD3E50", Offset = "0x1CD3050", Length = "0xDD")]
	[CalledBy(Type = typeof(Scrollbar), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Slider), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000455")]
	public override Selectable FindSelectableOnLeft() { }

	[Address(RVA = "0x1CD3F30", Offset = "0x1CD3130", Length = "0xDD")]
	[CalledBy(Type = typeof(Scrollbar), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Slider), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000456")]
	public override Selectable FindSelectableOnRight() { }

	[Address(RVA = "0x1CD4010", Offset = "0x1CD3210", Length = "0xDD")]
	[CalledBy(Type = typeof(Scrollbar), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Slider), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000457")]
	public override Selectable FindSelectableOnUp() { }

	[Address(RVA = "0x1CD5F30", Offset = "0x1CD5130", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600042A")]
	public static int get_allSelectableCount() { }

	[Address(RVA = "0x1CD6010", Offset = "0x1CD5210", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600042B")]
	public static List<Selectable> get_allSelectables() { }

	[Address(RVA = "0x1CD5F80", Offset = "0x1CD5180", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000429")]
	public static Selectable[] get_allSelectablesArray() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000435")]
	public AnimationTriggers get_animationTriggers() { }

	[Address(RVA = "0x1CD6110", Offset = "0x1CD5310", Length = "0x39")]
	[CalledBy(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x6000444")]
	public Animator get_animator() { }

	[Address(RVA = "0x1CD6150", Offset = "0x1CD5350", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000431")]
	public ColorBlock get_colors() { }

	[Address(RVA = "0x1CD6190", Offset = "0x1CD5390", Length = "0x64")]
	[CalledBy(Type = "UnityEngine.UI.Button+<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600044F")]
	protected SelectionState get_currentSelectionState() { }

	[Address(RVA = "0x1CD6200", Offset = "0x1CD5400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600043F")]
	private bool get_hasSelection() { }

	[Address(RVA = "0x1CD6210", Offset = "0x1CD5410", Length = "0x75")]
	[CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scrollbar)}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000442")]
	public Image get_image() { }

	[Address(RVA = "0x51DAF0", Offset = "0x51CCF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000439")]
	public bool get_interactable() { }

	[Address(RVA = "0x1B9DDF0", Offset = "0x1B9CFF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600043D")]
	private bool get_isPointerDown() { }

	[Address(RVA = "0x1CD6290", Offset = "0x1CD5490", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600043B")]
	private bool get_isPointerInside() { }

	[Address(RVA = "0x1CD62A0", Offset = "0x1CD54A0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600042D")]
	public Navigation get_navigation() { }

	[Address(RVA = "0x1CD62C0", Offset = "0x1CD54C0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000433")]
	public SpriteState get_spriteState() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000437")]
	public Graphic get_targetGraphic() { }

	[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042F")]
	public Transition get_transition() { }

	[Address(RVA = "0x1CD47B0", Offset = "0x1CD39B0", Length = "0x224")]
	[CalledBy(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000453")]
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	[Address(RVA = "0x1CD49E0", Offset = "0x1CD3BE0", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000450")]
	protected override void InstantClearState() { }

	[Address(RVA = "0x1CD4B00", Offset = "0x1CD3D00", Length = "0x64")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600045D")]
	protected bool IsHighlighted() { }

	[Address(RVA = "0x1CD4B70", Offset = "0x1CD3D70", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000448")]
	public override bool IsInteractable() { }

	[Address(RVA = "0x1CD4B90", Offset = "0x1CD3D90", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600045E")]
	protected bool IsPressed() { }

	[Address(RVA = "0x1CD4BE0", Offset = "0x1CD3DE0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(BaseEventData), Member = "set_selectedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000454")]
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	[Address(RVA = "0x1CD4C80", Offset = "0x1CD3E80", Length = "0x62")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600044E")]
	private void OnApplicationFocus(bool hasFocus) { }

	[Address(RVA = "0x1CD4CF0", Offset = "0x1CD3EF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[Token(Token = "0x6000446")]
	protected virtual void OnCanvasGroupChanged() { }

	[Address(RVA = "0x1CD4D30", Offset = "0x1CD3F30", Length = "0x72")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000465")]
	public override void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x1CD4DB0", Offset = "0x1CD3FB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[Token(Token = "0x6000449")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1CD4DC0", Offset = "0x1CD3FC0", Length = "0x1A6")]
	[CalledBy(Type = "HSVPicker.BoxSlider", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600044D")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CD4F70", Offset = "0x1CD4170", Length = "0x31F")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.BoxSlider", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Selectable), Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600044A")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CD5290", Offset = "0x1CD4490", Length = "0x122")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(BaseEventData), Member = "set_selectedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000459")]
	public override void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x1CD53C0", Offset = "0x1CD45C0", Length = "0x125")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.BoxSlider", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000460")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x1CD54F0", Offset = "0x1CD46F0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000462")]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x1CD5570", Offset = "0x1CD4770", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000463")]
	public override void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x1CD55F0", Offset = "0x1CD47F0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000461")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x1CD5620", Offset = "0x1CD4820", Length = "0x72")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000464")]
	public override void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x1CD56A0", Offset = "0x1CD48A0", Length = "0x71")]
	[CalledBy(Type = typeof(Selectable), Member = "set_navigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "set_transition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "set_colors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "set_spriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "set_animationTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationTriggers)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "set_targetGraphic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnCanvasGroupChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600044C")]
	private void OnSetProperty() { }

	[Address(RVA = "0x1CD5720", Offset = "0x1CD4920", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600044B")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x1CD5750", Offset = "0x1CD4950", Length = "0x18E")]
	[CalledBy(Type = typeof(Selectable), Member = "OnCanvasGroupChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasGroup), Member = "get_interactable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasGroup), Member = "get_ignoreParentGroups", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000447")]
	private bool ParentGroupAllowsInteraction() { }

	[Address(RVA = "0x1CD58E0", Offset = "0x1CD4AE0", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000466")]
	public override void Select() { }

	[Address(RVA = "0x1CD62E0", Offset = "0x1CD54E0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000436")]
	public void set_animationTriggers(AnimationTriggers value) { }

	[Address(RVA = "0x1CD6340", Offset = "0x1CD5540", Length = "0x9A")]
	[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplyInputFieldColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplySelectableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock&), typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[Token(Token = "0x6000432")]
	public void set_colors(ColorBlock value) { }

	[Address(RVA = "0x1CD63E0", Offset = "0x1CD55E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000440")]
	private void set_hasSelection(bool value) { }

	[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000443")]
	public void set_image(Image value) { }

	[Address(RVA = "0x1CD63F0", Offset = "0x1CD55F0", Length = "0x168")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600043A")]
	public void set_interactable(bool value) { }

	[Address(RVA = "0x1B9DE80", Offset = "0x1B9D080", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600043E")]
	private void set_isPointerDown(bool value) { }

	[Address(RVA = "0x1CD6560", Offset = "0x1CD5760", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600043C")]
	private void set_isPointerInside(bool value) { }

	[Address(RVA = "0x1CD6570", Offset = "0x1CD5770", Length = "0x76")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation&), typeof(Navigation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[Token(Token = "0x600042E")]
	public void set_navigation(Navigation value) { }

	[Address(RVA = "0x1CD65F0", Offset = "0x1CD57F0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState&), typeof(SpriteState)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[Token(Token = "0x6000434")]
	public void set_spriteState(SpriteState value) { }

	[Address(RVA = "0x1CD6660", Offset = "0x1CD5860", Length = "0x5B")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000438")]
	public void set_targetGraphic(Graphic value) { }

	[Address(RVA = "0x1CD66C0", Offset = "0x1CD58C0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[Token(Token = "0x6000430")]
	public void set_transition(Transition value) { }

	[Address(RVA = "0x1CD59D0", Offset = "0x1CD4BD0", Length = "0xF2")]
	[CalledBy(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600045A")]
	private void StartColorTween(Color targetColor, bool instant) { }

	[Address(RVA = "0x1CD5AD0", Offset = "0x1CD4CD0", Length = "0x24C")]
	[CalledBy(Type = typeof(Selectable), Member = "InstantClearState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Animator), Member = "get_hasBoundPlayables", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "get_animator", ReturnType = typeof(Animator))]
	[Calls(Type = typeof(Animator), Member = "ResetTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Animator), Member = "SetTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045C")]
	private void TriggerAnimation(string triggername) { }

}

