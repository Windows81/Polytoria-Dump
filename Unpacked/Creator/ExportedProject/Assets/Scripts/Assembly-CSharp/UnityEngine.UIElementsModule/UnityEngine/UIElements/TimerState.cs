namespace UnityEngine.UIElements;

[Token(Token = "0x20002D8")]
public struct TimerState : IEquatable<TimerState>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B85")]
	private long <start>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B86")]
	private long <now>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x170003D2")]
	public long deltaTime
	{
		[Address(RVA = "0x1AEB1B0", Offset = "0x1AEA3B0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60013E0")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170003D1")]
	public long now
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60013DE")]
		 get { } //Length: 5
		[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DF")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170003D0")]
	public long start
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60013DC")]
		 get { } //Length: 4
		[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DD")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1AEB090", Offset = "0x1AEA290", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013E1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1AEB060", Offset = "0x1AEA260", Length = "0x29")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013E2")]
	public override bool Equals(TimerState other) { }

	[Address(RVA = "0x1AEB1B0", Offset = "0x1AEA3B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60013E0")]
	public long get_deltaTime() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60013DE")]
	public long get_now() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60013DC")]
	public long get_start() { }

	[Address(RVA = "0x1AEB130", Offset = "0x1AEA330", Length = "0x72")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60013E3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DF")]
	public void set_now(long value) { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DD")]
	public void set_start(long value) { }

}

