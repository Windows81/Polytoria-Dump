namespace System.IO;

[Token(Token = "0x2000662")]
internal class UnexceptionalStreamReader : StreamReader
{
	[Token(Token = "0x4001A12")]
	private static Boolean[] newline; //Field offset: 0x0
	[Token(Token = "0x4001A13")]
	private static char newlineChar; //Field offset: 0x8

	[Address(RVA = "0x147F880", Offset = "0x147EA80", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002F7E")]
	private static UnexceptionalStreamReader() { }

	[Address(RVA = "0x147F930", Offset = "0x147EB30", Length = "0x69")]
	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F7F")]
	public UnexceptionalStreamReader(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x147F3E0", Offset = "0x147E5E0", Length = "0x1D1")]
	[CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002F83")]
	private bool CheckEOL(char current) { }

	[Address(RVA = "0x146FD90", Offset = "0x146EF90", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "Peek", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F80")]
	public virtual int Peek() { }

	[Address(RVA = "0x147F860", Offset = "0x147EA60", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "Read", ReturnType = typeof(int))]
	[Token(Token = "0x6002F81")]
	public virtual int Read() { }

	[Address(RVA = "0x147F600", Offset = "0x147E800", Length = "0x25C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StreamReader), Member = "Read", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnexceptionalStreamReader), Member = "CheckEOL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F82")]
	public virtual int Read(out Char[] dest_buffer, int index, int count) { }

	[Address(RVA = "0x147F5C0", Offset = "0x147E7C0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "ReadLine", ReturnType = typeof(string))]
	[Token(Token = "0x6002F84")]
	public virtual string ReadLine() { }

	[Address(RVA = "0x147F5E0", Offset = "0x147E7E0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
	[Token(Token = "0x6002F85")]
	public virtual string ReadToEnd() { }

}

