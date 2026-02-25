namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000D7")]
internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C6")]
	private readonly ByRefUpdater[] _byrefArgs; //Field offset: 0x20

	[Token(Token = "0x1700012A")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x1593A90", Offset = "0x1592C90", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000516")]
		 get { } //Length: 127
	}

	[Address(RVA = "0x1593A30", Offset = "0x1592C30", Length = "0x5E")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000515")]
	internal ByRefMethodInfoCallInstruction(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	[Address(RVA = "0x1593A90", Offset = "0x1592C90", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000516")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x1593510", Offset = "0x1592710", Length = "0x513")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18158E250")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LightLambda), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(LightLambda), Member = "RunVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CallInstruction), Member = "TryGetLightLambdaTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(LightLambda&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodInfoCallInstruction), Member = "GetArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(int), typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000517")]
	public virtual int Run(InterpretedFrame frame) { }

}

