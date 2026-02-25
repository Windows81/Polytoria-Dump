namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIContent.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x200000C")]
public class GUIContent
{
	[Token(Token = "0x4000052")]
	private static readonly GUIContent s_Text; //Field offset: 0x0
	[Token(Token = "0x4000053")]
	private static readonly GUIContent s_Image; //Field offset: 0x8
	[Token(Token = "0x4000054")]
	private static readonly GUIContent s_TextImage; //Field offset: 0x10
	[Token(Token = "0x4000055")]
	internal static string k_ZeroWidthSpace; //Field offset: 0x18
	[Token(Token = "0x4000056")]
	public static GUIContent none; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400004D")]
	private string m_Text; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400004E")]
	private Texture m_Image; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400004F")]
	private string m_Tooltip; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000050")]
	private string m_TextWithWhitespace; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000051")]
	private Action OnTextChanged; //Field offset: 0x30

	[Token(Token = "0x14000001")]
	internal event Action OnTextChanged
	{
		[Address(RVA = "0x19A2940", Offset = "0x19A1B40", Length = "0x9E")]
		[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60000CF")]
		internal add { } //Length: 158
		[Address(RVA = "0x19A2A50", Offset = "0x19A1C50", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60000D0")]
		internal remove { } //Length: 158
	}

	[Token(Token = "0x17000033")]
	public Texture image
	{
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D6")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000031")]
	public string text
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D1")]
		 get { } //Length: 7
		[Address(RVA = "0x19A2B70", Offset = "0x19A1D70", Length = "0x60")]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000D2")]
		 set { } //Length: 96
	}

	[Token(Token = "0x17000032")]
	internal string textWithWhitespace
	{
		[Address(RVA = "0x19A29E0", Offset = "0x19A1BE0", Length = "0x6E")]
		[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60000D3")]
		internal get { } //Length: 110
		[Address(RVA = "0x19A2AF0", Offset = "0x19A1CF0", Length = "0x7B")]
		[CalledBy(Type = typeof(GUI), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIContent), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIContent))]
		[CalledBy(Type = typeof(GUIContent), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000D4")]
		internal set { } //Length: 123
	}

	[Token(Token = "0x17000034")]
	public string tooltip
	{
		[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
		[CallerCount(Count = 69)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D7")]
		 get { } //Length: 7
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D8")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x19A2290", Offset = "0x19A1490", Length = "0x31B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E0")]
	private static GUIContent() { }

	[Address(RVA = "0x19A26B0", Offset = "0x19A18B0", Length = "0x104")]
	[CalledBy(Type = typeof(GUIWordWrapSizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUIContent), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DC")]
	public GUIContent(GUIContent src) { }

	[Address(RVA = "0x19A25B0", Offset = "0x19A17B0", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DB")]
	public GUIContent(string text, Texture image, string tooltip) { }

	[Address(RVA = "0x19A2840", Offset = "0x19A1A40", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DA")]
	public GUIContent(string text) { }

	[Address(RVA = "0x19A27C0", Offset = "0x19A19C0", Length = "0x72")]
	[CalledBy(Type = typeof(GUIContent), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000D9")]
	public GUIContent() { }

	[Address(RVA = "0x19A2940", Offset = "0x19A1B40", Length = "0x9E")]
	[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60000CF")]
	internal void add_OnTextChanged(Action value) { }

	[Address(RVA = "0x19A1F60", Offset = "0x19A1160", Length = "0x1D6")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "EndContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = "EndGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void ClearStaticCache() { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D1")]
	public string get_text() { }

	[Address(RVA = "0x19A29E0", Offset = "0x19A1BE0", Length = "0x6E")]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000D3")]
	internal string get_textWithWhitespace() { }

	[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
	[CallerCount(Count = 69)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D7")]
	public string get_tooltip() { }

	[Address(RVA = "0x19A2A50", Offset = "0x19A1C50", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60000D0")]
	internal void remove_OnTextChanged(Action value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D6")]
	public void set_image(Texture value) { }

	[Address(RVA = "0x19A2B70", Offset = "0x19A1D70", Length = "0x60")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D2")]
	public void set_text(string value) { }

	[Address(RVA = "0x19A2AF0", Offset = "0x19A1CF0", Length = "0x7B")]
	[CalledBy(Type = typeof(GUI), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIContent))]
	[CalledBy(Type = typeof(GUIContent), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000D4")]
	internal void set_textWithWhitespace(string value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D8")]
	public void set_tooltip(string value) { }

	[Address(RVA = "0x19A2140", Offset = "0x19A1340", Length = "0x35")]
	[CalledBy(Type = typeof(TextEditor), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnTextChangedHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnContentTextChangedHandle", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000D5")]
	internal void SetTextWithoutNotify(string value) { }

	[Address(RVA = "0x19A2180", Offset = "0x19A1380", Length = "0xD4")]
	[CalledBy(Type = typeof(GUILayout), Member = "PasswordField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(int), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "PasswordField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string), typeof(char), typeof(int), typeof(GUIStyle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GUILayout), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayout), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayout), Member = "Button", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GUILayout), Member = "PasswordField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(GUILayoutOption[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GUILayout), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GUILayout), Member = "HorizontalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUILayoutOption[])}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUILayout), Member = "HorizontalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUILayout), Member = "Window", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Rect), typeof(WindowFunction), typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000DD")]
	internal static GUIContent Temp(string t) { }

	[Address(RVA = "0x19A2260", Offset = "0x19A1460", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x60000DF")]
	public virtual string ToString() { }

}

