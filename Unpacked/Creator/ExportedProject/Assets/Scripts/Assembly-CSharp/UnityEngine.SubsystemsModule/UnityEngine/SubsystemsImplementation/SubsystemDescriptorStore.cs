namespace UnityEngine.SubsystemsImplementation;

[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
[Token(Token = "0x200000D")]
public static class SubsystemDescriptorStore
{
	[Token(Token = "0x400000C")]
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; //Field offset: 0x0
	[Token(Token = "0x400000D")]
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; //Field offset: 0x8
	[Token(Token = "0x400000E")]
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; //Field offset: 0x10

	[Address(RVA = "0x1A1A1C0", Offset = "0x1A193C0", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600001C")]
	private static SubsystemDescriptorStore() { }

	[Address(RVA = "0x1A19D00", Offset = "0x1A18F00", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000018")]
	internal static void ClearManagedDescriptors() { }

	[Address(RVA = "0x1A19E90", Offset = "0x1A19090", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000017")]
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	[Address(RVA = "0x1A19F80", Offset = "0x1A19180", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SubsystemDescriptorStore), Member = "RegisterDescriptor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "TBaseTypeInList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "System.Collections.Generic.List`1<TBaseTypeInList>"}, ReturnType = typeof(void))]
	[Token(Token = "0x600001B")]
	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	[Address(RVA = "0x768180", Offset = "0x767380", Length = "0x280")]
	[CalledBy(Type = typeof(Internal_SubsystemDescriptors), Member = "Internal_AddDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubsystemDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SubsystemDescriptorStore), Member = "RegisterDeprecatedDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubsystemDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SubsystemDescriptorStore), Member = "ReportSingleSubsystemAnalytics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001A")]
	internal static void RegisterDescriptor(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }

	[Address(RVA = "0x1A1A030", Offset = "0x1A19230", Length = "0x18B")]
	[CalledBy(Type = typeof(SubsystemDescriptorStore), Member = "RegisterDescriptor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "TBaseTypeInList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "System.Collections.Generic.List`1<TBaseTypeInList>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	private static void ReportSingleSubsystemAnalytics(string id) { }

	[Address(RVA = "0x1A19FF0", Offset = "0x1A191F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	private static void ReportSingleSubsystemAnalytics_Injected(ref ManagedSpanWrapper id) { }

}

