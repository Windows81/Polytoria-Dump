namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B9")]
public class ProceduralSkyProxy : SkyBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001003")]
	private readonly ProceduralSky proceduralSky; //Field offset: 0x20

	[Token(Token = "0x17000C37")]
	public float AtmosphereThickness
	{
		[Address(RVA = "0x4A8420", Offset = "0x4A7620", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028AA")]
		 get { } //Length: 31
		[Address(RVA = "0x4A84C0", Offset = "0x4A76C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralSky), Member = "set_AtmosphereThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028AB")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C3A")]
	public float Exposure
	{
		[Address(RVA = "0x4A4200", Offset = "0x4A3400", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60028B0")]
		 get { } //Length: 31
		[Address(RVA = "0x4A84E0", Offset = "0x4A76E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralSky), Member = "set_Exposure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028B1")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C39")]
	public Color GroundColor
	{
		[Address(RVA = "0x4A8440", Offset = "0x4A7640", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028AE")]
		 get { } //Length: 36
		[Address(RVA = "0x4A8500", Offset = "0x4A7700", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralSky), Member = "set_GroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028AF")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C38")]
	public Color SkyTint
	{
		[Address(RVA = "0x4A8470", Offset = "0x4A7670", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028AC")]
		 get { } //Length: 36
		[Address(RVA = "0x4A8530", Offset = "0x4A7730", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralSky), Member = "set_SkyTint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028AD")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C35")]
	public float SunSize
	{
		[Address(RVA = "0x4A6350", Offset = "0x4A5550", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60028A6")]
		 get { } //Length: 31
		[Address(RVA = "0x4A8580", Offset = "0x4A7780", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralSky), Member = "set_SunSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028A7")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C36")]
	public float SunSizeConvergence
	{
		[Address(RVA = "0x4A84A0", Offset = "0x4A76A0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028A8")]
		 get { } //Length: 31
		[Address(RVA = "0x4A8560", Offset = "0x4A7760", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralSky), Member = "set_SunSizeConvergence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028A9")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028A5")]
	public ProceduralSkyProxy(ProceduralSky target) { }

	[Address(RVA = "0x4A8420", Offset = "0x4A7620", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028AA")]
	public float get_AtmosphereThickness() { }

	[Address(RVA = "0x4A4200", Offset = "0x4A3400", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60028B0")]
	public float get_Exposure() { }

	[Address(RVA = "0x4A8440", Offset = "0x4A7640", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028AE")]
	public Color get_GroundColor() { }

	[Address(RVA = "0x4A8470", Offset = "0x4A7670", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028AC")]
	public Color get_SkyTint() { }

	[Address(RVA = "0x4A6350", Offset = "0x4A5550", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60028A6")]
	public float get_SunSize() { }

	[Address(RVA = "0x4A84A0", Offset = "0x4A76A0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028A8")]
	public float get_SunSizeConvergence() { }

	[Address(RVA = "0x4A84C0", Offset = "0x4A76C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralSky), Member = "set_AtmosphereThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028AB")]
	public void set_AtmosphereThickness(float value) { }

	[Address(RVA = "0x4A84E0", Offset = "0x4A76E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralSky), Member = "set_Exposure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028B1")]
	public void set_Exposure(float value) { }

	[Address(RVA = "0x4A8500", Offset = "0x4A7700", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralSky), Member = "set_GroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028AF")]
	public void set_GroundColor(Color value) { }

	[Address(RVA = "0x4A8530", Offset = "0x4A7730", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralSky), Member = "set_SkyTint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028AD")]
	public void set_SkyTint(Color value) { }

	[Address(RVA = "0x4A8580", Offset = "0x4A7780", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralSky), Member = "set_SunSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028A7")]
	public void set_SunSize(float value) { }

	[Address(RVA = "0x4A8560", Offset = "0x4A7760", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralSky), Member = "set_SunSizeConvergence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028A9")]
	public void set_SunSizeConvergence(float value) { }

}

