namespace UnityEngine.Events;

[Token(Token = "0x20001CE")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000667")]
	private Object[] m_InvokeArray; //Field offset: 0x0

	[Address(RVA = "0x842620", Offset = "0x841820", Length = "0x2B")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000C6D")]
	public UnityEvent`3() { }

	[Address(RVA = "0x8433D0", Offset = "0x8425D0", Length = "0xBC")]
	[CalledBy(Type = "HSVPicker.ColorLabel", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.ColorSlider", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.ColorSliderImage", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.SVBoxSlider", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEventBase), Member = "AddCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseInvokableCall)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C6E")]
	public void AddListener(UnityAction<T0, T1, T2> call) { }

	[Address(RVA = "0x843660", Offset = "0x842860", Length = "0x1C2")]
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
	[Token(Token = "0x6000C70")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x843A00", Offset = "0x842C00", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C71")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x843A80", Offset = "0x842C80", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C72")]
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action) { }

	[Address(RVA = "0x843C50", Offset = "0x842E50", Length = "0x37F")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "SendOnTextSelection", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "SendOnEndTextSelection", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvokableCall`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Events.BaseInvokableCall>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C73")]
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

	[Address(RVA = "0x8425D0", Offset = "0x8417D0", Length = "0x48")]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C6F")]
	public void RemoveListener(UnityAction<T0, T1, T2> call) { }

}

