namespace UnityEngine.UIElements;

[Token(Token = "0x20001A3")]
public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007BB")]
	private readonly EventDispatcher m_Dispatcher; //Field offset: 0x0

	[Address(RVA = "0x1C50390", Offset = "0x1C4F590", Length = "0x78")]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAllAnimations", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAllAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "ProcessEventQueue", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C1C")]
	public EventDispatcherGate(EventDispatcher d) { }

	[Address(RVA = "0x1C502E0", Offset = "0x1C4F4E0", Length = "0x1C")]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAllAnimations", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAllAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "ProcessEventQueue", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(EventDispatcher), Member = "OpenGate", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C1D")]
	public override void Dispose() { }

	[Address(RVA = "0x1B75970", Offset = "0x1B74B70", Length = "0xD")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C1E")]
	public override bool Equals(EventDispatcherGate other) { }

	[Address(RVA = "0x1C50300", Offset = "0x1C4F500", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C1F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B0B4B0", Offset = "0x1B0A6B0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C20")]
	public virtual int GetHashCode() { }

}

