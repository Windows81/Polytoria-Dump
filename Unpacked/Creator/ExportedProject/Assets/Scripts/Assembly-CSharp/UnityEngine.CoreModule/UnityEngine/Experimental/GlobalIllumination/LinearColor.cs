namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x2000309")]
public struct LinearColor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A7")]
	private float m_red; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009A8")]
	private float m_green; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009A9")]
	private float m_blue; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009AA")]
	private float m_intensity; //Field offset: 0xC

	[Token(Token = "0x17000262")]
	public float blue
	{
		[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBA")]
		 get { } //Length: 8
		[Address(RVA = "0x1985140", Offset = "0x1984340", Length = "0xBA")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(LinearColor&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EBB")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000261")]
	public float green
	{
		[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB8")]
		 get { } //Length: 8
		[Address(RVA = "0x1985200", Offset = "0x1984400", Length = "0xBA")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(LinearColor&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EB9")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000260")]
	public float red
	{
		[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB6")]
		 get { } //Length: 7
		[Address(RVA = "0x19852C0", Offset = "0x19844C0", Length = "0xB9")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(LinearColor&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EB7")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x1984DB0", Offset = "0x1983FB0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EBD")]
	public static LinearColor Black() { }

	[Address(RVA = "0x1984DE0", Offset = "0x1983FE0", Length = "0x355")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(LinearColor))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EBC")]
	public static LinearColor Convert(Color color, float intensity) { }

	[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBA")]
	public float get_blue() { }

	[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB8")]
	public float get_green() { }

	[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB6")]
	public float get_red() { }

	[Address(RVA = "0x1985140", Offset = "0x1984340", Length = "0xBA")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(LinearColor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EBB")]
	public void set_blue(float value) { }

	[Address(RVA = "0x1985200", Offset = "0x1984400", Length = "0xBA")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(LinearColor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EB9")]
	public void set_green(float value) { }

	[Address(RVA = "0x19852C0", Offset = "0x19844C0", Length = "0xB9")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(LinearColor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EB7")]
	public void set_red(float value) { }

}

