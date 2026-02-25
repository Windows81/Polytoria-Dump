namespace UnityEngine.Accessibility;

[Token(Token = "0x200000F")]
public class AccessibilityHierarchy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004A")]
	internal List<AccessibilityNode> m_RootNodes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004B")]
	private readonly IDictionary<Int32, AccessibilityNode> m_Nodes; //Field offset: 0x18

	[Address(RVA = "0x18FB770", Offset = "0x18FA970", Length = "0x24E")]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetNodeIdAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "TryGetNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[CalledBy(Type = typeof(AccessibilityHierarchyService), Member = "TryGetNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[Calls(Type = typeof(AccessibilityNode), Member = "get_frame", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000062")]
	internal static AccessibilityNode <TryGetNodeAt>g__FindNodeContainingPoint|27_0(IList<AccessibilityNode> nodes, Vector2 pos) { }

	[Address(RVA = "0x18FB560", Offset = "0x18FA760", Length = "0xFE")]
	[CalledBy(Type = typeof(AccessibilityHierarchyService), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityHierarchyService), Member = "RemoveActiveHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000060")]
	internal void FreeNative() { }

	[Address(RVA = "0x18FB6A0", Offset = "0x18FA8A0", Length = "0xCA")]
	[CalledBy(Type = typeof(NotificationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNotificationContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNodeData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeIncremented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeDecremented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeDismissed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AccessibilityHierarchyService), Member = "TryGetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005F")]
	public bool TryGetNode(int id, out AccessibilityNode node) { }

	[Address(RVA = "0x18FB660", Offset = "0x18FA860", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000061")]
	public bool TryGetNodeAt(float horizontalPosition, float verticalPosition, out AccessibilityNode node) { }

}

