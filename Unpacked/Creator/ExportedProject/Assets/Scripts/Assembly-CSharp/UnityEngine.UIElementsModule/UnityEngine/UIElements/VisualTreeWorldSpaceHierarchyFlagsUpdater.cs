namespace UnityEngine.UIElements;

[Token(Token = "0x2000529")]
internal class VisualTreeWorldSpaceHierarchyFlagsUpdater : VisualTreeHierarchyFlagsUpdater
{

	[Address(RVA = "0x1B79DF0", Offset = "0x1B78FF0", Length = "0x4F")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002573")]
	public VisualTreeWorldSpaceHierarchyFlagsUpdater() { }

	[Address(RVA = "0x1B79970", Offset = "0x1B78B70", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_flags", ReturnType = typeof(VisualElementFlags))]
	[Calls(Type = typeof(VisualElement), Member = "set_flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002570")]
	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	[Address(RVA = "0x1B79AD0", Offset = "0x1B78CD0", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_flags", ReturnType = typeof(VisualElementFlags))]
	[Calls(Type = typeof(VisualElement), Member = "set_flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002571")]
	private static void DirtyParentHierarchy(VisualElement ve, VisualElementFlags flags) { }

	[Address(RVA = "0x1B79BC0", Offset = "0x1B78DC0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600256F")]
	private static VisualElementFlags GetParentMustDirtyFlags(VisualElement ve) { }

	[Address(RVA = "0x1B79BF0", Offset = "0x1B78DF0", Length = "0x1F9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyChildrenHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_flags", ReturnType = typeof(VisualElementFlags))]
	[Calls(Type = typeof(VisualElement), Member = "set_flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600256E")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002572")]
	public virtual void Update() { }

}

