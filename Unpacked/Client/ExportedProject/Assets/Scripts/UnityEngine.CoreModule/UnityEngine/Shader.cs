namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[Token(Token = "0x20000B7")]
public sealed class Shader : object
{

	[Token(Token = "0x170000C1")]
	public static string globalRenderPipeline
	{
		[Address(RVA = "0x193EC70", Offset = "0x193DE70", Length = "0x16A")]
		[CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderPipelineManager), Member = "TryPrepareRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600041E")]
		 set { } //Length: 362
	}

	[Token(Token = "0x170000C0")]
	public bool isSupported
	{
		[Address(RVA = "0x193EBB0", Offset = "0x193DDB0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AmbientOcclusion", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflections", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.LightMeterMonitor", Member = "ShaderResourcesAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("IsSupported")]
		[Token(Token = "0x600041D")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x193EB20", Offset = "0x193DD20", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000423")]
	private Shader() { }

	[Address(RVA = "0x193E6E0", Offset = "0x193D8E0", Length = "0x6A")]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600041C")]
	public static Shader Find(string name) { }

	[Address(RVA = "0x193EBB0", Offset = "0x193DDB0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AmbientOcclusion", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflections", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.LightMeterMonitor", Member = "ShaderResourcesAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("IsSupported")]
	[Token(Token = "0x600041D")]
	public bool get_isSupported() { }

	[Address(RVA = "0x193EB70", Offset = "0x193DD70", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000424")]
	private static bool get_isSupported_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193E790", Offset = "0x193D990", Length = "0x17D")]
	[CallerCount(Count = 345)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	[Token(Token = "0x6000420")]
	public static int PropertyToID(string name) { }

	[Address(RVA = "0x193E750", Offset = "0x193D950", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000427")]
	private static int PropertyToID_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x193EC70", Offset = "0x193DE70", Length = "0x16A")]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "TryPrepareRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600041E")]
	public static void set_globalRenderPipeline(string value) { }

	[Address(RVA = "0x193EC30", Offset = "0x193DE30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000425")]
	private static void set_globalRenderPipeline_Injected(ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x193E910", Offset = "0x193DB10", Length = "0x41")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000422")]
	public static void SetGlobalFloat(int nameID, float value) { }

	[Address(RVA = "0x193E910", Offset = "0x193DB10", Length = "0x41")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	[Token(Token = "0x6000421")]
	private static void SetGlobalFloatImpl(int name, float value) { }

	[Address(RVA = "0x193E9A0", Offset = "0x193DBA0", Length = "0x17D")]
	[CalledBy(Type = typeof(ScriptableRenderContext), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShaderTagId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("ShaderScripting::TagToID")]
	[Token(Token = "0x600041F")]
	internal static int TagToID(string name) { }

	[Address(RVA = "0x193E960", Offset = "0x193DB60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000426")]
	private static int TagToID_Injected(ref ManagedSpanWrapper name) { }

}

