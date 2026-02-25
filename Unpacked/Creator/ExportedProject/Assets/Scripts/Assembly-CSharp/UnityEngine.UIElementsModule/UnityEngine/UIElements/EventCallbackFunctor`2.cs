namespace UnityEngine.UIElements;

[Token(Token = "0x20001C3")]
internal class EventCallbackFunctor : EventCallbackFunctorBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000807")]
	private EventCallback<TEventType, TCallbackArgs> m_Callback; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000808")]
	private TCallbackArgs <userArgs>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700024C")]
	internal TCallbackArgs userArgs
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CD3")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CD4")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CDA")]
	public EventCallbackFunctor`2() { }

	[Address(RVA = "0xC2ECF0", Offset = "0xC2DEF0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GenericPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD6")]
	public virtual void Dispose() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD3")]
	internal TCallbackArgs get_userArgs() { }

	[Address(RVA = "0xC2F180", Offset = "0xC2E380", Length = "0xF3")]
	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GenericPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD5")]
	public static EventCallbackFunctor<TEventType, TCallbackArgs> GetPooled(long eventTypeId, EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, InvokePolicy invokePolicy = 0) { }

	[Address(RVA = "0xC2F280", Offset = "0xC2E480", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD7")]
	public virtual void Invoke(EventBase evt) { }

	[Address(RVA = "0xC2EC80", Offset = "0xC2DE80", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD9")]
	public virtual bool IsEquivalentTo(long eventTypeId, Delegate callback) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD4")]
	internal void set_userArgs(TCallbackArgs value) { }

	[Address(RVA = "0xC2F560", Offset = "0xC2E760", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD8")]
	public virtual void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown) { }

}

