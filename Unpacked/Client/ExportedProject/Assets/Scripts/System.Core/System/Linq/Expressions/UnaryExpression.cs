namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(UnaryExpressionProxy))]
[Token(Token = "0x20000B0")]
public sealed class UnaryExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400017D")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017E")]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400017F")]
	private readonly Expression <Operand>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000180")]
	private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000106")]
	public virtual bool CanReduce
	{
		[Address(RVA = "0x15AC190", Offset = "0x15AB390", Length = "0x25")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000491")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000104")]
	public bool IsLifted
	{
		[Address(RVA = "0x15AC240", Offset = "0x15AB440", Length = "0x26A")]
		[CalledBy(Type = typeof(UnaryExpression), Member = "get_IsLiftedToNull", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
		[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		[Token(Token = "0x600048E")]
		 get { } //Length: 618
	}

	[Token(Token = "0x17000105")]
	public bool IsLiftedToNull
	{
		[Address(RVA = "0x15AC1C0", Offset = "0x15AB3C0", Length = "0x76")]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnaryExpression), Member = "get_IsLifted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600048F")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000107")]
	private bool IsPrefix
	{
		[Address(RVA = "0x15AC4B0", Offset = "0x15AB6B0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000493")]
		private get { } //Length: 75
	}

	[Token(Token = "0x17000103")]
	public MethodInfo Method
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600048D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000101")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600048B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000102")]
	public Expression Operand
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600048C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000100")]
	public virtual Type Type
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600048A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15AC0E0", Offset = "0x15AB2E0", Length = "0xA3")]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000489")]
	internal UnaryExpression(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[Address(RVA = "0x15AACA0", Offset = "0x15A9EA0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000490")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x15AACD0", Offset = "0x15A9ED0", Length = "0x140")]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000494")]
	private UnaryExpression FunctionalOp(Expression operand) { }

	[Address(RVA = "0x15AC190", Offset = "0x15AB390", Length = "0x25")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000491")]
	public virtual bool get_CanReduce() { }

	[Address(RVA = "0x15AC240", Offset = "0x15AB440", Length = "0x26A")]
	[CalledBy(Type = typeof(UnaryExpression), Member = "get_IsLiftedToNull", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x600048E")]
	public bool get_IsLifted() { }

	[Address(RVA = "0x15AC1C0", Offset = "0x15AB3C0", Length = "0x76")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnaryExpression), Member = "get_IsLifted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048F")]
	public bool get_IsLiftedToNull() { }

	[Address(RVA = "0x15AC4B0", Offset = "0x15AB6B0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000493")]
	private bool get_IsPrefix() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600048D")]
	public MethodInfo get_Method() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600048B")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600048C")]
	public Expression get_Operand() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600048A")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x15ABF90", Offset = "0x15AB190", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(UnaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(UnaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000492")]
	public virtual Expression Reduce() { }

	[Address(RVA = "0x15AAE20", Offset = "0x15AA020", Length = "0x7FA")]
	[CalledBy(Type = typeof(UnaryExpression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = "FunctionalOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(Expression), Member = "MakeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000497")]
	private Expression ReduceIndex() { }

	[Address(RVA = "0x15AB620", Offset = "0x15AA820", Length = "0x61D")]
	[CalledBy(Type = typeof(UnaryExpression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UnaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = "FunctionalOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Expression), Member = "MakeMemberAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000496")]
	private Expression ReduceMember() { }

	[Address(RVA = "0x15ABC40", Offset = "0x15AAE40", Length = "0x349")]
	[CalledBy(Type = typeof(UnaryExpression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnaryExpression), Member = "FunctionalOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000495")]
	private Expression ReduceVariable() { }

	[Address(RVA = "0x15AC010", Offset = "0x15AB210", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "MakeUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000498")]
	public UnaryExpression Update(Expression operand) { }

}

