namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E0")]
internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D5")]
	private TryFaultHandler _tryHandler; //Field offset: 0x18

	[Token(Token = "0x17000142")]
	internal TryFaultHandler Handler
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600054B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000140")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1597A10", Offset = "0x1596C10", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000549")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000141")]
	public virtual int ProducedContinuations
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600054A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000548")]
	internal EnterTryFaultInstruction(int targetIndex) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600054B")]
	internal TryFaultHandler get_Handler() { }

	[Address(RVA = "0x1597A10", Offset = "0x1596C10", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000549")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600054A")]
	public virtual int get_ProducedContinuations() { }

	[Address(RVA = "0x1597770", Offset = "0x1596970", Length = "0x29F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "PushContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18158E3F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600054D")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600054C")]
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

}

