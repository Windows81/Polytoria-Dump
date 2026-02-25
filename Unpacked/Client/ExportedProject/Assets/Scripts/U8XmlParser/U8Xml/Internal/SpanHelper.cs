namespace U8Xml.Internal;

[Extension]
[Token(Token = "0x200002E")]
internal static class SpanHelper
{

	[Address(RVA = "0x180A2D0", Offset = "0x18094D0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Extension]
	[Token(Token = "0x60000E0")]
	public static byte At(ReadOnlySpan<Byte> span, int index) { }

	[Address(RVA = "0x75C780", Offset = "0x75B980", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DE")]
	public static ReadOnlySpan<T> CreateReadOnlySpan(Void* ptr, int length) { }

	[Address(RVA = "0x75C780", Offset = "0x75B980", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DF")]
	public static Span<T> CreateSpan(Void* ptr, int length) { }

	[Address(RVA = "0x180A2F0", Offset = "0x18094F0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Extension]
	[Token(Token = "0x60000E1")]
	internal static ReadOnlySpan<Byte> SliceUnsafe(ReadOnlySpan<Byte> span, int start, int length) { }

	[Address(RVA = "0x180A610", Offset = "0x1809810", Length = "0x225")]
	[CalledBy(Type = typeof(RawString), Member = "FloatFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x60000E2")]
	internal static ReadOnlySpan<Byte> Trim(ReadOnlySpan<Byte> span) { }

	[Address(RVA = "0x180A3A0", Offset = "0x18095A0", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x60000E4")]
	internal static ReadOnlySpan<Byte> TrimEnd(ReadOnlySpan<Byte> span) { }

	[Address(RVA = "0x180A4C0", Offset = "0x18096C0", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x60000E3")]
	internal static ReadOnlySpan<Byte> TrimStart(ReadOnlySpan<Byte> span) { }

}

