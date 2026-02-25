namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
[Token(Token = "0x200008B")]
public class MemberExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000144")]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000097")]
	public Expression Expression
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000390")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000096")]
	public MemberInfo Member
	{
		[Address(RVA = "0x331320", Offset = "0x330520", Length = "0x14")]
		[CallerCount(Count = 30)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600038F")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000098")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x3CE1B0", Offset = "0x3CD3B0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000394")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15A5910", Offset = "0x15A4B10", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000391")]
	internal MemberExpression(Expression expression) { }

	[Address(RVA = "0x15A56C0", Offset = "0x15A48C0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000396")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000390")]
	public Expression get_Expression() { }

	[Address(RVA = "0x331320", Offset = "0x330520", Length = "0x14")]
	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600038F")]
	public MemberInfo get_Member() { }

	[Address(RVA = "0x3CE1B0", Offset = "0x3CD3B0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000394")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x15A56F0", Offset = "0x15A48F0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000395")]
	internal override MemberInfo GetMember() { }

	[Address(RVA = "0x15A57D0", Offset = "0x15A49D0", Length = "0xAE")]
	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000392")]
	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	[Address(RVA = "0x15A5720", Offset = "0x15A4920", Length = "0xAE")]
	[CalledBy(Type = typeof(Expression), Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(FieldInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000393")]
	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	[Address(RVA = "0x15A5880", Offset = "0x15A4A80", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "MakeMemberAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo)}, ReturnType = typeof(MemberExpression))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000397")]
	public MemberExpression Update(Expression expression) { }

}

