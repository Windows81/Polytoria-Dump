namespace System.IO;

[Token(Token = "0x2000663")]
internal class UnexceptionalStreamWriter : StreamWriter
{

	[Address(RVA = "0x147FA40", Offset = "0x147EC40", Length = "0x7B")]
	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F86")]
	public UnexceptionalStreamWriter(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x147F9A0", Offset = "0x147EBA0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Flush", ReturnType = typeof(void))]
	[Token(Token = "0x6002F87")]
	public virtual void Flush() { }

	[Address(RVA = "0x147FA00", Offset = "0x147EC00", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F88")]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x147F9C0", Offset = "0x147EBC0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F89")]
	public virtual void Write(char value) { }

	[Address(RVA = "0x147FA20", Offset = "0x147EC20", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F8A")]
	public virtual void Write(Char[] value) { }

	[Address(RVA = "0x147F9E0", Offset = "0x147EBE0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F8B")]
	public virtual void Write(string value) { }

}

