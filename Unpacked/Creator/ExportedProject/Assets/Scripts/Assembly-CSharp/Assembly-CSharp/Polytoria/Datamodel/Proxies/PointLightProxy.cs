namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B8")]
public class PointLightProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001002")]
	private readonly PointLight pointLight; //Field offset: 0x20

	[Token(Token = "0x17000C32")]
	public float Brightness
	{
		[Address(RVA = "0x4A82F0", Offset = "0x4A74F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PointLight), Member = "get_Brightness", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600289F")]
		 get { } //Length: 29
		[Address(RVA = "0x4A8390", Offset = "0x4A7590", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PointLight), Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028A0")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C33")]
	public Color Color
	{
		[Address(RVA = "0x4A8310", Offset = "0x4A7510", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PointLight), Member = "get_Color", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028A1")]
		 get { } //Length: 51
		[Address(RVA = "0x4A83B0", Offset = "0x4A75B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PointLight), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028A2")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C31")]
	public float Range
	{
		[Address(RVA = "0x4A8350", Offset = "0x4A7550", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PointLight), Member = "get_Range", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600289D")]
		 get { } //Length: 29
		[Address(RVA = "0x4A83E0", Offset = "0x4A75E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PointLight), Member = "set_Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600289E")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C34")]
	public bool Shadows
	{
		[Address(RVA = "0x4A8370", Offset = "0x4A7570", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PointLight), Member = "get_Shadows", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028A3")]
		 get { } //Length: 29
		[Address(RVA = "0x4A8400", Offset = "0x4A7600", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PointLight), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028A4")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600289C")]
	public PointLightProxy(PointLight target) { }

	[Address(RVA = "0x4A82F0", Offset = "0x4A74F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointLight), Member = "get_Brightness", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600289F")]
	public float get_Brightness() { }

	[Address(RVA = "0x4A8310", Offset = "0x4A7510", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointLight), Member = "get_Color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028A1")]
	public Color get_Color() { }

	[Address(RVA = "0x4A8350", Offset = "0x4A7550", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointLight), Member = "get_Range", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600289D")]
	public float get_Range() { }

	[Address(RVA = "0x4A8370", Offset = "0x4A7570", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointLight), Member = "get_Shadows", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028A3")]
	public bool get_Shadows() { }

	[Address(RVA = "0x4A8390", Offset = "0x4A7590", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointLight), Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028A0")]
	public void set_Brightness(float value) { }

	[Address(RVA = "0x4A83B0", Offset = "0x4A75B0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointLight), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028A2")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x4A83E0", Offset = "0x4A75E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointLight), Member = "set_Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600289E")]
	public void set_Range(float value) { }

	[Address(RVA = "0x4A8400", Offset = "0x4A7600", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointLight), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028A4")]
	public void set_Shadows(bool value) { }

}

