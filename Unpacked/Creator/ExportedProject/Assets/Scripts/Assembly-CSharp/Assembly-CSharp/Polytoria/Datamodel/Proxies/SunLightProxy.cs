namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C3")]
public class SunLightProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400100D")]
	private readonly SunLight sunLight; //Field offset: 0x20

	[Token(Token = "0x17000C54")]
	public float Brightness
	{
		[Address(RVA = "0x4ACDB0", Offset = "0x4ABFB0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028F0")]
		 get { } //Length: 31
		[Address(RVA = "0x4ACE20", Offset = "0x4AC020", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SunLight), Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028F1")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C55")]
	public Color Color
	{
		[Address(RVA = "0x4ACDD0", Offset = "0x4ABFD0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028F2")]
		 get { } //Length: 36
		[Address(RVA = "0x4ACE40", Offset = "0x4AC040", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SunLight), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028F3")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C56")]
	public bool Shadows
	{
		[Address(RVA = "0x4ACE00", Offset = "0x4AC000", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028F4")]
		 get { } //Length: 30
		[Address(RVA = "0x4ACE70", Offset = "0x4AC070", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SunLight), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028F5")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028EF")]
	public SunLightProxy(SunLight target) { }

	[Address(RVA = "0x4ACDB0", Offset = "0x4ABFB0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028F0")]
	public float get_Brightness() { }

	[Address(RVA = "0x4ACDD0", Offset = "0x4ABFD0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028F2")]
	public Color get_Color() { }

	[Address(RVA = "0x4ACE00", Offset = "0x4AC000", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028F4")]
	public bool get_Shadows() { }

	[Address(RVA = "0x4ACE20", Offset = "0x4AC020", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SunLight), Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028F1")]
	public void set_Brightness(float value) { }

	[Address(RVA = "0x4ACE40", Offset = "0x4AC040", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SunLight), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028F3")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x4ACE70", Offset = "0x4AC070", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SunLight), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028F5")]
	public void set_Shadows(bool value) { }

}

