namespace UnityEngine.UIElements;

[Token(Token = "0x200047C")]
internal class TextEditingManipulator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EF8")]
	private readonly TextElement m_TextElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EF9")]
	private TextEditorEventHandler m_EditingEventHandler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EFA")]
	internal TextEditingUtilities editingUtilities; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EFB")]
	private bool m_TouchScreenTextFieldInitialized; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EFC")]
	private IVisualElementScheduledItem m_HardwareKeyboardPoller; //Field offset: 0x30

	[Token(Token = "0x170008E1")]
	internal TextEditorEventHandler editingEventHandler
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002185")]
		internal get { } //Length: 5
		[Address(RVA = "0x1B30120", Offset = "0x1B2F320", Length = "0x71")]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "InitTextEditorEventHandler", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6002186")]
		internal set { } //Length: 113
	}

	[Token(Token = "0x170008E2")]
	private bool touchScreenTextFieldChanged
	{
		[Address(RVA = "0x1B30080", Offset = "0x1B2F280", Length = "0x91")]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "<OnFocusInEvent>b__14_0", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002187")]
		private get { } //Length: 145
	}

	[Address(RVA = "0x1B2FF70", Offset = "0x1B2F170", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextSelectingUtilities", "UnityEngine.TextCore.Text.TextHandle", typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "InitTextEditorEventHandler", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002188")]
	public TextEditingManipulator(TextElement textElement) { }

	[Address(RVA = "0x1B2FF20", Offset = "0x1B2F120", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_touchScreenTextFieldChanged", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "InitTextEditorEventHandler", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600218E")]
	private void <OnFocusInEvent>b__14_0() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002185")]
	internal TextEditorEventHandler get_editingEventHandler() { }

	[Address(RVA = "0x1B30080", Offset = "0x1B2F280", Length = "0x91")]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "<OnFocusInEvent>b__14_0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002187")]
	private bool get_touchScreenTextFieldChanged() { }

	[Address(RVA = "0x1B2F8B0", Offset = "0x1B2EAB0", Length = "0x255")]
	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "OnBlur", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600218B")]
	internal void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x1B2FB10", Offset = "0x1B2ED10", Length = "0xC6")]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "<OnFocusInEvent>b__14_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.set_isReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyboardTextEditorEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), "UnityEngine.TextEditingUtilities"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), "UnityEngine.TextEditingUtilities"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "set_editingEventHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditorEventHandler)}, ReturnType = typeof(void))]
	[Token(Token = "0x600218A")]
	private void InitTextEditorEventHandler() { }

	[Address(RVA = "0x1B2FBE0", Offset = "0x1B2EDE0", Length = "0x261")]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(FocusController), Member = "set_selectedTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_touchScreenTextFieldChanged", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "InitTextEditorEventHandler", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600218C")]
	private void OnFocusInEvent() { }

	[Address(RVA = "0x1B2FE50", Offset = "0x1B2F050", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "OnBlur", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600218D")]
	private void OnFocusOutEvent() { }

	[Address(RVA = "0x1B2FEB0", Offset = "0x1B2F0B0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002189")]
	public void Reset() { }

	[Address(RVA = "0x1B30120", Offset = "0x1B2F320", Length = "0x71")]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "InitTextEditorEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002186")]
	internal void set_editingEventHandler(TextEditorEventHandler value) { }

}

