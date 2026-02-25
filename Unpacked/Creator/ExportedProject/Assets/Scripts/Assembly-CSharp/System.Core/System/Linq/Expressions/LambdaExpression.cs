namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
[Token(Token = "0x200007D")]
public abstract class LambdaExpression : Expression, IParameterProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012E")]
	private readonly Expression _body; //Field offset: 0x10

	[Token(Token = "0x1700007F")]
	public Expression Body
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000360")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700007D")]
	public string Name
	{
		[Address(RVA = "0xE89DB0", Offset = "0xE88FB0", Length = "0x14")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600035E")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700007E")]
	internal override string NameCore
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600035F")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700007C")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x13024E0", Offset = "0x13016E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600035D")]
		 get { } //Length: 6
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x17000084")]
	internal override int ParameterCount
	{
		[Address(RVA = "0x15A5030", Offset = "0x15A4230", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000367")]
		internal get { } //Length: 39
	}

	[Token(Token = "0x1700007B")]
	internal abstract Type PublicType
	{
		[Token(Token = "0x600035C")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000080")]
	public Type ReturnType
	{
		[Address(RVA = "0x15A5060", Offset = "0x15A4260", Length = "0x83")]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000361")]
		 get { } //Length: 131
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x17000083")]
	private override int System.Linq.Expressions.IParameterProvider.ParameterCount
	{
		[Address(RVA = "0x15A4FA0", Offset = "0x15A41A0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000366")]
		private get { } //Length: 20
	}

	[Token(Token = "0x17000081")]
	public bool TailCall
	{
		[Address(RVA = "0x5C5140", Offset = "0x5C4340", Length = "0x14")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000362")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000082")]
	internal override bool TailCallCore
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000363")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000079")]
	public virtual Type Type
	{
		[Address(RVA = "0x10E6EA0", Offset = "0x10E60A0", Length = "0x14")]
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600035A")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700007A")]
	internal abstract Type TypeCore
	{
		[Token(Token = "0x600035B")]
		internal get { } //Length: 0
	}

	[Address(RVA = "0x15A4FC0", Offset = "0x15A41C0", Length = "0x65")]
	[CalledBy(Type = typeof(Expression`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000359")]
	internal LambdaExpression(Expression body) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000360")]
	public Expression get_Body() { }

	[Address(RVA = "0xE89DB0", Offset = "0xE88FB0", Length = "0x14")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600035E")]
	public string get_Name() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600035F")]
	internal override string get_NameCore() { }

	[Address(RVA = "0x13024E0", Offset = "0x13016E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600035D")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x15A5030", Offset = "0x15A4230", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000367")]
	internal override int get_ParameterCount() { }

	[Token(Token = "0x600035C")]
	internal abstract Type get_PublicType() { }

	[Address(RVA = "0x15A5060", Offset = "0x15A4260", Length = "0x83")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000361")]
	public Type get_ReturnType() { }

	[Address(RVA = "0x5C5140", Offset = "0x5C4340", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000362")]
	public bool get_TailCall() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000363")]
	internal override bool get_TailCallCore() { }

	[Address(RVA = "0x10E6EA0", Offset = "0x10E60A0", Length = "0x14")]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600035A")]
	public virtual Type get_Type() { }

	[Token(Token = "0x600035B")]
	internal abstract Type get_TypeCore() { }

	[Address(RVA = "0x15A4F50", Offset = "0x15A4150", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000365")]
	internal override ParameterExpression GetParameter(int index) { }

	[Address(RVA = "0x15A4FA0", Offset = "0x15A41A0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000366")]
	private override int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	[Address(RVA = "0x15A4F80", Offset = "0x15A4180", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000364")]
	private override ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

}

