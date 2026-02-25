namespace Polytoria.Datamodel;

[Instantiatable]
[RequireComponent(typeof(ParticleSystem))]
[Token(Token = "0x2000340")]
public class Particles : DynamicInstance
{
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000D4D")]
	private ParticleSystem particles; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[SyncVar(hook = "OnImageIDChanged")]
	[Token(Token = "0x4000D4E")]
	private string imageID; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[SyncVar(hook = "OnImageTypeChanged")]
	[Token(Token = "0x4000D4F")]
	private ImageType imageType; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[SyncVar(hook = "OnColorChanged")]
	[Token(Token = "0x4000D50")]
	private ColorRange color; //Field offset: 0x224
	[FieldOffset(Offset = "0x244")]
	[SyncVar(hook = "OnColorModeChanged")]
	[Token(Token = "0x4000D51")]
	private ParticleColorMode colorMode; //Field offset: 0x244
	[FieldOffset(Offset = "0x248")]
	[SyncVar(hook = "OnLifetimeChanged")]
	[Token(Token = "0x4000D52")]
	private NumberRange lifetime; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[SyncVar(hook = "OnSizeOverLifetimeChanged")]
	[Token(Token = "0x4000D53")]
	private NumberRange sizeOverLifetime; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[SyncVar(hook = "OnSpeedChanged")]
	[Token(Token = "0x4000D54")]
	private NumberRange speed; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[SyncVar(hook = "OnEmissionRateChanged")]
	[Token(Token = "0x4000D55")]
	private int emissionRate; //Field offset: 0x260
	[FieldOffset(Offset = "0x264")]
	[SyncVar(hook = "OnMaxParticlesChanged")]
	[Token(Token = "0x4000D56")]
	private int maxParticles; //Field offset: 0x264
	[FieldOffset(Offset = "0x268")]
	[SyncVar(hook = "OnGravityChanged")]
	[Token(Token = "0x4000D57")]
	private float gravity; //Field offset: 0x268
	[FieldOffset(Offset = "0x26C")]
	[SyncVar(hook = "OnSimulationSpaceChanged")]
	[Token(Token = "0x4000D58")]
	private ParticleSimulationSpace simulationSpace; //Field offset: 0x26C
	[FieldOffset(Offset = "0x270")]
	[SyncVar(hook = "OnStartRotationChanged")]
	[Token(Token = "0x4000D59")]
	private NumberRange startRotation; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[SyncVar(hook = "OnAngularVelocityChanged")]
	[Token(Token = "0x4000D5A")]
	private NumberRange angularVelocity; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[SyncVar(hook = "OnAutoplayChanged")]
	[Token(Token = "0x4000D5B")]
	private bool autoplay; //Field offset: 0x280
	[FieldOffset(Offset = "0x281")]
	[SyncVar(hook = "OnLoopChanged")]
	[Token(Token = "0x4000D5C")]
	private bool loop; //Field offset: 0x281
	[FieldOffset(Offset = "0x284")]
	[SyncVar(hook = "OnDurationChanged")]
	[Token(Token = "0x4000D5D")]
	private float duration; //Field offset: 0x284
	[FieldOffset(Offset = "0x288")]
	[SyncVar(hook = "OnShapeChanged")]
	[Token(Token = "0x4000D5E")]
	private ParticleShape shape; //Field offset: 0x288
	[FieldOffset(Offset = "0x28C")]
	[SyncVar(hook = "OnShapeRadiusChanged")]
	[Token(Token = "0x4000D5F")]
	private float shapeRadius; //Field offset: 0x28C
	[FieldOffset(Offset = "0x290")]
	[SyncVar(hook = "OnShapeAngleChanged")]
	[Token(Token = "0x4000D60")]
	private float shapeAngle; //Field offset: 0x290
	[FieldOffset(Offset = "0x294")]
	[SyncVar(hook = "OnShapeScaleChanged")]
	[Token(Token = "0x4000D61")]
	private Vector3 shapeScale; //Field offset: 0x294
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000D62")]
	private ImageCacheKey lastCacheKey; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000D63")]
	private ImageCacheEntry currentEntry; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000D64")]
	public Action<String, String> _Mirror_SyncVarHookDelegate_imageID; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000D65")]
	public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000D66")]
	public Action<ColorRange, ColorRange> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000D67")]
	public Action<ParticleColorMode, ParticleColorMode> _Mirror_SyncVarHookDelegate_colorMode; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000D68")]
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_lifetime; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000D69")]
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_sizeOverLifetime; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000D6A")]
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_speed; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000D6B")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_emissionRate; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000D6C")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_maxParticles; //Field offset: 0x300
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000D6D")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_gravity; //Field offset: 0x308
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000D6E")]
	public Action<ParticleSimulationSpace, ParticleSimulationSpace> _Mirror_SyncVarHookDelegate_simulationSpace; //Field offset: 0x310
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000D6F")]
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_startRotation; //Field offset: 0x318
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000D70")]
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_angularVelocity; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x4000D71")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_autoplay; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000D72")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_loop; //Field offset: 0x330
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000D73")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_duration; //Field offset: 0x338
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000D74")]
	public Action<ParticleShape, ParticleShape> _Mirror_SyncVarHookDelegate_shape; //Field offset: 0x340
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000D75")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_shapeRadius; //Field offset: 0x348
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000D76")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_shapeAngle; //Field offset: 0x350
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000D77")]
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_shapeScale; //Field offset: 0x358

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E2")]
	public NumberRange AngularVelocity
	{
		[Address(RVA = "0x44B440", Offset = "0x44A640", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002023")]
		 get { } //Length: 25
		[Address(RVA = "0x44B6F0", Offset = "0x44A8F0", Length = "0xE5")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnAngularVelocityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RotationOverLifetimeModule), Member = "set_z", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002024")]
		 set { } //Length: 229
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E3")]
	public bool Autoplay
	{
		[Address(RVA = "0x44B460", Offset = "0x44A660", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002025")]
		 get { } //Length: 8
		[Address(RVA = "0x44B7E0", Offset = "0x44A9E0", Length = "0xAF")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnAutoplayChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(ParticleSystem), Member = "Stop", ReturnType = typeof(void))]
		[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002026")]
		 set { } //Length: 175
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009D8")]
	public ColorRange Color
	{
		[Address(RVA = "0x44B480", Offset = "0x44A680", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600200F")]
		 get { } //Length: 25
		[Address(RVA = "0x44B9D0", Offset = "0x44ABD0", Length = "0x3EB")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ColorOverLifetimeModule), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxGradient)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MinMaxGradient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Gradient), Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientColorKey[]), typeof(GradientAlphaKey[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GradientColorKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Gradient), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange&), typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002010")]
		 set { } //Length: 1003
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009D9")]
	public ParticleColorMode ColorMode
	{
		[Address(RVA = "0x44B470", Offset = "0x44A670", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002011")]
		 get { } //Length: 7
		[Address(RVA = "0x44B890", Offset = "0x44AA90", Length = "0x132")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnColorModeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleColorMode), typeof(ParticleColorMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ColorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleColorMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Particles), Member = "GetImage", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002012")]
		 set { } //Length: 306
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E5")]
	public float Duration
	{
		[Address(RVA = "0x44B4A0", Offset = "0x44A6A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002029")]
		 get { } //Length: 9
		[Address(RVA = "0x44BDC0", Offset = "0x44AFC0", Length = "0x9A")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnDurationChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(MainModule), Member = "set_duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600202A")]
		 set { } //Length: 154
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009DD")]
	public int EmissionRate
	{
		[Address(RVA = "0x44B4B0", Offset = "0x44A6B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002019")]
		 get { } //Length: 7
		[Address(RVA = "0x44BE60", Offset = "0x44B060", Length = "0xC6")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnEmissionRateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_EmissionRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Calls(Type = typeof(MinMaxCurve), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(MinMaxCurve))]
		[Calls(Type = typeof(EmissionModule), Member = "set_rateOverTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600201A")]
		 set { } //Length: 198
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009DF")]
	public float Gravity
	{
		[Address(RVA = "0x443210", Offset = "0x442410", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600201D")]
		 get { } //Length: 9
		[Address(RVA = "0x44BF30", Offset = "0x44B130", Length = "0xC9")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnGravityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(MinMaxCurve), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(MinMaxCurve))]
		[Calls(Type = typeof(MainModule), Member = "set_gravityModifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600201E")]
		 set { } //Length: 201
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009D6")]
	public string ImageID
	{
		[Address(RVA = "0x44B4C0", Offset = "0x44A6C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600200B")]
		 get { } //Length: 8
		[Address(RVA = "0x44C000", Offset = "0x44B200", Length = "0x70")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnImageIDChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Calls(Type = typeof(Particles), Member = "GetImage", ReturnType = typeof(void))]
		[Token(Token = "0x600200C")]
		 set { } //Length: 112
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009D7")]
	public ImageType ImageType
	{
		[Address(RVA = "0x44B4D0", Offset = "0x44A6D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600200D")]
		 get { } //Length: 7
		[Address(RVA = "0x44C070", Offset = "0x44B270", Length = "0x6E")]
		[CalledBy(Type = typeof(Particles), Member = "OnImageTypeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType), typeof(ImageType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Calls(Type = typeof(Particles), Member = "GetImage", ReturnType = typeof(void))]
		[Token(Token = "0x600200E")]
		 set { } //Length: 110
	}

	[Token(Token = "0x170009EB")]
	public bool IsPaused
	{
		[Address(RVA = "0x44B4E0", Offset = "0x44A6E0", Length = "0x20")]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "get_IsPaused", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ParticleSystem), Member = "get_isPaused", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002034")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170009EA")]
	public bool IsPlaying
	{
		[Address(RVA = "0x44B510", Offset = "0x44A710", Length = "0x20")]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "get_IsPlaying", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002033")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170009EC")]
	public bool IsStopped
	{
		[Address(RVA = "0x44B540", Offset = "0x44A740", Length = "0x20")]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "get_IsStopped", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ParticleSystem), Member = "get_isStopped", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002035")]
		 get { } //Length: 32
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009DA")]
	public NumberRange Lifetime
	{
		[Address(RVA = "0x44B570", Offset = "0x44A770", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002013")]
		 get { } //Length: 25
		[Address(RVA = "0x44C0E0", Offset = "0x44B2E0", Length = "0xE5")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnLifetimeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Lifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MainModule), Member = "set_startLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002014")]
		 set { } //Length: 229
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E4")]
	public bool Loop
	{
		[Address(RVA = "0x44B590", Offset = "0x44A790", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002027")]
		 get { } //Length: 8
		[Address(RVA = "0x44C1D0", Offset = "0x44B3D0", Length = "0x99")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnLoopChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(MainModule), Member = "set_loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002028")]
		 set { } //Length: 153
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009DE")]
	public int MaxParticles
	{
		[Address(RVA = "0x44B5A0", Offset = "0x44A7A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600201B")]
		 get { } //Length: 7
		[Address(RVA = "0x44C270", Offset = "0x44B470", Length = "0x95")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnMaxParticlesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_MaxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Calls(Type = typeof(MainModule), Member = "set_maxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600201C")]
		 set { } //Length: 149
	}

	[Token(Token = "0x170009FC")]
	public NumberRange NetworkangularVelocity
	{
		[Address(RVA = "0x44B440", Offset = "0x44A640", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002079")]
		 get { } //Length: 25
		[Address(RVA = "0x44C310", Offset = "0x44B510", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Token(Token = "0x600207A")]
		 set { } //Length: 108
	}

	[Token(Token = "0x170009FD")]
	public bool Networkautoplay
	{
		[Address(RVA = "0x44B460", Offset = "0x44A660", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600207B")]
		 get { } //Length: 8
		[Address(RVA = "0x44C380", Offset = "0x44B580", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x600207C")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170009F2")]
	public ColorRange Networkcolor
	{
		[Address(RVA = "0x44B480", Offset = "0x44A680", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002065")]
		 get { } //Length: 25
		[Address(RVA = "0x44C460", Offset = "0x44B660", Length = "0x1B5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange&), typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002066")]
		 set { } //Length: 437
	}

	[Token(Token = "0x170009F3")]
	public ParticleColorMode NetworkcolorMode
	{
		[Address(RVA = "0x44B470", Offset = "0x44A670", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002067")]
		 get { } //Length: 7
		[Address(RVA = "0x44C3F0", Offset = "0x44B5F0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x6002068")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170009FF")]
	public float Networkduration
	{
		[Address(RVA = "0x44B4A0", Offset = "0x44A6A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600207F")]
		 get { } //Length: 9
		[Address(RVA = "0x44C620", Offset = "0x44B820", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002080")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170009F7")]
	public int NetworkemissionRate
	{
		[Address(RVA = "0x44B4B0", Offset = "0x44A6B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600206F")]
		 get { } //Length: 7
		[Address(RVA = "0x44C690", Offset = "0x44B890", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Token(Token = "0x6002070")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170009F9")]
	public float Networkgravity
	{
		[Address(RVA = "0x443210", Offset = "0x442410", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002073")]
		 get { } //Length: 9
		[Address(RVA = "0x44C700", Offset = "0x44B900", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002074")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170009F0")]
	public string NetworkimageID
	{
		[Address(RVA = "0x44B4C0", Offset = "0x44A6C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002061")]
		 get { } //Length: 8
		[Address(RVA = "0x44C770", Offset = "0x44B970", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Token(Token = "0x6002062")]
		 set { } //Length: 103
	}

	[Token(Token = "0x170009F1")]
	public ImageType NetworkimageType
	{
		[Address(RVA = "0x44B4D0", Offset = "0x44A6D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002063")]
		 get { } //Length: 7
		[Address(RVA = "0x44C7E0", Offset = "0x44B9E0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x6002064")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170009F4")]
	public NumberRange Networklifetime
	{
		[Address(RVA = "0x44B570", Offset = "0x44A770", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002069")]
		 get { } //Length: 25
		[Address(RVA = "0x44C850", Offset = "0x44BA50", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Token(Token = "0x600206A")]
		 set { } //Length: 108
	}

	[Token(Token = "0x170009FE")]
	public bool Networkloop
	{
		[Address(RVA = "0x44B590", Offset = "0x44A790", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600207D")]
		 get { } //Length: 8
		[Address(RVA = "0x44C8C0", Offset = "0x44BAC0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x600207E")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170009F8")]
	public int NetworkmaxParticles
	{
		[Address(RVA = "0x44B5A0", Offset = "0x44A7A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002071")]
		 get { } //Length: 7
		[Address(RVA = "0x44C930", Offset = "0x44BB30", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Token(Token = "0x6002072")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000A00")]
	public ParticleShape Networkshape
	{
		[Address(RVA = "0x44B5F0", Offset = "0x44A7F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002081")]
		 get { } //Length: 7
		[Address(RVA = "0x44CB00", Offset = "0x44BD00", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x6002082")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000A02")]
	public float NetworkshapeAngle
	{
		[Address(RVA = "0x44B5B0", Offset = "0x44A7B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002085")]
		 get { } //Length: 9
		[Address(RVA = "0x44C9A0", Offset = "0x44BBA0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002086")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000A01")]
	public float NetworkshapeRadius
	{
		[Address(RVA = "0x44B5C0", Offset = "0x44A7C0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002083")]
		 get { } //Length: 9
		[Address(RVA = "0x44CA10", Offset = "0x44BC10", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002084")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000A03")]
	public Vector3 NetworkshapeScale
	{
		[Address(RVA = "0x44B5D0", Offset = "0x44A7D0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002087")]
		 get { } //Length: 25
		[Address(RVA = "0x44CA80", Offset = "0x44BC80", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
		[Token(Token = "0x6002088")]
		 set { } //Length: 122
	}

	[Token(Token = "0x170009FA")]
	public ParticleSimulationSpace NetworksimulationSpace
	{
		[Address(RVA = "0x4389F0", Offset = "0x437BF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002075")]
		 get { } //Length: 7
		[Address(RVA = "0x44CB70", Offset = "0x44BD70", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x6002076")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170009F5")]
	public NumberRange NetworksizeOverLifetime
	{
		[Address(RVA = "0x44B600", Offset = "0x44A800", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600206B")]
		 get { } //Length: 25
		[Address(RVA = "0x44CBE0", Offset = "0x44BDE0", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Token(Token = "0x600206C")]
		 set { } //Length: 108
	}

	[Token(Token = "0x170009F6")]
	public NumberRange Networkspeed
	{
		[Address(RVA = "0x44B620", Offset = "0x44A820", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600206D")]
		 get { } //Length: 25
		[Address(RVA = "0x44CC50", Offset = "0x44BE50", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Token(Token = "0x600206E")]
		 set { } //Length: 108
	}

	[Token(Token = "0x170009FB")]
	public NumberRange NetworkstartRotation
	{
		[Address(RVA = "0x44B640", Offset = "0x44A840", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002077")]
		 get { } //Length: 25
		[Address(RVA = "0x44CCC0", Offset = "0x44BEC0", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Token(Token = "0x6002078")]
		 set { } //Length: 108
	}

	[Token(Token = "0x170009ED")]
	public int ParticleCount
	{
		[Address(RVA = "0x44B660", Offset = "0x44A860", Length = "0x20")]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "get_ParticleCount", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ParticleSystem), Member = "get_particleCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002036")]
		 get { } //Length: 32
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E6")]
	public ParticleShape Shape
	{
		[Address(RVA = "0x44B5F0", Offset = "0x44A7F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600202B")]
		 get { } //Length: 7
		[Address(RVA = "0x44CF40", Offset = "0x44C140", Length = "0x8C")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnShapeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleShape), typeof(ParticleShape)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleShape)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x600202C")]
		 set { } //Length: 140
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E8")]
	public float ShapeAngle
	{
		[Address(RVA = "0x44B5B0", Offset = "0x44A7B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600202F")]
		 get { } //Length: 9
		[Address(RVA = "0x44CD30", Offset = "0x44BF30", Length = "0x9A")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnShapeAngleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ShapeAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(ShapeModule), Member = "set_angle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002030")]
		 set { } //Length: 154
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E7")]
	public float ShapeRadius
	{
		[Address(RVA = "0x44B5C0", Offset = "0x44A7C0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600202D")]
		 get { } //Length: 9
		[Address(RVA = "0x44CDD0", Offset = "0x44BFD0", Length = "0x9A")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnShapeRadiusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ShapeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(ShapeModule), Member = "set_radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600202E")]
		 set { } //Length: 154
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E9")]
	public Vector3 ShapeScale
	{
		[Address(RVA = "0x44B5D0", Offset = "0x44A7D0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002031")]
		 get { } //Length: 25
		[Address(RVA = "0x44CE70", Offset = "0x44C070", Length = "0xC1")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnShapeScaleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ShapeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
		[Calls(Type = typeof(ShapeModule), Member = "set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002032")]
		 set { } //Length: 193
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E0")]
	public ParticleSimulationSpace SimulationSpace
	{
		[Address(RVA = "0x4389F0", Offset = "0x437BF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600201F")]
		 get { } //Length: 7
		[Address(RVA = "0x44D050", Offset = "0x44C250", Length = "0xA7")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnSimulationSpaceChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSimulationSpace), typeof(ParticleSimulationSpace)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_SimulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSimulationSpace)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Calls(Type = typeof(MainModule), Member = "set_simulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystemSimulationSpace)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002020")]
		 set { } //Length: 167
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009DB")]
	public NumberRange SizeOverLifetime
	{
		[Address(RVA = "0x44B600", Offset = "0x44A800", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002015")]
		 get { } //Length: 25
		[Address(RVA = "0x44D100", Offset = "0x44C300", Length = "0x1BC")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnSizeOverLifetimeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(MinMaxCurve), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(MinMaxCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(MainModule), Member = "set_startSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(AnimationCurve), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(AnimationCurve)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SizeOverLifetimeModule), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6002016")]
		 set { } //Length: 444
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009DC")]
	public NumberRange Speed
	{
		[Address(RVA = "0x44B620", Offset = "0x44A820", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002017")]
		 get { } //Length: 25
		[Address(RVA = "0x44D2C0", Offset = "0x44C4C0", Length = "0xE5")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnSpeedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Speed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MainModule), Member = "set_startSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002018")]
		 set { } //Length: 229
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170009E1")]
	public NumberRange StartRotation
	{
		[Address(RVA = "0x44B640", Offset = "0x44A840", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002021")]
		 get { } //Length: 25
		[Address(RVA = "0x44D3B0", Offset = "0x44C5B0", Length = "0xE5")]
		[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Particles), Member = "OnStartRotationChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "set_StartRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
		[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MainModule), Member = "set_startRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002022")]
		 set { } //Length: 229
	}

	[Token(Token = "0x170009EE")]
	public float Time
	{
		[Address(RVA = "0x44B690", Offset = "0x44A890", Length = "0x20")]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "get_Time", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ParticleSystem), Member = "get_time", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002037")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170009EF")]
	public float TotalTime
	{
		[Address(RVA = "0x44B6C0", Offset = "0x44A8C0", Length = "0x20")]
		[CalledBy(Type = typeof(ParticlesProxy), Member = "get_TotalTime", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ParticleSystem), Member = "get_totalTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002038")]
		 get { } //Length: 32
	}

	[Address(RVA = "0x44A960", Offset = "0x449B60", Length = "0x2BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6002095")]
	private static Particles() { }

	[Address(RVA = "0x44AC20", Offset = "0x449E20", Length = "0x816")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ColorRange), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicInstance), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<Polytoria.Types.ColorRange, Polytoria.Types.ColorRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x600205E")]
	public Particles() { }

	[Address(RVA = "0x449EB0", Offset = "0x4490B0", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ImageCacheKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600205F")]
	private void <GetImage>b__98_0(ImageCacheKey key, ImageCacheEntry entry) { }

	[Address(RVA = "0x4464B0", Offset = "0x4456B0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicInstance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Collider), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002039")]
	protected virtual void Awake() { }

	[Address(RVA = "0x446580", Offset = "0x445780", Length = "0x17E")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002040")]
	public void Clear() { }

	[Address(RVA = "0x446700", Offset = "0x445900", Length = "0x2CA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Particles), Member = "set_EmissionRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_ShapeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_ShapeAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_ShapeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleShape)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_StartRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_SimulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSimulationSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Particles), Member = "set_Speed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_Lifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_ColorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleColorMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Particles), Member = "GetImage", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(Particles), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicInstance), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Particles), Member = "set_MaxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002049")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x4469D0", Offset = "0x445BD0", Length = "0x9C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange&), typeof(System.Action`2<Polytoria.Types.ColorRange, Polytoria.Types.ColorRange>), typeof(ColorRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(System.Action`2<System.Int32, System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange&), typeof(System.Action`2<Polytoria.Types.NumberRange, Polytoria.Types.NumberRange>), typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneratedNetworkCode), Member = "_Read_Polytoria.Types.NumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(NumberRange))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneratedNetworkCode), Member = "_Read_Polytoria.Types.ColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ColorRange))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(System.Action`2<System.Int32Enum, System.Int32Enum>), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(System.Action`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynamicInstance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002097")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x447390", Offset = "0x446590", Length = "0x19B")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002041")]
	public void Emit(int count) { }

	[Address(RVA = "0x44B440", Offset = "0x44A640", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002023")]
	public NumberRange get_AngularVelocity() { }

	[Address(RVA = "0x44B460", Offset = "0x44A660", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002025")]
	public bool get_Autoplay() { }

	[Address(RVA = "0x44B480", Offset = "0x44A680", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600200F")]
	public ColorRange get_Color() { }

	[Address(RVA = "0x44B470", Offset = "0x44A670", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002011")]
	public ParticleColorMode get_ColorMode() { }

	[Address(RVA = "0x44B4A0", Offset = "0x44A6A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002029")]
	public float get_Duration() { }

	[Address(RVA = "0x44B4B0", Offset = "0x44A6B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002019")]
	public int get_EmissionRate() { }

	[Address(RVA = "0x443210", Offset = "0x442410", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600201D")]
	public float get_Gravity() { }

	[Address(RVA = "0x44B4C0", Offset = "0x44A6C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600200B")]
	public string get_ImageID() { }

	[Address(RVA = "0x44B4D0", Offset = "0x44A6D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600200D")]
	public ImageType get_ImageType() { }

	[Address(RVA = "0x44B4E0", Offset = "0x44A6E0", Length = "0x20")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "get_IsPaused", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPaused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002034")]
	public bool get_IsPaused() { }

	[Address(RVA = "0x44B510", Offset = "0x44A710", Length = "0x20")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "get_IsPlaying", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002033")]
	public bool get_IsPlaying() { }

	[Address(RVA = "0x44B540", Offset = "0x44A740", Length = "0x20")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "get_IsStopped", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002035")]
	public bool get_IsStopped() { }

	[Address(RVA = "0x44B570", Offset = "0x44A770", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002013")]
	public NumberRange get_Lifetime() { }

	[Address(RVA = "0x44B590", Offset = "0x44A790", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002027")]
	public bool get_Loop() { }

	[Address(RVA = "0x44B5A0", Offset = "0x44A7A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600201B")]
	public int get_MaxParticles() { }

	[Address(RVA = "0x44B440", Offset = "0x44A640", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002079")]
	public NumberRange get_NetworkangularVelocity() { }

	[Address(RVA = "0x44B460", Offset = "0x44A660", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600207B")]
	public bool get_Networkautoplay() { }

	[Address(RVA = "0x44B480", Offset = "0x44A680", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002065")]
	public ColorRange get_Networkcolor() { }

	[Address(RVA = "0x44B470", Offset = "0x44A670", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002067")]
	public ParticleColorMode get_NetworkcolorMode() { }

	[Address(RVA = "0x44B4A0", Offset = "0x44A6A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600207F")]
	public float get_Networkduration() { }

	[Address(RVA = "0x44B4B0", Offset = "0x44A6B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600206F")]
	public int get_NetworkemissionRate() { }

	[Address(RVA = "0x443210", Offset = "0x442410", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002073")]
	public float get_Networkgravity() { }

	[Address(RVA = "0x44B4C0", Offset = "0x44A6C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002061")]
	public string get_NetworkimageID() { }

	[Address(RVA = "0x44B4D0", Offset = "0x44A6D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002063")]
	public ImageType get_NetworkimageType() { }

	[Address(RVA = "0x44B570", Offset = "0x44A770", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002069")]
	public NumberRange get_Networklifetime() { }

	[Address(RVA = "0x44B590", Offset = "0x44A790", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600207D")]
	public bool get_Networkloop() { }

	[Address(RVA = "0x44B5A0", Offset = "0x44A7A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002071")]
	public int get_NetworkmaxParticles() { }

	[Address(RVA = "0x44B5F0", Offset = "0x44A7F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002081")]
	public ParticleShape get_Networkshape() { }

	[Address(RVA = "0x44B5B0", Offset = "0x44A7B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002085")]
	public float get_NetworkshapeAngle() { }

	[Address(RVA = "0x44B5C0", Offset = "0x44A7C0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002083")]
	public float get_NetworkshapeRadius() { }

	[Address(RVA = "0x44B5D0", Offset = "0x44A7D0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002087")]
	public Vector3 get_NetworkshapeScale() { }

	[Address(RVA = "0x4389F0", Offset = "0x437BF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002075")]
	public ParticleSimulationSpace get_NetworksimulationSpace() { }

	[Address(RVA = "0x44B600", Offset = "0x44A800", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600206B")]
	public NumberRange get_NetworksizeOverLifetime() { }

	[Address(RVA = "0x44B620", Offset = "0x44A820", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600206D")]
	public NumberRange get_Networkspeed() { }

	[Address(RVA = "0x44B640", Offset = "0x44A840", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002077")]
	public NumberRange get_NetworkstartRotation() { }

	[Address(RVA = "0x44B660", Offset = "0x44A860", Length = "0x20")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "get_ParticleCount", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_particleCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002036")]
	public int get_ParticleCount() { }

	[Address(RVA = "0x44B5F0", Offset = "0x44A7F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600202B")]
	public ParticleShape get_Shape() { }

	[Address(RVA = "0x44B5B0", Offset = "0x44A7B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600202F")]
	public float get_ShapeAngle() { }

	[Address(RVA = "0x44B5C0", Offset = "0x44A7C0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600202D")]
	public float get_ShapeRadius() { }

	[Address(RVA = "0x44B5D0", Offset = "0x44A7D0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002031")]
	public Vector3 get_ShapeScale() { }

	[Address(RVA = "0x4389F0", Offset = "0x437BF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600201F")]
	public ParticleSimulationSpace get_SimulationSpace() { }

	[Address(RVA = "0x44B600", Offset = "0x44A800", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002015")]
	public NumberRange get_SizeOverLifetime() { }

	[Address(RVA = "0x44B620", Offset = "0x44A820", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002017")]
	public NumberRange get_Speed() { }

	[Address(RVA = "0x44B640", Offset = "0x44A840", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002021")]
	public NumberRange get_StartRotation() { }

	[Address(RVA = "0x44B690", Offset = "0x44A890", Length = "0x20")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "get_Time", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002037")]
	public float get_Time() { }

	[Address(RVA = "0x44B6C0", Offset = "0x44A8C0", Length = "0x20")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "get_TotalTime", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_totalTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002038")]
	public float get_TotalTime() { }

	[Address(RVA = "0x447530", Offset = "0x446730", Length = "0x175")]
	[CalledBy(Type = typeof(Particles), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "set_ColorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleColorMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`2<Polytoria.Controllers.ImageCacheKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ImageCacheController), Member = "GetImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(System.Action`2<Polytoria.Controllers.ImageCacheKey, Polytoria.Controllers.ImageCacheEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600203C")]
	private void GetImage() { }

	[Address(RVA = "0x4476B0", Offset = "0x4468B0", Length = "0x26A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002090")]
	protected static void InvokeUserCode_RpcClear(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x447920", Offset = "0x446B20", Length = "0x29D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002092")]
	protected static void InvokeUserCode_RpcEmit__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x447BC0", Offset = "0x446DC0", Length = "0x26A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ParticleSystem), Member = "Pause", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600208C")]
	protected static void InvokeUserCode_RpcPause(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x447E30", Offset = "0x447030", Length = "0x276")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600208A")]
	protected static void InvokeUserCode_RpcPlay(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x4480B0", Offset = "0x4472B0", Length = "0x2A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002094")]
	protected static void InvokeUserCode_RpcSimulate__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x448360", Offset = "0x447560", Length = "0x26A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600208E")]
	protected static void InvokeUserCode_RpcStop(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x4485D0", Offset = "0x4477D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002056")]
	private void OnAngularVelocityChanged(NumberRange oldAngularVelocity, NumberRange newAngularVelocity) { }

	[Address(RVA = "0x448610", Offset = "0x447810", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002057")]
	private void OnAutoplayChanged(bool oldVal, bool newVal) { }

	[Address(RVA = "0x448650", Offset = "0x447850", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, ReturnType = typeof(void))]
	[Token(Token = "0x600204C")]
	private void OnColorChanged(ColorRange oldColor, ColorRange newColor) { }

	[Address(RVA = "0x4486A0", Offset = "0x4478A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_ColorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleColorMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x600204D")]
	private void OnColorModeChanged(ParticleColorMode oldColorMode, ParticleColorMode newColorMode) { }

	[Address(RVA = "0x4486E0", Offset = "0x4478E0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002059")]
	private void OnDurationChanged(float oldDuration, float newDuration) { }

	[Address(RVA = "0x448720", Offset = "0x447920", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_EmissionRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002051")]
	private void OnEmissionRateChanged(int oldEmissionRate, int newEmissionRate) { }

	[Address(RVA = "0x448760", Offset = "0x447960", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002053")]
	private void OnGravityChanged(float oldGravity, float newGravity) { }

	[Address(RVA = "0x4487A0", Offset = "0x4479A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600203A")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x4487F0", Offset = "0x4479F0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600204A")]
	private void OnImageIDChanged(string oldID, string newID) { }

	[Address(RVA = "0x448830", Offset = "0x447A30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[Token(Token = "0x600204B")]
	private void OnImageTypeChanged(ImageType oldType, ImageType newType) { }

	[Address(RVA = "0x448870", Offset = "0x447A70", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_Lifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Token(Token = "0x600204E")]
	private void OnLifetimeChanged(NumberRange oldLifetime, NumberRange newLifetime) { }

	[Address(RVA = "0x4488B0", Offset = "0x447AB0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002058")]
	private void OnLoopChanged(bool oldLoop, bool newLoop) { }

	[Address(RVA = "0x4488F0", Offset = "0x447AF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_MaxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002052")]
	private void OnMaxParticlesChanged(int oldMaxParticles, int newMaxParticles) { }

	[Address(RVA = "0x448930", Offset = "0x447B30", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_ShapeAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600205C")]
	private void OnShapeAngleChanged(float oldAngle, float newAngle) { }

	[Address(RVA = "0x448970", Offset = "0x447B70", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleShape)}, ReturnType = typeof(void))]
	[Token(Token = "0x600205A")]
	private void OnShapeChanged(ParticleShape oldShape, ParticleShape newShape) { }

	[Address(RVA = "0x4489B0", Offset = "0x447BB0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_ShapeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600205B")]
	private void OnShapeRadiusChanged(float oldRadius, float newRadius) { }

	[Address(RVA = "0x4489F0", Offset = "0x447BF0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_ShapeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x600205D")]
	private void OnShapeScaleChanged(Vector3 oldScale, Vector3 newScale) { }

	[Address(RVA = "0x448A40", Offset = "0x447C40", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnShow", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600203B")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x448A90", Offset = "0x447C90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_SimulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSimulationSpace)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002054")]
	private void OnSimulationSpaceChanged(ParticleSimulationSpace oldSimulationSpace, ParticleSimulationSpace newSimulationSpace) { }

	[Address(RVA = "0x448AD0", Offset = "0x447CD0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Token(Token = "0x600204F")]
	private void OnSizeOverLifetimeChanged(NumberRange oldSizeOverLifetime, NumberRange newSizeOverLifetime) { }

	[Address(RVA = "0x448B10", Offset = "0x447D10", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_Speed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002050")]
	private void OnSpeedChanged(NumberRange oldSpeed, NumberRange newSpeed) { }

	[Address(RVA = "0x448B50", Offset = "0x447D50", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Particles), Member = "set_StartRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002055")]
	private void OnStartRotationChanged(NumberRange oldStartRotation, NumberRange newStartRotation) { }

	[Address(RVA = "0x448B90", Offset = "0x447D90", Length = "0x17E")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "Pause", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "Pause", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600203E")]
	public void Pause() { }

	[Address(RVA = "0x448D10", Offset = "0x447F10", Length = "0x18C")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "Play", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600203D")]
	public void Play() { }

	[Address(RVA = "0x448EA0", Offset = "0x4480A0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x6002046")]
	private void RpcClear() { }

	[Address(RVA = "0x448FF0", Offset = "0x4481F0", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x6002047")]
	private void RpcEmit(int count) { }

	[Address(RVA = "0x449160", Offset = "0x448360", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x6002044")]
	private void RpcPause() { }

	[Address(RVA = "0x4492B0", Offset = "0x4484B0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x6002043")]
	private void RpcPlay() { }

	[Address(RVA = "0x449400", Offset = "0x448600", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x6002048")]
	private void RpcSimulate(float time) { }

	[Address(RVA = "0x449570", Offset = "0x448770", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x6002045")]
	private void RpcStop() { }

	[Address(RVA = "0x4496C0", Offset = "0x4488C0", Length = "0x4B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneratedNetworkCode), Member = "_Write_Polytoria.Types.ColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ColorRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneratedNetworkCode), Member = "_Write_Polytoria.Types.NumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002096")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x44B6F0", Offset = "0x44A8F0", Length = "0xE5")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnAngularVelocityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationOverLifetimeModule), Member = "set_z", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002024")]
	public void set_AngularVelocity(NumberRange value) { }

	[Address(RVA = "0x44B7E0", Offset = "0x44A9E0", Length = "0xAF")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnAutoplayChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002026")]
	public void set_Autoplay(bool value) { }

	[Address(RVA = "0x44B9D0", Offset = "0x44ABD0", Length = "0x3EB")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange&), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gradient), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GradientColorKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gradient), Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientColorKey[]), typeof(GradientAlphaKey[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MinMaxGradient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorOverLifetimeModule), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxGradient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002010")]
	public void set_Color(ColorRange value) { }

	[Address(RVA = "0x44B890", Offset = "0x44AA90", Length = "0x132")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnColorModeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleColorMode), typeof(ParticleColorMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ColorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleColorMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Particles), Member = "GetImage", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002012")]
	public void set_ColorMode(ParticleColorMode value) { }

	[Address(RVA = "0x44BDC0", Offset = "0x44AFC0", Length = "0x9A")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnDurationChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(MainModule), Member = "set_duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600202A")]
	public void set_Duration(float value) { }

	[Address(RVA = "0x44BE60", Offset = "0x44B060", Length = "0xC6")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnEmissionRateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_EmissionRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Calls(Type = typeof(MinMaxCurve), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(MinMaxCurve))]
	[Calls(Type = typeof(EmissionModule), Member = "set_rateOverTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600201A")]
	public void set_EmissionRate(int value) { }

	[Address(RVA = "0x44BF30", Offset = "0x44B130", Length = "0xC9")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnGravityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(MinMaxCurve), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(MinMaxCurve))]
	[Calls(Type = typeof(MainModule), Member = "set_gravityModifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600201E")]
	public void set_Gravity(float value) { }

	[Address(RVA = "0x44C000", Offset = "0x44B200", Length = "0x70")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnImageIDChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Calls(Type = typeof(Particles), Member = "GetImage", ReturnType = typeof(void))]
	[Token(Token = "0x600200C")]
	public void set_ImageID(string value) { }

	[Address(RVA = "0x44C070", Offset = "0x44B270", Length = "0x6E")]
	[CalledBy(Type = typeof(Particles), Member = "OnImageTypeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType), typeof(ImageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(Particles), Member = "GetImage", ReturnType = typeof(void))]
	[Token(Token = "0x600200E")]
	public void set_ImageType(ImageType value) { }

	[Address(RVA = "0x44C0E0", Offset = "0x44B2E0", Length = "0xE5")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnLifetimeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Lifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainModule), Member = "set_startLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002014")]
	public void set_Lifetime(NumberRange value) { }

	[Address(RVA = "0x44C1D0", Offset = "0x44B3D0", Length = "0x99")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnLoopChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(MainModule), Member = "set_loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002028")]
	public void set_Loop(bool value) { }

	[Address(RVA = "0x44C270", Offset = "0x44B470", Length = "0x95")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnMaxParticlesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_MaxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Calls(Type = typeof(MainModule), Member = "set_maxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600201C")]
	public void set_MaxParticles(int value) { }

	[Address(RVA = "0x44C310", Offset = "0x44B510", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Token(Token = "0x600207A")]
	public void set_NetworkangularVelocity(in NumberRange value) { }

	[Address(RVA = "0x44C380", Offset = "0x44B580", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x600207C")]
	public void set_Networkautoplay(in bool value) { }

	[Address(RVA = "0x44C460", Offset = "0x44B660", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorRange), typeof(ColorRange&), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002066")]
	public void set_Networkcolor(in ColorRange value) { }

	[Address(RVA = "0x44C3F0", Offset = "0x44B5F0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x6002068")]
	public void set_NetworkcolorMode(in ParticleColorMode value) { }

	[Address(RVA = "0x44C620", Offset = "0x44B820", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002080")]
	public void set_Networkduration(in float value) { }

	[Address(RVA = "0x44C690", Offset = "0x44B890", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Token(Token = "0x6002070")]
	public void set_NetworkemissionRate(in int value) { }

	[Address(RVA = "0x44C700", Offset = "0x44B900", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002074")]
	public void set_Networkgravity(in float value) { }

	[Address(RVA = "0x44C770", Offset = "0x44B970", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Token(Token = "0x6002062")]
	public void set_NetworkimageID(in string value) { }

	[Address(RVA = "0x44C7E0", Offset = "0x44B9E0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x6002064")]
	public void set_NetworkimageType(in ImageType value) { }

	[Address(RVA = "0x44C850", Offset = "0x44BA50", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Token(Token = "0x600206A")]
	public void set_Networklifetime(in NumberRange value) { }

	[Address(RVA = "0x44C8C0", Offset = "0x44BAC0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x600207E")]
	public void set_Networkloop(in bool value) { }

	[Address(RVA = "0x44C930", Offset = "0x44BB30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Token(Token = "0x6002072")]
	public void set_NetworkmaxParticles(in int value) { }

	[Address(RVA = "0x44CB00", Offset = "0x44BD00", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x6002082")]
	public void set_Networkshape(in ParticleShape value) { }

	[Address(RVA = "0x44C9A0", Offset = "0x44BBA0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002086")]
	public void set_NetworkshapeAngle(in float value) { }

	[Address(RVA = "0x44CA10", Offset = "0x44BC10", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002084")]
	public void set_NetworkshapeRadius(in float value) { }

	[Address(RVA = "0x44CA80", Offset = "0x44BC80", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Token(Token = "0x6002088")]
	public void set_NetworkshapeScale(in Vector3 value) { }

	[Address(RVA = "0x44CB70", Offset = "0x44BD70", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x6002076")]
	public void set_NetworksimulationSpace(in ParticleSimulationSpace value) { }

	[Address(RVA = "0x44CBE0", Offset = "0x44BDE0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Token(Token = "0x600206C")]
	public void set_NetworksizeOverLifetime(in NumberRange value) { }

	[Address(RVA = "0x44CC50", Offset = "0x44BE50", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Token(Token = "0x600206E")]
	public void set_Networkspeed(in NumberRange value) { }

	[Address(RVA = "0x44CCC0", Offset = "0x44BEC0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Token(Token = "0x6002078")]
	public void set_NetworkstartRotation(in NumberRange value) { }

	[Address(RVA = "0x44CF40", Offset = "0x44C140", Length = "0x8C")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnShapeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleShape), typeof(ParticleShape)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleShape)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600202C")]
	public void set_Shape(ParticleShape value) { }

	[Address(RVA = "0x44CD30", Offset = "0x44BF30", Length = "0x9A")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnShapeAngleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ShapeAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(ShapeModule), Member = "set_angle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002030")]
	public void set_ShapeAngle(float value) { }

	[Address(RVA = "0x44CDD0", Offset = "0x44BFD0", Length = "0x9A")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnShapeRadiusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ShapeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(ShapeModule), Member = "set_radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600202E")]
	public void set_ShapeRadius(float value) { }

	[Address(RVA = "0x44CE70", Offset = "0x44C070", Length = "0xC1")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnShapeScaleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_ShapeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Calls(Type = typeof(ShapeModule), Member = "set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002032")]
	public void set_ShapeScale(Vector3 value) { }

	[Address(RVA = "0x44D050", Offset = "0x44C250", Length = "0xA7")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnSimulationSpaceChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSimulationSpace), typeof(ParticleSimulationSpace)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_SimulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSimulationSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(MainModule), Member = "set_simulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystemSimulationSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002020")]
	public void set_SimulationSpace(ParticleSimulationSpace value) { }

	[Address(RVA = "0x44D100", Offset = "0x44C300", Length = "0x1BC")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnSizeOverLifetimeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SizeOverLifetimeModule), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(AnimationCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MinMaxCurve), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(MinMaxCurve))]
	[Calls(Type = typeof(MainModule), Member = "set_startSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002016")]
	public void set_SizeOverLifetime(NumberRange value) { }

	[Address(RVA = "0x44D2C0", Offset = "0x44C4C0", Length = "0xE5")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnSpeedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_Speed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainModule), Member = "set_startSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002018")]
	public void set_Speed(NumberRange value) { }

	[Address(RVA = "0x44D3B0", Offset = "0x44C5B0", Length = "0xE5")]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "OnStartRotationChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange), typeof(NumberRange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "set_StartRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberRange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CF80")]
	[Calls(Type = typeof(MinMaxCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainModule), Member = "set_startRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002022")]
	public void set_StartRotation(NumberRange value) { }

	[Address(RVA = "0x449B80", Offset = "0x448D80", Length = "0x1A8")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "Simulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002042")]
	public void Simulate(float time) { }

	[Address(RVA = "0x449D30", Offset = "0x448F30", Length = "0x17E")]
	[CalledBy(Type = typeof(ParticlesProxy), Member = "Stop", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600203F")]
	public void Stop() { }

	[Address(RVA = "0x449FA0", Offset = "0x4491A0", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600208F")]
	protected void UserCode_RpcClear() { }

	[Address(RVA = "0x44A130", Offset = "0x449330", Length = "0x1AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002091")]
	protected void UserCode_RpcEmit__Int32(int count) { }

	[Address(RVA = "0x44A2E0", Offset = "0x4494E0", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Pause", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600208B")]
	protected void UserCode_RpcPause() { }

	[Address(RVA = "0x44A470", Offset = "0x449670", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002089")]
	protected void UserCode_RpcPlay() { }

	[Address(RVA = "0x44A610", Offset = "0x449810", Length = "0x1B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002093")]
	protected void UserCode_RpcSimulate__Single(float time) { }

	[Address(RVA = "0x44A7D0", Offset = "0x4499D0", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600208D")]
	protected void UserCode_RpcStop() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002060")]
	public virtual bool Weaved() { }

}

