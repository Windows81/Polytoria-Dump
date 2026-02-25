namespace System.IO;

[Token(Token = "0x2000664")]
internal class CStreamReader : StreamReader
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A14")]
	private TermInfoDriver driver; //Field offset: 0x60

	[Address(RVA = "0x1470020", Offset = "0x146F220", Length = "0x12C")]
	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6002F8C")]
	public CStreamReader(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x146FD90", Offset = "0x146EF90", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "Peek", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F8D")]
	public virtual int Peek() { }

	[Address(RVA = "0x146FE10", Offset = "0x146F010", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Console), Member = "ReadKey", ReturnType = typeof(ConsoleKeyInfo))]
	[Token(Token = "0x6002F8E")]
	public virtual int Read() { }

	[Address(RVA = "0x146FE70", Offset = "0x146F070", Length = "0x1A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F8F")]
	public virtual int Read(out Char[] dest, int index, int count) { }

	[Address(RVA = "0x146FDB0", Offset = "0x146EFB0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002F90")]
	public virtual string ReadLine() { }

	[Address(RVA = "0x146FDE0", Offset = "0x146EFE0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadToEnd", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002F91")]
	public virtual string ReadToEnd() { }

}

