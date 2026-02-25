namespace UnityEngine;

[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[StaticAccessor("GetQualitySettings()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000B0")]
public sealed class QualitySettings : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000205")]
	private static Action<Int32, Int32> activeQualityLevelChanged; //Field offset: 0x0

	[Token(Token = "0x170000A7")]
	public static ColorSpace activeColorSpace
	{
		[Address(RVA = "0x1939FF0", Offset = "0x19391F0", Length = "0x2A")]
		[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.WaveformMonitor", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.VectorscopeMonitor", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.HistogramMonitor", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GltfImportBase+<LoadImages>d__105", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool), typeof(RenderTextureMemoryless), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlas", Member = "OnAssignedToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IPanel"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool), typeof(RenderTextureMemoryless)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_isLinearColorSpace", ReturnType = typeof(bool))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
		[Token(Token = "0x60003AE")]
		 get { } //Length: 42
	}

	[NativeProperty("AnisotropicTextures")]
	[Token(Token = "0x170000A2")]
	public static AnisotropicFiltering anisotropicFiltering
	{
		[Address(RVA = "0x193A020", Offset = "0x1939220", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A4")]
		 get { } //Length: 42
		[Address(RVA = "0x193A170", Offset = "0x1939370", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetAnisotropicFiltering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A5")]
		 set { } //Length: 49
	}

	[Token(Token = "0x170000A5")]
	public static int antiAliasing
	{
		[Address(RVA = "0x193A1B0", Offset = "0x19393B0", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetAntiAliasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003AA")]
		 set { } //Length: 49
	}

	[Token(Token = "0x170000A3")]
	public static int globalTextureMipmapLimit
	{
		[Address(RVA = "0x193A050", Offset = "0x1939250", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A6")]
		 get { } //Length: 42
		[Address(RVA = "0x193A1F0", Offset = "0x19393F0", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetTextureQuality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A7")]
		 set { } //Length: 49
	}

	[Token(Token = "0x1700009F")]
	public static int pixelLightCount
	{
		[Address(RVA = "0x193A080", Offset = "0x1939280", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600039E")]
		 get { } //Length: 42
		[Address(RVA = "0x193A230", Offset = "0x1939430", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetPixelLightCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600039F")]
		 set { } //Length: 49
	}

	[Token(Token = "0x170000A0")]
	public static float shadowDistance
	{
		[Address(RVA = "0x193A0B0", Offset = "0x19392B0", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A0")]
		 get { } //Length: 42
		[Address(RVA = "0x193A270", Offset = "0x1939470", Length = "0x3A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetShadowDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A1")]
		 set { } //Length: 58
	}

	[NativeProperty("ShadowResolution")]
	[Token(Token = "0x170000A1")]
	public static ShadowResolution shadowResolution
	{
		[Address(RVA = "0x193A0E0", Offset = "0x19392E0", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A2")]
		 get { } //Length: 42
		[Address(RVA = "0x193A2B0", Offset = "0x19394B0", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetShadowResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A3")]
		 set { } //Length: 49
	}

	[Token(Token = "0x170000A6")]
	public static SkinWeights skinWeights
	{
		[Address(RVA = "0x193A110", Offset = "0x1939310", Length = "0x2A")]
		[CalledBy(Type = "GLTFast.VertexBufferBones", Member = "ScheduleVertexBonesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.IGltfBuffers", typeof(int), typeof(int)}, ReturnType = "System.Nullable`1<JobHandle>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003AB")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000A4")]
	public static int vSyncCount
	{
		[Address(RVA = "0x193A140", Offset = "0x1939340", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A8")]
		 get { } //Length: 42
		[Address(RVA = "0x193A2F0", Offset = "0x19394F0", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetVSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A9")]
		 set { } //Length: 49
	}

	[Address(RVA = "0x1939FF0", Offset = "0x19391F0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_isLinearColorSpace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool), typeof(RenderTextureMemoryless)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlas", Member = "OnAssignedToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool), typeof(RenderTextureMemoryless), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadImages>d__105", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.HistogramMonitor", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.VectorscopeMonitor", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.WaveformMonitor", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x60003AE")]
	public static ColorSpace get_activeColorSpace() { }

	[Address(RVA = "0x193A020", Offset = "0x1939220", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A4")]
	public static AnisotropicFiltering get_anisotropicFiltering() { }

	[Address(RVA = "0x193A050", Offset = "0x1939250", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A6")]
	public static int get_globalTextureMipmapLimit() { }

	[Address(RVA = "0x193A080", Offset = "0x1939280", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600039E")]
	public static int get_pixelLightCount() { }

	[Address(RVA = "0x193A0B0", Offset = "0x19392B0", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A0")]
	public static float get_shadowDistance() { }

	[Address(RVA = "0x193A0E0", Offset = "0x19392E0", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A2")]
	public static ShadowResolution get_shadowResolution() { }

	[Address(RVA = "0x193A110", Offset = "0x1939310", Length = "0x2A")]
	[CalledBy(Type = "GLTFast.VertexBufferBones", Member = "ScheduleVertexBonesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.IGltfBuffers", typeof(int), typeof(int)}, ReturnType = "System.Nullable`1<JobHandle>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003AB")]
	public static SkinWeights get_skinWeights() { }

	[Address(RVA = "0x193A140", Offset = "0x1939340", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A8")]
	public static int get_vSyncCount() { }

	[Address(RVA = "0x1939EE0", Offset = "0x19390E0", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetCurrentIndex")]
	[Token(Token = "0x60003AC")]
	public static int GetQualityLevel() { }

	[Address(RVA = "0x1939F10", Offset = "0x1939110", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600039C")]
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	[Address(RVA = "0x193A170", Offset = "0x1939370", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetAnisotropicFiltering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A5")]
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[Address(RVA = "0x193A1B0", Offset = "0x19393B0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetAntiAliasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003AA")]
	public static void set_antiAliasing(int value) { }

	[Address(RVA = "0x193A1F0", Offset = "0x19393F0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetTextureQuality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A7")]
	public static void set_globalTextureMipmapLimit(int value) { }

	[Address(RVA = "0x193A230", Offset = "0x1939430", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetPixelLightCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600039F")]
	public static void set_pixelLightCount(int value) { }

	[Address(RVA = "0x193A270", Offset = "0x1939470", Length = "0x3A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetShadowDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A1")]
	public static void set_shadowDistance(float value) { }

	[Address(RVA = "0x193A2B0", Offset = "0x19394B0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetShadowResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A3")]
	public static void set_shadowResolution(ShadowResolution value) { }

	[Address(RVA = "0x193A2F0", Offset = "0x19394F0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetVSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A9")]
	public static void set_vSyncCount(int value) { }

	[Address(RVA = "0x1939FB0", Offset = "0x19391B0", Length = "0x33")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetQualityLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600039D")]
	public static void SetQualityLevel(int index) { }

	[Address(RVA = "0x1939F70", Offset = "0x1939170", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetCurrentIndex")]
	[Token(Token = "0x60003AD")]
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

}

