namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x200060E")]
internal abstract class BaseStyleMatcher
{
	[Token(Token = "0x200060F")]
	private struct MatchContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001695")]
		public int valueIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001696")]
		public int matchedVariableCount; //Field offset: 0x4

	}

	[Token(Token = "0x4001692")]
	protected static readonly Regex s_CustomIdentRegex; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001693")]
	private Stack<MatchContext> m_ContextStack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001694")]
	private MatchContext m_CurrentContext; //Field offset: 0x18

	[Token(Token = "0x17000AE9")]
	public int currentIndex
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A94")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A95")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000AE8")]
	public bool hasCurrent
	{
		[Address(RVA = "0x1BBDE90", Offset = "0x1BBD090", Length = "0x27")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002A93")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000AE7")]
	public abstract bool isCurrentComma
	{
		[Token(Token = "0x6002A92")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000AE6")]
	public abstract bool isCurrentVariable
	{
		[Token(Token = "0x6002A91")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000AEA")]
	public int matchedVariableCount
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A96")]
		 get { } //Length: 4
		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A97")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000AE5")]
	public abstract int valueCount
	{
		[Token(Token = "0x6002A90")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1BBDD80", Offset = "0x1BBCF80", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002AAA")]
	private static BaseStyleMatcher() { }

	[Address(RVA = "0x1BBDE10", Offset = "0x1BBD010", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002AA9")]
	protected BaseStyleMatcher() { }

	[Address(RVA = "0x1BBCD70", Offset = "0x1BBBF70", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A9C")]
	public void DropContext() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A94")]
	public int get_currentIndex() { }

	[Address(RVA = "0x1BBDE90", Offset = "0x1BBD090", Length = "0x27")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A93")]
	public bool get_hasCurrent() { }

	[Token(Token = "0x6002A92")]
	public abstract bool get_isCurrentComma() { }

	[Token(Token = "0x6002A91")]
	public abstract bool get_isCurrentVariable() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A96")]
	public int get_matchedVariableCount() { }

	[Token(Token = "0x6002A90")]
	public abstract int get_valueCount() { }

	[Address(RVA = "0x1BBCDC0", Offset = "0x1BBBFC0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A98")]
	protected void Initialize() { }

	[Address(RVA = "0x1BBDB10", Offset = "0x1BBCD10", Length = "0x18F")]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue>)}, ReturnType = typeof(MatchResult))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchManyByOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Int32*)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchJuxtaposition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MoveNext", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A9D")]
	protected bool Match(Expression exp) { }

	[Address(RVA = "0x1BBCE10", Offset = "0x1BBC010", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AA4")]
	private bool MatchAndAnd(Expression exp) { }

	[Token(Token = "0x6002A8E")]
	protected abstract bool MatchAngle() { }

	[Token(Token = "0x6002A89")]
	protected abstract bool MatchColor() { }

	[Address(RVA = "0x1BBCE50", Offset = "0x1BBC050", Length = "0x338")]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "RestoreContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AA1")]
	private bool MatchCombinator(Expression exp) { }

	[Token(Token = "0x6002A8F")]
	protected abstract bool MatchCustomIdent() { }

	[Address(RVA = "0x1BBD1A0", Offset = "0x1BBC3A0", Length = "0x164")]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002AA8")]
	private bool MatchDataType(Expression exp) { }

	[Address(RVA = "0x1BBD450", Offset = "0x1BBC650", Length = "0x102")]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchExpressionWithMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002A9E")]
	private bool MatchExpression(Expression exp) { }

	[Address(RVA = "0x1BBD330", Offset = "0x1BBC530", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MoveNext", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A9F")]
	private bool MatchExpressionWithMultiplier(Expression exp) { }

	[Token(Token = "0x6002A8D")]
	protected abstract bool MatchFilterFunction() { }

	[Address(RVA = "0x1BBD560", Offset = "0x1BBC760", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AA0")]
	private bool MatchGroup(Expression exp) { }

	[Token(Token = "0x6002A86")]
	protected abstract bool MatchInteger() { }

	[Address(RVA = "0x1BBD610", Offset = "0x1BBC810", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002AA7")]
	private bool MatchJuxtaposition(Expression exp) { }

	[Token(Token = "0x6002A84")]
	protected abstract bool MatchKeyword(string keyword) { }

	[Token(Token = "0x6002A87")]
	protected abstract bool MatchLength() { }

	[Address(RVA = "0x1BBD800", Offset = "0x1BBCA00", Length = "0x1B8")]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchOrOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchAndAnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchManyByOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Int32*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AA5")]
	private int MatchMany(Expression exp) { }

	[Address(RVA = "0x1BBD690", Offset = "0x1BBC890", Length = "0x166")]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002AA6")]
	private int MatchManyByOrder(Expression exp, Int32* matchOrder) { }

	[Token(Token = "0x6002A85")]
	protected abstract bool MatchNumber() { }

	[Address(RVA = "0x1BBD9E0", Offset = "0x1BBCBE0", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "RestoreContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AA2")]
	private bool MatchOr(Expression exp) { }

	[Address(RVA = "0x1BBD9C0", Offset = "0x1BBCBC0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AA3")]
	private bool MatchOrOr(Expression exp) { }

	[Token(Token = "0x6002A88")]
	protected abstract bool MatchPercentage() { }

	[Token(Token = "0x6002A8A")]
	protected abstract bool MatchResource() { }

	[Token(Token = "0x6002A8C")]
	protected abstract bool MatchTime() { }

	[Token(Token = "0x6002A8B")]
	protected abstract bool MatchUrl() { }

	[Address(RVA = "0x1BBDCA0", Offset = "0x1BBCEA0", Length = "0x38")]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchExpressionWithMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002A99")]
	public void MoveNext() { }

	[Address(RVA = "0x1BBDCE0", Offset = "0x1BBCEE0", Length = "0x49")]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A9B")]
	public void RestoreContext() { }

	[Address(RVA = "0x1BBDD30", Offset = "0x1BBCF30", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A9A")]
	public void SaveContext() { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A95")]
	public void set_currentIndex(int value) { }

	[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A97")]
	public void set_matchedVariableCount(int value) { }

}

