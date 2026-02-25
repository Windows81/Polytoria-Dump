namespace UnityEngine.Rendering;

[Token(Token = "0x20002E7")]
internal sealed class GPUDrivenRendererDataNativeCallback : MulticastDelegate
{

	[Address(RVA = "0x16067D0", Offset = "0x16059D0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E30")]
	public GPUDrivenRendererDataNativeCallback(object object, IntPtr method) { }

	[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E31")]
	public override void Invoke(in GPUDrivenRendererGroupDataNative rendererDataNative, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback) { }

}

