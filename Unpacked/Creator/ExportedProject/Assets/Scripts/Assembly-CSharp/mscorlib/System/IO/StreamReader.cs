namespace System.IO;

[Token(Token = "0x2000633")]
public class StreamReader : TextReader
{
	[Token(Token = "0x2000634")]
	private class NullStreamReader : StreamReader
	{

		[Token(Token = "0x17000703")]
		public virtual Stream BaseStream
		{
			[Address(RVA = "0x145DC80", Offset = "0x145CE80", Length = "0x4E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Token(Token = "0x6002D4F")]
			 get { } //Length: 78
		}

		[Token(Token = "0x17000704")]
		public virtual Encoding CurrentEncoding
		{
			[Address(RVA = "0x145DCD0", Offset = "0x145CED0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
			[DeduplicatedMethod]
			[Token(Token = "0x6002D50")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x145DB40", Offset = "0x145CD40", Length = "0x132")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002D4E")]
		internal NullStreamReader() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D51")]
		protected virtual void Dispose(bool disposing) { }

		[Address(RVA = "0x145DC80", Offset = "0x145CE80", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002D4F")]
		public virtual Stream get_BaseStream() { }

		[Address(RVA = "0x145DCD0", Offset = "0x145CED0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D50")]
		public virtual Encoding get_CurrentEncoding() { }

		[Address(RVA = "0x1108420", Offset = "0x1107620", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D52")]
		public virtual int Peek() { }

		[Address(RVA = "0x1108420", Offset = "0x1107620", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D53")]
		public virtual int Read() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D54")]
		public virtual int Read(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D57")]
		internal virtual int ReadBuffer() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D55")]
		public virtual string ReadLine() { }

		[Address(RVA = "0x145DB20", Offset = "0x145CD20", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D56")]
		public virtual string ReadToEnd() { }

	}

	[Token(Token = "0x400191D")]
	public static readonly StreamReader Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400191E")]
	private Stream _stream; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400191F")]
	private Encoding _encoding; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001920")]
	private Decoder _decoder; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001921")]
	private Byte[] _byteBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001922")]
	private Char[] _charBuffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001923")]
	private int _charPos; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001924")]
	private int _charLen; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001925")]
	private int _byteLen; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001926")]
	private int _bytePos; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001927")]
	private int _maxCharsPerBuffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001928")]
	private bool _detectEncoding; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x4001929")]
	private bool _checkPreamble; //Field offset: 0x55
	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x400192A")]
	private bool _isBlocked; //Field offset: 0x56
	[FieldOffset(Offset = "0x57")]
	[Token(Token = "0x400192B")]
	private bool _closable; //Field offset: 0x57
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400192C")]
	private Task _asyncReadTask; //Field offset: 0x58

	[Token(Token = "0x17000700")]
	public override Stream BaseStream
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D3D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006FF")]
	public override Encoding CurrentEncoding
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D3C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000702")]
	public bool EndOfStream
	{
		[Address(RVA = "0x1463F20", Offset = "0x1463120", Length = "0xD9")]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IoModule", Member = "lines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IO.StreamFileUserDataBase", Member = "Eof", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(StreamReader), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002D3F")]
		 get { } //Length: 217
	}

	[Token(Token = "0x17000701")]
	internal bool LeaveOpen
	{
		[Address(RVA = "0x1464000", Offset = "0x1463200", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002D3E")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x14635E0", Offset = "0x14627E0", Length = "0x18C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002D4D")]
	private static StreamReader() { }

	[Address(RVA = "0x1463BB0", Offset = "0x1462DB0", Length = "0x2C1")]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "OpenText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StreamReader))]
	[CalledBy(Type = typeof(File), Member = "InternalReadAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(StreamReader), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(FileOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002D37")]
	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	[Address(RVA = "0x1463850", Offset = "0x1462A50", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002D2E")]
	internal StreamReader() { }

	[Address(RVA = "0x1463E80", Offset = "0x1463080", Length = "0x49")]
	[CalledBy(Type = "MoonSharp.Interpreter.Script", Member = "LoadStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), "MoonSharp.Interpreter.Table", typeof(string)}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IoModule", Member = "lines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IO.StandardIOFileUserDataBase", Member = "CreateInputStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = "MoonSharp.Interpreter.CoreLib.IO.StandardIOFileUserDataBase")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D2F")]
	public StreamReader(Stream stream) { }

	[Address(RVA = "0x1463910", Offset = "0x1462B10", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D30")]
	public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	[Address(RVA = "0x1463820", Offset = "0x1462A20", Length = "0x27")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tokenizer), Member = "ChangeFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnexceptionalStreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CStreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IO.FileUserData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Script", typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D31")]
	public StreamReader(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x1463EF0", Offset = "0x14630F0", Length = "0x24")]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D32")]
	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	[Address(RVA = "0x1463970", Offset = "0x1462B70", Length = "0x239")]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StreamReader), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D33")]
	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	[Address(RVA = "0x1463770", Offset = "0x1462970", Length = "0x44")]
	[CalledBy(Type = typeof(Environment), Member = "ReadXdgUserDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D34")]
	public StreamReader(string path) { }

	[Address(RVA = "0x14637C0", Offset = "0x14629C0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D35")]
	public StreamReader(string path, bool detectEncodingFromByteOrderMarks) { }

	[Address(RVA = "0x1463ED0", Offset = "0x14630D0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D36")]
	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	[Address(RVA = "0x1461650", Offset = "0x1460850", Length = "0x58")]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(StreamReader), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002D2C")]
	private void CheckAsyncTaskInProgress() { }

	[Address(RVA = "0x1354D40", Offset = "0x1353F40", Length = "0x16")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D3A")]
	public virtual void Close() { }

	[Address(RVA = "0x14616B0", Offset = "0x14608B0", Length = "0x3E")]
	[CalledBy(Type = typeof(StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = "IsPreamble", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D46")]
	private void CompressBuffer(int n) { }

	[Address(RVA = "0x14616F0", Offset = "0x14608F0", Length = "0xA")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "InputPending", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "QueueEcho", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002D4C")]
	internal bool DataAvailable() { }

	[Address(RVA = "0x1461700", Offset = "0x1460900", Length = "0x2EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF32", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamReader), Member = "CompressBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002D47")]
	private void DetectEncoding() { }

	[Address(RVA = "0x14619F0", Offset = "0x1460BF0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FF90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002D3B")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D3D")]
	public override Stream get_BaseStream() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D3C")]
	public override Encoding get_CurrentEncoding() { }

	[Address(RVA = "0x1463F20", Offset = "0x1463120", Length = "0xD9")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IoModule", Member = "lines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IO.StreamFileUserDataBase", Member = "Eof", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(StreamReader), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002D3F")]
	public bool get_EndOfStream() { }

	[Address(RVA = "0x1464000", Offset = "0x1463200", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002D3E")]
	internal bool get_LeaveOpen() { }

	[Address(RVA = "0x1461A90", Offset = "0x1460C90", Length = "0x162")]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002D38")]
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	[Address(RVA = "0x1461A70", Offset = "0x1460C70", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002D39")]
	internal void Init(Stream stream) { }

	[Address(RVA = "0x1461C00", Offset = "0x1460E00", Length = "0x122")]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StreamReader), Member = "CompressBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002D48")]
	private bool IsPreamble() { }

	[Address(RVA = "0x1461D30", Offset = "0x1460F30", Length = "0x106")]
	[CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "Peek", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CStreamReader), Member = "Peek", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(StreamReader), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D40")]
	public virtual int Peek() { }

	[Address(RVA = "0x14632B0", Offset = "0x14624B0", Length = "0x103")]
	[CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "Read", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(StreamReader), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D41")]
	public virtual int Read() { }

	[Address(RVA = "0x14633C0", Offset = "0x14625C0", Length = "0x1C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamReader), Member = "ReadSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D42")]
	public virtual int Read(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1461E40", Offset = "0x1461040", Length = "0x216")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D45")]
	public virtual int ReadBlock(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1462060", Offset = "0x1461260", Length = "0x4BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF32", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StreamReader), Member = "IsPreamble", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamReader), Member = "CompressBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002D49")]
	internal override int ReadBuffer() { }

	[Address(RVA = "0x1462520", Offset = "0x1461720", Length = "0x6D8")]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(StreamReader), Member = "CompressBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StreamReader), Member = "IsPreamble", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF32", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187E10")]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002D4A")]
	private int ReadBuffer(Span<Char> userBuffer, out bool readToUserBuffer) { }

	[Address(RVA = "0x1462C00", Offset = "0x1461E00", Length = "0x297")]
	[CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "ReadLine", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(StreamReader), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6002D4B")]
	public virtual string ReadLine() { }

	[Address(RVA = "0x1462EA0", Offset = "0x14620A0", Length = "0x289")]
	[CalledBy(Type = typeof(StreamReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StreamReader), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187B70")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D43")]
	private int ReadSpan(Span<Char> buffer) { }

	[Address(RVA = "0x1463130", Offset = "0x1462330", Length = "0x173")]
	[CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(StreamReader), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002D44")]
	public virtual string ReadToEnd() { }

	[Address(RVA = "0x1463590", Offset = "0x1462790", Length = "0x4E")]
	[CalledBy(Type = typeof(StreamReader), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = "get_EndOfStream", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StreamReader), Member = "Peek", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StreamReader), Member = "Read", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadLine", ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002D2D")]
	private static void ThrowAsyncIOInProgress() { }

}

