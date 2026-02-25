namespace System.Linq.Expressions;

[Token(Token = "0x2000067")]
internal static class ConstantCheck
{

	[Address(RVA = "0x1594BE0", Offset = "0x1593DE0", Length = "0x22")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000256")]
	internal static AnalyzeTypeIsResult AnalyzeTypeIs(TypeBinaryExpression typeIs) { }

	[Address(RVA = "0x1594C10", Offset = "0x1593E10", Length = "0x20C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000257")]
	private static AnalyzeTypeIsResult AnalyzeTypeIs(Expression operand, Type testType) { }

}

