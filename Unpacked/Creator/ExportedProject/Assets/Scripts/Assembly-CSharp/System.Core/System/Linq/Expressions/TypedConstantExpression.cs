namespace System.Linq.Expressions;

[Token(Token = "0x200006C")]
internal class TypedConstantExpression : ConstantExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000BE")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000058")]
	public virtual Type Type
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600026C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15AAA30", Offset = "0x15A9C30", Length = "0x82")]
	[CalledBy(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600026B")]
	internal TypedConstantExpression(object value, Type type) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600026C")]
	public virtual Type get_Type() { }

}

