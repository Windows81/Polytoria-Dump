namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003CD")]
public class UITextInputProxy : UIViewProxy
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001017")]
	private readonly UITextInput uiTextInput; //Field offset: 0x28

	[Token(Token = "0x17000C90")]
	public bool AutoSize
	{
		[Address(RVA = "0x4B5F30", Offset = "0x4B5130", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600296C")]
		 get { } //Length: 30
		[Address(RVA = "0x4B6130", Offset = "0x4B5330", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600296D")]
		 set { } //Length: 30
	}

	[LuaEventParameter(typeof(string), "value", False)]
	[Token(Token = "0x17000C97")]
	public LuaEvent Changed
	{
		[Address(RVA = "0x4B5F50", Offset = "0x4B5150", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002979")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C91")]
	public TextFontPreset Font
	{
		[Address(RVA = "0x4B5F90", Offset = "0x4B5190", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600296E")]
		 get { } //Length: 29
		[Address(RVA = "0x4B6170", Offset = "0x4B5370", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600296F")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C8E")]
	public float FontSize
	{
		[Address(RVA = "0x4B5F70", Offset = "0x4B5170", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002968")]
		 get { } //Length: 31
		[Address(RVA = "0x4B6150", Offset = "0x4B5350", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002969")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C96")]
	public bool IsFocused
	{
		[Address(RVA = "0x4B5FB0", Offset = "0x4B51B0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "get_IsFocused", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002978")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000C94")]
	public bool IsMultiline
	{
		[Address(RVA = "0x4B5FD0", Offset = "0x4B51D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002974")]
		 get { } //Length: 30
		[Address(RVA = "0x4B6190", Offset = "0x4B5390", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_IsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002975")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C95")]
	public bool IsReadOnly
	{
		[Address(RVA = "0x4B5FF0", Offset = "0x4B51F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002976")]
		 get { } //Length: 30
		[Address(RVA = "0x4B61B0", Offset = "0x4B53B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002977")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C8C")]
	public TextJustify JustifyText
	{
		[Address(RVA = "0x4B6010", Offset = "0x4B5210", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002964")]
		 get { } //Length: 29
		[Address(RVA = "0x4B61D0", Offset = "0x4B53D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002965")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C8F")]
	public float MaxFontSize
	{
		[Address(RVA = "0x4B6030", Offset = "0x4B5230", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600296A")]
		 get { } //Length: 31
		[Address(RVA = "0x4B61F0", Offset = "0x4B53F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600296B")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C92")]
	public string Placeholder
	{
		[Address(RVA = "0x4B6080", Offset = "0x4B5280", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002970")]
		 get { } //Length: 30
		[Address(RVA = "0x4B6240", Offset = "0x4B5440", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_Placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002971")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C93")]
	public Color PlaceholderColor
	{
		[Address(RVA = "0x4B6050", Offset = "0x4B5250", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002972")]
		 get { } //Length: 36
		[Address(RVA = "0x4B6210", Offset = "0x4B5410", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_PlaceholderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002973")]
		 set { } //Length: 44
	}

	[LuaEventParameter(typeof(string), "value", False)]
	[Token(Token = "0x17000C98")]
	public LuaEvent Submitted
	{
		[Address(RVA = "0x4B60A0", Offset = "0x4B52A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600297A")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C8A")]
	public string Text
	{
		[Address(RVA = "0x4B60F0", Offset = "0x4B52F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "get_Text", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002960")]
		 get { } //Length: 29
		[Address(RVA = "0x4B6290", Offset = "0x4B5490", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002961")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C8B")]
	public Color TextColor
	{
		[Address(RVA = "0x4B60C0", Offset = "0x4B52C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002962")]
		 get { } //Length: 36
		[Address(RVA = "0x4B6260", Offset = "0x4B5460", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002963")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C8D")]
	public TextVerticalAlign VerticalAlign
	{
		[Address(RVA = "0x4B6110", Offset = "0x4B5310", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002966")]
		 get { } //Length: 29
		[Address(RVA = "0x4B62B0", Offset = "0x4B54B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITextInput), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002967")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A17F0", Offset = "0x4A09F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600295F")]
	public UITextInputProxy(UITextInput target) { }

	[Address(RVA = "0x4B5F10", Offset = "0x4B5110", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "Focus", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600297B")]
	public void Focus() { }

	[Address(RVA = "0x4B5F30", Offset = "0x4B5130", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600296C")]
	public bool get_AutoSize() { }

	[Address(RVA = "0x4B5F50", Offset = "0x4B5150", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002979")]
	public LuaEvent get_Changed() { }

	[Address(RVA = "0x4B5F90", Offset = "0x4B5190", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600296E")]
	public TextFontPreset get_Font() { }

	[Address(RVA = "0x4B5F70", Offset = "0x4B5170", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002968")]
	public float get_FontSize() { }

	[Address(RVA = "0x4B5FB0", Offset = "0x4B51B0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "get_IsFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002978")]
	public bool get_IsFocused() { }

	[Address(RVA = "0x4B5FD0", Offset = "0x4B51D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002974")]
	public bool get_IsMultiline() { }

	[Address(RVA = "0x4B5FF0", Offset = "0x4B51F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002976")]
	public bool get_IsReadOnly() { }

	[Address(RVA = "0x4B6010", Offset = "0x4B5210", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002964")]
	public TextJustify get_JustifyText() { }

	[Address(RVA = "0x4B6030", Offset = "0x4B5230", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600296A")]
	public float get_MaxFontSize() { }

	[Address(RVA = "0x4B6080", Offset = "0x4B5280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002970")]
	public string get_Placeholder() { }

	[Address(RVA = "0x4B6050", Offset = "0x4B5250", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002972")]
	public Color get_PlaceholderColor() { }

	[Address(RVA = "0x4B60A0", Offset = "0x4B52A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600297A")]
	public LuaEvent get_Submitted() { }

	[Address(RVA = "0x4B60F0", Offset = "0x4B52F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "get_Text", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002960")]
	public string get_Text() { }

	[Address(RVA = "0x4B60C0", Offset = "0x4B52C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002962")]
	public Color get_TextColor() { }

	[Address(RVA = "0x4B6110", Offset = "0x4B5310", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002966")]
	public TextVerticalAlign get_VerticalAlign() { }

	[Address(RVA = "0x4B6130", Offset = "0x4B5330", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600296D")]
	public void set_AutoSize(bool value) { }

	[Address(RVA = "0x4B6170", Offset = "0x4B5370", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600296F")]
	public void set_Font(TextFontPreset value) { }

	[Address(RVA = "0x4B6150", Offset = "0x4B5350", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002969")]
	public void set_FontSize(float value) { }

	[Address(RVA = "0x4B6190", Offset = "0x4B5390", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_IsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002975")]
	public void set_IsMultiline(bool value) { }

	[Address(RVA = "0x4B61B0", Offset = "0x4B53B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002977")]
	public void set_IsReadOnly(bool value) { }

	[Address(RVA = "0x4B61D0", Offset = "0x4B53D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002965")]
	public void set_JustifyText(TextJustify value) { }

	[Address(RVA = "0x4B61F0", Offset = "0x4B53F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600296B")]
	public void set_MaxFontSize(float value) { }

	[Address(RVA = "0x4B6240", Offset = "0x4B5440", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_Placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002971")]
	public void set_Placeholder(string value) { }

	[Address(RVA = "0x4B6210", Offset = "0x4B5410", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_PlaceholderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002973")]
	public void set_PlaceholderColor(Color value) { }

	[Address(RVA = "0x4B6290", Offset = "0x4B5490", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002961")]
	public void set_Text(string value) { }

	[Address(RVA = "0x4B6260", Offset = "0x4B5460", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002963")]
	public void set_TextColor(Color value) { }

	[Address(RVA = "0x4B62B0", Offset = "0x4B54B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002967")]
	public void set_VerticalAlign(TextVerticalAlign value) { }

}

