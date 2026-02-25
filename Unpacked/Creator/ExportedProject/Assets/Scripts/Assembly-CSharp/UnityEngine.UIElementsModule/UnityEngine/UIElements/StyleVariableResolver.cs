namespace UnityEngine.UIElements;

[Token(Token = "0x200046D")]
internal class StyleVariableResolver
{
	[Token(Token = "0x200046F")]
	private struct ResolveContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC1")]
		public StyleSheet sheet; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000EC2")]
		public StyleValueHandle[] handles; //Field offset: 0x8

	}

	[Token(Token = "0x200046E")]
	private enum Result
	{
		Valid = 0,
		Invalid = 1,
		NotFound = 2,
	}

	[Token(Token = "0x4000EB4")]
	internal const int kMaxResolves = 100; //Field offset: 0x0
	[Token(Token = "0x4000EB5")]
	private static StyleSyntaxParser s_SyntaxParser; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EB6")]
	private StylePropertyValueMatcher m_Matcher; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EB7")]
	private List<StylePropertyValue> m_ResolvedValues; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EB8")]
	private Stack<String> m_ResolvedVarStack; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EB9")]
	private StyleProperty m_Property; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EBA")]
	private Stack<ResolveContext> m_ContextStack; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EBB")]
	private ResolveContext m_CurrentContext; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000EBC")]
	private StyleVariableContext <variableContext>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x170008CE")]
	private StyleValueHandle[] currentHandles
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600210C")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170008CD")]
	private StyleSheet currentSheet
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600210B")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170008CF")]
	public List<StylePropertyValue> resolvedValues
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600210D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170008D0")]
	public StyleVariableContext variableContext
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600210E")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600210F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1B2F2A0", Offset = "0x1B2E4A0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StyleSyntaxParser), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600211B")]
	private static StyleVariableResolver() { }

	[Address(RVA = "0x1B2F320", Offset = "0x1B2E520", Length = "0x138")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StylePropertyValueMatcher), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600211A")]
	public StyleVariableResolver() { }

	[Address(RVA = "0x1B2E2A0", Offset = "0x1B2D4A0", Length = "0x117")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "LoadProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002113")]
	public void AddValue(StyleValueHandle handle) { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600210C")]
	private StyleValueHandle[] get_currentHandles() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600210B")]
	private StyleSheet get_currentSheet() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600210D")]
	public List<StylePropertyValue> get_resolvedValues() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600210E")]
	public StyleVariableContext get_variableContext() { }

	[Address(RVA = "0x1B2E3C0", Offset = "0x1B2D5C0", Length = "0xC1")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "LoadProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleVariableResolver), Member = "PushContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002110")]
	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) { }

	[Address(RVA = "0x1B2E490", Offset = "0x1B2D690", Length = "0x14B")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002119")]
	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName) { }

	[Address(RVA = "0x1B2E5E0", Offset = "0x1B2D7E0", Length = "0x83")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.UIElements.StyleVariableResolver+ResolveContext>), Member = "Pop", ReturnType = typeof(ResolveContext))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002112")]
	private void PopContext() { }

	[Address(RVA = "0x1B2E670", Offset = "0x1B2D870", Length = "0xAD")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleProperty), typeof(StyleSheet), typeof(StyleValueHandle[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.UIElements.StyleVariableResolver+ResolveContext>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResolveContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002111")]
	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) { }

	[Address(RVA = "0x1B2E720", Offset = "0x1B2D920", Length = "0x264")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(string)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(string)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ParseVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle[]), typeof(Int32&), typeof(Int32&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002118")]
	private Result ResolveFallback(ref int index, bool appendValues) { }

	[Address(RVA = "0x1B2EAD0", Offset = "0x1B2DCD0", Length = "0x2C0")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "LoadProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002114")]
	public bool ResolveVarFunction(ref int index) { }

	[Address(RVA = "0x1B2E990", Offset = "0x1B2DB90", Length = "0x139")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002115")]
	private Result ResolveVarFunction(ref int index, int argc, string varName) { }

	[Address(RVA = "0x1B2EDA0", Offset = "0x1B2DFA0", Length = "0x37C")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(string)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "PopContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(string)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleVariableResolver), Member = "PushContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002117")]
	private Result ResolveVariable(string variableName) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600210F")]
	public void set_variableContext(StyleVariableContext value) { }

	[Address(RVA = "0x1B2F120", Offset = "0x1B2E320", Length = "0x17F")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "LoadProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StylePropertyCache), Member = "TryGetSyntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(StylePropertyValueMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue>)}, ReturnType = typeof(MatchResult))]
	[Calls(Type = typeof(MatchResult), Member = "get_success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogAssertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002116")]
	public bool ValidateResolvedValues() { }

}

