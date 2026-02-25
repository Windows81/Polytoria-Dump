namespace UnityEngine.InputForUI;

[Token(Token = "0x2000002")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct CommandEvent : IEventProperties
{
	[Token(Token = "0x2000004")]
	internal enum Command
	{
		Invalid = 0,
		Cut = 1,
		Copy = 2,
		Paste = 3,
		SelectAll = 4,
		DeselectAll = 5,
		InvertSelection = 6,
		Duplicate = 7,
		Rename = 8,
		Delete = 9,
		SoftDelete = 10,
		Find = 11,
		SelectChildren = 12,
		SelectPrefabRoot = 13,
		UndoRedoPerformed = 14,
		OnLostFocus = 15,
		NewKeyboardFocus = 16,
		ModifierKeysChanged = 17,
		EyeDropperUpdate = 18,
		EyeDropperClicked = 19,
		EyeDropperCancelled = 20,
		ColorPickerChanged = 21,
		FrameSelected = 22,
		FrameSelectedWithLock = 23,
	}

	[Token(Token = "0x2000003")]
	internal enum Type
	{
		Validate = 1,
		Execute = 2,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000002")]
	public Command command; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000003")]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000004")]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000005")]
	private uint <playerId>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000004")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000005")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000002")]
	public override EventSource eventSource
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000002")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000003")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000003")]
	public uint playerId
	{
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000004")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000001")]
	public DiscreteTime timestamp
	{
		[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000001")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000005")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000002")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public void set_eventModifiers(EventModifiers value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public void set_eventSource(EventSource value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public void set_playerId(uint value) { }

	[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000001")]
	public void set_timestamp(DiscreteTime value) { }

	[Address(RVA = "0x19CFC80", Offset = "0x19CEE80", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000007")]
	public virtual string ToString() { }

}

