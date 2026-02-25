namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeManager.h")]
[Token(Token = "0x2000009")]
internal static class AccessibilityNodeManager
{

	[Address(RVA = "0x18FCC00", Offset = "0x18FBE00", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003A")]
	internal static void DestroyNativeNode(int id, int parentId) { }

	[Address(RVA = "0x18FCC40", Offset = "0x18FBE40", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "TryGetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000041")]
	internal static void Internal_InvokeDecremented(int id) { }

	[Address(RVA = "0x18FCD10", Offset = "0x18FBF10", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "TryGetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000042")]
	internal static bool Internal_InvokeDismissed(int id) { }

	[Address(RVA = "0x18FCE00", Offset = "0x18FC000", Length = "0x1E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "TryGetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AccessibilityManager), Member = "QueueNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotificationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003E")]
	internal static void Internal_InvokeFocusChanged(int id, bool isNodeFocused) { }

	[Address(RVA = "0x18FCFF0", Offset = "0x18FC1F0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "TryGetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000040")]
	internal static void Internal_InvokeIncremented(int id) { }

	[Address(RVA = "0x18FD0C0", Offset = "0x18FC2C0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "TryGetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x600003F")]
	internal static bool Internal_InvokeSelected(int id) { }

	[Address(RVA = "0x18FD1B0", Offset = "0x18FC3B0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	internal static void SetActions(int id, AccessibilityAction[] actions) { }

	[Address(RVA = "0x18FD230", Offset = "0x18FC430", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	internal static void SetChildren(int id, Int32[] childIds) { }

	[Address(RVA = "0x18FD1F0", Offset = "0x18FC3F0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000044")]
	private static void SetChildren_Injected(int id, ref ManagedSpanWrapper childIds) { }

	[Address(RVA = "0x18FD340", Offset = "0x18FC540", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003B")]
	internal static void SetFrame(int id, Rect frame) { }

	[Address(RVA = "0x18FD300", Offset = "0x18FC500", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000043")]
	private static void SetFrame_Injected(int id, in Rect frame) { }

}

