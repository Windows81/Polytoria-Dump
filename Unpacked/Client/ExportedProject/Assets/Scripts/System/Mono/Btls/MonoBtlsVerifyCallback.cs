namespace Mono.Btls;

[Token(Token = "0x200007F")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class MonoBtlsVerifyCallback : MulticastDelegate
{

	[Address(RVA = "0xC44560", Offset = "0xC43760", Length = "0x124")]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000225")]
	public MonoBtlsVerifyCallback(object object, IntPtr method) { }

	[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000226")]
	public override int Invoke(MonoBtlsX509StoreCtx ctx) { }

}

