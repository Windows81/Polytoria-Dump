namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003CF")]
public class UIViewProxy : UIFieldProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001019")]
	private readonly UIView uiView; //Field offset: 0x20

	[Token(Token = "0x17000C99")]
	public Color BorderColor
	{
		[Address(RVA = "0x4B62D0", Offset = "0x4B54D0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600297E")]
		 get { } //Length: 36
		[Address(RVA = "0x4B6370", Offset = "0x4B5570", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIView), Member = "set_BorderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600297F")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C9A")]
	public float BorderWidth
	{
		[Address(RVA = "0x4B6300", Offset = "0x4B5500", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002980")]
		 get { } //Length: 31
		[Address(RVA = "0x4B63A0", Offset = "0x4B55A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIView), Member = "set_BorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002981")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C9B")]
	public Color Color
	{
		[Address(RVA = "0x4B6320", Offset = "0x4B5520", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002982")]
		 get { } //Length: 36
		[Address(RVA = "0x4B63C0", Offset = "0x4B55C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIView), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002983")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C9C")]
	public float CornerRadius
	{
		[Address(RVA = "0x4B6350", Offset = "0x4B5550", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002984")]
		 get { } //Length: 31
		[Address(RVA = "0x4B63F0", Offset = "0x4B55F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIView), Member = "set_CornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002985")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600297D")]
	public UIViewProxy(UIView target) { }

	[Address(RVA = "0x4B62D0", Offset = "0x4B54D0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600297E")]
	public Color get_BorderColor() { }

	[Address(RVA = "0x4B6300", Offset = "0x4B5500", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002980")]
	public float get_BorderWidth() { }

	[Address(RVA = "0x4B6320", Offset = "0x4B5520", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002982")]
	public Color get_Color() { }

	[Address(RVA = "0x4B6350", Offset = "0x4B5550", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002984")]
	public float get_CornerRadius() { }

	[Address(RVA = "0x4B6370", Offset = "0x4B5570", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIView), Member = "set_BorderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600297F")]
	public void set_BorderColor(Color value) { }

	[Address(RVA = "0x4B63A0", Offset = "0x4B55A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIView), Member = "set_BorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002981")]
	public void set_BorderWidth(float value) { }

	[Address(RVA = "0x4B63C0", Offset = "0x4B55C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIView), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002983")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x4B63F0", Offset = "0x4B55F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIView), Member = "set_CornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002985")]
	public void set_CornerRadius(float value) { }

}

