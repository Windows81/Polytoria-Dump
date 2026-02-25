namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A4")]
internal sealed class LocalVariables
{
	[Token(Token = "0x20001A5")]
	private sealed class VariableScope
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400032B")]
		public readonly int Start; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400032C")]
		public int Stop; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400032D")]
		public readonly LocalVariable Variable; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400032E")]
		public readonly VariableScope Parent; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400032F")]
		public List<VariableScope> ChildScopes; //Field offset: 0x28

		[Address(RVA = "0x15EC640", Offset = "0x15EB840", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60008C6")]
		public VariableScope(LocalVariable variable, int start, VariableScope parent) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000327")]
	private readonly HybridReferenceDictionary<ParameterExpression, VariableScope> _variables; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000328")]
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000329")]
	private int _localCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400032A")]
	private int _maxLocalCount; //Field offset: 0x24

	[Token(Token = "0x170001CB")]
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008C3")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001CA")]
	public int LocalCount
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008C1")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x15D7B10", Offset = "0x15D6D10", Length = "0x77")]
	[CalledBy(Type = typeof(LightCompiler), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60008C5")]
	public LocalVariables() { }

	[Address(RVA = "0x15D7420", Offset = "0x15D6620", Length = "0x10D")]
	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008C4")]
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	[Address(RVA = "0x15D7530", Offset = "0x15D6730", Length = "0x14F")]
	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(InstructionList), Member = "SwitchToBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60008C0")]
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	[Address(RVA = "0x15D7680", Offset = "0x15D6880", Length = "0x2BE")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArrayIndexAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMultiDimArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(IArgumentProvider), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBlockStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression)}, ReturnType = typeof(LocalDefinition[]))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60008BE")]
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C3")]
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C1")]
	public int get_LocalCount() { }

	[Address(RVA = "0x15D7940", Offset = "0x15D6B40", Length = "0xE2")]
	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CalledBy(Type = typeof(LightCompiler), Member = "ResolveLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGetBoxedVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileQuoteUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008C2")]
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	[Address(RVA = "0x15D7A30", Offset = "0x15D6C30", Length = "0xD1")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBlockExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBlockEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60008BF")]
	public void UndefineLocal(LocalDefinition definition, int end) { }

}

