namespace UnityEngine.UIElements;

[EventCategory(EventCategory::StyleTransition (13))]
[Token(Token = "0x2000238")]
public abstract class TransitionEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C5")]
	private readonly StylePropertyNameCollection <stylePropertyNames>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C6")]
	private double <elapsedTime>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170002CE")]
	protected double elapsedTime
	{
		[Address(RVA = "0x96AC80", Offset = "0x969E80", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F67")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170002CD")]
	public override StylePropertyNameCollection stylePropertyNames
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F66")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1002710", Offset = "0x1001910", Length = "0x130")]
	[CalledBy(Type = typeof(TransitionCancelEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TransitionCancelEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(TransitionCancelEvent))]
	[CalledBy(Type = "UnityEngine.UIElements.TransitionEndEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(TransitionEndEvent))]
	[CalledBy(Type = typeof(TransitionStartEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransitionEndEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransitionRunEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TransitionRunEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(TransitionRunEvent))]
	[CalledBy(Type = "UnityEngine.UIElements.TransitionStartEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(TransitionStartEvent))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F68")]
	protected TransitionEventBase`1() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F66")]
	public override StylePropertyNameCollection get_stylePropertyNames() { }

	[Address(RVA = "0x1002490", Offset = "0x1001690", Length = "0x179")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionRunEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionStartEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionEndEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "SendTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F6B")]
	public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime) { }

	[Address(RVA = "0x1002610", Offset = "0x1001810", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F69")]
	protected virtual void Init() { }

	[Address(RVA = "0x10026A0", Offset = "0x10018A0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F6A")]
	private void LocalInit() { }

	[Address(RVA = "0x96AC80", Offset = "0x969E80", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F67")]
	protected void set_elapsedTime(double value) { }

}

