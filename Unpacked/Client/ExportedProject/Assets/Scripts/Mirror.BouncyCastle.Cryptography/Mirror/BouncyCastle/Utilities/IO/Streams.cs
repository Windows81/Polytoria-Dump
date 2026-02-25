namespace Mirror.BouncyCastle.Utilities.IO;

[Token(Token = "0x2000010")]
public static class Streams
{
	[CompilerGenerated]
	[Token(Token = "0x2000011")]
	private struct <CopyToAsync>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400000C")]
		public int bufferSize; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400000D")]
		public Stream destination; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400000E")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400000F")]
		public Stream source; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000010")]
		private Byte[] <buffer>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000011")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000012")]
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x58

		[Address(RVA = "0x10C5400", Offset = "0x10C4600", Length = "0x384")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<CopyToAsync>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<CopyToAsync>d__8&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Int32>), typeof(<CopyToAsync>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Int32>&), typeof(<CopyToAsync>d__8&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600006D")]
		private override void MoveNext() { }

		[Address(RVA = "0x10C5790", Offset = "0x10C4990", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x600006E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x4000009")]
	private static readonly int MaxStackAlloc; //Field offset: 0x0

	[Token(Token = "0x1700000C")]
	public static int DefaultBufferSize
	{
		[Address(RVA = "0x10C3D70", Offset = "0x10C2F70", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x10C3D00", Offset = "0x10C2F00", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600006C")]
	private static Streams() { }

	[Address(RVA = "0x10C3630", Offset = "0x10C2830", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000065")]
	public static void CopyTo(Stream source, Stream destination, int bufferSize) { }

	[Address(RVA = "0x10C34F0", Offset = "0x10C26F0", Length = "0x134")]
	[AsyncStateMachine(typeof(<CopyToAsync>d__8))]
	[CalledBy(Type = typeof(BaseInputStream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(FilterStream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsync>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsync>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000066")]
	public static Task CopyToAsync(Stream source, Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[Address(RVA = "0x10C3D70", Offset = "0x10C2F70", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000064")]
	public static int get_DefaultBufferSize() { }

	[Address(RVA = "0x10C3700", Offset = "0x10C2900", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000067")]
	public static void PipeAll(Stream inStr, Stream outStr) { }

	[Address(RVA = "0x10C3870", Offset = "0x10C2A70", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000068")]
	public static void PipeAll(Stream inStr, Stream outStr, int bufferSize) { }

	[Address(RVA = "0x10C3970", Offset = "0x10C2B70", Length = "0x1D1")]
	[CalledBy(Type = typeof(BerBitStringParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(BerBitString))]
	[CalledBy(Type = typeof(BerOctetStringParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(BerOctetString))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000069")]
	public static Byte[] ReadAll(Stream inStr) { }

	[Address(RVA = "0x10C3B50", Offset = "0x10C2D50", Length = "0x96")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "CreateDerBmpString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefiniteLengthInputStream)}, ReturnType = typeof(DerBmpString))]
	[CalledBy(Type = typeof(DefiniteLengthInputStream), Member = "ReadAllIntoByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefiniteLengthInputStream), Member = "ToArray", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006A")]
	public static int ReadFully(Stream inStr, Byte[] buf, int off, int len) { }

	[Address(RVA = "0x10C3BF0", Offset = "0x10C2DF0", Length = "0x102")]
	[CalledBy(Type = typeof(ConstructedBitStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ConstructedOctetStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600006B")]
	public static void ValidateBufferArguments(Byte[] buffer, int offset, int count) { }

}

