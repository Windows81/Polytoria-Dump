namespace System.Buffers;

[Token(Token = "0x2000608")]
public sealed class SpanAction : MulticastDelegate
{

	[Address(RVA = "0xA32D20", Offset = "0xA31F20", Length = "0xA6")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C40")]
	public SpanAction`2(object object, IntPtr method) { }

	[Address(RVA = "0x9B31D0", Offset = "0x9B23D0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C41")]
	public override void Invoke(Span<T> span, TArg arg) { }

}

