namespace UnityEngine.UIElements;

[Token(Token = "0x20001C2")]
internal class EventCallbackFunctor : EventCallbackFunctorBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000806")]
	private EventCallback<TEventType> m_Callback; //Field offset: 0x0

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD2")]
	public EventCallbackFunctor`1() { }

	[Address(RVA = "0xC2EA60", Offset = "0xC2DC60", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GenericPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCE")]
	public virtual void Dispose() { }

	[Address(RVA = "0xC2EAE0", Offset = "0xC2DCE0", Length = "0xC2")]
	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GenericPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCD")]
	public static EventCallbackFunctor<TEventType> GetPooled(long eventTypeId, EventCallback<TEventType> callback, InvokePolicy invokePolicy = 0) { }

	[Address(RVA = "0xC2EBB0", Offset = "0xC2DDB0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCF")]
	public virtual void Invoke(EventBase evt) { }

	[Address(RVA = "0xC2EC80", Offset = "0xC2DE80", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD1")]
	public virtual bool IsEquivalentTo(long eventTypeId, Delegate callback) { }

	[Address(RVA = "0xC2ECB0", Offset = "0xC2DEB0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD0")]
	public virtual void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown) { }

}

