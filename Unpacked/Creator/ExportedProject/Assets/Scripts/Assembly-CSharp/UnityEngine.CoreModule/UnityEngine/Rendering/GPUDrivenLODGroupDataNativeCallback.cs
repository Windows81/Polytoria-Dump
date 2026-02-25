namespace UnityEngine.Rendering;

[Token(Token = "0x20002E5")]
internal sealed class GPUDrivenLODGroupDataNativeCallback : MulticastDelegate
{

	[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2C")]
	public GPUDrivenLODGroupDataNativeCallback(object object, IntPtr method) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2D")]
	public override void Invoke(in GPUDrivenLODGroupDataNative lodGroupDataNative, GPUDrivenLODGroupDataCallback callback) { }

}

