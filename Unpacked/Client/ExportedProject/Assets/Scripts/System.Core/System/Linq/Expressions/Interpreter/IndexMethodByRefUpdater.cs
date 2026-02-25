namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000187")]
internal sealed class IndexMethodByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400030C")]
	private readonly MethodInfo _indexer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400030D")]
	private readonly Nullable<LocalDefinition> _obj; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400030E")]
	private readonly LocalDefinition[] _args; //Field offset: 0x38

	[Address(RVA = "0x15D48C0", Offset = "0x15D3AC0", Length = "0x7E")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMultiDimArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(IArgumentProvider), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000803")]
	public IndexMethodByRefUpdater(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	[Address(RVA = "0x15D4480", Offset = "0x15D3680", Length = "0x1D6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000805")]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Address(RVA = "0x15D4660", Offset = "0x15D3860", Length = "0x25D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000804")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

