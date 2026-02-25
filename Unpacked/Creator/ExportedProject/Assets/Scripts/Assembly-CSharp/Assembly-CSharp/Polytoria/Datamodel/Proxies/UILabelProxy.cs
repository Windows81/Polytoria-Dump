namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003CC")]
public class UILabelProxy : UIViewProxy
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001016")]
	private readonly UILabel uiLabel; //Field offset: 0x28

	[Token(Token = "0x17000C86")]
	public bool AutoSize
	{
		[Address(RVA = "0x4B5C50", Offset = "0x4B4E50", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002957")]
		 get { } //Length: 30
		[Address(RVA = "0x4B5DB0", Offset = "0x4B4FB0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002958")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C87")]
	public TextFontPreset Font
	{
		[Address(RVA = "0x4B5C90", Offset = "0x4B4E90", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002959")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5DF0", Offset = "0x4B4FF0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600295A")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C84")]
	public float FontSize
	{
		[Address(RVA = "0x4B5C70", Offset = "0x4B4E70", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002953")]
		 get { } //Length: 31
		[Address(RVA = "0x4B5DD0", Offset = "0x4B4FD0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002954")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C82")]
	public TextJustify JustifyText
	{
		[Address(RVA = "0x4B5CB0", Offset = "0x4B4EB0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600294F")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5E10", Offset = "0x4B5010", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002950")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C85")]
	public float MaxFontSize
	{
		[Address(RVA = "0x4B5CD0", Offset = "0x4B4ED0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002955")]
		 get { } //Length: 31
		[Address(RVA = "0x4B5E30", Offset = "0x4B5030", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002956")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C88")]
	public Color OutlineColor
	{
		[Address(RVA = "0x4B5CF0", Offset = "0x4B4EF0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600295B")]
		 get { } //Length: 36
		[Address(RVA = "0x4B5E50", Offset = "0x4B5050", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_OutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600295C")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C89")]
	public float OutlineWidth
	{
		[Address(RVA = "0x4B5D20", Offset = "0x4B4F20", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600295D")]
		 get { } //Length: 31
		[Address(RVA = "0x4B5E80", Offset = "0x4B5080", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_OutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600295E")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C80")]
	public string Text
	{
		[Address(RVA = "0x4B5D70", Offset = "0x4B4F70", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600294B")]
		 get { } //Length: 30
		[Address(RVA = "0x4B5ED0", Offset = "0x4B50D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600294C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C81")]
	public Color TextColor
	{
		[Address(RVA = "0x4B5D40", Offset = "0x4B4F40", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600294D")]
		 get { } //Length: 36
		[Address(RVA = "0x4B5EA0", Offset = "0x4B50A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600294E")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C83")]
	public TextVerticalAlign VerticalAlign
	{
		[Address(RVA = "0x4B5D90", Offset = "0x4B4F90", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002951")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5EF0", Offset = "0x4B50F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002952")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A17F0", Offset = "0x4A09F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600294A")]
	public UILabelProxy(UILabel target) { }

	[Address(RVA = "0x4B5C50", Offset = "0x4B4E50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002957")]
	public bool get_AutoSize() { }

	[Address(RVA = "0x4B5C90", Offset = "0x4B4E90", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002959")]
	public TextFontPreset get_Font() { }

	[Address(RVA = "0x4B5C70", Offset = "0x4B4E70", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002953")]
	public float get_FontSize() { }

	[Address(RVA = "0x4B5CB0", Offset = "0x4B4EB0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600294F")]
	public TextJustify get_JustifyText() { }

	[Address(RVA = "0x4B5CD0", Offset = "0x4B4ED0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002955")]
	public float get_MaxFontSize() { }

	[Address(RVA = "0x4B5CF0", Offset = "0x4B4EF0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600295B")]
	public Color get_OutlineColor() { }

	[Address(RVA = "0x4B5D20", Offset = "0x4B4F20", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600295D")]
	public float get_OutlineWidth() { }

	[Address(RVA = "0x4B5D70", Offset = "0x4B4F70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600294B")]
	public string get_Text() { }

	[Address(RVA = "0x4B5D40", Offset = "0x4B4F40", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600294D")]
	public Color get_TextColor() { }

	[Address(RVA = "0x4B5D90", Offset = "0x4B4F90", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002951")]
	public TextVerticalAlign get_VerticalAlign() { }

	[Address(RVA = "0x4B5DB0", Offset = "0x4B4FB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002958")]
	public void set_AutoSize(bool value) { }

	[Address(RVA = "0x4B5DF0", Offset = "0x4B4FF0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600295A")]
	public void set_Font(TextFontPreset value) { }

	[Address(RVA = "0x4B5DD0", Offset = "0x4B4FD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002954")]
	public void set_FontSize(float value) { }

	[Address(RVA = "0x4B5E10", Offset = "0x4B5010", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002950")]
	public void set_JustifyText(TextJustify value) { }

	[Address(RVA = "0x4B5E30", Offset = "0x4B5030", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002956")]
	public void set_MaxFontSize(float value) { }

	[Address(RVA = "0x4B5E50", Offset = "0x4B5050", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_OutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600295C")]
	public void set_OutlineColor(Color value) { }

	[Address(RVA = "0x4B5E80", Offset = "0x4B5080", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_OutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600295E")]
	public void set_OutlineWidth(float value) { }

	[Address(RVA = "0x4B5ED0", Offset = "0x4B50D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600294C")]
	public void set_Text(string value) { }

	[Address(RVA = "0x4B5EA0", Offset = "0x4B50A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600294E")]
	public void set_TextColor(Color value) { }

	[Address(RVA = "0x4B5EF0", Offset = "0x4B50F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002952")]
	public void set_VerticalAlign(TextVerticalAlign value) { }

}

