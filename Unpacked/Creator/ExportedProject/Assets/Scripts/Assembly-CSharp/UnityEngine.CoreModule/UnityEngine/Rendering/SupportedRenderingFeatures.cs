namespace UnityEngine.Rendering;

[Token(Token = "0x2000301")]
public class SupportedRenderingFeatures
{
	[Flags]
	[Token(Token = "0x2000303")]
	internal enum LightmapMixedBakeModes
	{
		None = 0,
		IndirectOnly = 1,
		Subtractive = 2,
		Shadowmask = 4,
	}

	[Flags]
	[Token(Token = "0x2000302")]
	internal enum ReflectionProbeModes
	{
		None = 0,
		Rotation = 1,
	}

	[Token(Token = "0x400095B")]
	private static SupportedRenderingFeatures s_Active; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400095C")]
	private ReflectionProbeModes <reflectionProbeModes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400095D")]
	private LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400095E")]
	private LightmapMixedBakeModes <mixedLightingModes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400095F")]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000960")]
	private LightmapsMode <lightmapsModes>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000961")]
	private bool <enlightenLightmapper>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x4000962")]
	private bool <enlighten>k__BackingField; //Field offset: 0x25
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x4000963")]
	private bool <skyOcclusion>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x27")]
	[Token(Token = "0x4000964")]
	private bool <lightProbeProxyVolumes>k__BackingField; //Field offset: 0x27
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000965")]
	private bool <motionVectors>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000966")]
	private bool <receiveShadows>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000967")]
	private bool <reflectionProbes>k__BackingField; //Field offset: 0x2A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x4000968")]
	private bool <reflectionProbesBlendDistance>k__BackingField; //Field offset: 0x2B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000969")]
	private bool <rendererPriority>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x400096A")]
	private bool <rendersUIOverlay>k__BackingField; //Field offset: 0x2D
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x400096B")]
	private bool <overridesEnvironmentLighting>k__BackingField; //Field offset: 0x2E
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F")]
	[Token(Token = "0x400096C")]
	private bool <overridesFog>k__BackingField; //Field offset: 0x2F
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400096D")]
	private bool <overridesRealtimeReflectionProbes>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400096E")]
	private bool <overridesOtherLightingSettings>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400096F")]
	private bool <editableMaterialRenderQueue>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x4000970")]
	private bool <overridesLODBias>k__BackingField; //Field offset: 0x33
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000971")]
	private bool <overridesMaximumLODLevel>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x4000972")]
	private bool <overridesEnableLODCrossFade>k__BackingField; //Field offset: 0x35
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x4000973")]
	private bool <rendererProbes>k__BackingField; //Field offset: 0x36
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x37")]
	[Token(Token = "0x4000974")]
	private bool <particleSystemInstancing>k__BackingField; //Field offset: 0x37
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000975")]
	private bool <ambientProbeBaking>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000976")]
	private bool <defaultReflectionProbeBaking>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000977")]
	private bool <overridesShadowmask>k__BackingField; //Field offset: 0x3A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4000978")]
	private bool <overridesLightProbeSystem>k__BackingField; //Field offset: 0x3B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000979")]
	private bool <supportsHDR>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x400097A")]
	private bool <supportsClouds>k__BackingField; //Field offset: 0x3D
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400097B")]
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x17000256")]
	public static SupportedRenderingFeatures active
	{
		[Address(RVA = "0x1990A80", Offset = "0x198FC80", Length = "0xDB")]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsUIOverlayRenderedBySRP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapsModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapsMode), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsAmbientProbeBakingSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsDefaultReflectionProbeBakingSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "OverridesLightProbeSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000E9D")]
		 get { } //Length: 219
		[Address(RVA = "0x1990B80", Offset = "0x198FD80", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000E9E")]
		 set { } //Length: 105
	}

	[Token(Token = "0x1700025D")]
	public bool ambientProbeBaking
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000257")]
	public LightmapMixedBakeModes defaultMixedLightingModes
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E9F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700025E")]
	public bool defaultReflectionProbeBaking
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700025B")]
	public bool enlighten
	{
		[Address(RVA = "0x1990B60", Offset = "0x198FD60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000EA3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000259")]
	public LightmapBakeType lightmapBakeTypes
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA1")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700025A")]
	public LightmapsMode lightmapsModes
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA2")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000258")]
	public LightmapMixedBakeModes mixedLightingModes
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700025F")]
	public bool overridesLightProbeSystem
	{
		[Address(RVA = "0x1990B70", Offset = "0x198FD70", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000EA7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700025C")]
	public bool rendersUIOverlay
	{
		[Address(RVA = "0x3BAA10", Offset = "0x3B9C10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1990970", Offset = "0x198FB70", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000EB5")]
	private static SupportedRenderingFeatures() { }

	[Address(RVA = "0x19909E0", Offset = "0x198FBE0", Length = "0x92")]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EB4")]
	public SupportedRenderingFeatures() { }

	[Address(RVA = "0x198FFA0", Offset = "0x198F1A0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EB3")]
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	[Address(RVA = "0x198FFC0", Offset = "0x198F1C0", Length = "0x24A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EA8")]
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	[Address(RVA = "0x1990A80", Offset = "0x198FC80", Length = "0xDB")]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "OverridesLightProbeSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsDefaultReflectionProbeBakingSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapsModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapsMode), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsAmbientProbeBakingSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsUIOverlayRenderedBySRP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000E9D")]
	public static SupportedRenderingFeatures get_active() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA5")]
	public bool get_ambientProbeBaking() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E9F")]
	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA6")]
	public bool get_defaultReflectionProbeBaking() { }

	[Address(RVA = "0x1990B60", Offset = "0x198FD60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000EA3")]
	public bool get_enlighten() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA1")]
	public LightmapBakeType get_lightmapBakeTypes() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA2")]
	public LightmapsMode get_lightmapsModes() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA0")]
	public LightmapMixedBakeModes get_mixedLightingModes() { }

	[Address(RVA = "0x1990B70", Offset = "0x198FD70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000EA7")]
	public bool get_overridesLightProbeSystem() { }

	[Address(RVA = "0x3BAA10", Offset = "0x3B9C10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA4")]
	public bool get_rendersUIOverlay() { }

	[Address(RVA = "0x1990210", Offset = "0x198F410", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EB0")]
	internal static void IsAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[Address(RVA = "0x1990280", Offset = "0x198F480", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EB1")]
	internal static void IsDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	[Address(RVA = "0x19903F0", Offset = "0x198F5F0", Length = "0x133")]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EAB")]
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[Address(RVA = "0x19902F0", Offset = "0x198F4F0", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EAC")]
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[Address(RVA = "0x1990530", Offset = "0x198F730", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EAE")]
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[Address(RVA = "0x1990560", Offset = "0x198F760", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EAD")]
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[Address(RVA = "0x1990740", Offset = "0x198F940", Length = "0x14E")]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EA9")]
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[Address(RVA = "0x19905E0", Offset = "0x198F7E0", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EAA")]
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	[Address(RVA = "0x1990890", Offset = "0x198FA90", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EAF")]
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[Address(RVA = "0x1990900", Offset = "0x198FB00", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EB2")]
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	[Address(RVA = "0x1990B80", Offset = "0x198FD80", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E9E")]
	public static void set_active(SupportedRenderingFeatures value) { }

}

