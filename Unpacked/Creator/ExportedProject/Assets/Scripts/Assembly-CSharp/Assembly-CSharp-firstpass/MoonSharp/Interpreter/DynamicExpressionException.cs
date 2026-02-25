namespace MoonSharp.Interpreter;

[Token(Token = "0x200005B")]
public class DynamicExpressionException : ScriptRuntimeException
{

	[Address(RVA = "0x2FC250", Offset = "0x2FB450", Length = "0x66")]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "EvalArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "EvalComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue), "MoonSharp.Interpreter.Tree.Expressions.BinaryOperatorExpression+Operator"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InterpreterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60005B5")]
	public DynamicExpressionException(string format, Object[] args) { }

	[Address(RVA = "0x2FC2C0", Offset = "0x2FB4C0", Length = "0x8A")]
	[CalledBy(Type = typeof(IndexExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(AssignmentStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Tree.Statements.ForEachLoopStatement+<>c__DisplayClass7_0", Member = "<.ctor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(SymbolRefExpression))]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "EvalArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "EvalComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue), "MoonSharp.Interpreter.Tree.Expressions.BinaryOperatorExpression+Operator"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FunctionCallExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(SymbolRefExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SymbolRefExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(SymbolRef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TableConstructor), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(UnaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60005B6")]
	public DynamicExpressionException(string message) { }

}

