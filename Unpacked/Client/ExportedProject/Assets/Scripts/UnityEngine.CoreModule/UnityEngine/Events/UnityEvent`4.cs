namespace UnityEngine.Events;

[Token(Token = "0x20001D0")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000668")]
	private Object[] m_InvokeArray; //Field offset: 0x0

	[Address(RVA = "0x842620", Offset = "0x841820", Length = "0x2B")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000C76")]
	public UnityEvent`4() { }

	[Address(RVA = "0x844980", Offset = "0x843B80", Length = "0x226")]
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
	[Token(Token = "0x6000C77")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x840C60", Offset = "0x83FE60", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C78")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

