namespace System.IO;

[Token(Token = "0x2000665")]
internal class CStreamWriter : StreamWriter
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A15")]
	private TermInfoDriver driver; //Field offset: 0x70

	[Address(RVA = "0x14705D0", Offset = "0x146F7D0", Length = "0x157")]
	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6002F92")]
	public CStreamWriter(Stream stream, Encoding encoding, bool leaveOpen) { }

	[Address(RVA = "0x1470150", Offset = "0x146F350", Length = "0x14")]
	[CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F96")]
	public void InternalWriteChar(char val) { }

	[Address(RVA = "0x1470170", Offset = "0x146F370", Length = "0x20")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "QueueEcho", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "EchoFlush", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F97")]
	public void InternalWriteChars(Char[] buffer, int n) { }

	[Address(RVA = "0x1470190", Offset = "0x146F390", Length = "0x14")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "WriteConsole", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ChangeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ResetColor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002F95")]
	public void InternalWriteString(string val) { }

	[Address(RVA = "0x1470210", Offset = "0x146F410", Length = "0x21B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002F93")]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1470430", Offset = "0x146F630", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002F94")]
	public virtual void Write(char val) { }

	[Address(RVA = "0x1470590", Offset = "0x146F790", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002F98")]
	public virtual void Write(Char[] val) { }

	[Address(RVA = "0x1470520", Offset = "0x146F720", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002F99")]
	public virtual void Write(string val) { }

	[Address(RVA = "0x14701B0", Offset = "0x146F3B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002F9A")]
	public virtual void WriteLine(string val) { }

}

