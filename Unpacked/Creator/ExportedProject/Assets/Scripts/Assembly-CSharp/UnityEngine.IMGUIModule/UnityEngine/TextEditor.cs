namespace UnityEngine;

[Token(Token = "0x2000031")]
public class TextEditor
{
	[Token(Token = "0x2000032")]
	internal enum DblClickSnapping
	{
		WORDS = 0,
		PARAGRAPHS = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015B")]
	private readonly GUIContent m_Content; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400015C")]
	private TextSelectingUtilities m_TextSelecting; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015D")]
	internal TextEditingUtilities m_TextEditing; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400015E")]
	internal IMGUITextHandle m_TextHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400015F")]
	public TouchScreenKeyboard keyboardOnScreen; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000160")]
	public int controlID; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000161")]
	public GUIStyle style; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Obsolete("'hasHorizontalCursorPos' has been deprecated. Changes to this member will not be observed. Use 'hasHorizontalCursor' instead.", True)]
	[Token(Token = "0x4000162")]
	public bool hasHorizontalCursorPos; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000163")]
	public bool isPasswordField; //Field offset: 0x49
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000164")]
	public Vector2 scrollOffset; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000165")]
	private bool focus; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000166")]
	private string m_TextWithWhitespace; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000167")]
	private Rect <position>k__BackingField; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000168")]
	public Vector2 graphicalCursorPos; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000169")]
	private Vector2 lastCursorPos; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400016A")]
	private Vector2 previousContentSize; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400016B")]
	private string oldText; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400016C")]
	private int oldPos; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400016D")]
	private int oldSelectPos; //Field offset: 0x94

	[Token(Token = "0x17000096")]
	public int cursorIndex
	{
		[Address(RVA = "0x19C8FC0", Offset = "0x19C81C0", Length = "0x68")]
		[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002C2")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000090")]
	public bool isMultiline
	{
		[Address(RVA = "0x19C9140", Offset = "0x19C8340", Length = "0x1A")]
		[CalledBy(Type = typeof(GUI), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002B8")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000092")]
	internal bool m_HasFocus
	{
		[Address(RVA = "0x19C9030", Offset = "0x19C8230", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002BA")]
		internal get { } //Length: 7
		[Address(RVA = "0x33C800", Offset = "0x33BA00", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002BB")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000095")]
	public Rect position
	{
		[Address(RVA = "0x3B2190", Offset = "0x3B1390", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C0")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2210", Offset = "0x3B1410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C1")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000097")]
	public int selectIndex
	{
		[Address(RVA = "0x19C9040", Offset = "0x19C8240", Length = "0x68")]
		[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002C3")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000091")]
	public bool showCursor
	{
		[Address(RVA = "0x19C90B0", Offset = "0x19C82B0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002B9")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000093")]
	public string text
	{
		[Address(RVA = "0x1676360", Offset = "0x1675560", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002BC")]
		 get { } //Length: 27
		[Address(RVA = "0x19C91E0", Offset = "0x19C83E0", Length = "0xB5")]
		[CalledBy(Type = typeof(GUI), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextEditor), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002BD")]
		 set { } //Length: 181
	}

	[Token(Token = "0x17000094")]
	internal string textWithWhitespace
	{
		[Address(RVA = "0x19C90D0", Offset = "0x19C82D0", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60002BE")]
		internal get { } //Length: 110
		[Address(RVA = "0x19C9160", Offset = "0x19C8360", Length = "0x7B")]
		[CalledBy(Type = typeof(TextEditor), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "OnTextChangedHandle", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "OnContentTextChangedHandle", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60002BF")]
		internal set { } //Length: 123
	}

	[Address(RVA = "0x19C8A20", Offset = "0x19C7C20", Length = "0x597")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[Calls(Type = typeof(GUIContent), Member = "add_OnTextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60002C4")]
	public TextEditor() { }

	[Address(RVA = "0x19C7250", Offset = "0x19C6450", Length = "0x1A")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D1")]
	public void DblClickSnap(DblClickSnapping snapping) { }

	[Address(RVA = "0x14BDFB0", Offset = "0x14BD1B0", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D9")]
	public void DetectFocusChange() { }

	[Address(RVA = "0x19C7270", Offset = "0x19C6470", Length = "0x4F9")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(GUIClip), Member = "UnclipToWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIStyle), Member = "set_Internal_clipOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "set_contentOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_contentOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIStyle), Member = "get_lineHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIContent), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextEditor), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUIStyle), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002D7")]
	public void DrawCursor(string newText) { }

	[Address(RVA = "0x19C8FC0", Offset = "0x19C81C0", Length = "0x68")]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002C2")]
	public int get_cursorIndex() { }

	[Address(RVA = "0x19C9030", Offset = "0x19C8230", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002BA")]
	internal bool get_m_HasFocus() { }

	[Address(RVA = "0x3B2190", Offset = "0x3B1390", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C0")]
	public Rect get_position() { }

	[Address(RVA = "0x19C9040", Offset = "0x19C8240", Length = "0x68")]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002C3")]
	public int get_selectIndex() { }

	[Address(RVA = "0x19C90B0", Offset = "0x19C82B0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002B9")]
	public bool get_showCursor() { }

	[Address(RVA = "0x1676360", Offset = "0x1675560", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002BC")]
	public string get_text() { }

	[Address(RVA = "0x19C90D0", Offset = "0x19C82D0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60002BE")]
	internal string get_textWithWhitespace() { }

	[Address(RVA = "0x19C7770", Offset = "0x19C6970", Length = "0x127")]
	[CalledBy(Type = typeof(TextEditor), Member = "MoveCursorToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "MoveCursorToPosition_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_preferredSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIStyle), Member = "get_lineHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "Internal_GetTextRectOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CF")]
	private Vector2 GetLocalCursorPosition(Vector2 cursorPosition) { }

	[Address(RVA = "0x19C78A0", Offset = "0x19C6AA0", Length = "0x23A")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextEditingUtilities), Member = "RestoreCursorState", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(Event), Member = "set_modifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C9")]
	public bool HandleKeyEvent(Event e) { }

	[Address(RVA = "0x19C7AE0", Offset = "0x19C6CE0", Length = "0x14C")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002CB")]
	public void Insert(char c) { }

	[Address(RVA = "0x19C7C30", Offset = "0x19C6E30", Length = "0x1E")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MouseDragSelectsWholeWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D0")]
	public void MouseDragSelectsWholeWords(bool on) { }

	[Address(RVA = "0x19C7D20", Offset = "0x19C6F20", Length = "0x109")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditor), Member = "GetLocalCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002CC")]
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	[Address(RVA = "0x19C7C50", Offset = "0x19C6E50", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEditor), Member = "GetLocalCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002CD")]
	protected private void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	[Address(RVA = "0x19C7E30", Offset = "0x19C7030", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002C6")]
	private void OnContentTextChangedHandle() { }

	[Address(RVA = "0x19C7F20", Offset = "0x19C7120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DB")]
	internal override void OnCursorIndexChange() { }

	[Address(RVA = "0x19C7F30", Offset = "0x19C7130", Length = "0x1B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60002DA")]
	internal override void OnDetectFocusChange() { }

	[Address(RVA = "0x19C80F0", Offset = "0x19C72F0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002C7")]
	public void OnFocus() { }

	[Address(RVA = "0x19C8190", Offset = "0x19C7390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002C8")]
	public void OnLostFocus() { }

	[Address(RVA = "0x19C7F20", Offset = "0x19C7120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DC")]
	internal override void OnSelectIndexChange() { }

	[Address(RVA = "0x19C81A0", Offset = "0x19C73A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C5")]
	private void OnTextChangedHandle() { }

	[Address(RVA = "0x19C8200", Offset = "0x19C7400", Length = "0x1E")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextEditingUtilities), Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CA")]
	public void ReplaceSelection(string replace) { }

	[Address(RVA = "0x19C8220", Offset = "0x19C7420", Length = "0xF7")]
	[CalledBy(Type = typeof(GUI), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002D8")]
	public void SaveBackup() { }

	[Address(RVA = "0x19C8320", Offset = "0x19C7520", Length = "0x1D")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D3")]
	public void SelectCurrentParagraph() { }

	[Address(RVA = "0x19C8340", Offset = "0x19C7540", Length = "0x1D")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D2")]
	public void SelectCurrentWord() { }

	[Address(RVA = "0x19C8360", Offset = "0x19C7560", Length = "0x2F")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextEditor), Member = "GetLocalCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CE")]
	public void SelectToPosition(Vector2 cursorPosition) { }

	[Address(RVA = "0x19C9140", Offset = "0x19C8340", Length = "0x1A")]
	[CalledBy(Type = typeof(GUI), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002B8")]
	public void set_isMultiline(bool value) { }

	[Address(RVA = "0x33C800", Offset = "0x33BA00", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002BB")]
	internal void set_m_HasFocus(bool value) { }

	[Address(RVA = "0x3B2210", Offset = "0x3B1410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C1")]
	public void set_position(Rect value) { }

	[Address(RVA = "0x19C91E0", Offset = "0x19C83E0", Length = "0xB5")]
	[CalledBy(Type = typeof(GUI), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002BD")]
	public void set_text(string value) { }

	[Address(RVA = "0x19C9160", Offset = "0x19C8360", Length = "0x7B")]
	[CalledBy(Type = typeof(TextEditor), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnTextChangedHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnContentTextChangedHandle", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60002BF")]
	internal void set_textWithWhitespace(string value) { }

	[Address(RVA = "0x19C83E0", Offset = "0x19C75E0", Length = "0x489")]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffsetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnCursorIndexChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnSelectIndexChange", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStyle), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIContent), Member = "get_textWithWhitespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(GUIStyle), Member = "get_lineHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D6")]
	[VisibleToOtherModules]
	internal void UpdateScrollOffset() { }

	[Address(RVA = "0x19C8390", Offset = "0x19C7590", Length = "0x4D")]
	[CalledBy(Type = typeof(GUI), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D4")]
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[Address(RVA = "0x19C8870", Offset = "0x19C7A70", Length = "0x1A7")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnTextChangedHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnContentTextChangedHandle", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D5")]
	internal void UpdateTextHandle() { }

}

