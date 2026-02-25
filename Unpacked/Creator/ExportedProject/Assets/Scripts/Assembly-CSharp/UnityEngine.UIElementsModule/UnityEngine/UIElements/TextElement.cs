namespace UnityEngine.UIElements;

[Token(Token = "0x200047D")]
public class TextElement : BindableElement, INotifyValueChanged<String>, ITextEdition, IExperimentalFeatures, ITextSelection
{
	[IsReadOnly]
	[Token(Token = "0x200047E")]
	internal struct GlyphsEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F43")]
		public readonly int Count; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000F44")]
		private readonly List<NativeSlice`1<Vertex>> m_Vertices; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F45")]
		private readonly TextElement m_TextElement; //Field offset: 0x10

		[Address(RVA = "0x1B3D330", Offset = "0x1B3C530", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GlyphsEnumerable), Member = "ComputeCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>)}, ReturnType = typeof(int))]
		[Token(Token = "0x6002228")]
		internal GlyphsEnumerable(TextElement te, List<NativeSlice`1<Vertex>> vertices) { }

		[Address(RVA = "0x1B3D230", Offset = "0x1B3C430", Length = "0xF6")]
		[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GlyphsEnumerable), Member = "ComputeCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002229")]
		internal GlyphsEnumerable(TextElement te, List<NativeSlice`1<Vertex>> vertices, ATGMeshInfo[] meshInfos) { }

		[Address(RVA = "0x1B3D170", Offset = "0x1B3C370", Length = "0xB1")]
		[CalledBy(Type = typeof(GlyphsEnumerable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GlyphsEnumerable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(ATGMeshInfo[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITKTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600222A")]
		private static int ComputeCount(List<NativeSlice`1<Vertex>> verts) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200047F")]
	internal class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
	{

		[Address(RVA = "0x1B51030", Offset = "0x1B50230", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600222B")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000480")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000F46")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000F47")]
		private UxmlBoolAttributeDescription m_EnableRichText; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000F48")]
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000F49")]
		private UxmlBoolAttributeDescription m_ParseEscapeSequences; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000F4A")]
		private UxmlBoolAttributeDescription m_Selectable; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000F4B")]
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000F4C")]
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000F4D")]
		private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; //Field offset: 0xC8

		[Address(RVA = "0x1B53A10", Offset = "0x1B52C10", Length = "0x322")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600222D")]
		public UxmlTraits() { }

		[Address(RVA = "0x1B53600", Offset = "0x1B52800", Length = "0x404")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextElement), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "set_enableRichText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "set_isSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "set_parseEscapeSequences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(TextElement), Member = "set_displayTooltipWhenElided", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		[Token(Token = "0x600222C")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000EFD")]
	internal static readonly BindingId displayTooltipWhenElidedProperty; //Field offset: 0x0
	[Token(Token = "0x4000F2A")]
	private const string ZeroWidthSpace = "​"; //Field offset: 0x0
	[Token(Token = "0x4000EFE")]
	internal static readonly BindingId emojiFallbackSupportProperty; //Field offset: 0x98
	[Token(Token = "0x4000EFF")]
	internal static readonly BindingId enableRichTextProperty; //Field offset: 0x130
	[Token(Token = "0x4000F00")]
	internal static readonly BindingId isElidedProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000F01")]
	internal static readonly BindingId parseEscapeSequencesProperty; //Field offset: 0x260
	[Token(Token = "0x4000F02")]
	internal static readonly BindingId textProperty; //Field offset: 0x2F8
	[Token(Token = "0x4000F03")]
	internal static readonly BindingId valueProperty; //Field offset: 0x390
	[Token(Token = "0x4000F04")]
	public static readonly string ussClassName; //Field offset: 0x428
	[Token(Token = "0x4000F05")]
	public static readonly string selectableUssClassName; //Field offset: 0x430
	[Token(Token = "0x4000F0E")]
	internal static readonly string k_EllipsisText; //Field offset: 0x438
	[Token(Token = "0x4000F11")]
	internal static readonly BindingId autoCorrectionProperty; //Field offset: 0x440
	[Token(Token = "0x4000F12")]
	internal static readonly BindingId hideMobileInputProperty; //Field offset: 0x4D8
	[Token(Token = "0x4000F13")]
	internal static readonly BindingId keyboardTypeProperty; //Field offset: 0x570
	[Token(Token = "0x4000F14")]
	internal static readonly BindingId isReadOnlyProperty; //Field offset: 0x608
	[Token(Token = "0x4000F15")]
	internal static readonly BindingId isPasswordProperty; //Field offset: 0x6A0
	[Token(Token = "0x4000F16")]
	internal static readonly BindingId maxLengthProperty; //Field offset: 0x738
	[Token(Token = "0x4000F17")]
	internal static readonly BindingId maskCharProperty; //Field offset: 0x7D0
	[Token(Token = "0x4000F31")]
	internal static readonly BindingId isSelectableProperty; //Field offset: 0x868
	[Token(Token = "0x4000F32")]
	internal static readonly BindingId cursorIndexProperty; //Field offset: 0x900
	[Token(Token = "0x4000F33")]
	internal static readonly BindingId selectIndexProperty; //Field offset: 0x998
	[Token(Token = "0x4000F34")]
	internal static readonly BindingId doubleClickSelectsWordProperty; //Field offset: 0xA30
	[Token(Token = "0x4000F35")]
	internal static readonly BindingId tripleClickSelectsLineProperty; //Field offset: 0xAC8
	[Token(Token = "0x4000F36")]
	internal static readonly BindingId cursorPositionProperty; //Field offset: 0xB60
	[Token(Token = "0x4000F37")]
	internal static readonly BindingId selectAllOnFocusProperty; //Field offset: 0xBF8
	[Token(Token = "0x4000F38")]
	internal static readonly BindingId selectAllOnMouseUpProperty; //Field offset: 0xC90
	[Token(Token = "0x4000F39")]
	internal static readonly BindingId selectionProperty; //Field offset: 0xD28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000F06")]
	private Action<GlyphsEnumerable> <PostProcessTextVertices>k__BackingField; //Field offset: 0x2E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000F07")]
	private UITKTextHandle <uitkTextHandle>k__BackingField; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000F08")]
	private string m_Text; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000F09")]
	private bool m_EnableRichText; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2F9")]
	[Token(Token = "0x4000F0A")]
	private bool m_EmojiFallbackSupport; //Field offset: 0x2F9
	[FieldOffset(Offset = "0x2FA")]
	[Token(Token = "0x4000F0B")]
	private bool m_ParseEscapeSequences; //Field offset: 0x2FA
	[FieldOffset(Offset = "0x2FB")]
	[Token(Token = "0x4000F0C")]
	private bool m_DisplayTooltipWhenElided; //Field offset: 0x2FB
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x4000F0D")]
	private bool <isElided>k__BackingField; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000F0F")]
	internal string elidedText; //Field offset: 0x300
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000F10")]
	private bool m_WasElided; //Field offset: 0x308
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000F18")]
	private TextEditingManipulator <editingManipulator>k__BackingField; //Field offset: 0x310
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000F19")]
	internal bool isInputField; //Field offset: 0x318
	[FieldOffset(Offset = "0x319")]
	[Token(Token = "0x4000F1A")]
	private bool m_Multiline; //Field offset: 0x319
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000F1B")]
	internal TouchScreenKeyboard m_TouchScreenKeyboard; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x4000F1C")]
	internal Action<Boolean> onIsReadOnlyChanged; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000F1D")]
	internal TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x330
	[FieldOffset(Offset = "0x334")]
	[Token(Token = "0x4000F1E")]
	private bool m_HideMobileInput; //Field offset: 0x334
	[FieldOffset(Offset = "0x335")]
	[Token(Token = "0x4000F1F")]
	private bool m_IsReadOnly; //Field offset: 0x335
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000F20")]
	private int m_MaxLength; //Field offset: 0x338
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000F21")]
	private string m_PlaceholderText; //Field offset: 0x340
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000F22")]
	private bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; //Field offset: 0x348
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000F23")]
	private Func<Char, Boolean> <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField; //Field offset: 0x350
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000F24")]
	private Action<Boolean> <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField; //Field offset: 0x358
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000F25")]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField; //Field offset: 0x360
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000F26")]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField; //Field offset: 0x368
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x4000F27")]
	private Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField; //Field offset: 0x370
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000F28")]
	private Action <OnPlaceholderChanged>k__BackingField; //Field offset: 0x378
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x4000F29")]
	private Func<String> <UnityEngine.UIElements.ITextEdition.GetDefaultValueType>k__BackingField; //Field offset: 0x380
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x4000F2B")]
	private string m_RenderedText; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x4000F2C")]
	private string m_OriginalText; //Field offset: 0x390
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x4000F2D")]
	private char m_MaskChar; //Field offset: 0x398
	[FieldOffset(Offset = "0x39A")]
	[Token(Token = "0x4000F2E")]
	private bool m_IsPassword; //Field offset: 0x39A
	[FieldOffset(Offset = "0x39B")]
	[Token(Token = "0x4000F2F")]
	private bool m_HidePlaceholderTextOnFocus; //Field offset: 0x39B
	[FieldOffset(Offset = "0x39C")]
	[Token(Token = "0x4000F30")]
	private bool m_AutoCorrection; //Field offset: 0x39C
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x4000F3A")]
	private TextSelectingManipulator m_SelectingManipulator; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000F3B")]
	private bool m_IsSelectable; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3A9")]
	[Token(Token = "0x4000F3C")]
	private bool m_DoubleClickSelectsWord; //Field offset: 0x3A9
	[FieldOffset(Offset = "0x3AA")]
	[Token(Token = "0x4000F3D")]
	private bool m_TripleClickSelectsLine; //Field offset: 0x3AA
	[FieldOffset(Offset = "0x3AB")]
	[Token(Token = "0x4000F3E")]
	private bool m_SelectAllOnFocus; //Field offset: 0x3AB
	[FieldOffset(Offset = "0x3AC")]
	[Token(Token = "0x4000F3F")]
	private bool m_SelectAllOnMouseUp; //Field offset: 0x3AC
	[FieldOffset(Offset = "0x3B0")]
	[Token(Token = "0x4000F40")]
	private Color m_SelectionColor; //Field offset: 0x3B0
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x4000F41")]
	private Color m_CursorColor; //Field offset: 0x3C0
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x4000F42")]
	private float m_CursorWidth; //Field offset: 0x3D0

	[CreateProperty]
	[Token(Token = "0x1700090B")]
	private bool autoCorrection
	{
		[Address(RVA = "0x1B35D80", Offset = "0x1B34F80", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021F5")]
		private get { } //Length: 72
		[Address(RVA = "0x1B368B0", Offset = "0x1B35AB0", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021F6")]
		private set { } //Length: 88
	}

	[Token(Token = "0x17000921")]
	internal Color cursorColor
	{
		[Address(RVA = "0x1B35DD0", Offset = "0x1B34FD0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600221F")]
		internal get { } //Length: 14
		[Address(RVA = "0x1B36910", Offset = "0x1B35B10", Length = "0x7C")]
		[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Token(Token = "0x6002220")]
		internal set { } //Length: 124
	}

	[CreateProperty]
	[Token(Token = "0x17000912")]
	private int cursorIndex
	{
		[Address(RVA = "0x1B35DE0", Offset = "0x1B34FE0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002201")]
		private get { } //Length: 72
		[Address(RVA = "0x1B36990", Offset = "0x1B35B90", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002202")]
		private set { } //Length: 86
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700091E")]
	private Vector2 cursorPosition
	{
		[Address(RVA = "0x1B35E30", Offset = "0x1B35030", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600221B")]
		private get { } //Length: 72
	}

	[CreateProperty]
	[Token(Token = "0x170008E9")]
	public bool displayTooltipWhenElided
	{
		[Address(RVA = "0x1B35E80", Offset = "0x1B35080", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600219F")]
		 get { } //Length: 8
		[Address(RVA = "0x1B369F0", Offset = "0x1B35BF0", Length = "0x8C")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60021A0")]
		 set { } //Length: 140
	}

	[CreateProperty]
	[Token(Token = "0x17000916")]
	internal bool doubleClickSelectsWord
	{
		[Address(RVA = "0x1B35E90", Offset = "0x1B35090", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600220C")]
		internal get { } //Length: 72
		[Address(RVA = "0x1B36A80", Offset = "0x1B35C80", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600220D")]
		internal set { } //Length: 88
	}

	[Token(Token = "0x170008EF")]
	internal TextEditingManipulator editingManipulator
	{
		[Address(RVA = "0x1551C50", Offset = "0x1550E50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021B3")]
		internal get { } //Length: 8
		[Address(RVA = "0x1B36AE0", Offset = "0x1B35CE0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021B4")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170008EE")]
	internal ITextEdition edition
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021B2")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000905")]
	private char effectiveMaskChar
	{
		[Address(RVA = "0x1B35EE0", Offset = "0x1B350E0", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021EB")]
		private get { } //Length: 92
	}

	[CreateProperty]
	[Token(Token = "0x170008E7")]
	public bool emojiFallbackSupport
	{
		[Address(RVA = "0x1B35F40", Offset = "0x1B35140", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600219B")]
		 get { } //Length: 8
		[Address(RVA = "0x1B36B00", Offset = "0x1B35D00", Length = "0x89")]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600219C")]
		 set { } //Length: 137
	}

	[CreateProperty]
	[Token(Token = "0x170008E6")]
	public bool enableRichText
	{
		[Address(RVA = "0x1B35F50", Offset = "0x1B35150", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002199")]
		 get { } //Length: 8
		[Address(RVA = "0x1B36B90", Offset = "0x1B35D90", Length = "0x89")]
		[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600219A")]
		 set { } //Length: 137
	}

	[Token(Token = "0x170008EB")]
	internal bool hasFocus
	{
		[Address(RVA = "0x1B35F60", Offset = "0x1B35160", Length = "0x77")]
		[CalledBy(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HasFocus", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "get_canSwitchToMixedValue", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "get_canSwitchToMixedValue", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021AA")]
		internal get { } //Length: 119
	}

	[CreateProperty]
	[Token(Token = "0x170008F5")]
	private bool hideMobileInput
	{
		[Address(RVA = "0x1B35FE0", Offset = "0x1B351E0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021BE")]
		private get { } //Length: 72
		[Address(RVA = "0x1B36C20", Offset = "0x1B35E20", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021BF")]
		private set { } //Length: 88
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170008EA")]
	public private bool isElided
	{
		[Address(RVA = "0x1B36030", Offset = "0x1B35230", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60021A1")]
		 get { } //Length: 8
		[Address(RVA = "0x1B36C80", Offset = "0x1B35E80", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60021A2")]
		private set { } //Length: 7
	}

	[CreateProperty]
	[Token(Token = "0x17000907")]
	private bool isPassword
	{
		[Address(RVA = "0x1B36040", Offset = "0x1B35240", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021EE")]
		private get { } //Length: 72
		[Address(RVA = "0x1B36C90", Offset = "0x1B35E90", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021EF")]
		private set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x170008F7")]
	private bool isReadOnly
	{
		[Address(RVA = "0x1B36090", Offset = "0x1B35290", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021C2")]
		private get { } //Length: 72
		[Address(RVA = "0x1B36CF0", Offset = "0x1B35EF0", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021C3")]
		private set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x17000910")]
	internal bool isSelectable
	{
		[Address(RVA = "0x1B360E0", Offset = "0x1B352E0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021FD")]
		internal get { } //Length: 69
		[Address(RVA = "0x1B36D50", Offset = "0x1B35F50", Length = "0x58")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021FE")]
		internal set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x170008F3")]
	private TouchScreenKeyboardType keyboardType
	{
		[Address(RVA = "0x1B36130", Offset = "0x1B35330", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021BA")]
		private get { } //Length: 72
		[Address(RVA = "0x1B36DB0", Offset = "0x1B35FB0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021BB")]
		private set { } //Length: 86
	}

	[CreateProperty]
	[Token(Token = "0x17000904")]
	private char maskChar
	{
		[Address(RVA = "0x1B36180", Offset = "0x1B35380", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60021E9")]
		private get { } //Length: 187
		[Address(RVA = "0x1B36E10", Offset = "0x1B36010", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60021EA")]
		private set { } //Length: 180
	}

	[CreateProperty]
	[Token(Token = "0x170008F9")]
	private int maxLength
	{
		[Address(RVA = "0x1B36240", Offset = "0x1B35440", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021CF")]
		private get { } //Length: 72
		[Address(RVA = "0x1B36ED0", Offset = "0x1B360D0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021D0")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000901")]
	internal Action OnPlaceholderChanged
	{
		[Address(RVA = "0x95D830", Offset = "0x95CA30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E1")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E610", Offset = "0x95D810", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E2")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700090D")]
	internal string originalText
	{
		[Address(RVA = "0x1B36290", Offset = "0x1B35490", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021F9")]
		internal get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170008E8")]
	public bool parseEscapeSequences
	{
		[Address(RVA = "0x1B362A0", Offset = "0x1B354A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600219D")]
		 get { } //Length: 8
		[Address(RVA = "0x1B36F30", Offset = "0x1B36130", Length = "0x89")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600219E")]
		 set { } //Length: 137
	}

	[Token(Token = "0x170008E3")]
	public Action<GlyphsEnumerable> PostProcessTextVertices
	{
		[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002191")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700090C")]
	internal RenderedText renderedText
	{
		[Address(RVA = "0x1B362B0", Offset = "0x1B354B0", Length = "0x29A")]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60021F7")]
		internal get { } //Length: 666
	}

	[CreateProperty]
	[Token(Token = "0x1700091A")]
	private bool selectAllOnFocus
	{
		[Address(RVA = "0x1B36550", Offset = "0x1B35750", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002214")]
		private get { } //Length: 72
		[Address(RVA = "0x1B36FC0", Offset = "0x1B361C0", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002215")]
		private set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x1700091C")]
	private bool selectAllOnMouseUp
	{
		[Address(RVA = "0x1B365A0", Offset = "0x1B357A0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002218")]
		private get { } //Length: 72
		[Address(RVA = "0x1B37020", Offset = "0x1B36220", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002219")]
		private set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x17000914")]
	private int selectIndex
	{
		[Address(RVA = "0x1B365F0", Offset = "0x1B357F0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002205")]
		private get { } //Length: 72
		[Address(RVA = "0x1B37080", Offset = "0x1B36280", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002206")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000923")]
	internal TextSelectingManipulator selectingManipulator
	{
		[Address(RVA = "0x1B36640", Offset = "0x1B35840", Length = "0x77")]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_cursorIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.SelectNone", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.SelectAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_selectIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_selectIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_cursorIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.HasSelection", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.set_isReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TextSelectingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002222")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 119
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700090E")]
	public ITextSelection selection
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021FA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000920")]
	internal Color selectionColor
	{
		[Address(RVA = "0x1B366C0", Offset = "0x1B358C0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600221D")]
		internal get { } //Length: 14
		[Address(RVA = "0x1B370E0", Offset = "0x1B362E0", Length = "0x7C")]
		[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Token(Token = "0x600221E")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x17000909")]
	internal bool showPlaceholderText
	{
		[Address(RVA = "0x1B366D0", Offset = "0x1B358D0", Length = "0x10C")]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "UpdatePlaceholderClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TValueType>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "get_IsPlaceholder", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "get_renderedText", ReturnType = "UnityEngine.TextCore.Text.RenderedText")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021F2")]
		internal get { } //Length: 268
	}

	[CreateProperty]
	[Token(Token = "0x170008E5")]
	public override string text
	{
		[Address(RVA = "0x1B367E0", Offset = "0x1B359E0", Length = "0x3B")]
		[CalledBy(Type = typeof(Button), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002197")]
		 get { } //Length: 59
		[Address(RVA = "0x1B37160", Offset = "0x1B36360", Length = "0x4D")]
		[CalledBy(Type = typeof(Button), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Token(Token = "0x6002198")]
		 set { } //Length: 77
	}

	[CreateProperty]
	[Token(Token = "0x17000918")]
	internal bool tripleClickSelectsLine
	{
		[Address(RVA = "0x1B36820", Offset = "0x1B35A20", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002210")]
		internal get { } //Length: 72
		[Address(RVA = "0x1B371B0", Offset = "0x1B363B0", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002211")]
		internal set { } //Length: 88
	}

	[Token(Token = "0x170008E4")]
	internal UITKTextHandle uitkTextHandle
	{
		[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002192")]
		internal get { } //Length: 8
		[Address(RVA = "0x1B2F500", Offset = "0x1B2E700", Length = "0x13")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002193")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170008EC")]
	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.value
	{
		[Address(RVA = "0x1B32D70", Offset = "0x1B31F70", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021AD")]
		private get { } //Length: 30
		[Address(RVA = "0x1B32D90", Offset = "0x1B31F90", Length = "0x1FC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Object>), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60021AE")]
		private set { } //Length: 508
	}

	[Token(Token = "0x170008FC")]
	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.AcceptCharacter
	{
		[Address(RVA = "0x826C70", Offset = "0x825E70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021D7")]
		private get { } //Length: 8
		[Address(RVA = "0x1B33350", Offset = "0x1B32550", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x60021D8")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700090A")]
	private override bool UnityEngine.UIElements.ITextEdition.autoCorrection
	{
		[Address(RVA = "0x1B33250", Offset = "0x1B32450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021F3")]
		private get { } //Length: 8
		[Address(RVA = "0x1B33390", Offset = "0x1B32590", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60021F4")]
		private set { } //Length: 127
	}

	[Token(Token = "0x17000902")]
	private override Func<String> UnityEngine.UIElements.ITextEdition.GetDefaultValueType
	{
		[Address(RVA = "0x95DA00", Offset = "0x95CC00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E3")]
		private get { } //Length: 8
		[Address(RVA = "0x95EFA0", Offset = "0x95E1A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E4")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170008F4")]
	private override bool UnityEngine.UIElements.ITextEdition.hideMobileInput
	{
		[Address(RVA = "0x1B33260", Offset = "0x1B32460", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_inputFieldAppearance", ReturnType = typeof(InputFieldAppearance))]
		[Token(Token = "0x60021BC")]
		private get { } //Length: 49
		[Address(RVA = "0x1B33410", Offset = "0x1B32610", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_inputFieldAppearance", ReturnType = typeof(InputFieldAppearance))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60021BD")]
		private set { } //Length: 137
	}

	[Token(Token = "0x17000908")]
	private override bool UnityEngine.UIElements.ITextEdition.hidePlaceholderOnFocus
	{
		[Address(RVA = "0x1B332A0", Offset = "0x1B324A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021F0")]
		private get { } //Length: 8
		[Address(RVA = "0x1B334A0", Offset = "0x1B326A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021F1")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170008FB")]
	private override bool UnityEngine.UIElements.ITextEdition.isDelayed
	{
		[Address(RVA = "0x1B332B0", Offset = "0x1B324B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60021D3")]
		private get { } //Length: 8
		[Address(RVA = "0x1B334B0", Offset = "0x1B326B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60021D4")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000906")]
	private override bool UnityEngine.UIElements.ITextEdition.isPassword
	{
		[Address(RVA = "0x1B332C0", Offset = "0x1B324C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021EC")]
		private get { } //Length: 8
		[Address(RVA = "0x1B334C0", Offset = "0x1B326C0", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60021ED")]
		private set { } //Length: 143
	}

	[Token(Token = "0x170008F6")]
	private override bool UnityEngine.UIElements.ITextEdition.isReadOnly
	{
		[Address(RVA = "0x1B332D0", Offset = "0x1B324D0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		[Token(Token = "0x60021C0")]
		private get { } //Length: 34
		[Address(RVA = "0x1B33550", Offset = "0x1B32750", Length = "0x236")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
		[Calls(Type = "UnityEngine.TextEditingUtilities", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextSelectingUtilities", "UnityEngine.TextCore.Text.TextHandle", typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextEditingManipulator), Member = "InitTextEditorEventHandler", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x60021C1")]
		private set { } //Length: 566
	}

	[Token(Token = "0x170008F2")]
	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.keyboardType
	{
		[Address(RVA = "0x1B33300", Offset = "0x1B32500", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021B8")]
		private get { } //Length: 7
		[Address(RVA = "0x1B33790", Offset = "0x1B32990", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60021B9")]
		private set { } //Length: 124
	}

	[Token(Token = "0x17000903")]
	private override char UnityEngine.UIElements.ITextEdition.maskChar
	{
		[Address(RVA = "0x1B33310", Offset = "0x1B32510", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021E7")]
		private get { } //Length: 8
		[Address(RVA = "0x1B33810", Offset = "0x1B32A10", Length = "0xB3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60021E8")]
		private set { } //Length: 179
	}

	[Token(Token = "0x170008F8")]
	private override int UnityEngine.UIElements.ITextEdition.maxLength
	{
		[Address(RVA = "0x1B33320", Offset = "0x1B32520", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021CD")]
		private get { } //Length: 7
		[Address(RVA = "0x1B338D0", Offset = "0x1B32AD0", Length = "0xD3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60021CE")]
		private set { } //Length: 211
	}

	[Token(Token = "0x17000900")]
	private override Action UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot
	{
		[Address(RVA = "0x95DD10", Offset = "0x95CF10", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DF")]
		private get { } //Length: 8
		[Address(RVA = "0x95FC40", Offset = "0x95EE40", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E0")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170008F0")]
	private override bool UnityEngine.UIElements.ITextEdition.multiline
	{
		[Address(RVA = "0x1B33330", Offset = "0x1B32530", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021B5")]
		private get { } //Length: 8
		[Address(RVA = "0x1B339B0", Offset = "0x1B32BB0", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021B6")]
		private set { } //Length: 125
	}

	[Token(Token = "0x170008FA")]
	private override string UnityEngine.UIElements.ITextEdition.placeholder
	{
		[Address(RVA = "0x1B33340", Offset = "0x1B32540", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60021D1")]
		private get { } //Length: 8
		[Address(RVA = "0x1B33A30", Offset = "0x1B32C30", Length = "0x1C5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x60021D2")]
		private set { } //Length: 453
	}

	[Token(Token = "0x170008F1")]
	private override TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.touchScreenKeyboard
	{
		[Address(RVA = "0x833AA0", Offset = "0x832CA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021B7")]
		private get { } //Length: 8
	}

	[Token(Token = "0x170008FD")]
	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.UpdateScrollOffset
	{
		[Address(RVA = "0x826C50", Offset = "0x825E50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021D9")]
		private get { } //Length: 8
		[Address(RVA = "0x1B33370", Offset = "0x1B32570", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x60021DA")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170008FF")]
	private override Action UnityEngine.UIElements.ITextEdition.UpdateTextFromValue
	{
		[Address(RVA = "0x95D840", Offset = "0x95CA40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DD")]
		private get { } //Length: 8
		[Address(RVA = "0x95E650", Offset = "0x95D850", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DE")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170008FE")]
	private override Action UnityEngine.UIElements.ITextEdition.UpdateValueFromText
	{
		[Address(RVA = "0x826C60", Offset = "0x825E60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DB")]
		private get { } //Length: 8
		[Address(RVA = "0x95E630", Offset = "0x95D830", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DC")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000911")]
	private override int UnityEngine.UIElements.ITextSelection.cursorIndex
	{
		[Address(RVA = "0x1B33D50", Offset = "0x1B32F50", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
		[Calls(Type = typeof(TextSelectingManipulator), Member = "get_cursorIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60021FF")]
		private get { } //Length: 109
		[Address(RVA = "0x1B34020", Offset = "0x1B33220", Length = "0xF1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
		[Calls(Type = typeof(TextSelectingManipulator), Member = "set_cursorIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002200")]
		private set { } //Length: 241
	}

	[Token(Token = "0x1700091D")]
	private override Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition
	{
		[Address(RVA = "0x1B33DC0", Offset = "0x1B32FC0", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600221A")]
		private get { } //Length: 206
	}

	[Token(Token = "0x17000922")]
	private override float UnityEngine.UIElements.ITextSelection.cursorWidth
	{
		[Address(RVA = "0x1B33E90", Offset = "0x1B33090", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002221")]
		private get { } //Length: 9
	}

	[Token(Token = "0x17000915")]
	private override bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord
	{
		[Address(RVA = "0x1B33EA0", Offset = "0x1B330A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600220A")]
		private get { } //Length: 8
		[Address(RVA = "0x1B34120", Offset = "0x1B33320", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600220B")]
		private set { } //Length: 127
	}

	[Token(Token = "0x1700090F")]
	private override bool UnityEngine.UIElements.ITextSelection.isSelectable
	{
		[Address(RVA = "0x1B33EB0", Offset = "0x1B330B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60021FB")]
		private get { } //Length: 57
		[Address(RVA = "0x1B341A0", Offset = "0x1B333A0", Length = "0xBD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60021FC")]
		private set { } //Length: 189
	}

	[Token(Token = "0x1700091F")]
	private override float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition
	{
		[Address(RVA = "0x1B33EF0", Offset = "0x1B330F0", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeightFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600221C")]
		private get { } //Length: 133
	}

	[Token(Token = "0x17000919")]
	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus
	{
		[Address(RVA = "0x1B33F80", Offset = "0x1B33180", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002212")]
		private get { } //Length: 8
		[Address(RVA = "0x1B34260", Offset = "0x1B33460", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002213")]
		private set { } //Length: 127
	}

	[Token(Token = "0x1700091B")]
	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp
	{
		[Address(RVA = "0x1B33F90", Offset = "0x1B33190", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002216")]
		private get { } //Length: 8
		[Address(RVA = "0x1B342E0", Offset = "0x1B334E0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002217")]
		private set { } //Length: 127
	}

	[Token(Token = "0x17000913")]
	private override int UnityEngine.UIElements.ITextSelection.selectIndex
	{
		[Address(RVA = "0x1B33FA0", Offset = "0x1B331A0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
		[Calls(Type = typeof(TextSelectingManipulator), Member = "get_selectIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002203")]
		private get { } //Length: 109
		[Address(RVA = "0x1B34360", Offset = "0x1B33560", Length = "0xF1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
		[Calls(Type = typeof(TextSelectingManipulator), Member = "set_selectIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002204")]
		private set { } //Length: 241
	}

	[Token(Token = "0x17000917")]
	private override bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine
	{
		[Address(RVA = "0x1B34010", Offset = "0x1B33210", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600220E")]
		private get { } //Length: 8
		[Address(RVA = "0x1B34460", Offset = "0x1B33660", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600220F")]
		private set { } //Length: 127
	}

	[CreateProperty]
	[Token(Token = "0x170008ED")]
	private string value
	{
		[Address(RVA = "0x1B36870", Offset = "0x1B35A70", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x60021AF")]
		private get { } //Length: 59
		[Address(RVA = "0x1B37210", Offset = "0x1B36410", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Token(Token = "0x60021B0")]
		private set { } //Length: 77
	}

	[Address(RVA = "0x1B34710", Offset = "0x1B33910", Length = "0x12D9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002227")]
	private static TextElement() { }

	[Address(RVA = "0x1B359F0", Offset = "0x1B34BF0", Length = "0x383")]
	[CalledBy(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BasePopupField`2+PopupTextElement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RepeatButton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PopupWindow), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RepeatButton), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindableElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600218F")]
	public TextElement() { }

	[Address(RVA = "0x1B301A0", Offset = "0x1B2F3A0", Length = "0x333")]
	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DropdownMenu), Member = "AppendAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<UnityEngine.UIElements.DropdownMenuAction>), typeof(System.Func`2<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction+Status>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60021C8")]
	private void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	[Address(RVA = "0x1B30570", Offset = "0x1B2F770", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = "ProcessMenuCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021C6")]
	private void Copy(DropdownMenuAction a) { }

	[Address(RVA = "0x1B304E0", Offset = "0x1B2F6E0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021CA")]
	private Status CopyActionStatus(DropdownMenuAction a) { }

	[Address(RVA = "0x1B30640", Offset = "0x1B2F840", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = "ProcessMenuCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021C5")]
	private void Cut(DropdownMenuAction a) { }

	[Address(RVA = "0x1B305B0", Offset = "0x1B2F7B0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021C9")]
	private Status CutActionStatus(DropdownMenuAction a) { }

	[Address(RVA = "0x1B30680", Offset = "0x1B2F880", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_renderedText", ReturnType = "UnityEngine.TextCore.Text.RenderedText")]
	[Calls(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[Token(Token = "0x60021AC")]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x1B30720", Offset = "0x1B2F920", Length = "0x2E5")]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCharacterHeightFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(AlignmentUtils), Member = "CeilToPixelGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801D8CC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002225")]
	internal void DrawCaret(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B30A10", Offset = "0x1B2FC10", Length = "0x8FA")]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(TextElement), Member = "GetLastCharacterAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801D8CC0")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002223")]
	private void DrawHighlighting(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B31310", Offset = "0x1B30510", Length = "0x4B1")]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetHighlightRectangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Rect[]))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002224")]
	private void DrawNativeHighlighting(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B317D0", Offset = "0x1B309D0", Length = "0x2A8")]
	[CalledBy(Type = typeof(TextElement), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextElement), Member = "BuildContextualMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DropdownMenu), Member = "InsertSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021CC")]
	private void EditionHandleEvent(EventBase evt) { }

	[Address(RVA = "0x1B31A80", Offset = "0x1B30C80", Length = "0x4F4")]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "MeasureTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021A6")]
	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	[Address(RVA = "0x1B35D80", Offset = "0x1B34F80", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021F5")]
	private bool get_autoCorrection() { }

	[Address(RVA = "0x1B35DD0", Offset = "0x1B34FD0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600221F")]
	internal Color get_cursorColor() { }

	[Address(RVA = "0x1B35DE0", Offset = "0x1B34FE0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002201")]
	private int get_cursorIndex() { }

	[Address(RVA = "0x1B35E30", Offset = "0x1B35030", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600221B")]
	private Vector2 get_cursorPosition() { }

	[Address(RVA = "0x1B35E80", Offset = "0x1B35080", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600219F")]
	public bool get_displayTooltipWhenElided() { }

	[Address(RVA = "0x1B35E90", Offset = "0x1B35090", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600220C")]
	internal bool get_doubleClickSelectsWord() { }

	[Address(RVA = "0x1551C50", Offset = "0x1550E50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021B3")]
	internal TextEditingManipulator get_editingManipulator() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021B2")]
	internal ITextEdition get_edition() { }

	[Address(RVA = "0x1B35EE0", Offset = "0x1B350E0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021EB")]
	private char get_effectiveMaskChar() { }

	[Address(RVA = "0x1B35F40", Offset = "0x1B35140", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600219B")]
	public bool get_emojiFallbackSupport() { }

	[Address(RVA = "0x1B35F50", Offset = "0x1B35150", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002199")]
	public bool get_enableRichText() { }

	[Address(RVA = "0x1B35F60", Offset = "0x1B35160", Length = "0x77")]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "get_canSwitchToMixedValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "get_canSwitchToMixedValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HasFocus", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021AA")]
	internal bool get_hasFocus() { }

	[Address(RVA = "0x1B35FE0", Offset = "0x1B351E0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021BE")]
	private bool get_hideMobileInput() { }

	[Address(RVA = "0x1B36030", Offset = "0x1B35230", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60021A1")]
	public bool get_isElided() { }

	[Address(RVA = "0x1B36040", Offset = "0x1B35240", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021EE")]
	private bool get_isPassword() { }

	[Address(RVA = "0x1B36090", Offset = "0x1B35290", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021C2")]
	private bool get_isReadOnly() { }

	[Address(RVA = "0x1B360E0", Offset = "0x1B352E0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021FD")]
	internal bool get_isSelectable() { }

	[Address(RVA = "0x1B36130", Offset = "0x1B35330", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021BA")]
	private TouchScreenKeyboardType get_keyboardType() { }

	[Address(RVA = "0x1B36180", Offset = "0x1B35380", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021E9")]
	private char get_maskChar() { }

	[Address(RVA = "0x1B36240", Offset = "0x1B35440", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021CF")]
	private int get_maxLength() { }

	[Address(RVA = "0x95D830", Offset = "0x95CA30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E1")]
	internal Action get_OnPlaceholderChanged() { }

	[Address(RVA = "0x1B36290", Offset = "0x1B35490", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021F9")]
	internal string get_originalText() { }

	[Address(RVA = "0x1B362A0", Offset = "0x1B354A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600219D")]
	public bool get_parseEscapeSequences() { }

	[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002191")]
	public Action<GlyphsEnumerable> get_PostProcessTextVertices() { }

	[Address(RVA = "0x1B362B0", Offset = "0x1B354B0", Length = "0x29A")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60021F7")]
	internal RenderedText get_renderedText() { }

	[Address(RVA = "0x1B36550", Offset = "0x1B35750", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002214")]
	private bool get_selectAllOnFocus() { }

	[Address(RVA = "0x1B365A0", Offset = "0x1B357A0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002218")]
	private bool get_selectAllOnMouseUp() { }

	[Address(RVA = "0x1B365F0", Offset = "0x1B357F0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002205")]
	private int get_selectIndex() { }

	[Address(RVA = "0x1B36640", Offset = "0x1B35840", Length = "0x77")]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.set_isReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.HasSelection", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_selectIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_selectIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.SelectAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.SelectNone", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_cursorIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_cursorIndex", ReturnType = typeof(int))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextSelectingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002222")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextSelectingManipulator get_selectingManipulator() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021FA")]
	public ITextSelection get_selection() { }

	[Address(RVA = "0x1B366C0", Offset = "0x1B358C0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600221D")]
	internal Color get_selectionColor() { }

	[Address(RVA = "0x1B366D0", Offset = "0x1B358D0", Length = "0x10C")]
	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "UpdatePlaceholderClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TValueType>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "get_IsPlaceholder", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "get_renderedText", ReturnType = "UnityEngine.TextCore.Text.RenderedText")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021F2")]
	internal bool get_showPlaceholderText() { }

	[Address(RVA = "0x1B367E0", Offset = "0x1B359E0", Length = "0x3B")]
	[CalledBy(Type = typeof(Button), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x6002197")]
	public override string get_text() { }

	[Address(RVA = "0x1B36820", Offset = "0x1B35A20", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002210")]
	internal bool get_tripleClickSelectsLine() { }

	[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002192")]
	internal UITKTextHandle get_uitkTextHandle() { }

	[Address(RVA = "0x1B36870", Offset = "0x1B35A70", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x60021AF")]
	private string get_value() { }

	[Address(RVA = "0x1B31F80", Offset = "0x1B31180", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002190")]
	private string GetDefaultValueType() { }

	[Address(RVA = "0x1B31FA0", Offset = "0x1B311A0", Length = "0x2D1")]
	[CalledBy(Type = typeof(TextElement), Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002226")]
	private int GetLastCharacterAt(int lineIndex) { }

	[Address(RVA = "0x1B32280", Offset = "0x1B31480", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(ContextualMenuPopulateEvent), typeof(KeyDownEvent), typeof(KeyUpEvent), typeof(ValidateCommandEvent), typeof(ExecuteCommandEvent), typeof(FocusEvent), typeof(BlurEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(PointerDownEvent), typeof(PointerUpEvent), typeof(PointerMoveEvent), typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(IMEEvent), typeof(GeometryChangedEvent), typeof(AttachToPanelEvent), typeof(DetachFromPanelEvent)})]
	[Token(Token = "0x6002194")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x1B323A0", Offset = "0x1B315A0", Length = "0x99")]
	[CalledBy(Type = "UnityEngine.UIElements.BasePopupField`2+PopupTextElement", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Button), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextElement), Member = "ElideText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(TextOverflowPosition)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[Token(Token = "0x60021AB")]
	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	[Address(RVA = "0x1B32440", Offset = "0x1B31640", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002196")]
	private void OnDetachFromPanel(DetachFromPanelEvent detachEvent) { }

	[Address(RVA = "0x1B32640", Offset = "0x1B31840", Length = "0x21C")]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "RevealCursor", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "HasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021A4")]
	internal void OnGenerateTextOver(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B32480", Offset = "0x1B31680", Length = "0x1BA")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextElement), Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "HasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "RevealCursor", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021A5")]
	internal void OnGenerateTextOverNative(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B32860", Offset = "0x1B31A60", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(TextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021A3")]
	internal static void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B329C0", Offset = "0x1B31BC0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[Token(Token = "0x6002195")]
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	[Address(RVA = "0x1B32A40", Offset = "0x1B31C40", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60021C7")]
	private void Paste(DropdownMenuAction a) { }

	[Address(RVA = "0x1B329D0", Offset = "0x1B31BD0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "CanPaste", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021CB")]
	private Status PasteActionStatus(DropdownMenuAction a) { }

	[Address(RVA = "0x1B32A80", Offset = "0x1B31C80", Length = "0xFD")]
	[CalledBy(Type = typeof(TextElement), Member = "Cut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021C4")]
	private void ProcessMenuCommand(string command) { }

	[Address(RVA = "0x1B368B0", Offset = "0x1B35AB0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021F6")]
	private void set_autoCorrection(bool value) { }

	[Address(RVA = "0x1B36910", Offset = "0x1B35B10", Length = "0x7C")]
	[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Token(Token = "0x6002220")]
	internal void set_cursorColor(Color value) { }

	[Address(RVA = "0x1B36990", Offset = "0x1B35B90", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002202")]
	private void set_cursorIndex(int value) { }

	[Address(RVA = "0x1B369F0", Offset = "0x1B35BF0", Length = "0x8C")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021A0")]
	public void set_displayTooltipWhenElided(bool value) { }

	[Address(RVA = "0x1B36A80", Offset = "0x1B35C80", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600220D")]
	internal void set_doubleClickSelectsWord(bool value) { }

	[Address(RVA = "0x1B36AE0", Offset = "0x1B35CE0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021B4")]
	private void set_editingManipulator(TextEditingManipulator value) { }

	[Address(RVA = "0x1B36B00", Offset = "0x1B35D00", Length = "0x89")]
	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600219C")]
	public void set_emojiFallbackSupport(bool value) { }

	[Address(RVA = "0x1B36B90", Offset = "0x1B35D90", Length = "0x89")]
	[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600219A")]
	public void set_enableRichText(bool value) { }

	[Address(RVA = "0x1B36C20", Offset = "0x1B35E20", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021BF")]
	private void set_hideMobileInput(bool value) { }

	[Address(RVA = "0x1B36C80", Offset = "0x1B35E80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60021A2")]
	private void set_isElided(bool value) { }

	[Address(RVA = "0x1B36C90", Offset = "0x1B35E90", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021EF")]
	private void set_isPassword(bool value) { }

	[Address(RVA = "0x1B36CF0", Offset = "0x1B35EF0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021C3")]
	private void set_isReadOnly(bool value) { }

	[Address(RVA = "0x1B36D50", Offset = "0x1B35F50", Length = "0x58")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021FE")]
	internal void set_isSelectable(bool value) { }

	[Address(RVA = "0x1B36DB0", Offset = "0x1B35FB0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021BB")]
	private void set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0x1B36E10", Offset = "0x1B36010", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021EA")]
	private void set_maskChar(char value) { }

	[Address(RVA = "0x1B36ED0", Offset = "0x1B360D0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021D0")]
	private void set_maxLength(int value) { }

	[Address(RVA = "0x95E610", Offset = "0x95D810", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E2")]
	internal void set_OnPlaceholderChanged(Action value) { }

	[Address(RVA = "0x1B36F30", Offset = "0x1B36130", Length = "0x89")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600219E")]
	public void set_parseEscapeSequences(bool value) { }

	[Address(RVA = "0x1B36FC0", Offset = "0x1B361C0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002215")]
	private void set_selectAllOnFocus(bool value) { }

	[Address(RVA = "0x1B37020", Offset = "0x1B36220", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002219")]
	private void set_selectAllOnMouseUp(bool value) { }

	[Address(RVA = "0x1B37080", Offset = "0x1B36280", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002206")]
	private void set_selectIndex(int value) { }

	[Address(RVA = "0x1B370E0", Offset = "0x1B362E0", Length = "0x7C")]
	[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Token(Token = "0x600221E")]
	internal void set_selectionColor(Color value) { }

	[Address(RVA = "0x1B37160", Offset = "0x1B36360", Length = "0x4D")]
	[CalledBy(Type = typeof(Button), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Token(Token = "0x6002198")]
	public override void set_text(string value) { }

	[Address(RVA = "0x1B371B0", Offset = "0x1B363B0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002211")]
	internal void set_tripleClickSelectsLine(bool value) { }

	[Address(RVA = "0x1B2F500", Offset = "0x1B2E700", Length = "0x13")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002193")]
	internal void set_uitkTextHandle(UITKTextHandle value) { }

	[Address(RVA = "0x1B37210", Offset = "0x1B36410", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Token(Token = "0x60021B0")]
	private void set_value(string value) { }

	[Address(RVA = "0x95E670", Offset = "0x95D870", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F8")]
	private void SetRenderedText(string value) { }

	[Address(RVA = "0x1B32B80", Offset = "0x1B31D80", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021A9")]
	private bool ShouldElide() { }

	[Address(RVA = "0x1B32D70", Offset = "0x1B31F70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021AD")]
	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	[Address(RVA = "0x1B32D90", Offset = "0x1B31F90", Length = "0x1FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Object>), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021AE")]
	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	[Address(RVA = "0x1B32BD0", Offset = "0x1B31DD0", Length = "0x19F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021B1")]
	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	[Address(RVA = "0x1B32F90", Offset = "0x1B32190", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021E6")]
	private override string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	[Address(RVA = "0x826C70", Offset = "0x825E70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021D7")]
	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	[Address(RVA = "0x1B33250", Offset = "0x1B32450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021F3")]
	private override bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	[Address(RVA = "0x95DA00", Offset = "0x95CC00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E3")]
	private override Func<String> UnityEngine.UIElements.ITextEdition.get_GetDefaultValueType() { }

	[Address(RVA = "0x1B33260", Offset = "0x1B32460", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_inputFieldAppearance", ReturnType = typeof(InputFieldAppearance))]
	[Token(Token = "0x60021BC")]
	private override bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	[Address(RVA = "0x1B332A0", Offset = "0x1B324A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021F0")]
	private override bool UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus() { }

	[Address(RVA = "0x1B332B0", Offset = "0x1B324B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60021D3")]
	private override bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	[Address(RVA = "0x1B332C0", Offset = "0x1B324C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021EC")]
	private override bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	[Address(RVA = "0x1B332D0", Offset = "0x1B324D0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Token(Token = "0x60021C0")]
	private override bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	[Address(RVA = "0x1B33300", Offset = "0x1B32500", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021B8")]
	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	[Address(RVA = "0x1B33310", Offset = "0x1B32510", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021E7")]
	private override char UnityEngine.UIElements.ITextEdition.get_maskChar() { }

	[Address(RVA = "0x1B33320", Offset = "0x1B32520", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021CD")]
	private override int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	[Address(RVA = "0x95DD10", Offset = "0x95CF10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DF")]
	private override Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	[Address(RVA = "0x1B33330", Offset = "0x1B32530", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021B5")]
	private override bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	[Address(RVA = "0x1B33340", Offset = "0x1B32540", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021D1")]
	private override string UnityEngine.UIElements.ITextEdition.get_placeholder() { }

	[Address(RVA = "0x833AA0", Offset = "0x832CA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021B7")]
	private override TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.get_touchScreenKeyboard() { }

	[Address(RVA = "0x826C50", Offset = "0x825E50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021D9")]
	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	[Address(RVA = "0x95D840", Offset = "0x95CA40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DD")]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	[Address(RVA = "0x826C60", Offset = "0x825E60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DB")]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	[Address(RVA = "0x1B33010", Offset = "0x1B32210", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021D6")]
	private override void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	[Address(RVA = "0x1B33030", Offset = "0x1B32230", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021D5")]
	private override void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	[Address(RVA = "0x1B33350", Offset = "0x1B32550", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x60021D8")]
	private override void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(Func<Char, Boolean> value) { }

	[Address(RVA = "0x1B33390", Offset = "0x1B32590", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021F4")]
	private override void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	[Address(RVA = "0x95EFA0", Offset = "0x95E1A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E4")]
	private override void UnityEngine.UIElements.ITextEdition.set_GetDefaultValueType(Func<String> value) { }

	[Address(RVA = "0x1B33410", Offset = "0x1B32610", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_inputFieldAppearance", ReturnType = typeof(InputFieldAppearance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021BD")]
	private override void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	[Address(RVA = "0x1B334A0", Offset = "0x1B326A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60021F1")]
	private override void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(bool value) { }

	[Address(RVA = "0x1B334B0", Offset = "0x1B326B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60021D4")]
	private override void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	[Address(RVA = "0x1B334C0", Offset = "0x1B326C0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021ED")]
	private override void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	[Address(RVA = "0x1B33550", Offset = "0x1B32750", Length = "0x236")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextSelectingUtilities", "UnityEngine.TextCore.Text.TextHandle", typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "InitTextEditorEventHandler", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60021C1")]
	private override void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	[Address(RVA = "0x1B33790", Offset = "0x1B32990", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021B9")]
	private override void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0x1B33810", Offset = "0x1B32A10", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021E8")]
	private override void UnityEngine.UIElements.ITextEdition.set_maskChar(char value) { }

	[Address(RVA = "0x1B338D0", Offset = "0x1B32AD0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021CE")]
	private override void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	[Address(RVA = "0x95FC40", Offset = "0x95EE40", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E0")]
	private override void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	[Address(RVA = "0x1B339B0", Offset = "0x1B32BB0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021B6")]
	private override void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	[Address(RVA = "0x1B33A30", Offset = "0x1B32C30", Length = "0x1C5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60021D2")]
	private override void UnityEngine.UIElements.ITextEdition.set_placeholder(string value) { }

	[Address(RVA = "0x1B33370", Offset = "0x1B32570", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x60021DA")]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(Action<Boolean> value) { }

	[Address(RVA = "0x95E650", Offset = "0x95D850", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DE")]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	[Address(RVA = "0x95E630", Offset = "0x95D830", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DC")]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	[Address(RVA = "0x1B33070", Offset = "0x1B32270", Length = "0x1D6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(InputEvent))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60021E5")]
	private override void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	[Address(RVA = "0x1B33D50", Offset = "0x1B32F50", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60021FF")]
	private override int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	[Address(RVA = "0x1B33DC0", Offset = "0x1B32FC0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600221A")]
	private override Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	[Address(RVA = "0x1B33E90", Offset = "0x1B33090", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002221")]
	private override float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	[Address(RVA = "0x1B33EA0", Offset = "0x1B330A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600220A")]
	private override bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	[Address(RVA = "0x1B33EB0", Offset = "0x1B330B0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021FB")]
	private override bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	[Address(RVA = "0x1B33EF0", Offset = "0x1B330F0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeightFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600221C")]
	private override float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	[Address(RVA = "0x1B33F80", Offset = "0x1B33180", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002212")]
	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	[Address(RVA = "0x1B33F90", Offset = "0x1B33190", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002216")]
	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	[Address(RVA = "0x1B33FA0", Offset = "0x1B331A0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002203")]
	private override int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	[Address(RVA = "0x1B34010", Offset = "0x1B33210", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600220E")]
	private override bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	[Address(RVA = "0x1B33C00", Offset = "0x1B32E00", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "HasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002209")]
	private override bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	[Address(RVA = "0x1B33C70", Offset = "0x1B32E70", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002207")]
	private override void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	[Address(RVA = "0x1B33CE0", Offset = "0x1B32EE0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectNone", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002208")]
	private override void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	[Address(RVA = "0x1B34020", Offset = "0x1B33220", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "set_cursorIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002200")]
	private override void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	[Address(RVA = "0x1B34120", Offset = "0x1B33320", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600220B")]
	private override void UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord(bool value) { }

	[Address(RVA = "0x1B341A0", Offset = "0x1B333A0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021FC")]
	private override void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	[Address(RVA = "0x1B34260", Offset = "0x1B33460", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002213")]
	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	[Address(RVA = "0x1B342E0", Offset = "0x1B334E0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002217")]
	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	[Address(RVA = "0x1B34360", Offset = "0x1B33560", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "set_selectIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002204")]
	private override void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	[Address(RVA = "0x1B34460", Offset = "0x1B33660", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600220F")]
	private override void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(bool value) { }

	[Address(RVA = "0x1B344E0", Offset = "0x1B336E0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021A7")]
	private void UpdateTooltip() { }

	[Address(RVA = "0x1B34560", Offset = "0x1B33760", Length = "0x1AE")]
	[CalledBy(Type = typeof(TextElement), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_displayTooltipWhenElided", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextElement), Member = "ElideText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(TextOverflowPosition)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021A8")]
	private void UpdateVisibleText() { }

}

