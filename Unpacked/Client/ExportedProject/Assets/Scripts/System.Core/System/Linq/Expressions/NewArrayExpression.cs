namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewArrayExpressionProxy))]
[Token(Token = "0x200009F")]
public class NewArrayExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000164")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000165")]
	private readonly ReadOnlyCollection<Expression> <Expressions>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000B2")]
	public ReadOnlyCollection<Expression> Expressions
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B1")]
	public virtual Type Type
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EE")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15A7260", Offset = "0x15A6460", Length = "0x82")]
	[CalledBy(Type = typeof(NewArrayExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CalledBy(Type = typeof(NewArrayInitExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewArrayBoundsExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003EC")]
	internal NewArrayExpression(Type type, ReadOnlyCollection<Expression> expressions) { }

	[Address(RVA = "0x15A7040", Offset = "0x15A6240", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003F0")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EF")]
	public ReadOnlyCollection<Expression> get_Expressions() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EE")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x15A7070", Offset = "0x15A6270", Length = "0x7E")]
	[CalledBy(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CalledBy(Type = typeof(Expression), Member = "NewArrayBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NewArrayExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003ED")]
	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions) { }

	[Address(RVA = "0x15A70F0", Offset = "0x15A62F0", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "SameElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>&", "System.Collections.Generic.IReadOnlyList`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[Calls(Type = typeof(Expression), Member = "NewArrayBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60003F1")]
	public NewArrayExpression Update(IEnumerable<Expression> expressions) { }

}

