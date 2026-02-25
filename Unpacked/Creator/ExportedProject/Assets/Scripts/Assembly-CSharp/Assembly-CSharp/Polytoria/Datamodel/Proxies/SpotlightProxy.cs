namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C1")]
public class SpotlightProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400100B")]
	private readonly Spotlight spotlight; //Field offset: 0x20

	[Token(Token = "0x17000C4F")]
	public float Angle
	{
		[Address(RVA = "0x4ACC00", Offset = "0x4ABE00", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "get_Angle", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028E4")]
		 get { } //Length: 29
		[Address(RVA = "0x4ACCC0", Offset = "0x4ABEC0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "set_Angle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028E5")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C50")]
	public float Brightness
	{
		[Address(RVA = "0x4ACC20", Offset = "0x4ABE20", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "get_Brightness", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028E6")]
		 get { } //Length: 29
		[Address(RVA = "0x4ACCE0", Offset = "0x4ABEE0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028E7")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C51")]
	public Color Color
	{
		[Address(RVA = "0x4ACC40", Offset = "0x4ABE40", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "get_Color", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028E8")]
		 get { } //Length: 51
		[Address(RVA = "0x4ACD00", Offset = "0x4ABF00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028E9")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C4E")]
	public float Range
	{
		[Address(RVA = "0x4ACC80", Offset = "0x4ABE80", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "get_Range", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028E2")]
		 get { } //Length: 29
		[Address(RVA = "0x4ACD30", Offset = "0x4ABF30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "set_Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028E3")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C52")]
	public bool Shadows
	{
		[Address(RVA = "0x4ACCA0", Offset = "0x4ABEA0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "get_Shadows", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028EA")]
		 get { } //Length: 29
		[Address(RVA = "0x4ACD50", Offset = "0x4ABF50", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Spotlight), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028EB")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028E1")]
	public SpotlightProxy(Spotlight target) { }

	[Address(RVA = "0x4ACC00", Offset = "0x4ABE00", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "get_Angle", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028E4")]
	public float get_Angle() { }

	[Address(RVA = "0x4ACC20", Offset = "0x4ABE20", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "get_Brightness", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028E6")]
	public float get_Brightness() { }

	[Address(RVA = "0x4ACC40", Offset = "0x4ABE40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "get_Color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028E8")]
	public Color get_Color() { }

	[Address(RVA = "0x4ACC80", Offset = "0x4ABE80", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "get_Range", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028E2")]
	public float get_Range() { }

	[Address(RVA = "0x4ACCA0", Offset = "0x4ABEA0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "get_Shadows", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028EA")]
	public bool get_Shadows() { }

	[Address(RVA = "0x4ACCC0", Offset = "0x4ABEC0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "set_Angle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028E5")]
	public void set_Angle(float value) { }

	[Address(RVA = "0x4ACCE0", Offset = "0x4ABEE0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028E7")]
	public void set_Brightness(float value) { }

	[Address(RVA = "0x4ACD00", Offset = "0x4ABF00", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028E9")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x4ACD30", Offset = "0x4ABF30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "set_Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028E3")]
	public void set_Range(float value) { }

	[Address(RVA = "0x4ACD50", Offset = "0x4ABF50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spotlight), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028EB")]
	public void set_Shadows(bool value) { }

}

