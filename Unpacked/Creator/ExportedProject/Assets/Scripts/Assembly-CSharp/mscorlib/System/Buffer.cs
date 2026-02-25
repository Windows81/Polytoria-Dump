namespace System;

[ComVisible(True)]
[Token(Token = "0x200017C")]
public static class Buffer
{

	[Address(RVA = "0x14D15E0", Offset = "0x14D07E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C1B0")]
	[Token(Token = "0x6000D50")]
	private static int _ByteLength(Array array) { }

	[Address(RVA = "0x14D0D10", Offset = "0x14CFF10", Length = "0x287")]
	[CallerCount(Count = 230)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BE80")]
	[Calls(Type = typeof(Buffer), Member = "ByteLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D55")]
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[Address(RVA = "0x14D0FA0", Offset = "0x14D01A0", Length = "0xAB")]
	[CalledBy(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C1B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D54")]
	public static int ByteLength(Array array) { }

	[Address(RVA = "0x14D1050", Offset = "0x14D0250", Length = "0xAF")]
	[CalledBy(Type = typeof(ByteEqualityComparer), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000D4F")]
	internal static int IndexOfByte(Byte* src, byte value, int index, int count) { }

	[Address(RVA = "0x14D1100", Offset = "0x14D0300", Length = "0x5")]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BE80")]
	[Token(Token = "0x6000D4E")]
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	[Address(RVA = "0x14D1110", Offset = "0x14D0310", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BF80")]
	[Token(Token = "0x6000D53")]
	internal static void InternalMemcpy(Byte* dest, Byte* src, int count) { }

	[Address(RVA = "0x14D1410", Offset = "0x14D0610", Length = "0x48")]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000D52")]
	internal static void Memcpy(Byte* pDest, int destIndex, Byte[] src, int srcIndex, int len) { }

	[Address(RVA = "0x14D1120", Offset = "0x14D0320", Length = "0x2E2")]
	[CalledBy(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Marshal), Member = "WriteInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(short)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString), typeof(SecureStringAllocator)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Marshal), Member = "ReadInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Marshal), Member = "ReadInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Marshal), Member = "ClearUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "ZeroFreeBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "ClearBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(string), Member = "memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.UriComponents"}, ReturnType = typeof(string))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BF80")]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Token(Token = "0x6000D5A")]
	internal static void Memcpy(Byte* dest, Byte* src, int len) { }

	[Address(RVA = "0x14D15F0", Offset = "0x14D07F0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D59")]
	private static void memcpy1(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x14D16A0", Offset = "0x14D08A0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D58")]
	internal static void memcpy2(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x14D1720", Offset = "0x14D0920", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D57")]
	internal static void memcpy4(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x14D1460", Offset = "0x14D0660", Length = "0x2C")]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeImports), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D5B")]
	internal static void Memmove(Byte* dest, Byte* src, uint len) { }

	[Address(RVA = "0x6852D0", Offset = "0x6844D0", Length = "0x10")]
	[CalledBy(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadOnlySpan`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnlySpan`1), Member = "ToArray", ReturnType = "T[]")]
	[CalledBy(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Span`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Span`1), Member = "ToArray", ReturnType = "T[]")]
	[CalledBy(Type = typeof(File), Member = "ReadAllBytesUnknownLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileStream)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D5C")]
	internal static void Memmove(ref T destination, ref T source, ulong elementCount) { }

	[Address(RVA = "0x14D1490", Offset = "0x14D0690", Length = "0x121")]
	[CalledBy(Type = typeof(CompareInfo), Member = "InvariantCreateSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = "System.Collections.SortedList+ValueList", Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamWriter), Member = "WriteSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "U8Xml.Internal.RawStringPairList", Member = "Growup", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeImports), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D56")]
	public static void MemoryCopy(Void* source, Void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	[Address(RVA = "0x14D15C0", Offset = "0x14D07C0", Length = "0x20")]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000D51")]
	internal static void ZeroMemory(Byte* src, long len) { }

}

