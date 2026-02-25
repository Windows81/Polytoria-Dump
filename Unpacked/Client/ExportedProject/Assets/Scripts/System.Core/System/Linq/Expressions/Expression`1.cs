namespace System.Linq.Expressions;

[Token(Token = "0x200007E")]
public class Expression : LambdaExpression
{

	[Token(Token = "0x17000086")]
	internal virtual Type PublicType
	{
		[Address(RVA = "0xC30E90", Offset = "0xC30090", Length = "0x39")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		[Token(Token = "0x600036A")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x17000085")]
	internal virtual Type TypeCore
	{
		[Address(RVA = "0xC30ED0", Offset = "0xC300D0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000369")]
		internal get { } //Length: 56
	}

	[Address(RVA = "0xC30E80", Offset = "0xC30080", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LambdaExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000368")]
	internal Expression`1(Expression body) { }

	[Address(RVA = "0xC30A70", Offset = "0xC2FC70", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036E")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0xC30C60", Offset = "0xC2FE60", Length = "0xD8")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = "OptimizeGetter", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor", Member = "MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.PropertyMemberDescriptor", Member = "OptimizeGetter", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.PropertyMemberDescriptor", Member = "OptimizeSetter", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(LightCompiler), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600036B")]
	public TDelegate Compile() { }

	[Address(RVA = "0xC30AD0", Offset = "0xC2FCD0", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LightCompiler), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
	[Calls(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x600036C")]
	public TDelegate Compile(bool preferInterpretation) { }

	[Address(RVA = "0xC30E90", Offset = "0xC30090", Length = "0x39")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	[Token(Token = "0x600036A")]
	internal virtual Type get_PublicType() { }

	[Address(RVA = "0xC30ED0", Offset = "0xC300D0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000369")]
	internal virtual Type get_TypeCore() { }

	[Address(RVA = "0xC30E60", Offset = "0xC30060", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x600036D")]
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

