namespace UnityEngine.UIElements;

[Token(Token = "0x20002A8")]
internal class RepaintData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AAE")]
	private Matrix4x4 <currentOffset>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000AAF")]
	private Vector2 <mousePosition>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000AB0")]
	private Rect <currentWorldClip>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AB1")]
	private Event <repaintEvent>k__BackingField; //Field offset: 0x68

	[Token(Token = "0x1700036A")]
	public Matrix4x4 currentOffset
	{
		[Address(RVA = "0xB115E0", Offset = "0xB107E0", Length = "0x23")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001224")]
		 get { } //Length: 35
	}

	[Token(Token = "0x1700036B")]
	public Rect currentWorldClip
	{
		[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001225")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700036C")]
	public Event repaintEvent
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001226")]
		 get { } //Length: 5
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001227")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1C8DCB0", Offset = "0x1C8CEB0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001228")]
	public RepaintData() { }

	[Address(RVA = "0xB115E0", Offset = "0xB107E0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001224")]
	public Matrix4x4 get_currentOffset() { }

	[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001225")]
	public Rect get_currentWorldClip() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001226")]
	public Event get_repaintEvent() { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001227")]
	public void set_repaintEvent(Event value) { }

}

