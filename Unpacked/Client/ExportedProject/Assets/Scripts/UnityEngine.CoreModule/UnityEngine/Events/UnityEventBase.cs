namespace UnityEngine.Events;

[Token(Token = "0x20001C6")]
[UsedByNativeCode]
public abstract class UnityEventBase : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000661")]
	private InvokableCallList m_Calls; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_PersistentListeners")]
	[SerializeField]
	[Token(Token = "0x4000662")]
	private PersistentCallGroup m_PersistentCalls; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000663")]
	private bool m_CallsDirty; //Field offset: 0x20

	[Address(RVA = "0x1992E90", Offset = "0x1992090", Length = "0x1B5")]
	[CalledBy(Type = typeof(UnityEvent`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`3), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`4), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x6000C41")]
	protected UnityEventBase() { }

	[Address(RVA = "0x19922F0", Offset = "0x19914F0", Length = "0xBD")]
	[CalledBy(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`2), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`2<T0, T1>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`3), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`3<T0, T1, T2>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C4A")]
	internal void AddCall(BaseInvokableCall call) { }

	[Address(RVA = "0x19923B0", Offset = "0x19915B0", Length = "0xD9")]
	[CalledBy(Type = typeof(UnityEventBase), Member = "UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEventBase), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C48")]
	private void DirtyPersistentCalls() { }

	[Address(RVA = "0x1992490", Offset = "0x1991690", Length = "0x1C7")]
	[CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEventBase)}, ReturnType = typeof(BaseInvokableCall))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE760")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(PersistentCall), Member = "get_targetAssemblyTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(PersistentListenerMode), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C46")]
	internal MethodInfo FindMethod(PersistentCall call) { }

	[Address(RVA = "0x1992660", Offset = "0x1991860", Length = "0x360")]
	[CalledBy(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PersistentCall)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000C47")]
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	[Token(Token = "0x6000C44")]
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Token(Token = "0x6000C45")]
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x19929E0", Offset = "0x1991BE0", Length = "0x1FE")]
	[CalledBy(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(PersistentListenerMode), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(UnityEvent), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(UnityEvent`1), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(UnityEvent`2), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(UnityEvent`3), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(UnityEvent`4), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000C4F")]
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }

	[Address(RVA = "0x1992BE0", Offset = "0x1991DE0", Length = "0xD9")]
	[CalledBy(Type = typeof(UnityEvent`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`2), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C4D")]
	internal List<BaseInvokableCall> PrepareInvoke() { }

	[Address(RVA = "0x1992CC0", Offset = "0x1991EC0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C49")]
	private void RebuildPersistentCallsIfNeeded() { }

	[Address(RVA = "0x1992D00", Offset = "0x1991F00", Length = "0xC9")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SetPublishModalSelectedGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleJSON.JSONNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTActiveLibDropDown", Member = "SetActiveLibIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnColorBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnColorDisplayerBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMin", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMax", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadLeaderboardThumbnail>d__121", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.UIControls.UnityEventHelper", Member = "RemoveAllListeners", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "System.Func`2<T, UnityEvent>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.UnityEventHelper", Member = "RemoveAllListeners", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "System.Func`2<T, UnityEvent`1<V>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C4C")]
	public void RemoveAllListeners() { }

	[Address(RVA = "0x1992DD0", Offset = "0x1991FD0", Length = "0x1E")]
	[CalledBy(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`2), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`2<T0, T1>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`3), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`3<T0, T1, T2>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvokableCallList), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C4B")]
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	[Address(RVA = "0x1992DF0", Offset = "0x1991FF0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C4E")]
	public virtual string ToString() { }

	[Address(RVA = "0x1992E80", Offset = "0x1992080", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventBase), Member = "DirtyPersistentCalls", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C43")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x1992E80", Offset = "0x1992080", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventBase), Member = "DirtyPersistentCalls", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C42")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

