namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200004C")]
internal static class BurstRuntime
{
	[Token(Token = "0x200004D")]
	private struct HashCode64
	{
		[Token(Token = "0x40000BC")]
		public static readonly long Value; //Field offset: 0x0

		[Address(RVA = "0xC5BC80", Offset = "0xC5AE80", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C8")]
		private static HashCode64`1() { }

	}


	[Address(RVA = "0x6854B0", Offset = "0x6846B0", Length = "0x75")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C6")]
	public static long GetHashCode64() { }

	[Address(RVA = "0x181A070", Offset = "0x1819270", Length = "0x81")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C7")]
	internal static long HashStringWithFNV1A64(string text) { }

}

