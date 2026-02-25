namespace System;

[Token(Token = "0x20001C3")]
internal class TermInfoDriver : IConsoleDriver
{
	[Token(Token = "0x4000737")]
	private static Int32* native_terminal_size; //Field offset: 0x0
	[Token(Token = "0x4000738")]
	private static int terminal_size; //Field offset: 0x8
	[Token(Token = "0x4000739")]
	private static readonly String[] locations; //Field offset: 0x10
	[Token(Token = "0x4000760")]
	private static readonly Int32[] _consoleColorToAnsiCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400073A")]
	private TermInfoReader reader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400073B")]
	private int cursorLeft; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400073C")]
	private int cursorTop; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400073D")]
	private string title; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400073E")]
	private string titleFormat; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400073F")]
	private bool cursorVisible; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000740")]
	private string csrVisible; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000741")]
	private string csrInvisible; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000742")]
	private string clear; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000743")]
	private string bell; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000744")]
	private string term; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000745")]
	private StreamReader stdin; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000746")]
	private CStreamWriter stdout; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000747")]
	private int windowWidth; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000748")]
	private int windowHeight; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000749")]
	private int bufferHeight; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400074A")]
	private int bufferWidth; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400074B")]
	private Char[] buffer; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400074C")]
	private int readpos; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400074D")]
	private int writepos; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400074E")]
	private string keypadXmit; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400074F")]
	private string keypadLocal; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000750")]
	private bool inited; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000751")]
	private object initLock; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000752")]
	private bool initKeys; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000753")]
	private string origPair; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000754")]
	private string origColors; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000755")]
	private string cursorAddress; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000756")]
	private ConsoleColor fgcolor; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000757")]
	private string setfgcolor; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000758")]
	private string setbgcolor; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000759")]
	private int maxColors; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x400075A")]
	private bool noGetPosition; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400075B")]
	private Hashtable keymap; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400075C")]
	private ByteMatcher rootmap; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400075D")]
	private int rl_startx; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400075E")]
	private int rl_starty; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400075F")]
	private Byte[] control_characters; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000761")]
	private Char[] echobuf; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000762")]
	private int echon; //Field offset: 0x118

	[Token(Token = "0x1700016E")]
	public override ConsoleColor ForegroundColor
	{
		[Address(RVA = "0x1504AA0", Offset = "0x1503CA0", Length = "0x1B8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ParameterizedStrings), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FormatParam[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000FEB")]
		 set { } //Length: 440
	}

	[Token(Token = "0x1700016D")]
	public override bool Initialized
	{
		[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FE3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700016F")]
	public override int WindowHeight
	{
		[Address(RVA = "0x1504A40", Offset = "0x1503C40", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
		[Token(Token = "0x6000FEE")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000170")]
	public override int WindowWidth
	{
		[Address(RVA = "0x1504A70", Offset = "0x1503C70", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
		[Token(Token = "0x6000FEF")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1504130", Offset = "0x1503330", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001003")]
	private static TermInfoDriver() { }

	[Address(RVA = "0x15042D0", Offset = "0x15034D0", Length = "0x767")]
	[CalledBy(Type = typeof(ConsoleDriver), Member = "CreateTermInfoDriver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IConsoleDriver))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CStreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "OpenStandardOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(TermInfoReader), Member = "ReadNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoReader), Member = "ReadHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(TermInfoDriver), Member = "TryTermInfoDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FE2")]
	public TermInfoDriver(string term) { }

	[Address(RVA = "0x14FE840", Offset = "0x14FDA40", Length = "0x195")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ByteMatcher), Member = "AddMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoStrings), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001002")]
	private void AddStringMapping(TermInfoStrings s) { }

	[Address(RVA = "0x14FE9E0", Offset = "0x14FDBE0", Length = "0x107")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000FF0")]
	private void AddToBuffer(int b) { }

	[Address(RVA = "0x14FEAF0", Offset = "0x14FDCF0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000FF1")]
	private void AdjustBuffer() { }

	[Address(RVA = "0x14FEB10", Offset = "0x14FDD10", Length = "0x192")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParameterizedStrings), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FormatParam[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FEA")]
	private void ChangeColor(string format, ConsoleColor color) { }

	[Address(RVA = "0x14FECB0", Offset = "0x14FDEB0", Length = "0x159")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "IncrementX", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "get_WindowHeight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "get_WindowWidth", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TermInfoReader), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoNumbers)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FED")]
	private void CheckWindowDimensions() { }

	[Address(RVA = "0x14FEE10", Offset = "0x14FE010", Length = "0x11C")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000FF2")]
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	[Address(RVA = "0x14FEF60", Offset = "0x14FE160", Length = "0x2817")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 60)]
	[Token(Token = "0x6001000")]
	private void CreateKeyMap() { }

	[Address(RVA = "0x15017D0", Offset = "0x15009D0", Length = "0x192")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000FF7")]
	private void Echo(ConsoleKeyInfo key) { }

	[Address(RVA = "0x1501780", Offset = "0x1500980", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FF8")]
	private void EchoFlush() { }

	[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FE3")]
	public override bool get_Initialized() { }

	[Address(RVA = "0x1504A40", Offset = "0x1503C40", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	[Token(Token = "0x6000FEE")]
	public override int get_WindowHeight() { }

	[Address(RVA = "0x1504A70", Offset = "0x1503C70", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	[Token(Token = "0x6000FEF")]
	public override int get_WindowWidth() { }

	[Address(RVA = "0x1501970", Offset = "0x1500B70", Length = "0x2DC")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B460")]
	[Calls(Type = typeof(TermInfoDriver), Member = "AddToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6000FEC")]
	private void GetCursorPosition() { }

	[Address(RVA = "0x1501C50", Offset = "0x1500E50", Length = "0x3FC")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ByteMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(TermInfoStrings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000FF3")]
	private object GetKeyFromBuffer(bool cooked) { }

	[Address(RVA = "0x1502050", Offset = "0x1501250", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	[Token(Token = "0x6000FE5")]
	private void IncrementX() { }

	[Address(RVA = "0x15022D0", Offset = "0x15014D0", Length = "0xB0C")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "IncrementX", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "get_WindowHeight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "get_WindowWidth", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ResetColor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B6B0")]
	[Calls(Type = typeof(TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TermInfoReader), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoStrings)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TermInfoReader), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoNumbers)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B5F0")]
	[Calls(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000FE4")]
	public override void Init() { }

	[Address(RVA = "0x15020E0", Offset = "0x15012E0", Length = "0x1EA")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TermInfoDriver), Member = "CreateKeyMap", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "AddStringMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoStrings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteMatcher), Member = "AddMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoStrings), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001001")]
	private void InitKeys() { }

	[Address(RVA = "0x1502DE0", Offset = "0x1501FE0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FF5")]
	private bool InputPending() { }

	[Address(RVA = "0x1502E20", Offset = "0x1502020", Length = "0x4D")]
	[CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000FE9")]
	public bool IsSpecialKey(char c) { }

	[Address(RVA = "0x1502E70", Offset = "0x1502070", Length = "0x104")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FE8")]
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	[Address(RVA = "0x1502F90", Offset = "0x1502190", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000FF6")]
	private void QueueEcho(char c) { }

	[Address(RVA = "0x15035E0", Offset = "0x15027E0", Length = "0x351")]
	[CalledBy(Type = typeof(CStreamReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TermInfoDriver), Member = "AddToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FF9")]
	public int Read(out Char[] dest, int index, int count) { }

	[Address(RVA = "0x15032B0", Offset = "0x15024B0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FFA")]
	public override ConsoleKeyInfo ReadKey(bool intercept) { }

	[Address(RVA = "0x1503090", Offset = "0x1502290", Length = "0x211")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B460")]
	[Calls(Type = typeof(StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TermInfoDriver), Member = "AddToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000FF4")]
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	[Address(RVA = "0x1503370", Offset = "0x1502570", Length = "0xA")]
	[CalledBy(Type = typeof(CStreamReader), Member = "ReadLine", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000FFB")]
	public override string ReadLine() { }

	[Address(RVA = "0x1503380", Offset = "0x1502580", Length = "0xA")]
	[CalledBy(Type = typeof(CStreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000FFC")]
	public string ReadToEnd() { }

	[Address(RVA = "0x1503390", Offset = "0x1502590", Length = "0x249")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadLine", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadToEnd", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FFD")]
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	[Address(RVA = "0x1503940", Offset = "0x1502B40", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FFE")]
	public override void ResetColor() { }

	[Address(RVA = "0x15039A0", Offset = "0x1502BA0", Length = "0x175")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TermInfoDriver), Member = "TryTermInfoDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FE0")]
	private static string SearchTerminfo(string term) { }

	[Address(RVA = "0x1504AA0", Offset = "0x1503CA0", Length = "0x1B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ParameterizedStrings), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FormatParam[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FEB")]
	public override void set_ForegroundColor(ConsoleColor value) { }

	[Address(RVA = "0x1503B20", Offset = "0x1502D20", Length = "0x271")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParameterizedStrings), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FormatParam[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FFF")]
	public override void SetCursorPosition(int left, int top) { }

	[Address(RVA = "0x1503DA0", Offset = "0x1502FA0", Length = "0x10D")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "SearchTerminfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FDF")]
	private static string TryTermInfoDir(string dir, string term) { }

	[Address(RVA = "0x1503EB0", Offset = "0x15030B0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FE1")]
	private void WriteConsole(string str) { }

	[Address(RVA = "0x1503EE0", Offset = "0x15030E0", Length = "0x4D")]
	[CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000FE7")]
	public void WriteSpecialKey(char c) { }

	[Address(RVA = "0x1503F30", Offset = "0x1503130", Length = "0x58")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000FE6")]
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

}

