namespace System.Net.Http.Headers;

[Token(Token = "0x2000030")]
internal struct Token
{
	[Token(Token = "0x2000031")]
	internal enum Type
	{
		Error = 0,
		End = 1,
		Token = 2,
		QuotedString = 3,
		SeparatorEqual = 4,
		SeparatorSemicolon = 5,
		SeparatorSlash = 6,
		SeparatorDash = 7,
		SeparatorComma = 8,
		OpenParens = 9,
	}

	[Token(Token = "0x40000AF")]
	public static readonly Token Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B0")]
	private readonly Type type; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000B1")]
	private int <StartPosition>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B2")]
	private int <EndPosition>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000045")]
	public private int EndPosition
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600013C")]
		 get { } //Length: 4
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600013D")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000046")]
	public Type Kind
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013E")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000044")]
	public private int StartPosition
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600013A")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600013B")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x161C530", Offset = "0x161B730", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000141")]
	private static Token() { }

	[Address(RVA = "0x161C5C0", Offset = "0x161B7C0", Length = "0x75")]
	[CalledBy(Type = typeof(Lexer), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000139")]
	public Token(Type type, int startPosition, int endPosition) { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600013C")]
	public int get_EndPosition() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013E")]
	public Type get_Kind() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600013A")]
	public int get_StartPosition() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013F")]
	public static Type op_Implicit(Token token) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600013D")]
	private void set_EndPosition(int value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600013B")]
	private void set_StartPosition(int value) { }

	[Address(RVA = "0x161C470", Offset = "0x161B670", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000140")]
	public virtual string ToString() { }

}

