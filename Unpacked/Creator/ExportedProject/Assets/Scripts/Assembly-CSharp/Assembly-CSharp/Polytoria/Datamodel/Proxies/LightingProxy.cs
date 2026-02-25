namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003AA")]
public class LightingProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FF4")]
	private readonly Lighting lighting; //Field offset: 0x18

	[Token(Token = "0x17000BB4")]
	public Color AmbientColor
	{
		[Address(RVA = "0x4A58C0", Offset = "0x4A4AC0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Lighting), Member = "get_AmbientColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600277E")]
		 get { } //Length: 51
		[Address(RVA = "0x4A5980", Offset = "0x4A4B80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Lighting), Member = "set_AmbientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600277F")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000BB5")]
	public AmbientSource AmbientSource
	{
		[Address(RVA = "0x4A4000", Offset = "0x4A3200", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002780")]
		 get { } //Length: 29
		[Address(RVA = "0x4A59B0", Offset = "0x4A4BB0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Lighting), Member = "set_AmbientSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AmbientSource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002781")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BB6")]
	public bool Shadows
	{
		[Address(RVA = "0x4A5900", Offset = "0x4A4B00", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Lighting), Member = "get_Shadows", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002782")]
		 get { } //Length: 29
		[Address(RVA = "0x4A59D0", Offset = "0x4A4BD0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Lighting), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002783")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BB2")]
	public float SunBrightness
	{
		[Address(RVA = "0x4A5920", Offset = "0x4A4B20", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Lighting), Member = "get_SunBrightness", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600277A")]
		 get { } //Length: 29
		[Address(RVA = "0x4A59F0", Offset = "0x4A4BF0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Lighting), Member = "set_SunBrightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600277B")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BB3")]
	public Color SunColor
	{
		[Address(RVA = "0x4A5940", Offset = "0x4A4B40", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Lighting), Member = "get_SunColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600277C")]
		 get { } //Length: 51
		[Address(RVA = "0x4A5A10", Offset = "0x4A4C10", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Lighting), Member = "set_SunColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600277D")]
		 set { } //Length: 44
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002779")]
	public LightingProxy(Lighting target) { }

	[Address(RVA = "0x4A58C0", Offset = "0x4A4AC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lighting), Member = "get_AmbientColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600277E")]
	public Color get_AmbientColor() { }

	[Address(RVA = "0x4A4000", Offset = "0x4A3200", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002780")]
	public AmbientSource get_AmbientSource() { }

	[Address(RVA = "0x4A5900", Offset = "0x4A4B00", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lighting), Member = "get_Shadows", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002782")]
	public bool get_Shadows() { }

	[Address(RVA = "0x4A5920", Offset = "0x4A4B20", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lighting), Member = "get_SunBrightness", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600277A")]
	public float get_SunBrightness() { }

	[Address(RVA = "0x4A5940", Offset = "0x4A4B40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lighting), Member = "get_SunColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600277C")]
	public Color get_SunColor() { }

	[Address(RVA = "0x4A5980", Offset = "0x4A4B80", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lighting), Member = "set_AmbientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600277F")]
	public void set_AmbientColor(Color value) { }

	[Address(RVA = "0x4A59B0", Offset = "0x4A4BB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lighting), Member = "set_AmbientSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AmbientSource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002781")]
	public void set_AmbientSource(AmbientSource value) { }

	[Address(RVA = "0x4A59D0", Offset = "0x4A4BD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lighting), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002783")]
	public void set_Shadows(bool value) { }

	[Address(RVA = "0x4A59F0", Offset = "0x4A4BF0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lighting), Member = "set_SunBrightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600277B")]
	public void set_SunBrightness(float value) { }

	[Address(RVA = "0x4A5A10", Offset = "0x4A4C10", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lighting), Member = "set_SunColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600277D")]
	public void set_SunColor(Color value) { }

}

