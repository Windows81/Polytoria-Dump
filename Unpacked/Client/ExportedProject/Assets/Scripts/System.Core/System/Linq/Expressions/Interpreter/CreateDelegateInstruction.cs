namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200021B")]
internal sealed class CreateDelegateInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400039A")]
	private readonly LightDelegateCreator _creator; //Field offset: 0x10

	[Token(Token = "0x17000202")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x15D0790", Offset = "0x15CF990", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interpreter), Member = "get_ClosureSize", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009FA")]
		 get { } //Length: 38
	}

	[Token(Token = "0x17000204")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15D07C0", Offset = "0x15CF9C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60009FC")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000203")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009FB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F9")]
	internal CreateDelegateInstruction(LightDelegateCreator delegateCreator) { }

	[Address(RVA = "0x15D0790", Offset = "0x15CF990", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interpreter), Member = "get_ClosureSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009FA")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15D07C0", Offset = "0x15CF9C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60009FC")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009FB")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15D05C0", Offset = "0x15CF7C0", Length = "0x1C8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IStrongBox[])}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009FD")]
	public virtual int Run(InterpretedFrame frame) { }

}

