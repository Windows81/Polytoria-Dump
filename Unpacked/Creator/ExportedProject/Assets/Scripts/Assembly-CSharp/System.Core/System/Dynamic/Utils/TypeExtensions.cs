namespace System.Dynamic.Utils;

[Extension]
[Token(Token = "0x2000246")]
internal static class TypeExtensions
{
	[Token(Token = "0x40003D9")]
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; //Field offset: 0x0

	[Address(RVA = "0x15E6EF0", Offset = "0x15E60F0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CacheDict`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000AC5")]
	private static TypeExtensions() { }

	[Address(RVA = "0x15E6AD0", Offset = "0x15E5CD0", Length = "0xAB")]
	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeExtensions), Member = "MatchesArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000AC1")]
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[Address(RVA = "0x15E6B80", Offset = "0x15E5D80", Length = "0x119")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CacheDict`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CacheDict`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	[Token(Token = "0x6000AC4")]
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	[Address(RVA = "0x15E6CA0", Offset = "0x15E5EA0", Length = "0x2D")]
	[CalledBy(Type = typeof(ExclusiveOrInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(LessThanInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(LeftShiftInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(IncrementInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(GreaterThanOrEqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(GreaterThanInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(DivInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(DecrementInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(AndInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(AddOvfInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(AddInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(LessThanOrEqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Extension]
	[Token(Token = "0x6000AC3")]
	public static TypeCode GetTypeCode(Type type) { }

	[Address(RVA = "0x15E6CD0", Offset = "0x15E5ED0", Length = "0x21B")]
	[CalledBy(Type = typeof(TypeExtensions), Member = "GetAnyStaticMethodValidated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(TypeUtils), Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	[Token(Token = "0x6000AC2")]
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

}

