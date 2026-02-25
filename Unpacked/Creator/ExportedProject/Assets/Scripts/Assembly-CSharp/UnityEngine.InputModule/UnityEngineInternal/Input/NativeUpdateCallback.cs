namespace UnityEngineInternal.Input;

[Token(Token = "0x2000002")]
internal sealed class NativeUpdateCallback : MulticastDelegate
{

	[Address(RVA = "0x3914F0", Offset = "0x3906F0", Length = "0xA6")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000001")]
	public NativeUpdateCallback(object object, IntPtr method) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000002")]
	public override void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

}

