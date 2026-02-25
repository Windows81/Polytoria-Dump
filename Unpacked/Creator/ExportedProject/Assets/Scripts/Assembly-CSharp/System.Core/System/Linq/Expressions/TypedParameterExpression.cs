namespace System.Linq.Expressions;

[Token(Token = "0x20000A5")]
internal class TypedParameterExpression : ParameterExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000169")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000BA")]
	public virtual Type Type
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000403")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15AAAC0", Offset = "0x15A9CC0", Length = "0x82")]
	[CalledBy(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(ByRefParameterExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000402")]
	internal TypedParameterExpression(Type type, string name) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000403")]
	public virtual Type get_Type() { }

}

