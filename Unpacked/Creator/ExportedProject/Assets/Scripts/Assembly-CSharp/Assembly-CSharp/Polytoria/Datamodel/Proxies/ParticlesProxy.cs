namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B2")]
public class ParticlesProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FFC")]
	private readonly Particles particles; //Field offset: 0x20

	[Token(Token = "0x17000BE0")]
	public NumberRange AngularVelocity
	{
		[Address(RVA = "0x4A6A70", Offset = "0x4A5C70", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027E4")]
		 get { } //Length: 47
		[Address(RVA = "0x4A6E00", Offset = "0x4A6000", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027E5")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BE1")]
	public bool Autoplay
	{
		[Address(RVA = "0x4A6AA0", Offset = "0x4A5CA0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027E6")]
		 get { } //Length: 30
		[Address(RVA = "0x4A6E20", Offset = "0x4A6020", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027E7")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BD6")]
	public ColorRange Color
	{
		[Address(RVA = "0x4A6AE0", Offset = "0x4A5CE0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D0")]
		 get { } //Length: 47
		[Address(RVA = "0x4A6E60", Offset = "0x4A6060", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D1")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000BD7")]
	public ParticleColorMode ColorMode
	{
		[Address(RVA = "0x4A6AC0", Offset = "0x4A5CC0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D2")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6E40", Offset = "0x4A6040", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_ColorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleColorMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D3")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BE3")]
	public float Duration
	{
		[Address(RVA = "0x4A6B10", Offset = "0x4A5D10", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027EA")]
		 get { } //Length: 31
		[Address(RVA = "0x4A6EA0", Offset = "0x4A60A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027EB")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BDB")]
	public int EmissionRate
	{
		[Address(RVA = "0x4A6B30", Offset = "0x4A5D30", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027DA")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6EC0", Offset = "0x4A60C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_EmissionRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027DB")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BDD")]
	public float Gravity
	{
		[Address(RVA = "0x4A6B50", Offset = "0x4A5D50", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027DE")]
		 get { } //Length: 31
		[Address(RVA = "0x4A6EE0", Offset = "0x4A60E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027DF")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BD4")]
	public string ImageID
	{
		[Address(RVA = "0x4A6B70", Offset = "0x4A5D70", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027CC")]
		 get { } //Length: 30
		[Address(RVA = "0x4A6F00", Offset = "0x4A6100", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027CD")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BD5")]
	public ImageType ImageType
	{
		[Address(RVA = "0x4A6B90", Offset = "0x4A5D90", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60027CE")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6F20", Offset = "0x4A6120", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027CF")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BE9")]
	public bool IsPaused
	{
		[Address(RVA = "0x4A6BB0", Offset = "0x4A5DB0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "get_IsPaused", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F5")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BE8")]
	public bool IsPlaying
	{
		[Address(RVA = "0x4A6BD0", Offset = "0x4A5DD0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "get_IsPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F4")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BEA")]
	public bool IsStopped
	{
		[Address(RVA = "0x4A6BF0", Offset = "0x4A5DF0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "get_IsStopped", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F6")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BD8")]
	public NumberRange Lifetime
	{
		[Address(RVA = "0x4A6C10", Offset = "0x4A5E10", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D4")]
		 get { } //Length: 47
		[Address(RVA = "0x4A6F40", Offset = "0x4A6140", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_Lifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D5")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BE2")]
	public bool Loop
	{
		[Address(RVA = "0x4A6C40", Offset = "0x4A5E40", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027E8")]
		 get { } //Length: 30
		[Address(RVA = "0x4A6F60", Offset = "0x4A6160", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027E9")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BDC")]
	public int MaxParticles
	{
		[Address(RVA = "0x4A6C60", Offset = "0x4A5E60", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027DC")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6F80", Offset = "0x4A6180", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_MaxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027DD")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BEB")]
	public int ParticleCount
	{
		[Address(RVA = "0x4A6C80", Offset = "0x4A5E80", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "get_ParticleCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F7")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BE4")]
	public ParticleShape Shape
	{
		[Address(RVA = "0x4A6D10", Offset = "0x4A5F10", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027EC")]
		 get { } //Length: 29
		[Address(RVA = "0x4A7020", Offset = "0x4A6220", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleShape)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027ED")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BE6")]
	public float ShapeAngle
	{
		[Address(RVA = "0x4A6CA0", Offset = "0x4A5EA0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F0")]
		 get { } //Length: 31
		[Address(RVA = "0x4A6FA0", Offset = "0x4A61A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_ShapeAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F1")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BE5")]
	public float ShapeRadius
	{
		[Address(RVA = "0x4A6CC0", Offset = "0x4A5EC0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027EE")]
		 get { } //Length: 31
		[Address(RVA = "0x4A6FC0", Offset = "0x4A61C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_ShapeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027EF")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BE7")]
	public Vector3 ShapeScale
	{
		[Address(RVA = "0x4A6CE0", Offset = "0x4A5EE0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F2")]
		 get { } //Length: 47
		[Address(RVA = "0x4A6FE0", Offset = "0x4A61E0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_ShapeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F3")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000BDE")]
	public ParticleSimulationSpace SimulationSpace
	{
		[Address(RVA = "0x4A5F10", Offset = "0x4A5110", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60027E0")]
		 get { } //Length: 29
		[Address(RVA = "0x4A7040", Offset = "0x4A6240", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_SimulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSimulationSpace)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027E1")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BD9")]
	public NumberRange SizeOverLifetime
	{
		[Address(RVA = "0x4A6D30", Offset = "0x4A5F30", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D6")]
		 get { } //Length: 47
		[Address(RVA = "0x4A7060", Offset = "0x4A6260", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D7")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BDA")]
	public NumberRange Speed
	{
		[Address(RVA = "0x4A6D60", Offset = "0x4A5F60", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D8")]
		 get { } //Length: 47
		[Address(RVA = "0x4A7080", Offset = "0x4A6280", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_Speed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D9")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BDF")]
	public NumberRange StartRotation
	{
		[Address(RVA = "0x4A6D90", Offset = "0x4A5F90", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027E2")]
		 get { } //Length: 47
		[Address(RVA = "0x4A70A0", Offset = "0x4A62A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "set_StartRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027E3")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BEC")]
	public float Time
	{
		[Address(RVA = "0x4A6DC0", Offset = "0x4A5FC0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "get_Time", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F8")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BED")]
	public float TotalTime
	{
		[Address(RVA = "0x4A6DE0", Offset = "0x4A5FE0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Particles), Member = "get_TotalTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027F9")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60027CB")]
	public ParticlesProxy(Particles target) { }

	[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027FD")]
	public void Clear() { }

	[Address(RVA = "0x4A69D0", Offset = "0x4A5BD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027FE")]
	public void Emit(int count) { }

	[Address(RVA = "0x4A6A70", Offset = "0x4A5C70", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E4")]
	public NumberRange get_AngularVelocity() { }

	[Address(RVA = "0x4A6AA0", Offset = "0x4A5CA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E6")]
	public bool get_Autoplay() { }

	[Address(RVA = "0x4A6AE0", Offset = "0x4A5CE0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D0")]
	public ColorRange get_Color() { }

	[Address(RVA = "0x4A6AC0", Offset = "0x4A5CC0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D2")]
	public ParticleColorMode get_ColorMode() { }

	[Address(RVA = "0x4A6B10", Offset = "0x4A5D10", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027EA")]
	public float get_Duration() { }

	[Address(RVA = "0x4A6B30", Offset = "0x4A5D30", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027DA")]
	public int get_EmissionRate() { }

	[Address(RVA = "0x4A6B50", Offset = "0x4A5D50", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027DE")]
	public float get_Gravity() { }

	[Address(RVA = "0x4A6B70", Offset = "0x4A5D70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027CC")]
	public string get_ImageID() { }

	[Address(RVA = "0x4A6B90", Offset = "0x4A5D90", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60027CE")]
	public ImageType get_ImageType() { }

	[Address(RVA = "0x4A6BB0", Offset = "0x4A5DB0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "get_IsPaused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F5")]
	public bool get_IsPaused() { }

	[Address(RVA = "0x4A6BD0", Offset = "0x4A5DD0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "get_IsPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F4")]
	public bool get_IsPlaying() { }

	[Address(RVA = "0x4A6BF0", Offset = "0x4A5DF0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "get_IsStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F6")]
	public bool get_IsStopped() { }

	[Address(RVA = "0x4A6C10", Offset = "0x4A5E10", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D4")]
	public NumberRange get_Lifetime() { }

	[Address(RVA = "0x4A6C40", Offset = "0x4A5E40", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E8")]
	public bool get_Loop() { }

	[Address(RVA = "0x4A6C60", Offset = "0x4A5E60", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027DC")]
	public int get_MaxParticles() { }

	[Address(RVA = "0x4A6C80", Offset = "0x4A5E80", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "get_ParticleCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F7")]
	public int get_ParticleCount() { }

	[Address(RVA = "0x4A6D10", Offset = "0x4A5F10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027EC")]
	public ParticleShape get_Shape() { }

	[Address(RVA = "0x4A6CA0", Offset = "0x4A5EA0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F0")]
	public float get_ShapeAngle() { }

	[Address(RVA = "0x4A6CC0", Offset = "0x4A5EC0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027EE")]
	public float get_ShapeRadius() { }

	[Address(RVA = "0x4A6CE0", Offset = "0x4A5EE0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F2")]
	public Vector3 get_ShapeScale() { }

	[Address(RVA = "0x4A5F10", Offset = "0x4A5110", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60027E0")]
	public ParticleSimulationSpace get_SimulationSpace() { }

	[Address(RVA = "0x4A6D30", Offset = "0x4A5F30", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D6")]
	public NumberRange get_SizeOverLifetime() { }

	[Address(RVA = "0x4A6D60", Offset = "0x4A5F60", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D8")]
	public NumberRange get_Speed() { }

	[Address(RVA = "0x4A6D90", Offset = "0x4A5F90", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E2")]
	public NumberRange get_StartRotation() { }

	[Address(RVA = "0x4A6DC0", Offset = "0x4A5FC0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "get_Time", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F8")]
	public float get_Time() { }

	[Address(RVA = "0x4A6DE0", Offset = "0x4A5FE0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "get_TotalTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F9")]
	public float get_TotalTime() { }

	[Address(RVA = "0x4A69F0", Offset = "0x4A5BF0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "Pause", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027FB")]
	public void Pause() { }

	[Address(RVA = "0x4A6A10", Offset = "0x4A5C10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "Play", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027FA")]
	public void Play() { }

	[Address(RVA = "0x4A6E00", Offset = "0x4A6000", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E5")]
	public void set_AngularVelocity(NumberRange value) { }

	[Address(RVA = "0x4A6E20", Offset = "0x4A6020", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E7")]
	public void set_Autoplay(bool value) { }

	[Address(RVA = "0x4A6E60", Offset = "0x4A6060", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D1")]
	public void set_Color(ColorRange value) { }

	[Address(RVA = "0x4A6E40", Offset = "0x4A6040", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_ColorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleColorMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D3")]
	public void set_ColorMode(ParticleColorMode value) { }

	[Address(RVA = "0x4A6EA0", Offset = "0x4A60A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027EB")]
	public void set_Duration(float value) { }

	[Address(RVA = "0x4A6EC0", Offset = "0x4A60C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_EmissionRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027DB")]
	public void set_EmissionRate(int value) { }

	[Address(RVA = "0x4A6EE0", Offset = "0x4A60E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027DF")]
	public void set_Gravity(float value) { }

	[Address(RVA = "0x4A6F00", Offset = "0x4A6100", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027CD")]
	public void set_ImageID(string value) { }

	[Address(RVA = "0x4A6F20", Offset = "0x4A6120", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027CF")]
	public void set_ImageType(ImageType value) { }

	[Address(RVA = "0x4A6F40", Offset = "0x4A6140", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_Lifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D5")]
	public void set_Lifetime(NumberRange value) { }

	[Address(RVA = "0x4A6F60", Offset = "0x4A6160", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E9")]
	public void set_Loop(bool value) { }

	[Address(RVA = "0x4A6F80", Offset = "0x4A6180", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_MaxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027DD")]
	public void set_MaxParticles(int value) { }

	[Address(RVA = "0x4A7020", Offset = "0x4A6220", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleShape)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027ED")]
	public void set_Shape(ParticleShape value) { }

	[Address(RVA = "0x4A6FA0", Offset = "0x4A61A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_ShapeAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F1")]
	public void set_ShapeAngle(float value) { }

	[Address(RVA = "0x4A6FC0", Offset = "0x4A61C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_ShapeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027EF")]
	public void set_ShapeRadius(float value) { }

	[Address(RVA = "0x4A6FE0", Offset = "0x4A61E0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_ShapeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F3")]
	public void set_ShapeScale(Vector3 value) { }

	[Address(RVA = "0x4A7040", Offset = "0x4A6240", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_SimulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSimulationSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E1")]
	public void set_SimulationSpace(ParticleSimulationSpace value) { }

	[Address(RVA = "0x4A7060", Offset = "0x4A6260", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D7")]
	public void set_SizeOverLifetime(NumberRange value) { }

	[Address(RVA = "0x4A7080", Offset = "0x4A6280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_Speed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D9")]
	public void set_Speed(NumberRange value) { }

	[Address(RVA = "0x4A70A0", Offset = "0x4A62A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_StartRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E3")]
	public void set_StartRotation(NumberRange value) { }

	[Address(RVA = "0x4A6A30", Offset = "0x4A5C30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "Simulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027FF")]
	public void Simulate(float time) { }

	[Address(RVA = "0x4A6A50", Offset = "0x4A5C50", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027FC")]
	public void Stop() { }

}

