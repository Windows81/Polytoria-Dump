namespace UnityEngine.Events;

[Token(Token = "0x20001CC")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000666")]
	private Object[] m_InvokeArray; //Field offset: 0x0

	[Address(RVA = "0x842620", Offset = "0x841820", Length = "0x2B")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000C64")]
	public UnityEvent`2() { }

	[Address(RVA = "0x842650", Offset = "0x841850", Length = "0xBC")]
	[CalledBy(Type = "HSVPicker.SVBoxSlider", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEventBase), Member = "AddCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseInvokableCall)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C65")]
	public void AddListener(UnityAction<T0, T1> call) { }

	[Address(RVA = "0x842880", Offset = "0x841A80", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C67")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x8429F0", Offset = "0x841BF0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C68")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x842AF0", Offset = "0x841CF0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C69")]
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action) { }

	[Address(RVA = "0x8430B0", Offset = "0x8422B0", Length = "0x31A")]
	[CalledBy(Type = "HSVPicker.BoxSlider", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.BoxSlider", Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvokableCall`2), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Events.BaseInvokableCall>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C6A")]
	public void Invoke(T0 arg0, T1 arg1) { }

	[Address(RVA = "0x8425D0", Offset = "0x8417D0", Length = "0x48")]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C66")]
	public void RemoveListener(UnityAction<T0, T1> call) { }

}

