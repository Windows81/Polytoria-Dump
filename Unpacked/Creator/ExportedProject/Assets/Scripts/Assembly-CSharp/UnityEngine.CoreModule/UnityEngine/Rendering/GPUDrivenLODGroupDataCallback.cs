namespace UnityEngine.Rendering;

[Token(Token = "0x20002E4")]
internal sealed class GPUDrivenLODGroupDataCallback : MulticastDelegate
{

	[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2A")]
	public GPUDrivenLODGroupDataCallback(object object, IntPtr method) { }

	[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2B")]
	public override void Invoke(in GPUDrivenLODGroupData lodGroupData) { }

}

