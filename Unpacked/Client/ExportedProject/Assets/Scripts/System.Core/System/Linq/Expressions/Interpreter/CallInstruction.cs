namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000D5")]
internal abstract class CallInstruction : Instruction
{

	[Token(Token = "0x17000125")]
	public abstract int ArgumentCount
	{
		[Token(Token = "0x6000503")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000127")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x1573F90", Offset = "0x1573190", Length = "0x14")]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600050B")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000126")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15944A0", Offset = "0x15936A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000504")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600050E")]
	protected CallInstruction() { }

	[Address(RVA = "0x1593B20", Offset = "0x1592D20", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000508")]
	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	[Address(RVA = "0x1593B50", Offset = "0x1592D50", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000509")]
	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	[Address(RVA = "0x1593B80", Offset = "0x1592D80", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600050A")]
	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	[Address(RVA = "0x1593BC0", Offset = "0x1592DC0", Length = "0x57")]
	[CalledBy(Type = typeof(CallInstruction), Member = "GetArrayAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(int)}, ReturnType = typeof(CallInstruction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000505")]
	public static CallInstruction Create(MethodInfo info) { }

	[Address(RVA = "0x1593C20", Offset = "0x1592E20", Length = "0x198")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodCallExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(IArgumentProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMultiDimArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(IArgumentProvider), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000506")]
	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	[Token(Token = "0x6000503")]
	public abstract int get_ArgumentCount() { }

	[Address(RVA = "0x1573F90", Offset = "0x1573190", Length = "0x14")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600050B")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15944A0", Offset = "0x15936A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000504")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x1593DC0", Offset = "0x1592FC0", Length = "0x516")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(CallInstruction))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000507")]
	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	[Address(RVA = "0x15942E0", Offset = "0x15934E0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "RunVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(LightLambda), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600050D")]
	protected object InterpretLambdaInvoke(LightLambda targetLambda, Object[] args) { }

	[Address(RVA = "0x1594340", Offset = "0x1593540", Length = "0x15C")]
	[CalledBy(Type = typeof(MethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ByRefMethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600050C")]
	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

}

