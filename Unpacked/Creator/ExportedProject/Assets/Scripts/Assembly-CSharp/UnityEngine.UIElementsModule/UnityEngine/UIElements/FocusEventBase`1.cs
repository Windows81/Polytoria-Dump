namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Focus (11))]
[Token(Token = "0x20001CE")]
public abstract class FocusEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400082A")]
	private Focusable <relatedTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400082B")]
	private FocusChangeDirection <direction>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400082C")]
	private FocusController <focusController>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400082D")]
	private bool <IsFocusDelegated>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700024F")]
	public private override FocusChangeDirection direction
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D27")]
		 get { } //Length: 5
		[Address(RVA = "0x5ECDD0", Offset = "0x5EBFD0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D28")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000250")]
	protected private FocusController focusController
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D29")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D2A")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000251")]
	internal bool IsFocusDelegated
	{
		[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D2B")]
		internal get { } //Length: 8
		[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D2C")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700024E")]
	public private override Focusable relatedTarget
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D25")]
		 get { } //Length: 5
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D26")]
		private set { } //Length: 13
	}

	[Address(RVA = "0xC411B0", Offset = "0xC403B0", Length = "0x79")]
	[CalledBy(Type = "UnityEngine.UIElements.FocusOutEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(FocusOutEvent))]
	[CalledBy(Type = typeof(FocusOutEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BlurEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(BlurEvent))]
	[CalledBy(Type = typeof(BlurEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FocusInEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(FocusInEvent))]
	[CalledBy(Type = typeof(FocusInEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FocusEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(FocusEvent))]
	[CalledBy(Type = typeof(FocusEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABE90")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D30")]
	protected FocusEventBase`1() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D27")]
	public override FocusChangeDirection get_direction() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D29")]
	protected FocusController get_focusController() { }

	[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2B")]
	internal bool get_IsFocusDelegated() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D25")]
	public override Focusable get_relatedTarget() { }

	[Address(RVA = "0xC40EE0", Offset = "0xC400E0", Length = "0x1AD")]
	[CalledBy(Type = typeof(FocusController), Member = "AboutToReleaseFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "ReleaseFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "AboutToGrabFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "GrabFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2F")]
	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false) { }

	[Address(RVA = "0xC41090", Offset = "0xC40290", Length = "0x4F")]
	[CalledBy(Type = typeof(FocusOutEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusInEvent), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABE90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2D")]
	protected virtual void Init() { }

	[Address(RVA = "0xC410E0", Offset = "0xC402E0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2E")]
	private void LocalInit() { }

	[Address(RVA = "0x5ECDD0", Offset = "0x5EBFD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D28")]
	private void set_direction(FocusChangeDirection value) { }

	[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2A")]
	private void set_focusController(FocusController value) { }

	[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2C")]
	private void set_IsFocusDelegated(bool value) { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D26")]
	private void set_relatedTarget(Focusable value) { }

}

