namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C4")]
public class Text3DProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400100E")]
	private readonly Text3D text3D; //Field offset: 0x20

	[Token(Token = "0x17000C58")]
	public Color Color
	{
		[Address(RVA = "0x4ACE90", Offset = "0x4AC090", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "get_Color", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028F9")]
		 get { } //Length: 51
		[Address(RVA = "0x4ACF90", Offset = "0x4AC190", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028FA")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C5A")]
	public bool FaceCamera
	{
		[Address(RVA = "0x4ACED0", Offset = "0x4AC0D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028FD")]
		 get { } //Length: 30
		[Address(RVA = "0x4ACFC0", Offset = "0x4AC1C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028FE")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C5D")]
	public TextFontPreset Font
	{
		[Address(RVA = "0x4ACF10", Offset = "0x4AC110", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002903")]
		 get { } //Length: 29
		[Address(RVA = "0x4AD000", Offset = "0x4AC200", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002904")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C59")]
	public float FontSize
	{
		[Address(RVA = "0x4ACEF0", Offset = "0x4AC0F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "get_FontSize", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028FB")]
		 get { } //Length: 29
		[Address(RVA = "0x4ACFE0", Offset = "0x4AC1E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028FC")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C5B")]
	public HorizontalAlignmentOptions HorizontalAlignment
	{
		[Address(RVA = "0x4ACF30", Offset = "0x4AC130", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028FF")]
		 get { } //Length: 29
		[Address(RVA = "0x4AD020", Offset = "0x4AC220", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "set_HorizontalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalAlignmentOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002900")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C57")]
	public string Text
	{
		[Address(RVA = "0x4ACF50", Offset = "0x4AC150", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "get_Text", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028F7")]
		 get { } //Length: 29
		[Address(RVA = "0x4AD040", Offset = "0x4AC240", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028F8")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C5C")]
	public VerticalAlignmentOptions VerticalAlignment
	{
		[Address(RVA = "0x4ACF70", Offset = "0x4AC170", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002901")]
		 get { } //Length: 29
		[Address(RVA = "0x4AD060", Offset = "0x4AC260", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text3D), Member = "set_VerticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VerticalAlignmentOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002902")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028F6")]
	public Text3DProxy(Text3D target) { }

	[Address(RVA = "0x4ACE90", Offset = "0x4AC090", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "get_Color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028F9")]
	public Color get_Color() { }

	[Address(RVA = "0x4ACED0", Offset = "0x4AC0D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028FD")]
	public bool get_FaceCamera() { }

	[Address(RVA = "0x4ACF10", Offset = "0x4AC110", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002903")]
	public TextFontPreset get_Font() { }

	[Address(RVA = "0x4ACEF0", Offset = "0x4AC0F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "get_FontSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028FB")]
	public float get_FontSize() { }

	[Address(RVA = "0x4ACF30", Offset = "0x4AC130", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028FF")]
	public HorizontalAlignmentOptions get_HorizontalAlignment() { }

	[Address(RVA = "0x4ACF50", Offset = "0x4AC150", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "get_Text", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028F7")]
	public string get_Text() { }

	[Address(RVA = "0x4ACF70", Offset = "0x4AC170", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002901")]
	public VerticalAlignmentOptions get_VerticalAlignment() { }

	[Address(RVA = "0x4ACF90", Offset = "0x4AC190", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028FA")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x4ACFC0", Offset = "0x4AC1C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028FE")]
	public void set_FaceCamera(bool value) { }

	[Address(RVA = "0x4AD000", Offset = "0x4AC200", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002904")]
	public void set_Font(TextFontPreset value) { }

	[Address(RVA = "0x4ACFE0", Offset = "0x4AC1E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028FC")]
	public void set_FontSize(float value) { }

	[Address(RVA = "0x4AD020", Offset = "0x4AC220", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "set_HorizontalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002900")]
	public void set_HorizontalAlignment(HorizontalAlignmentOptions value) { }

	[Address(RVA = "0x4AD040", Offset = "0x4AC240", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028F8")]
	public void set_Text(string value) { }

	[Address(RVA = "0x4AD060", Offset = "0x4AC260", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text3D), Member = "set_VerticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VerticalAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002902")]
	public void set_VerticalAlignment(VerticalAlignmentOptions value) { }

}

