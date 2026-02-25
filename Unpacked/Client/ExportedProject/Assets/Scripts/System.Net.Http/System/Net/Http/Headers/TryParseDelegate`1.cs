namespace System.Net.Http.Headers;

[Token(Token = "0x2000022")]
internal sealed class TryParseDelegate : MulticastDelegate
{

	[Address(RVA = "0x100F800", Offset = "0x100EA00", Length = "0xB5")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E4")]
	public TryParseDelegate`1(object object, IntPtr method) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E5")]
	public override bool Invoke(string value, out T result) { }

}

