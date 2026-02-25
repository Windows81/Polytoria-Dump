namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001C9")]
internal class NewInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400034E")]
	protected readonly ConstructorInfo _constructor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400034F")]
	protected readonly int _argumentCount; //Field offset: 0x18

	[Token(Token = "0x170001DB")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001DD")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15DC3B0", Offset = "0x15DB5B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600091F")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001DC")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x13B9AE0", Offset = "0x13B8CE0", Length = "0x42")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091C")]
	public NewInstruction(ConstructorInfo constructor, int argumentCount) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091D")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15DC3B0", Offset = "0x15DB5B0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600091F")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091E")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15DBF90", Offset = "0x15DB190", Length = "0x18D")]
	[CalledBy(Type = typeof(NewInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ByRefNewInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000921")]
	protected Object[] GetArgs(InterpretedFrame frame, int first) { }

	[Address(RVA = "0x15DC120", Offset = "0x15DB320", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NewInstruction), Member = "GetArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000920")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x15DC240", Offset = "0x15DB440", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000922")]
	public virtual string ToString() { }

}

