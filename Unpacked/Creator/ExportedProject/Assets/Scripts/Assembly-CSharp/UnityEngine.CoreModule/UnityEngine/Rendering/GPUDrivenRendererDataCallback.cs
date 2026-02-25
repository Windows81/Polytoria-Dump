namespace UnityEngine.Rendering;

[Token(Token = "0x20002E6")]
internal sealed class GPUDrivenRendererDataCallback : MulticastDelegate
{

	[Address(RVA = "0x1606420", Offset = "0x1605620", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2E")]
	public GPUDrivenRendererDataCallback(object object, IntPtr method) { }

	[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2F")]
	public override void Invoke(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials) { }

}

