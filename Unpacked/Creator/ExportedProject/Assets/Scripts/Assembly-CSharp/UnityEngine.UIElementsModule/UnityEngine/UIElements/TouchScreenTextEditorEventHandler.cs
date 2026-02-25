namespace UnityEngine.UIElements;

[Token(Token = "0x20000F0")]
internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40004B9")]
	private static long <Frame>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40004BA")]
	private static TouchScreenKeyboard <activeTouchScreenKeyboard>k__BackingField; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B6")]
	private IVisualElementScheduledItem m_TouchKeyboardPoller; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004B7")]
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40004B8")]
	private bool m_IsClicking; //Field offset: 0x29

	[Token(Token = "0x17000134")]
	private static TouchScreenKeyboard activeTouchScreenKeyboard
	{
		[Address(RVA = "0x1C155F0", Offset = "0x1C147F0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x600078F")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000133")]
	internal static long Frame
	{
		[Address(RVA = "0x1C15570", Offset = "0x1C14770", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x600078D")]
		internal get { } //Length: 54
		[Address(RVA = "0x1C155B0", Offset = "0x1C147B0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x600078E")]
		private set { } //Length: 60
	}

	[Address(RVA = "0x1C15500", Offset = "0x1C14700", Length = "0x6A")]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "InitTextEditorEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000790")]
	public TouchScreenTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	[Address(RVA = "0x1C13F10", Offset = "0x1C13110", Length = "0xEB")]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OnFocusOutEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusOutEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_hideInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000794")]
	private void CloseTouchScreenKeyboard() { }

	[Address(RVA = "0x1C14000", Offset = "0x1C13200", Length = "0x5CB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canGetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(Status))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "Update", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000792")]
	private void DoPollTouchScreenKeyboard() { }

	[Address(RVA = "0x1C15570", Offset = "0x1C14770", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x600078D")]
	internal static long get_Frame() { }

	[Address(RVA = "0x1C145D0", Offset = "0x1C137D0", Length = "0x3B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "PollTouchScreenKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000796")]
	public virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x1C14990", Offset = "0x1C13B90", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "PollTouchScreenKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000799")]
	private void OnFocusInEvent() { }

	[Address(RVA = "0x1C14A80", Offset = "0x1C13C80", Length = "0x281")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600079A")]
	private void OnFocusOutEvent(FocusOutEvent evt) { }

	[Address(RVA = "0x1C14D10", Offset = "0x1C13F10", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000797")]
	private void OnPointerDownEvent() { }

	[Address(RVA = "0x1C14E50", Offset = "0x1C14050", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000798")]
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	[Address(RVA = "0x1C14E80", Offset = "0x1C14080", Length = "0x308")]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_hideInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(TouchScreenKeyboard))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000795")]
	private void OpenTouchScreenKeyboard() { }

	[Address(RVA = "0x1C15190", Offset = "0x1C14390", Length = "0x218")]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000791")]
	private void PollTouchScreenKeyboard() { }

	[Address(RVA = "0x1C155F0", Offset = "0x1C147F0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x600078F")]
	private static void set_activeTouchScreenKeyboard(TouchScreenKeyboard value) { }

	[Address(RVA = "0x1C155B0", Offset = "0x1C147B0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x600078E")]
	private static void set_Frame(long value) { }

	[Address(RVA = "0x1C153B0", Offset = "0x1C145B0", Length = "0x145")]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_selection", ReturnType = typeof(RangeInt))]
	[Calls(Type = typeof(RangeInt), Member = "get_end", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000793")]
	private void UpdateStringPositionFromKeyboard() { }

}

