namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001CA")]
internal class ByRefNewInstruction : NewInstruction
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000350")]
	private readonly ByRefUpdater[] _byrefArgs; //Field offset: 0x20

	[Token(Token = "0x170001DE")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15CE290", Offset = "0x15CD490", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000924")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1593A30", Offset = "0x1592C30", Length = "0x5E")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000923")]
	internal ByRefNewInstruction(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	[Address(RVA = "0x15CE290", Offset = "0x15CD490", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000924")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15CE090", Offset = "0x15CD290", Length = "0x1F2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815CD530")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NewInstruction), Member = "GetArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000925")]
	public virtual int Run(InterpretedFrame frame) { }

}

