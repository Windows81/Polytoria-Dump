namespace UnityEngine.UIElements;

[Token(Token = "0x2000293")]
public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A32")]
	private MouseButton <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000A33")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A34")]
	private int <clickCount>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000363")]
	public MouseButton button
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60011E6")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E7")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000365")]
	public int clickCount
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60011EA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000364")]
	public EventModifiers modifiers
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60011E8")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E9")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1C87190", Offset = "0x1C86390", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011EB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1C87240", Offset = "0x1C86440", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011EC")]
	public override bool Equals(ManipulatorActivationFilter other) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60011E6")]
	public MouseButton get_button() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60011EA")]
	public int get_clickCount() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60011E8")]
	public EventModifiers get_modifiers() { }

	[Address(RVA = "0x1C87260", Offset = "0x1C86460", Length = "0x69")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60011ED")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1C872D0", Offset = "0x1C864D0", Length = "0xE8")]
	[CalledBy(Type = typeof(ManipulatorActivationFilter), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ManipulatorActivationFilter), Member = "MatchModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60011EF")]
	private bool HasModifiers(IPointerEvent e) { }

	[Address(RVA = "0x1C87440", Offset = "0x1C86640", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ManipulatorActivationFilter), Member = "HasModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011EE")]
	public bool Matches(IPointerEvent e) { }

	[Address(RVA = "0x1C873C0", Offset = "0x1C865C0", Length = "0x7F")]
	[CalledBy(Type = typeof(ManipulatorActivationFilter), Member = "HasModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60011F0")]
	private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E7")]
	public void set_button(MouseButton value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E9")]
	public void set_modifiers(EventModifiers value) { }

}

