namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
[Token(Token = "0x20001A8")]
public abstract class PointerCaptureEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007CF")]
	private IEventHandler <relatedTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007D0")]
	private int <pointerId>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700022D")]
	public private override int pointerId
	{
		[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C31")]
		 get { } //Length: 4
		[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C32")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700022C")]
	private IEventHandler relatedTarget
	{
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C30")]
		private set { } //Length: 13
	}

	[Address(RVA = "0xE68880", Offset = "0xE67A80", Length = "0xCF")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerCaptureOutEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(PointerCaptureOutEvent))]
	[CalledBy(Type = typeof(PointerCaptureOutEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerCaptureEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(PointerCaptureEvent))]
	[CalledBy(Type = typeof(PointerCaptureEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseCaptureEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C36")]
	protected PointerCaptureEventBase`1() { }

	[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C31")]
	public override int get_pointerId() { }

	[Address(RVA = "0xE68610", Offset = "0xE67810", Length = "0x158")]
	[CalledBy(Type = typeof(PointerDispatchState), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C35")]
	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }

	[Address(RVA = "0xE68770", Offset = "0xE67970", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C33")]
	protected virtual void Init() { }

	[Address(RVA = "0xE68800", Offset = "0xE67A00", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C34")]
	private void LocalInit() { }

	[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C32")]
	private void set_pointerId(int value) { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C30")]
	private void set_relatedTarget(IEventHandler value) { }

}

