namespace System.Linq.Expressions;

[Token(Token = "0x20000A6")]
internal sealed class PrimitiveParameterExpression : ParameterExpression
{

	[Token(Token = "0x170000BB")]
	public virtual Type Type
	{
		[Address(RVA = "0xC30ED0", Offset = "0xC300D0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000405")]
		 get { } //Length: 56
	}

	[Address(RVA = "0xE89A30", Offset = "0xE88C30", Length = "0x8")]
	[CalledBy(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ParameterExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000404")]
	internal PrimitiveParameterExpression`1(string name) { }

	[Address(RVA = "0xC30ED0", Offset = "0xC300D0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000405")]
	public virtual Type get_Type() { }

}

