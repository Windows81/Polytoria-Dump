namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000232")]
internal static class ScriptingRuntimeHelpers
{

	[Address(RVA = "0x15E38E0", Offset = "0x15E2AE0", Length = "0x39C")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitInitializeLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBlockStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression)}, ReturnType = typeof(LocalDefinition[]))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNoLabelPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A48")]
	internal static object GetPrimitiveDefaultValue(Type type) { }

	[Address(RVA = "0x15E3CC0", Offset = "0x15E2EC0", Length = "0x156")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.AddInstruction+AddInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.AddOvfInstruction+AddOvfInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.DivInstruction+DivInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.IncrementInstruction+IncrementInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ModuloInstruction+ModuloInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.MulInstruction+MulInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.MulOvfInstruction+MulOvfInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.SubInstruction+SubInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.SubOvfInstruction+SubOvfInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A47")]
	public static object Int32ToObject(int i) { }

}

