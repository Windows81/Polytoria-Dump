namespace UnityEngine;

[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[NativeHeader("Runtime/Camera/RenderSettings.h")]
[StaticAccessor("GetRenderSettings()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000B6")]
public sealed class RenderSettings : object
{

	[NativeProperty("AmbientSkyColor")]
	[Token(Token = "0x170000BE")]
	public static Color ambientLight
	{
		[Address(RVA = "0x193C9C0", Offset = "0x193BBC0", Length = "0x3C")]
		[CalledBy(Type = "Polytoria.Datamodel.Lighting", Member = "get_AmbientColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000414")]
		 get { } //Length: 60
		[Address(RVA = "0x193CB80", Offset = "0x193BD80", Length = "0x33")]
		[CalledBy(Type = "Polytoria.Datamodel.Lighting", Member = "set_AmbientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000415")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170000BD")]
	public static AmbientMode ambientMode
	{
		[Address(RVA = "0x193CBC0", Offset = "0x193BDC0", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Datamodel.Lighting", Member = "set_AmbientSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.AmbientSource"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000413")]
		 set { } //Length: 49
	}

	[NativeProperty("UseFog")]
	[Token(Token = "0x170000B7")]
	public static bool fog
	{
		[Address(RVA = "0x193CB10", Offset = "0x193BD10", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000409")]
		 get { } //Length: 42
		[Address(RVA = "0x193CD40", Offset = "0x193BF40", Length = "0x33")]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600040A")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170000BB")]
	public static Color fogColor
	{
		[Address(RVA = "0x193CA40", Offset = "0x193BC40", Length = "0x3C")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000410")]
		 get { } //Length: 60
		[Address(RVA = "0x193CC40", Offset = "0x193BE40", Length = "0x33")]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000411")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170000BC")]
	public static float fogDensity
	{
		[Address(RVA = "0x193CA80", Offset = "0x193BC80", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000412")]
		 get { } //Length: 42
	}

	[NativeProperty("LinearFogEnd")]
	[Token(Token = "0x170000B9")]
	public static float fogEndDistance
	{
		[Address(RVA = "0x193CAB0", Offset = "0x193BCB0", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600040D")]
		 get { } //Length: 42
		[Address(RVA = "0x193CC80", Offset = "0x193BE80", Length = "0x3A")]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600040E")]
		 set { } //Length: 58
	}

	[Token(Token = "0x170000BA")]
	public static FogMode fogMode
	{
		[Address(RVA = "0x193CCC0", Offset = "0x193BEC0", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600040F")]
		 set { } //Length: 49
	}

	[NativeProperty("LinearFogStart")]
	[Token(Token = "0x170000B8")]
	public static float fogStartDistance
	{
		[Address(RVA = "0x193CAE0", Offset = "0x193BCE0", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600040B")]
		 get { } //Length: 42
		[Address(RVA = "0x193CD00", Offset = "0x193BF00", Length = "0x3A")]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogStartDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600040C")]
		 set { } //Length: 58
	}

	[NativeProperty("SkyboxMaterial")]
	[Token(Token = "0x170000BF")]
	public static Material skybox
	{
		[Address(RVA = "0x193CDC0", Offset = "0x193BFC0", Length = "0x6B")]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_Skybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.SkyboxPreset"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.ProceduralSky", Member = "Apply", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.SkyBase", Member = "Apply", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000416")]
		 set { } //Length: 107
	}

	[Address(RVA = "0x193C9C0", Offset = "0x193BBC0", Length = "0x3C")]
	[CalledBy(Type = "Polytoria.Datamodel.Lighting", Member = "get_AmbientColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000414")]
	public static Color get_ambientLight() { }

	[Address(RVA = "0x193C980", Offset = "0x193BB80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000419")]
	private static void get_ambientLight_Injected(out Color ret) { }

	[Address(RVA = "0x193CB10", Offset = "0x193BD10", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000409")]
	public static bool get_fog() { }

	[Address(RVA = "0x193CA40", Offset = "0x193BC40", Length = "0x3C")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000410")]
	public static Color get_fogColor() { }

	[Address(RVA = "0x193CA00", Offset = "0x193BC00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000417")]
	private static void get_fogColor_Injected(out Color ret) { }

	[Address(RVA = "0x193CA80", Offset = "0x193BC80", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000412")]
	public static float get_fogDensity() { }

	[Address(RVA = "0x193CAB0", Offset = "0x193BCB0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600040D")]
	public static float get_fogEndDistance() { }

	[Address(RVA = "0x193CAE0", Offset = "0x193BCE0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600040B")]
	public static float get_fogStartDistance() { }

	[Address(RVA = "0x193CB80", Offset = "0x193BD80", Length = "0x33")]
	[CalledBy(Type = "Polytoria.Datamodel.Lighting", Member = "set_AmbientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000415")]
	public static void set_ambientLight(Color value) { }

	[Address(RVA = "0x193CB40", Offset = "0x193BD40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600041A")]
	private static void set_ambientLight_Injected(in Color value) { }

	[Address(RVA = "0x193CBC0", Offset = "0x193BDC0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Datamodel.Lighting", Member = "set_AmbientSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.AmbientSource"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000413")]
	public static void set_ambientMode(AmbientMode value) { }

	[Address(RVA = "0x193CD40", Offset = "0x193BF40", Length = "0x33")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600040A")]
	public static void set_fog(bool value) { }

	[Address(RVA = "0x193CC40", Offset = "0x193BE40", Length = "0x33")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000411")]
	public static void set_fogColor(Color value) { }

	[Address(RVA = "0x193CC00", Offset = "0x193BE00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000418")]
	private static void set_fogColor_Injected(in Color value) { }

	[Address(RVA = "0x193CC80", Offset = "0x193BE80", Length = "0x3A")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600040E")]
	public static void set_fogEndDistance(float value) { }

	[Address(RVA = "0x193CCC0", Offset = "0x193BEC0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600040F")]
	public static void set_fogMode(FogMode value) { }

	[Address(RVA = "0x193CD00", Offset = "0x193BF00", Length = "0x3A")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_FogStartDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600040C")]
	public static void set_fogStartDistance(float value) { }

	[Address(RVA = "0x193CDC0", Offset = "0x193BFC0", Length = "0x6B")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_Skybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.SkyboxPreset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ProceduralSky", Member = "Apply", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.SkyBase", Member = "Apply", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000416")]
	public static void set_skybox(Material value) { }

	[Address(RVA = "0x193CD80", Offset = "0x193BF80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600041B")]
	private static void set_skybox_Injected(IntPtr value) { }

}

