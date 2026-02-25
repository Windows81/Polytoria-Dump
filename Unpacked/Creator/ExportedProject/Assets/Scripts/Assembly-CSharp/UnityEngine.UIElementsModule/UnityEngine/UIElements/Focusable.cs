namespace UnityEngine.UIElements;

[Token(Token = "0x200024D")]
public abstract class Focusable : CallbackEventHandler
{
	[Token(Token = "0x40008EB")]
	internal static readonly BindingId focusableProperty; //Field offset: 0x0
	[Token(Token = "0x40008EC")]
	internal static readonly BindingId tabIndexProperty; //Field offset: 0x98
	[Token(Token = "0x40008ED")]
	internal static readonly BindingId delegatesFocusProperty; //Field offset: 0x130
	[Token(Token = "0x40008EE")]
	internal static readonly BindingId canGrabFocusProperty; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008EF")]
	private bool m_Focusable; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40008F0")]
	private int m_TabIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008F1")]
	private bool m_DelegatesFocus; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40008F2")]
	private bool m_ExcludeFromFocusRing; //Field offset: 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x40008F3")]
	private bool <isEligibleToReceiveFocusFromDisabledChild>k__BackingField; //Field offset: 0x2A

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170002E9")]
	public override bool canGrabFocus
	{
		[Address(RVA = "0x1C69D50", Offset = "0x1C68F50", Length = "0x14")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000FD4")]
		 get { } //Length: 20
	}

	[CreateProperty]
	[Token(Token = "0x170002E6")]
	public bool delegatesFocus
	{
		[Address(RVA = "0x1C69D70", Offset = "0x1C68F70", Length = "0x7")]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000FCE")]
		 get { } //Length: 7
		[Address(RVA = "0x1C69D90", Offset = "0x1C68F90", Length = "0x79")]
		[CalledBy(Type = typeof(BaseCompositeField`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoundsField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoundsIntField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char), "UnityEngine.UIElements.TextInputBaseField`1<TValueType>+TextInputBase<TValueType>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RadioButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000FCF")]
		 set { } //Length: 121
	}

	[Token(Token = "0x170002E7")]
	internal bool excludeFromFocusRing
	{
		[Address(RVA = "0x1C69D80", Offset = "0x1C68F80", Length = "0x7")]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 5)]
		[Token(Token = "0x6000FD0")]
		internal get { } //Length: 7
		[Address(RVA = "0x1C69E10", Offset = "0x1C69010", Length = "0xD0")]
		[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_isCompositeRoot", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000FD1")]
		internal set { } //Length: 208
	}

	[CreateProperty]
	[Token(Token = "0x170002E4")]
	public override bool focusable
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FCA")]
		 get { } //Length: 5
		[Address(RVA = "0x1C69EF0", Offset = "0x1C690F0", Length = "0x72")]
		[CalledBy(Type = typeof(Foldout), Member = "set_focusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000FCB")]
		 set { } //Length: 114
	}

	[Token(Token = "0x170002E3")]
	public abstract FocusController focusController
	{
		[Token(Token = "0x6000FC9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E8")]
	internal bool isEligibleToReceiveFocusFromDisabledChild
	{
		[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FD2")]
		internal get { } //Length: 5
		[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FD3")]
		internal set { } //Length: 4
	}

	[CreateProperty]
	[Token(Token = "0x170002E5")]
	public int tabIndex
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FCC")]
		 get { } //Length: 4
		[Address(RVA = "0x1C69F70", Offset = "0x1C69170", Length = "0x76")]
		[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char), "UnityEngine.UIElements.TextInputBaseField`1<TValueType>+TextInputBase<TValueType>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumnResizeHandle), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseField`1), Member = "get_mixedValueLabel", ReturnType = typeof(Label))]
		[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000FCD")]
		 set { } //Length: 118
	}

	[Address(RVA = "0x1C69940", Offset = "0x1C68B40", Length = "0x368")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000FDA")]
	private static Focusable() { }

	[Address(RVA = "0x1C69CB0", Offset = "0x1C68EB0", Length = "0x9F")]
	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackEventHandler), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "VisualElementCreation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FC8")]
	protected Focusable() { }

	[Address(RVA = "0x1C69560", Offset = "0x1C68760", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "Blur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FD6")]
	public override void Blur() { }

	[Address(RVA = "0x1C69510", Offset = "0x1C68710", Length = "0x44")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FocusController), Member = "Blur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FD7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void BlurImmediately() { }

	[Address(RVA = "0x1C695B0", Offset = "0x1C687B0", Length = "0x14C")]
	[CalledBy(Type = typeof(VisualElement), Member = "Focus", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Focusable), Member = "GetFirstFocusableChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FD5")]
	public override void Focus() { }

	[Address(RVA = "0x1C69D50", Offset = "0x1C68F50", Length = "0x14")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FD4")]
	public override bool get_canGrabFocus() { }

	[Address(RVA = "0x1C69D70", Offset = "0x1C68F70", Length = "0x7")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000FCE")]
	public bool get_delegatesFocus() { }

	[Address(RVA = "0x1C69D80", Offset = "0x1C68F80", Length = "0x7")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 5)]
	[Token(Token = "0x6000FD0")]
	internal bool get_excludeFromFocusRing() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FCA")]
	public override bool get_focusable() { }

	[Token(Token = "0x6000FC9")]
	public abstract FocusController get_focusController() { }

	[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FD2")]
	internal bool get_isEligibleToReceiveFocusFromDisabledChild() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FCC")]
	public int get_tabIndex() { }

	[Address(RVA = "0x1C69700", Offset = "0x1C68900", Length = "0x18E")]
	[CalledBy(Type = typeof(Focusable), Member = "Focus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Focusable), Member = "GetFocusDelegate", ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(Focusable), Member = "GetFirstFocusableChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_isCompositeRoot", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Focusable), Member = "GetFirstFocusableChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FD9")]
	private static Focusable GetFirstFocusableChild(VisualElement ve) { }

	[Address(RVA = "0x1C69890", Offset = "0x1C68A90", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Focusable), Member = "GetFirstFocusableChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[Token(Token = "0x6000FD8")]
	internal Focusable GetFocusDelegate() { }

	[Address(RVA = "0x1C69D90", Offset = "0x1C68F90", Length = "0x79")]
	[CalledBy(Type = typeof(BaseCompositeField`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundsField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundsIntField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char), "UnityEngine.UIElements.TextInputBaseField`1<TValueType>+TextInputBase<TValueType>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000FCF")]
	public void set_delegatesFocus(bool value) { }

	[Address(RVA = "0x1C69E10", Offset = "0x1C69010", Length = "0xD0")]
	[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_isCompositeRoot", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000FD1")]
	internal void set_excludeFromFocusRing(bool value) { }

	[Address(RVA = "0x1C69EF0", Offset = "0x1C690F0", Length = "0x72")]
	[CalledBy(Type = typeof(Foldout), Member = "set_focusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000FCB")]
	public override void set_focusable(bool value) { }

	[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FD3")]
	internal void set_isEligibleToReceiveFocusFromDisabledChild(bool value) { }

	[Address(RVA = "0x1C69F70", Offset = "0x1C69170", Length = "0x76")]
	[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "get_mixedValueLabel", ReturnType = typeof(Label))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char), "UnityEngine.UIElements.TextInputBaseField`1<TValueType>+TextInputBase<TValueType>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumnResizeHandle), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000FCD")]
	public void set_tabIndex(int value) { }

}

