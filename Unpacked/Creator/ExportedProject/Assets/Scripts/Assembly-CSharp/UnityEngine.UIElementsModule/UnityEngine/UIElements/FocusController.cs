namespace UnityEngine.UIElements;

[Token(Token = "0x2000250")]
public class FocusController
{
	[Token(Token = "0x2000251")]
	private struct FocusedElement
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008FF")]
		public VisualElement m_SubTreeRoot; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000900")]
		public VisualElement m_FocusedElement; //Field offset: 0x8

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008F8")]
	private readonly IFocusRing <focusRing>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008F9")]
	private TextElement m_SelectedTextElement; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008FA")]
	private List<FocusedElement> m_FocusedElements; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008FB")]
	private Focusable m_LastFocusedElement; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008FC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Focusable m_LastPendingFocusedElement; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008FD")]
	private int m_PendingFocusCount; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40008FE")]
	private int <imguiKeyboardControl>k__BackingField; //Field offset: 0x3C

	[Token(Token = "0x170002EF")]
	public Focusable focusedElement
	{
		[Address(RVA = "0x1C68AF0", Offset = "0x1C67CF0", Length = "0x5B")]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FocusController), Member = "GetRetargetedFocusedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000FE9")]
		 get { } //Length: 91
	}

	[Token(Token = "0x170002ED")]
	private IFocusRing focusRing
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FE7")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002F0")]
	internal int imguiKeyboardControl
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001000")]
		internal get { } //Length: 4
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001001")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002EE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextElement selectedTextElement
	{
		[Address(RVA = "0x1C68B50", Offset = "0x1C67D50", Length = "0x7B")]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnSelectIndexChange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnCursorIndexChange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusController), typeof(Focusable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000FE8")]
		internal set { } //Length: 123
	}

	[Address(RVA = "0x1C68A50", Offset = "0x1C67C50", Length = "0x9D")]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000FE6")]
	public FocusController(IFocusRing focusRing) { }

	[Address(RVA = "0x1C66800", Offset = "0x1C65A00", Length = "0x109")]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(Focusable), typeof(FocusChangeDirection), typeof(FocusController), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FF8")]
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	[Address(RVA = "0x1C66910", Offset = "0x1C65B10", Length = "0x109")]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(Focusable), typeof(FocusChangeDirection), typeof(FocusController), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FF6")]
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	[Address(RVA = "0x1C66B30", Offset = "0x1C65D30", Length = "0x10F")]
	[CalledBy(Type = typeof(Focusable), Member = "Blur", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Focusable), Member = "BlurImmediately", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(FocusController), Member = "IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FFA")]
	internal void Blur(Focusable focusable, bool bIsFocusDelegated = false, DispatchMode dispatchMode = 1) { }

	[Address(RVA = "0x1C66A20", Offset = "0x1C65C20", Length = "0x101")]
	[CalledBy(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FF1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void BlurLastFocusedElement() { }

	[Address(RVA = "0x1C66C40", Offset = "0x1C65E40", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "GetFocusTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.FocusController+FocusedElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FF2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void DoFocusChange(Focusable f) { }

	[Address(RVA = "0x1C66CC0", Offset = "0x1C65EC0", Length = "0x108")]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000FF5")]
	internal Focusable FocusNextInDirection(Focusable currentFocusable, FocusChangeDirection direction) { }

	[Address(RVA = "0x1C68AF0", Offset = "0x1C67CF0", Length = "0x5B")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FocusController), Member = "GetRetargetedFocusedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FE9")]
	public Focusable get_focusedElement() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FE7")]
	private IFocusRing get_focusRing() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001000")]
	internal int get_imguiKeyboardControl() { }

	[Address(RVA = "0x1C66F30", Offset = "0x1C66130", Length = "0x155")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetFocusChangeDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(FocusChangeDirection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(FocusController), Member = "IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FFF")]
	internal bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget) { }

	[Address(RVA = "0x1C66DD0", Offset = "0x1C65FD0", Length = "0x15A")]
	[CalledBy(Type = typeof(FocusController), Member = "DoFocusChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "ProcessPendingFocusChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "ReleaseFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "GrabFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_isCompositeRoot", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FF4")]
	private static void GetFocusTargets(Focusable f, List<FocusedElement> outTargets) { }

	[Address(RVA = "0x1C67090", Offset = "0x1C66290", Length = "0xB9")]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "get_currentFocusedElement", ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FocusBasedEventSequence", ReturnType = typeof(FocusBasedEventSequenceContext))]
	[CalledBy(Type = typeof(FocusBasedEventSequenceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultEventSystem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerDownEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBinding), Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FED")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Focusable GetLeafFocusedElement() { }

	[Address(RVA = "0x1C67150", Offset = "0x1C66350", Length = "0x22C")]
	[CalledBy(Type = typeof(FocusController), Member = "get_focusedElement", ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_isCompositeRoot", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FEC")]
	internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst) { }

	[Address(RVA = "0x1C67380", Offset = "0x1C66580", Length = "0x335")]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(FocusController), Member = "GetFocusTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.FocusController+FocusedElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(Focusable), typeof(FocusChangeDirection), typeof(FocusController), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FF9")]
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	[Address(RVA = "0x1C676C0", Offset = "0x1C668C0", Length = "0xD2")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnNavigationMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnNavigationEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.NavigationEventBase`1<TEvent>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "OnNavigationMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "set_processedByFocusController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FEA")]
	public void IgnoreEvent(EventBase evt) { }

	[Address(RVA = "0x1C677A0", Offset = "0x1C669A0", Length = "0x13C")]
	[CalledBy(Type = typeof(DataBinding), Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(FocusController), Member = "Blur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "GetFocusableParentForPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetFocusChangeDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(FocusChangeDirection))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FEB")]
	internal bool IsFocused(Focusable f) { }

	[Address(RVA = "0x1C678E0", Offset = "0x1C66AE0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FEE")]
	private bool IsLocalElement(Focusable f) { }

	[Address(RVA = "0x1C67930", Offset = "0x1C66B30", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FEF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool IsPendingFocus(Focusable f) { }

	[Address(RVA = "0x1C67A00", Offset = "0x1C66C00", Length = "0x288")]
	[CalledBy(Type = typeof(FocusOutEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusInEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "GetFocusTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.FocusController+FocusedElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000FF3")]
	internal void ProcessPendingFocusChange(Focusable f) { }

	[Address(RVA = "0x1C67C90", Offset = "0x1C66E90", Length = "0xC6")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusController), Member = "GetRetargetedFocusedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(VisualElement), Member = "get_areAncestorsAndSelfDisplayed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_visible", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000FFE")]
	internal void ReevaluateFocus() { }

	[Address(RVA = "0x1C67D60", Offset = "0x1C66F60", Length = "0x32E")]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(FocusController), Member = "GetFocusTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.FocusController+FocusedElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(Focusable), typeof(FocusChangeDirection), typeof(FocusController), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FF7")]
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001001")]
	internal void set_imguiKeyboardControl(int value) { }

	[Address(RVA = "0x1C68B50", Offset = "0x1C67D50", Length = "0x7B")]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnSelectIndexChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnCursorIndexChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusController), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FE8")]
	internal void set_selectedTextElement(TextElement value) { }

	[Address(RVA = "0x1C68090", Offset = "0x1C67290", Length = "0x8F")]
	[CalledBy(Type = typeof(Panel), Member = "ValidateFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "TickSchedulingUpdaters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FF0")]
	internal void SetFocusToLastFocusedElement() { }

	[Address(RVA = "0x1C68400", Offset = "0x1C67600", Length = "0xC5")]
	[CalledBy(Type = typeof(TextInputBase), Member = "MoveFocusToCompositeRoot", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Focusable), Member = "Focus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "Blur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000FFB")]
	internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false, DispatchMode dispatchMode = 1) { }

	[Address(RVA = "0x1C684D0", Offset = "0x1C676D0", Length = "0x457")]
	[CalledBy(Type = typeof(FocusChangeDirection), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusController), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "SyncIMGUIFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Focusable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(FocusController), Member = "ReleaseFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "AboutToGrabFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "AboutToReleaseFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FocusController), Member = "GrabFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(VisualElement), Member = "RetargetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FFC")]
	internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false, DispatchMode dispatchMode = 1) { }

	[Address(RVA = "0x1C68120", Offset = "0x1C67320", Length = "0x2DF")]
	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerDownEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "get_processedByFocusController", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase), Member = "set_processedByFocusController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000FFD")]
	internal void SwitchFocusOnEvent(Focusable currentFocusable, EventBase e) { }

	[Address(RVA = "0x1C68930", Offset = "0x1C67B30", Length = "0x11C")]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001002")]
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

