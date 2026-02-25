namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(TryExpressionProxy))]
[Token(Token = "0x20000AE")]
public sealed class TryExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000176")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000177")]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000178")]
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000179")]
	private readonly Expression <Finally>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017A")]
	private readonly Expression <Fault>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170000FA")]
	public Expression Body
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000481")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000FD")]
	public Expression Fault
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000484")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170000FC")]
	public Expression Finally
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000483")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000FB")]
	public ReadOnlyCollection<CatchBlock> Handlers
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000482")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F9")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x15AAA20", Offset = "0x15A9C20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000480")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000F8")]
	public virtual Type Type
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15AA950", Offset = "0x15A9B50", Length = "0xC3")]
	[CalledBy(Type = typeof(Expression), Member = "MakeTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(TryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600047E")]
	internal TryExpression(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[Address(RVA = "0x15AA820", Offset = "0x15A9A20", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000485")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000481")]
	public Expression get_Body() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000484")]
	public Expression get_Fault() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000483")]
	public Expression get_Finally() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000482")]
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[Address(RVA = "0x15AAA20", Offset = "0x15A9C20", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000480")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047F")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x15AA850", Offset = "0x15A9A50", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "SameElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>&", "System.Collections.Generic.IReadOnlyList`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "MakeTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(TryExpression))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000486")]
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }

}

