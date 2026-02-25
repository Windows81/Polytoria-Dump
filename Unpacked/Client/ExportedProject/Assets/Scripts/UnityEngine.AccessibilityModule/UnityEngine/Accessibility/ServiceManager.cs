namespace UnityEngine.Accessibility;

[Token(Token = "0x2000015")]
internal class ServiceManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000063")]
	private readonly IDictionary<Type, IService> m_Services; //Field offset: 0x10

	[Address(RVA = "0x18FF4F0", Offset = "0x18FE6F0", Length = "0x2AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccessibilityManager), Member = "add_screenReaderStatusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ServiceManager), Member = "UpdateServices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002A760")]
	[Calls(Type = "UnityEngine.Bindings.BindingsAllocator", Member = "GetNativeOwnedDataPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(Void*))]
	[Calls(Type = "UnityEngine.Bindings.BindingsAllocator", Member = "FreeNativeOwnedMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008C")]
	public ServiceManager() { }

	[Address(RVA = "0x758E10", Offset = "0x758010", Length = "0x15C")]
	[CalledBy(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008D")]
	public T GetService() { }

	[Address(RVA = "0x18FF2A0", Offset = "0x18FE4A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ServiceManager), Member = "UpdateServices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000090")]
	protected void ScreenReaderStatusChanged(bool isScreenReaderEnabled) { }

	[Address(RVA = "0x759170", Offset = "0x758370", Length = "0x1EF")]
	[CalledBy(Type = typeof(ServiceManager), Member = "UpdateServices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008E")]
	private void StopService() { }

	[Address(RVA = "0x18FF2B0", Offset = "0x18FE4B0", Length = "0x235")]
	[CalledBy(Type = typeof(AssistiveSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServiceManager), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServiceManager), Member = "ScreenReaderStatusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ServiceManager), Member = "StopService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600008F")]
	private void UpdateServices(bool isScreenReaderEnabled) { }

}

