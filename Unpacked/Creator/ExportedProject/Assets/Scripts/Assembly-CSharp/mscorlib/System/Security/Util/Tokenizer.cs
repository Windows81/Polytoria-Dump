namespace System.Security.Util;

[Token(Token = "0x20002C9")]
internal sealed class Tokenizer
{
	[Token(Token = "0x20002CC")]
	public interface ITokenReader
	{

		[Token(Token = "0x6001732")]
		public int Read() { }

	}

	[Token(Token = "0x20002CD")]
	public class StreamTokenReader : ITokenReader
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C45")]
		internal StreamReader _in; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C46")]
		internal int _numCharRead; //Field offset: 0x18

		[Token(Token = "0x17000259")]
		internal int NumCharEncountered
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001735")]
			internal get { } //Length: 4
		}

		[Address(RVA = "0x351D60", Offset = "0x350F60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001733")]
		internal StreamTokenReader(StreamReader input) { }

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001735")]
		internal int get_NumCharEncountered() { }

		[Address(RVA = "0x1332600", Offset = "0x1331800", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001734")]
		public override int Read() { }

	}

	[Token(Token = "0x20002CB")]
	public sealed class StringMaker
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C3F")]
		private String[] aStrings; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C40")]
		private uint cStringsMax; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000C41")]
		private uint cStringsUsed; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C42")]
		public StringBuilder _outStringBuilder; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C43")]
		public Char[] _outChars; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C44")]
		public int _outIndex; //Field offset: 0x30

		[Address(RVA = "0x1332B10", Offset = "0x1331D10", Length = "0x8A")]
		[CalledBy(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600172F")]
		public StringMaker() { }

		[Address(RVA = "0x1332640", Offset = "0x1331840", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001730")]
		private bool CompareStringAndChars(string str, Char[] a, int l) { }

		[Address(RVA = "0x13326D0", Offset = "0x13318D0", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600172E")]
		private static uint HashCharArray(Char[] a, int l) { }

		[Address(RVA = "0x1332740", Offset = "0x1331940", Length = "0x72")]
		[CalledBy(Type = typeof(StringMaker), Member = "MakeString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600172D")]
		private static uint HashString(string str) { }

		[Address(RVA = "0x13327C0", Offset = "0x13319C0", Length = "0x344")]
		[CalledBy(Type = typeof(SecurityDocument), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Tokenizer), Member = "GetStringToken", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(StringMaker), Member = "HashString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001731")]
		public string MakeString() { }

	}

	[Token(Token = "0x20002CA")]
	private enum TokenSource
	{
		UnicodeByteArray = 0,
		UTF8ByteArray = 1,
		ASCIIByteArray = 2,
		CharArray = 3,
		String = 4,
		NestedStrings = 5,
		Other = 6,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C27")]
	public int LineNo; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C28")]
	private int _inProcessingTag; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C29")]
	private Byte[] _inBytes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C2A")]
	private Char[] _inChars; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C2B")]
	private string _inString; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C2C")]
	private int _inIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000C2D")]
	private int _inSize; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C2E")]
	private int _inSavedCharacter; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000C2F")]
	private TokenSource _inTokenSource; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C30")]
	private ITokenReader _inTokenReader; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C31")]
	private StringMaker _maker; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C32")]
	private String[] _searchStrings; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C33")]
	private String[] _replaceStrings; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C34")]
	private int _inNestedIndex; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000C35")]
	private int _inNestedSize; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C36")]
	private string _inNestedString; //Field offset: 0x68

	[Address(RVA = "0x13340A0", Offset = "0x13332A0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001729")]
	internal Tokenizer(string input) { }

	[Address(RVA = "0x13332F0", Offset = "0x13324F0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001727")]
	internal void BasicInitialization() { }

	[Address(RVA = "0x1333370", Offset = "0x1332570", Length = "0x290")]
	[CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600172A")]
	internal void ChangeFormat(Encoding encoding) { }

	[Address(RVA = "0x1333610", Offset = "0x1332810", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringMaker), Member = "MakeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600172C")]
	private string GetStringToken() { }

	[Address(RVA = "0x1333630", Offset = "0x1332830", Length = "0x9E8")]
	[CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringMaker), Member = "MakeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TokenizerStream), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TokenizerStream), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600172B")]
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	[Address(RVA = "0x1334050", Offset = "0x1333250", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SharedStatics), Member = "ReleaseSharedStringMaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringMaker&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001728")]
	public void Recycle() { }

}

