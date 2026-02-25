namespace System;

[Token(Token = "0x20000C1")]
public static class BitConverter
{
	[CompilerGenerated]
	[Token(Token = "0x20000C2")]
	private sealed class <>c
	{
		[Token(Token = "0x40002C9")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002CA")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"value", "startIndex", "length"})]
		public static SpanAction<Char, ValueTuple`3<Byte[], Int32, Int32>> <>9__38_0; //Field offset: 0x8

		[Address(RVA = "0x14262C0", Offset = "0x14254C0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000455")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000456")]
		public <>c() { }

		[Address(RVA = "0x1425F70", Offset = "0x1425170", Length = "0x207")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000457")]
		internal void <ToString>b__38_0(Span<Char> dst, ValueTuple<Byte[], Int32, Int32> state) { }

	}

	[Intrinsic]
	[Token(Token = "0x40002C8")]
	public static readonly bool IsLittleEndian; //Field offset: 0x0

	[Address(RVA = "0x140BBD0", Offset = "0x140ADD0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000454")]
	private static BitConverter() { }

	[Address(RVA = "0x140B7A0", Offset = "0x140A9A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000452")]
	public static long DoubleToInt64Bits(double value) { }

	[Address(RVA = "0x140B7B0", Offset = "0x140A9B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000453")]
	public static int SingleToInt32Bits(float value) { }

	[Address(RVA = "0x140B7C0", Offset = "0x140A9C0", Length = "0x73")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600044E")]
	public static int ToInt32(Byte[] value, int startIndex) { }

	[Address(RVA = "0x140B870", Offset = "0x140AA70", Length = "0x2DC")]
	[CalledBy(Type = "Mirror.NetworkReader", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.NetworkWriter", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.Extensions", Member = "ToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "DumpBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "DumpBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Mirror.SimpleWeb.ArrayBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "BufferToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), "System.Nullable`1<Int32>"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerHandshake", Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "kcp2k.Extensions", Member = "ToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TState", "System.Buffers.SpanAction`2<Char, TState>"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000450")]
	public static string ToString(Byte[] value, int startIndex, int length) { }

	[Address(RVA = "0x140B840", Offset = "0x140AA40", Length = "0x2C")]
	[CalledBy(Type = typeof(SerializationHeaderRecord), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "PubKeyFingerprint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000451")]
	public static string ToString(Byte[] value) { }

	[Address(RVA = "0x140B7C0", Offset = "0x140A9C0", Length = "0x73")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044F")]
	public static uint ToUInt32(Byte[] value, int startIndex) { }

	[Address(RVA = "0x140BB50", Offset = "0x140AD50", Length = "0x72")]
	[CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x600044D")]
	public static bool TryWriteBytes(Span<Byte> destination, uint value) { }

}

