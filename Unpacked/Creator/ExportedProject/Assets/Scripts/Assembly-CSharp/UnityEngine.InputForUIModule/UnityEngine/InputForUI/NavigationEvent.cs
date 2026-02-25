namespace UnityEngine.InputForUI;

[Token(Token = "0x2000015")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct NavigationEvent : IEventProperties
{
	[Token(Token = "0x2000017")]
	internal enum Direction
	{
		None = 0,
		Left = 1,
		Up = 2,
		Right = 3,
		Down = 4,
		Next = 5,
		Previous = 6,
	}

	[Token(Token = "0x2000016")]
	internal enum Type
	{
		Move = 1,
		Submit = 2,
		Cancel = 3,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000066")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000067")]
	public Direction direction; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000068")]
	public bool shouldBeUsed; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000069")]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006A")]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400006B")]
	private uint <playerId>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400006C")]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000025")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000052")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000053")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000023")]
	public override EventSource eventSource
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600004F")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000050")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public uint playerId
	{
		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000051")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000022")]
	public DiscreteTime timestamp
	{
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600004E")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x19D7440", Offset = "0x19D6640", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000055")]
	internal static Direction DetermineMoveDirection(Vector2 vec, float deadZone = 0.6) { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000052")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600004F")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000053")]
	public void set_eventModifiers(EventModifiers value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000050")]
	public void set_eventSource(EventSource value) { }

	[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000051")]
	public void set_playerId(uint value) { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600004E")]
	public void set_timestamp(DiscreteTime value) { }

	[Address(RVA = "0x19D74B0", Offset = "0x19D66B0", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000054")]
	public virtual string ToString() { }

}

