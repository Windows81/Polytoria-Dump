namespace System.Runtime;

[Token(Token = "0x2000333")]
public static class RuntimeImports
{

	[Address(RVA = "0x1374070", Offset = "0x1373270", Length = "0x5")]
	[CalledBy(Type = typeof(Number), Member = "DoubleToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C410")]
	[Token(Token = "0x60019BB")]
	internal static void _ecvt_s(Byte* buffer, int sizeInBytes, double value, int count, Int32* dec, Int32* sign) { }

	[Address(RVA = "0x1374040", Offset = "0x1373240", Length = "0x5")]
	[CalledBy(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C360")]
	[Token(Token = "0x60019B9")]
	internal static void Memmove(Byte* dest, Byte* src, uint len) { }

	[Address(RVA = "0x1374050", Offset = "0x1373250", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C370")]
	[Token(Token = "0x60019BA")]
	internal static void Memmove_wbarrier(Byte* dest, Byte* src, uint len, IntPtr type_handle) { }

	[Address(RVA = "0x1374060", Offset = "0x1373260", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C400")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019B7")]
	internal static void RhZeroMemory(ref byte b, ulong byteLength) { }

	[Address(RVA = "0x1374060", Offset = "0x1373260", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C400")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019B8")]
	private static void ZeroMemory(Void* p, uint byteLength) { }

}

