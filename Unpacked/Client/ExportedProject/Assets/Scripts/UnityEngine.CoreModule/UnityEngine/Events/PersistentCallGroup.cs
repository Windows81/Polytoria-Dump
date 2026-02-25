namespace UnityEngine.Events;

[Token(Token = "0x20001C4")]
internal class PersistentCallGroup
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("m_Listeners")]
	[SerializeField]
	[Token(Token = "0x400065C")]
	private List<PersistentCall> m_Calls; //Field offset: 0x10

	[Address(RVA = "0x1985C50", Offset = "0x1984E50", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C38")]
	public PersistentCallGroup() { }

	[Address(RVA = "0x1985AD0", Offset = "0x1984CD0", Length = "0x17E")]
	[CalledBy(Type = typeof(UnityEventBase), Member = "RebuildPersistentCallsIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Events.BaseInvokableCall>))]
	[CalledBy(Type = typeof(UnityEvent), Member = "Invoke", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PersistentCall), Member = "get_targetAssemblyTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEventBase)}, ReturnType = typeof(BaseInvokableCall))]
	[Calls(Type = typeof(InvokableCallList), Member = "AddPersistentInvokableCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseInvokableCall)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C39")]
	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }

}

