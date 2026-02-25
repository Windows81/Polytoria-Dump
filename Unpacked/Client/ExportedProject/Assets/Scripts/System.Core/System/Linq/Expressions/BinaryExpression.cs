namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BinaryExpressionProxy))]
[Token(Token = "0x2000035")]
public class BinaryExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008A")]
	private readonly Expression <Right>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008B")]
	private readonly Expression <Left>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000023")]
	public virtual bool CanReduce
	{
		[Address(RVA = "0x1573F60", Offset = "0x1573160", Length = "0x25")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000122")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000027")]
	public LambdaExpression Conversion
	{
		[Address(RVA = "0x1573F90", Offset = "0x1573190", Length = "0x14")]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600012E")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000028")]
	public bool IsLifted
	{
		[Address(RVA = "0x15741C0", Offset = "0x15733C0", Length = "0x1BA")]
		[CalledBy(Type = typeof(BinaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LambdaExpression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[CalledBy(Type = typeof(BinaryExpression), Member = "get_IsLiftedToNull", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
		[Calls(Type = typeof(TypeUtils), Member = "GetNonRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6000130")]
		 get { } //Length: 442
	}

	[Token(Token = "0x1700002A")]
	internal bool IsLiftedLogical
	{
		[Address(RVA = "0x1573FB0", Offset = "0x15731B0", Length = "0x182")]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000133")]
		internal get { } //Length: 386
	}

	[Token(Token = "0x17000029")]
	public bool IsLiftedToNull
	{
		[Address(RVA = "0x1574140", Offset = "0x1573340", Length = "0x76")]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BinaryExpression), Member = "get_IsLifted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000131")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700002B")]
	internal bool IsReferenceComparison
	{
		[Address(RVA = "0x1574380", Offset = "0x1573580", Length = "0xEC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000134")]
		internal get { } //Length: 236
	}

	[Token(Token = "0x17000025")]
	public Expression Left
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000125")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000026")]
	public MethodInfo Method
	{
		[Address(RVA = "0x331320", Offset = "0x330520", Length = "0x14")]
		[CallerCount(Count = 30)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000126")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000024")]
	public Expression Right
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000124")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1573ED0", Offset = "0x15730D0", Length = "0x82")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000121")]
	internal BinaryExpression(Expression left, Expression right) { }

	[Address(RVA = "0x1572080", Offset = "0x1571280", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000132")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x1573F60", Offset = "0x1573160", Length = "0x25")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000122")]
	public virtual bool get_CanReduce() { }

	[Address(RVA = "0x1573F90", Offset = "0x1573190", Length = "0x14")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012E")]
	public LambdaExpression get_Conversion() { }

	[Address(RVA = "0x15741C0", Offset = "0x15733C0", Length = "0x1BA")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LambdaExpression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "get_IsLiftedToNull", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000130")]
	public bool get_IsLifted() { }

	[Address(RVA = "0x1573FB0", Offset = "0x15731B0", Length = "0x182")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000133")]
	internal bool get_IsLiftedLogical() { }

	[Address(RVA = "0x1574140", Offset = "0x1573340", Length = "0x76")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BinaryExpression), Member = "get_IsLifted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000131")]
	public bool get_IsLiftedToNull() { }

	[Address(RVA = "0x1574380", Offset = "0x1573580", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000134")]
	internal bool get_IsReferenceComparison() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000125")]
	public Expression get_Left() { }

	[Address(RVA = "0x331320", Offset = "0x330520", Length = "0x14")]
	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000126")]
	public MethodInfo get_Method() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000124")]
	public Expression get_Right() { }

	[Address(RVA = "0x15720B0", Offset = "0x15712B0", Length = "0x20")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600012A")]
	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012F")]
	internal override LambdaExpression GetConversion() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000127")]
	internal override MethodInfo GetMethod() { }

	[Address(RVA = "0x15721D0", Offset = "0x15713D0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000123")]
	private static bool IsOpAssignment(ExpressionType op) { }

	[Address(RVA = "0x1573910", Offset = "0x1572B10", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(BinaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000129")]
	public virtual Expression Reduce() { }

	[Address(RVA = "0x15721E0", Offset = "0x15713E0", Length = "0x71F")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(BinaryExpression), Member = "GetBinaryOpFromAssignmentOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType)}, ReturnType = typeof(ExpressionType))]
	[Calls(Type = typeof(IndexExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[Calls(Type = typeof(ArrayBuilderExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ArrayBuilder`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(IndexExpression), Member = "GetArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(Expression), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArrayBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexExpression), Member = "get_ArgumentCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600012D")]
	private Expression ReduceIndex() { }

	[Address(RVA = "0x1572900", Offset = "0x1571B00", Length = "0x507")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BinaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "MakeMemberAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(BinaryExpression), Member = "GetBinaryOpFromAssignmentOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType)}, ReturnType = typeof(ExpressionType))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Variable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600012C")]
	private Expression ReduceMember() { }

	[Address(RVA = "0x1572E10", Offset = "0x1572010", Length = "0x9B5")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(MethodCallExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(Type[]), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TypeUtils), Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000135")]
	internal Expression ReduceUserdefinedLifted() { }

	[Address(RVA = "0x15737D0", Offset = "0x15729D0", Length = "0x138")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BinaryExpression), Member = "GetBinaryOpFromAssignmentOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType)}, ReturnType = typeof(ExpressionType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600012B")]
	private Expression ReduceVariable() { }

	[Address(RVA = "0x1573990", Offset = "0x1572B90", Length = "0x537")]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ReferenceEqualityNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = "get_IsLifted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(TypeUtils), Member = "HasReferenceEquality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[Token(Token = "0x6000128")]
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

}

