namespace System.Runtime.CompilerServices;

[Token(Token = "0x200049E")]
internal static class JitHelpers
{

	[Address(RVA = "0x6E83F0", Offset = "0x6E75F0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020A9")]
	internal static T UnsafeCast(object o) { }

	[Address(RVA = "0x6E84D0", Offset = "0x6E76D0", Length = "0x3A")]
	[CalledBy(Type = typeof(EnumEqualityComparer`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EnumEqualityComparer`1), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020AA")]
	internal static int UnsafeEnumCast(T val) { }

	[Address(RVA = "0x6E8430", Offset = "0x6E7630", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020AB")]
	internal static long UnsafeEnumCastLong(T val) { }

}

