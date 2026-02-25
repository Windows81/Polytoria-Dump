namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000193")]
internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction
{

	[Token(Token = "0x170001AE")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600087A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001AF")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15E4060", Offset = "0x15E3260", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600087B")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000879")]
	internal StoreLocalInstruction(int index) { }

	[Address(RVA = "0x15E3F50", Offset = "0x15E3150", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InstructionList), Member = "StoreLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Token(Token = "0x600087D")]
	public override Instruction BoxIfIndexMatches(int index) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600087A")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15E4060", Offset = "0x15E3260", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600087B")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15E3FC0", Offset = "0x15E31C0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600087C")]
	public virtual int Run(InterpretedFrame frame) { }

}

