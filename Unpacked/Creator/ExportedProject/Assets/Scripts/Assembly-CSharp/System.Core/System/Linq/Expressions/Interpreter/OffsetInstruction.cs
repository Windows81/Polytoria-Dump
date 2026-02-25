namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000D8")]
internal abstract class OffsetInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C7")]
	protected int _offset; //Field offset: 0x10

	[Token(Token = "0x1700012B")]
	public abstract Instruction[] Cache
	{
		[Token(Token = "0x6000518")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1592C70", Offset = "0x1591E70", Length = "0xE")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051C")]
	protected OffsetInstruction() { }

	[Address(RVA = "0x15A74D0", Offset = "0x15A66D0", Length = "0x9E")]
	[CalledBy(Type = typeof(InstructionList), Member = "FixupBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000519")]
	public Instruction Fixup(int offset) { }

	[Token(Token = "0x6000518")]
	public abstract Instruction[] get_Cache() { }

	[Address(RVA = "0x15A7570", Offset = "0x15A6770", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600051A")]
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

	[Address(RVA = "0x15A7630", Offset = "0x15A6830", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600051B")]
	public virtual string ToString() { }

}

