namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ParameterExpressionProxy))]
[Token(Token = "0x20000A3")]
public class ParameterExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000168")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000B9")]
	public bool IsByRef
	{
		[Address(RVA = "0x331320", Offset = "0x330520", Length = "0x14")]
		[CallerCount(Count = 30)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003FD")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000B8")]
	public string Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003FC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B7")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x3CE210", Offset = "0x3CD410", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003FB")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000B6")]
	public virtual Type Type
	{
		[Address(RVA = "0x15A7EE0", Offset = "0x15A70E0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x60003FA")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x15A7E70", Offset = "0x15A7070", Length = "0x65")]
	[CalledBy(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(PrimitiveParameterExpression`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003F8")]
	internal ParameterExpression(string name) { }

	[Address(RVA = "0x15A76E0", Offset = "0x15A68E0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003FF")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x331320", Offset = "0x330520", Length = "0x14")]
	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003FD")]
	public bool get_IsByRef() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003FC")]
	public string get_Name() { }

	[Address(RVA = "0x3CE210", Offset = "0x3CD410", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003FB")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x15A7EE0", Offset = "0x15A70E0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x60003FA")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003FE")]
	internal override bool GetIsByRef() { }

	[Address(RVA = "0x15A7710", Offset = "0x15A6910", Length = "0x714")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Variable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypeExtensions), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PrimitiveParameterExpression`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParameterExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypedParameterExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60003F9")]
	internal static ParameterExpression Make(Type type, string name, bool isByRef) { }

}

