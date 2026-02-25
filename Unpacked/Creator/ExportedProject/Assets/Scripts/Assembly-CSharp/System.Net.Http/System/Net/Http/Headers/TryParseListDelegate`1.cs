namespace System.Net.Http.Headers;

[Token(Token = "0x2000023")]
internal sealed class TryParseListDelegate : MulticastDelegate
{

	[Address(RVA = "0x100F8C0", Offset = "0x100EAC0", Length = "0xB5")]
	[CalledBy(Type = typeof(HttpHeaders), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E6")]
	public TryParseListDelegate`1(object object, IntPtr method) { }

	[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E7")]
	public override bool Invoke(string value, int minimalCount, out List<T>& result) { }

}

