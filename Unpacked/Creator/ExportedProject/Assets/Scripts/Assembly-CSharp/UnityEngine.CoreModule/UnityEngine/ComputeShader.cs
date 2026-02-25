namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Graphics/RayTracing/RayTracingAccelerationStructure.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[Token(Token = "0x200017A")]
[UsedByNativeCode]
public sealed class ComputeShader : object
{

	[Address(RVA = "0x195EEB0", Offset = "0x195E0B0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A89")]
	private ComputeShader() { }

	[Address(RVA = "0x195EBE0", Offset = "0x195DDE0", Length = "0x1BB")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.WaveformMonitor", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Color), typeof(float)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(float)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.LogHistogram", Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.VectorscopeMonitor", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "PushUpsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), typeof(int), typeof(int), "System.Nullable`1<Int32>", typeof(RenderTargetIdentifier), typeof(Vector3), typeof(Vector2), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.HistogramMonitor", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "PushDownsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AutoExposureRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "PushRenderCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), typeof(int), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000A87")]
	public int FindKernel(string name) { }

	[Address(RVA = "0x195EB90", Offset = "0x195DD90", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A8A")]
	private static int FindKernel_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x195EE00", Offset = "0x195E000", Length = "0xA7")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "PushRenderCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), typeof(int), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.LogHistogram", Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureLerper", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(float)}, ReturnType = typeof(Texture))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6000A88")]
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[Address(RVA = "0x195EDA0", Offset = "0x195DFA0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A8B")]
	private static void GetKernelThreadGroupSizes_Injected(IntPtr _unity_self, int kernelIndex, out uint x, out uint y, out uint z) { }

}

