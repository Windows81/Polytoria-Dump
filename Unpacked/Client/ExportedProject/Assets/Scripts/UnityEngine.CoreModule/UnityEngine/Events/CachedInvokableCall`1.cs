namespace UnityEngine.Events;

[Token(Token = "0x20001C1")]
internal class CachedInvokableCall : InvokableCall<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000651")]
	private readonly T m_Arg1; //Field offset: 0x0

	[Address(RVA = "0x968640", Offset = "0x967840", Length = "0x38")]
	[CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEventBase)}, ReturnType = typeof(BaseInvokableCall))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2A")]
	public CachedInvokableCall`1(object target, MethodInfo theFunction, T argument) { }

	[Address(RVA = "0x968450", Offset = "0x967650", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvokableCall`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2B")]
	public virtual void Invoke(Object[] args) { }

	[Address(RVA = "0x968450", Offset = "0x967650", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvokableCall`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2C")]
	public virtual void Invoke(T arg0) { }

}

