namespace UnityEngine.Rendering;

[RequiredByNativeCode]
[Token(Token = "0x20002E8")]
internal static class GPUDrivenCallbacks
{

	[Address(RVA = "0x1980D70", Offset = "0x197FF70", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000E32")]
	public static void InvokeGPUDrivenLODGroupDataNativeCallback(GPUDrivenLODGroupDataNativeCallback callback, in GPUDrivenLODGroupDataNative lodGroupDataNative, GPUDrivenLODGroupDataCallback target) { }

	[Address(RVA = "0x1980DA0", Offset = "0x197FFA0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000E33")]
	public static void InvokeGPUDrivenRendererDataNativeCallback(GPUDrivenRendererDataNativeCallback callback, in GPUDrivenRendererGroupDataNative rendererDataNative, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback target) { }

}

