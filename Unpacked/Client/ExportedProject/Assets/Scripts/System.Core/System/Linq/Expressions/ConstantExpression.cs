namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ConstantExpressionProxy))]
[Token(Token = "0x200006B")]
public class ConstantExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BD")]
	private readonly object <Value>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000056")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000268")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000055")]
	public virtual Type Type
	{
		[Address(RVA = "0x1594EC0", Offset = "0x15940C0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x6000267")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000057")]
	public object Value
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000269")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1594E50", Offset = "0x1594050", Length = "0x65")]
	[CalledBy(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ConstantExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000266")]
	internal ConstantExpression(object value) { }

	[Address(RVA = "0x1594E20", Offset = "0x1594020", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026A")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000268")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x1594EC0", Offset = "0x15940C0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x6000267")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000269")]
	public object get_Value() { }

}

