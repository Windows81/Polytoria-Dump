namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x200061A")]
internal class StyleSyntaxTokenizer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016E0")]
	private List<StyleSyntaxToken> m_Tokens; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016E1")]
	private int m_CurrentTokenIndex; //Field offset: 0x18

	[Token(Token = "0x17000AF0")]
	public StyleSyntaxToken current
	{
		[Address(RVA = "0x1BCCF60", Offset = "0x1BCC160", Length = "0xBC")]
		[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer), typeof(ExpressionMultiplier&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
		[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseTerm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
		[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseCombinatorType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(ExpressionCombinator))]
		[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
		[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
		[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
		[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleSyntaxParser), Member = "EatSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleSyntaxTokenizer), Member = "MoveNext", ReturnType = typeof(StyleSyntaxToken))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6002AD5")]
		 get { } //Length: 188
	}

	[Address(RVA = "0x1BCCEE0", Offset = "0x1BCC0E0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002ADD")]
	public StyleSyntaxTokenizer() { }

	[Address(RVA = "0x1BCCF60", Offset = "0x1BCC160", Length = "0xBC")]
	[CalledBy(Type = typeof(StyleSyntaxTokenizer), Member = "MoveNext", ReturnType = typeof(StyleSyntaxToken))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "EatSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseCombinatorType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(ExpressionCombinator))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseTerm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer), typeof(ExpressionMultiplier&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002AD5")]
	public StyleSyntaxToken get_current() { }

	[Address(RVA = "0x1BCC0A0", Offset = "0x1BCB2A0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002ADC")]
	private static int GlobCharacter(string s, int index, char c) { }

	[Address(RVA = "0x1BCC100", Offset = "0x1BCB300", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AD9")]
	private static bool IsNextCharacter(string s, int index, char c) { }

	[Address(RVA = "0x1BCC150", Offset = "0x1BCB350", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002ADA")]
	private static bool IsNextLetterOrDash(string s, int index) { }

	[Address(RVA = "0x1BCC200", Offset = "0x1BCB400", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002ADB")]
	private static bool IsNextNumber(string s, int index) { }

	[Address(RVA = "0x1BCC260", Offset = "0x1BCB460", Length = "0xC2")]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseTerm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseCombinatorType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(ExpressionCombinator))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer), typeof(ExpressionMultiplier&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "EatSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002AD6")]
	public StyleSyntaxToken MoveNext() { }

	[Address(RVA = "0x1BCC330", Offset = "0x1BCB530", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002AD7")]
	public StyleSyntaxToken PeekNext() { }

	[Address(RVA = "0x1BCC3F0", Offset = "0x1BCB5F0", Length = "0xAB0")]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogAssertionFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CF140")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002AD8")]
	public void Tokenize(string syntax) { }

}

