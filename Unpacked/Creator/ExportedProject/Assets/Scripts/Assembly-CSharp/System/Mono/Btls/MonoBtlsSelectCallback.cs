namespace Mono.Btls;

[Token(Token = "0x2000080")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class MonoBtlsSelectCallback : MulticastDelegate
{

	[Address(RVA = "0x102BF10", Offset = "0x102B110", Length = "0xB4")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000227")]
	public MonoBtlsSelectCallback(object object, IntPtr method) { }

	[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000228")]
	public override int Invoke(String[] acceptableIssuers) { }

}

