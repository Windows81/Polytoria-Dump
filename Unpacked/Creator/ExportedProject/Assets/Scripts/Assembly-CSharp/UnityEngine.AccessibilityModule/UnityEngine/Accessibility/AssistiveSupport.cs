namespace UnityEngine.Accessibility;

[Token(Token = "0x200000D")]
public static class AssistiveSupport
{
	[Token(Token = "0x200000E")]
	public class NotificationDispatcher : IAccessibilityNotificationDispatcher
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005E")]
		public NotificationDispatcher() { }

		[Address(RVA = "0x18FF230", Offset = "0x18FE430", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005C")]
		private static void Send(in AccessibilityNotificationContext context) { }

		[Address(RVA = "0x18FF190", Offset = "0x18FE390", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005D")]
		public override void SendScreenChanged(AccessibilityNode nodeToFocus = null) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000045")]
	private static Action<AccessibilityNode> nodeFocusChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000046")]
	private static Action<Boolean> screenReaderStatusChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000047")]
	private static bool <isScreenReaderEnabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000048")]
	private static readonly IAccessibilityNotificationDispatcher <notificationDispatcher>k__BackingField; //Field offset: 0x18
	[Token(Token = "0x4000049")]
	private static ServiceManager s_ServiceManager; //Field offset: 0x20

	[Token(Token = "0x17000022")]
	public static AccessibilityHierarchy activeHierarchy
	{
		[Address(RVA = "0x18FEC10", Offset = "0x18FDE10", Length = "0x60")]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "get_frame", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "CalculateFrame", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "ChildrenChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "ActionsChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "IsInActiveHierarchy", ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Token(Token = "0x600005A")]
		 get { } //Length: 96
	}

	[Token(Token = "0x17000020")]
	public private static bool isScreenReaderEnabled
	{
		[Address(RVA = "0x18FEC70", Offset = "0x18FDE70", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000053")]
		 get { } //Length: 79
		[Address(RVA = "0x18FED10", Offset = "0x18FDF10", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000054")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000021")]
	public static IAccessibilityNotificationDispatcher notificationDispatcher
	{
		[Address(RVA = "0x18FECC0", Offset = "0x18FDEC0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000055")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x18FEB90", Offset = "0x18FDD90", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005B")]
	private static AssistiveSupport() { }

	[Address(RVA = "0x18FEC10", Offset = "0x18FDE10", Length = "0x60")]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "get_frame", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "CalculateFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "ChildrenChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "ActionsChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "IsInActiveHierarchy", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x600005A")]
	public static AccessibilityHierarchy get_activeHierarchy() { }

	[Address(RVA = "0x18FEC70", Offset = "0x18FDE70", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000053")]
	public static bool get_isScreenReaderEnabled() { }

	[Address(RVA = "0x18FECC0", Offset = "0x18FDEC0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000055")]
	public static IAccessibilityNotificationDispatcher get_notificationDispatcher() { }

	[Address(RVA = "0x6508A0", Offset = "0x64FAA0", Length = "0x99")]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeIncremented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NotificationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNotificationContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetRootNodeIds", ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNodeData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetNodeIdAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeDecremented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeDismissed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ServiceManager), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	internal static T GetService() { }

	[Address(RVA = "0x18FE5F0", Offset = "0x18FD7F0", Length = "0x3B9")]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AccessibilityManager), Member = "add_screenReaderStatusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ServiceManager), Member = "UpdateServices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000056")]
	internal static void Initialize() { }

	[Address(RVA = "0x18FE9B0", Offset = "0x18FDBB0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000059")]
	private static void NodeFocusChanged(AccessibilityNode currentNode) { }

	[Address(RVA = "0x18FEA20", Offset = "0x18FDC20", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000058")]
	private static void ScreenReaderStatusChanged(bool screenReaderEnabled) { }

	[Address(RVA = "0x18FED10", Offset = "0x18FDF10", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000054")]
	private static void set_isScreenReaderEnabled(bool value) { }

}

