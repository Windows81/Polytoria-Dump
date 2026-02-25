namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000610")]
internal class StylePropertyValueMatcher : BaseStyleMatcher
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001697")]
	private List<StylePropertyValue> m_Values; //Field offset: 0x20

	[Token(Token = "0x17000AEB")]
	private StylePropertyValue current
	{
		[Address(RVA = "0x1BC6680", Offset = "0x1BC5880", Length = "0x97")]
		[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue>)}, ReturnType = typeof(MatchResult))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002AAB")]
		private get { } //Length: 151
	}

	[Token(Token = "0x17000AEE")]
	public virtual bool isCurrentComma
	{
		[Address(RVA = "0x1BC6720", Offset = "0x1BC5920", Length = "0xA4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002AAE")]
		 get { } //Length: 164
	}

	[Token(Token = "0x17000AED")]
	public virtual bool isCurrentVariable
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AAD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000AEC")]
	public virtual int valueCount
	{
		[Address(RVA = "0x1BC67D0", Offset = "0x1BC59D0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002AAC")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x1BC65D0", Offset = "0x1BC57D0", Length = "0xA8")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002ABC")]
	public StylePropertyValueMatcher() { }

	[Address(RVA = "0x1BC6680", Offset = "0x1BC5880", Length = "0x97")]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue>)}, ReturnType = typeof(MatchResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002AAB")]
	private StylePropertyValue get_current() { }

	[Address(RVA = "0x1BC6720", Offset = "0x1BC5920", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AAE")]
	public virtual bool get_isCurrentComma() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AAD")]
	public virtual bool get_isCurrentVariable() { }

	[Address(RVA = "0x1BC67D0", Offset = "0x1BC59D0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002AAC")]
	public virtual int get_valueCount() { }

	[Address(RVA = "0x1BC6310", Offset = "0x1BC5510", Length = "0x2B7")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ValidateResolvedValues", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StylePropertyValueMatcher), Member = "get_current", ReturnType = typeof(StylePropertyValue))]
	[Calls(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AAF")]
	public MatchResult Match(Expression exp, List<StylePropertyValue> values) { }

	[Address(RVA = "0x1BC57B0", Offset = "0x1BC49B0", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002ABB")]
	protected virtual bool MatchAngle() { }

	[Address(RVA = "0x1BC58C0", Offset = "0x1BC4AC0", Length = "0x180")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002AB5")]
	protected virtual bool MatchColor() { }

	[Address(RVA = "0x1BC5A50", Offset = "0x1BC4C50", Length = "0x13E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002ABA")]
	protected virtual bool MatchCustomIdent() { }

	[Address(RVA = "0x1BC5B90", Offset = "0x1BC4D90", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AB9")]
	protected virtual bool MatchFilterFunction() { }

	[Address(RVA = "0x1BC5D00", Offset = "0x1BC4F00", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB2")]
	protected virtual bool MatchInteger() { }

	[Address(RVA = "0x1BC5DA0", Offset = "0x1BC4FA0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleValueKeywordExtension), Member = "ToUssString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueKeyword)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002AB0")]
	protected virtual bool MatchKeyword(string keyword) { }

	[Address(RVA = "0x1BC5EB0", Offset = "0x1BC50B0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AB3")]
	protected virtual bool MatchLength() { }

	[Address(RVA = "0x1BC5D00", Offset = "0x1BC4F00", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB1")]
	protected virtual bool MatchNumber() { }

	[Address(RVA = "0x1BC5FC0", Offset = "0x1BC51C0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AB4")]
	protected virtual bool MatchPercentage() { }

	[Address(RVA = "0x1BC60D0", Offset = "0x1BC52D0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AB6")]
	protected virtual bool MatchResource() { }

	[Address(RVA = "0x1BC6170", Offset = "0x1BC5370", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AB8")]
	protected virtual bool MatchTime() { }

	[Address(RVA = "0x1BC6260", Offset = "0x1BC5460", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002AB7")]
	protected virtual bool MatchUrl() { }

}

