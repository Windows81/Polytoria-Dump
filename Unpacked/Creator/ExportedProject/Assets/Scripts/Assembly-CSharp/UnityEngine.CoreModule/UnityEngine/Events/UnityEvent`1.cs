namespace UnityEngine.Events;

[Token(Token = "0x20001CA")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000665")]
	private Object[] m_InvokeArray; //Field offset: 0x0

	[Address(RVA = "0x842620", Offset = "0x841820", Length = "0x2B")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000C5B")]
	public UnityEvent`1() { }

	[Address(RVA = "0x840250", Offset = "0x83F450", Length = "0xBC")]
	[CallerCount(Count = 95)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T1>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEventBase), Member = "AddCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseInvokableCall)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C5C")]
	public void AddListener(UnityAction<T0> call) { }

	[Address(RVA = "0x840660", Offset = "0x83F860", Length = "0xF2")]
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
	[Token(Token = "0x6000C5E")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x840CE0", Offset = "0x83FEE0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C5F")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x840D60", Offset = "0x83FF60", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T1>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C60")]
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }

	[Address(RVA = "0x841470", Offset = "0x840670", Length = "0x271")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateCulling", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Toggle", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Events.BaseInvokableCall>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C61")]
	public void Invoke(T0 arg0) { }

	[Address(RVA = "0x8425D0", Offset = "0x8417D0", Length = "0x48")]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C5D")]
	public void RemoveListener(UnityAction<T0> call) { }

}

