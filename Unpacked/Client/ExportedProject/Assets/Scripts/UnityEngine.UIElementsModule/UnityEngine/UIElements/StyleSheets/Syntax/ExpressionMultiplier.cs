namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x2000616")]
internal struct ExpressionMultiplier
{
	[Token(Token = "0x40016BF")]
	public const int Infinity = 100; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016C0")]
	private ExpressionMultiplierType m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40016C1")]
	public int min; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40016C2")]
	public int max; //Field offset: 0x8

	[Token(Token = "0x17000AEF")]
	public ExpressionMultiplierType type
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ABE")]
		 get { } //Length: 5
		[Address(RVA = "0x1BBEDE0", Offset = "0x1BBDFE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExpressionMultiplier), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002ABF")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x1BBEDC0", Offset = "0x1BBDFC0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionMultiplier), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002AC0")]
	public ExpressionMultiplier(ExpressionMultiplierType type = 0) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002ABE")]
	public ExpressionMultiplierType get_type() { }

	[Address(RVA = "0x1BBEDE0", Offset = "0x1BBDFE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionMultiplier), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002ABF")]
	public void set_type(ExpressionMultiplierType value) { }

	[Address(RVA = "0x1BBED40", Offset = "0x1BBDF40", Length = "0x60")]
	[CalledBy(Type = typeof(ExpressionMultiplier), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionMultiplier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer), typeof(ExpressionMultiplier&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002AC1")]
	private void SetType(ExpressionMultiplierType value) { }

}

