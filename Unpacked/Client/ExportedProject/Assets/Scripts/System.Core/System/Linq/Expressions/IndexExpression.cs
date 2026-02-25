namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(IndexExpressionProxy))]
[Token(Token = "0x2000078")]
public sealed class IndexExpression : Expression, IArgumentProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000124")]
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000125")]
	private readonly Expression <Object>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000126")]
	private readonly PropertyInfo <Indexer>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700006D")]
	public override int ArgumentCount
	{
		[Address(RVA = "0x15A3EB0", Offset = "0x15A30B0", Length = "0x46")]
		[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "EmitIndexGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileNoLabelPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600033F")]
		 get { } //Length: 70
	}

	[Token(Token = "0x1700006C")]
	public PropertyInfo Indexer
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000069")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x15A3F00", Offset = "0x15A3100", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600033A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700006B")]
	public Expression Object
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006A")]
	public virtual Type Type
	{
		[Address(RVA = "0x15A3F10", Offset = "0x15A3110", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600033B")]
		 get { } //Length: 127
	}

	[Address(RVA = "0x15A3E00", Offset = "0x15A3000", Length = "0xAC")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeIndexProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000339")]
	internal IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) { }

	[Address(RVA = "0x15A3CF0", Offset = "0x15A2EF0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000340")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x15A3EB0", Offset = "0x15A30B0", Length = "0x46")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitIndexGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNoLabelPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600033F")]
	public override int get_ArgumentCount() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033D")]
	public PropertyInfo get_Indexer() { }

	[Address(RVA = "0x15A3F00", Offset = "0x15A3100", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600033A")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033C")]
	public Expression get_Object() { }

	[Address(RVA = "0x15A3F10", Offset = "0x15A3110", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600033B")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x15A3D20", Offset = "0x15A2F20", Length = "0x54")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionStringBuilder), Member = "VisitIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNoLabelPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600033E")]
	public override Expression GetArgument(int index) { }

	[Address(RVA = "0x15A3D80", Offset = "0x15A2F80", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "MakeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[Token(Token = "0x6000341")]
	internal Expression Rewrite(Expression instance, Expression[] arguments) { }

}

