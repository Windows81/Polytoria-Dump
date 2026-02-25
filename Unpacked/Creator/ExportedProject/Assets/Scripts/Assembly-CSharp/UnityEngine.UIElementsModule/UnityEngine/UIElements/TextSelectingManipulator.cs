namespace UnityEngine.UIElements;

[Token(Token = "0x2000483")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TextSelectingManipulator
{
	[Token(Token = "0x4000F63")]
	private const int k_DragThresholdSqr = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F5D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextSelectingUtilities m_SelectingUtilities; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F5E")]
	private bool selectAllOnMouseUp; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F5F")]
	private TextElement m_TextElement; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F60")]
	private Vector2 m_ClickStartPosition; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F61")]
	private bool m_Dragged; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000F62")]
	private bool m_IsClicking; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000F64")]
	private int m_ConsecutiveMouseDownCount; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F65")]
	private long m_LastMouseDownTimeStamp; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F66")]
	private readonly Event m_ImguiEvent; //Field offset: 0x40

	[Token(Token = "0x17000926")]
	internal int cursorIndex
	{
		[Address(RVA = "0x1B427E0", Offset = "0x1B419E0", Length = "0x16")]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_cursorIndex", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_cursorIndex", ReturnType = typeof(int))]
		[Token(Token = "0x6002245")]
		internal get { } //Length: 22
		[Address(RVA = "0x1B42820", Offset = "0x1B41A20", Length = "0x1E")]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_cursorIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002246")]
		internal set { } //Length: 30
	}

	[Token(Token = "0x17000925")]
	internal bool isClicking
	{
		[Address(RVA = "0x35C800", Offset = "0x35BA00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002242")]
		internal get { } //Length: 5
		[Address(RVA = "0x1B42840", Offset = "0x1B41A40", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002243")]
		private set { } //Length: 9
	}

	[Token(Token = "0x17000927")]
	internal int selectIndex
	{
		[Address(RVA = "0x1B42800", Offset = "0x1B41A00", Length = "0x16")]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_selectIndex", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_selectIndex", ReturnType = typeof(int))]
		[Token(Token = "0x6002247")]
		internal get { } //Length: 22
		[Address(RVA = "0x1B42850", Offset = "0x1B41A50", Length = "0x1E")]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_selectIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002248")]
		internal set { } //Length: 30
	}

	[Address(RVA = "0x1B424D0", Offset = "0x1B416D0", Length = "0x305")]
	[CalledBy(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002244")]
	public TextSelectingManipulator(TextElement textElement) { }

	[Address(RVA = "0x1B427E0", Offset = "0x1B419E0", Length = "0x16")]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_cursorIndex", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Token(Token = "0x6002245")]
	internal int get_cursorIndex() { }

	[Address(RVA = "0x35C800", Offset = "0x35BA00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002242")]
	internal bool get_isClicking() { }

	[Address(RVA = "0x1B42800", Offset = "0x1B41A00", Length = "0x16")]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_selectIndex", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_selectIndex", ReturnType = typeof(int))]
	[Token(Token = "0x6002247")]
	internal int get_selectIndex() { }

	[Address(RVA = "0x1B40FE0", Offset = "0x1B401E0", Length = "0x777")]
	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "OnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyDownEvent), Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "Copy", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600224F")]
	internal void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x1B41760", Offset = "0x1B40960", Length = "0x1D")]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600224E")]
	internal bool HasFocus() { }

	[Address(RVA = "0x1B41780", Offset = "0x1B40980", Length = "0x1D")]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.HasSelection", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600224D")]
	internal bool HasSelection() { }

	[Address(RVA = "0x1B417A0", Offset = "0x1B409A0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002258")]
	private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) { }

	[Address(RVA = "0x1B417E0", Offset = "0x1B409E0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002251")]
	private void OnBlurEvent() { }

	[Address(RVA = "0x1B41840", Offset = "0x1B40A40", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "set_selectedTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600224B")]
	private void OnCursorIndexChange() { }

	[Address(RVA = "0x1B41950", Offset = "0x1B40B50", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "Copy", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002257")]
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	[Address(RVA = "0x1B41A60", Offset = "0x1B40C60", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "OnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002250")]
	private void OnFocusEvent() { }

	[Address(RVA = "0x1B41BB0", Offset = "0x1B40DB0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyDownEvent), Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002252")]
	private void OnKeyDown(KeyDownEvent evt) { }

	[Address(RVA = "0x1B41C20", Offset = "0x1B40E20", Length = "0x37A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventBase`1), Member = "get_shiftKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "MouseDragSelectsWholeWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveCursorToPosition_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002253")]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[Address(RVA = "0x1B41FA0", Offset = "0x1B411A0", Length = "0x19F")]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002254")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x1B42140", Offset = "0x1B41340", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002255")]
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	[Address(RVA = "0x1B421F0", Offset = "0x1B413F0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002249")]
	private void OnRevealCursor() { }

	[Address(RVA = "0x1B42220", Offset = "0x1B41420", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "set_selectedTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600224A")]
	private void OnSelectIndexChange() { }

	[Address(RVA = "0x1B42330", Offset = "0x1B41530", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6002256")]
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	[Address(RVA = "0x1B424B0", Offset = "0x1B416B0", Length = "0x1B")]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600224C")]
	internal bool RevealCursor() { }

	[Address(RVA = "0x1B42820", Offset = "0x1B41A20", Length = "0x1E")]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_cursorIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002246")]
	internal void set_cursorIndex(int value) { }

	[Address(RVA = "0x1B42840", Offset = "0x1B41A40", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002243")]
	private void set_isClicking(bool value) { }

	[Address(RVA = "0x1B42850", Offset = "0x1B41A50", Length = "0x1E")]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_selectIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002248")]
	internal void set_selectIndex(int value) { }

}

