namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003A3")]
public class GradientSkyProxy : SkyBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FED")]
	private readonly GradientSky gradientSky; //Field offset: 0x20

	[Token(Token = "0x17000B95")]
	public Color HorizonLineColor
	{
		[Address(RVA = "0x4A40A0", Offset = "0x4A32A0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002738")]
		 get { } //Length: 36
		[Address(RVA = "0x4A4240", Offset = "0x4A3440", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002739")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000B97")]
	public float HorizonLineContribution
	{
		[Address(RVA = "0x4A40D0", Offset = "0x4A32D0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600273C")]
		 get { } //Length: 31
		[Address(RVA = "0x4A4270", Offset = "0x4A3470", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600273D")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B96")]
	public float HorizonLineExponent
	{
		[Address(RVA = "0x4A40F0", Offset = "0x4A32F0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600273A")]
		 get { } //Length: 31
		[Address(RVA = "0x4A4290", Offset = "0x4A3490", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600273B")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B99")]
	public Color SkyGradientBottom
	{
		[Address(RVA = "0x4A4110", Offset = "0x4A3310", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002740")]
		 get { } //Length: 36
		[Address(RVA = "0x4A42B0", Offset = "0x4A34B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002741")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000B9A")]
	public float SkyGradientExponent
	{
		[Address(RVA = "0x4A4140", Offset = "0x4A3340", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002742")]
		 get { } //Length: 31
		[Address(RVA = "0x4A42E0", Offset = "0x4A34E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002743")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B98")]
	public Color SkyGradientTop
	{
		[Address(RVA = "0x4A4160", Offset = "0x4A3360", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600273E")]
		 get { } //Length: 36
		[Address(RVA = "0x4A4300", Offset = "0x4A3500", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600273F")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000B8F")]
	public Color SunDiscColor
	{
		[Address(RVA = "0x4A18A0", Offset = "0x4A0AA0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600272C")]
		 get { } //Length: 36
		[Address(RVA = "0x4A4330", Offset = "0x4A3530", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_SunDiscColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600272D")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000B91")]
	public float SunDiscExponent
	{
		[Address(RVA = "0x4A4190", Offset = "0x4A3390", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002730")]
		 get { } //Length: 31
		[Address(RVA = "0x4A4360", Offset = "0x4A3560", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_SunDiscExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002731")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B90")]
	public float SunDiscMultiplier
	{
		[Address(RVA = "0x4A41B0", Offset = "0x4A33B0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600272E")]
		 get { } //Length: 31
		[Address(RVA = "0x4A4380", Offset = "0x4A3580", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_SunDiscMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600272F")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B92")]
	public Color SunHaloColor
	{
		[Address(RVA = "0x4A41D0", Offset = "0x4A33D0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002732")]
		 get { } //Length: 36
		[Address(RVA = "0x4A43A0", Offset = "0x4A35A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_SunHaloColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002733")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000B94")]
	public float SunHaloContribution
	{
		[Address(RVA = "0x4A4200", Offset = "0x4A3400", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002736")]
		 get { } //Length: 31
		[Address(RVA = "0x4A43D0", Offset = "0x4A35D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_SunHaloContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002737")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B93")]
	public float SunHaloExponent
	{
		[Address(RVA = "0x4A4220", Offset = "0x4A3420", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002734")]
		 get { } //Length: 31
		[Address(RVA = "0x4A43F0", Offset = "0x4A35F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GradientSky), Member = "set_SunHaloExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002735")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600272B")]
	public GradientSkyProxy(GradientSky target) { }

	[Address(RVA = "0x4A40A0", Offset = "0x4A32A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002738")]
	public Color get_HorizonLineColor() { }

	[Address(RVA = "0x4A40D0", Offset = "0x4A32D0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600273C")]
	public float get_HorizonLineContribution() { }

	[Address(RVA = "0x4A40F0", Offset = "0x4A32F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600273A")]
	public float get_HorizonLineExponent() { }

	[Address(RVA = "0x4A4110", Offset = "0x4A3310", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002740")]
	public Color get_SkyGradientBottom() { }

	[Address(RVA = "0x4A4140", Offset = "0x4A3340", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002742")]
	public float get_SkyGradientExponent() { }

	[Address(RVA = "0x4A4160", Offset = "0x4A3360", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600273E")]
	public Color get_SkyGradientTop() { }

	[Address(RVA = "0x4A18A0", Offset = "0x4A0AA0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600272C")]
	public Color get_SunDiscColor() { }

	[Address(RVA = "0x4A4190", Offset = "0x4A3390", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002730")]
	public float get_SunDiscExponent() { }

	[Address(RVA = "0x4A41B0", Offset = "0x4A33B0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600272E")]
	public float get_SunDiscMultiplier() { }

	[Address(RVA = "0x4A41D0", Offset = "0x4A33D0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002732")]
	public Color get_SunHaloColor() { }

	[Address(RVA = "0x4A4200", Offset = "0x4A3400", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002736")]
	public float get_SunHaloContribution() { }

	[Address(RVA = "0x4A4220", Offset = "0x4A3420", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002734")]
	public float get_SunHaloExponent() { }

	[Address(RVA = "0x4A4240", Offset = "0x4A3440", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002739")]
	public void set_HorizonLineColor(Color value) { }

	[Address(RVA = "0x4A4270", Offset = "0x4A3470", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600273D")]
	public void set_HorizonLineContribution(float value) { }

	[Address(RVA = "0x4A4290", Offset = "0x4A3490", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600273B")]
	public void set_HorizonLineExponent(float value) { }

	[Address(RVA = "0x4A42B0", Offset = "0x4A34B0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002741")]
	public void set_SkyGradientBottom(Color value) { }

	[Address(RVA = "0x4A42E0", Offset = "0x4A34E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002743")]
	public void set_SkyGradientExponent(float value) { }

	[Address(RVA = "0x4A4300", Offset = "0x4A3500", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600273F")]
	public void set_SkyGradientTop(Color value) { }

	[Address(RVA = "0x4A4330", Offset = "0x4A3530", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SunDiscColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600272D")]
	public void set_SunDiscColor(Color value) { }

	[Address(RVA = "0x4A4360", Offset = "0x4A3560", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SunDiscExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002731")]
	public void set_SunDiscExponent(float value) { }

	[Address(RVA = "0x4A4380", Offset = "0x4A3580", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SunDiscMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600272F")]
	public void set_SunDiscMultiplier(float value) { }

	[Address(RVA = "0x4A43A0", Offset = "0x4A35A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SunHaloColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002733")]
	public void set_SunHaloColor(Color value) { }

	[Address(RVA = "0x4A43D0", Offset = "0x4A35D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SunHaloContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002737")]
	public void set_SunHaloContribution(float value) { }

	[Address(RVA = "0x4A43F0", Offset = "0x4A35F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SunHaloExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002735")]
	public void set_SunHaloExponent(float value) { }

}

