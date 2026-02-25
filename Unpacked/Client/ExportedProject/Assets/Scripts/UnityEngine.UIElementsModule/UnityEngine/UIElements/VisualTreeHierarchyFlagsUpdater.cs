namespace UnityEngine.UIElements;

[Token(Token = "0x2000528")]
internal class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x400110D")]
	private static readonly string s_Description; //Field offset: 0x0
	[Token(Token = "0x400110E")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400110B")]
	private uint m_Version; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400110C")]
	private uint m_LastVersion; //Field offset: 0x2C

	[Token(Token = "0x170009B6")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x1B76700", Offset = "0x1B75900", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002565")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x1B76650", Offset = "0x1B75850", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600256D")]
	private static VisualTreeHierarchyFlagsUpdater() { }

	[Address(RVA = "0x1B766F0", Offset = "0x1B758F0", Length = "0xD")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600256C")]
	public VisualTreeHierarchyFlagsUpdater() { }

	[Address(RVA = "0x1B76150", Offset = "0x1B75350", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_flags", ReturnType = typeof(VisualElementFlags))]
	[Calls(Type = typeof(VisualElement), Member = "set_flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002569")]
	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	[Address(RVA = "0x1B76240", Offset = "0x1B75440", Length = "0xF2")]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyChildrenHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_flags", ReturnType = typeof(VisualElementFlags))]
	[Calls(Type = typeof(VisualElement), Member = "set_flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyChildrenHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002568")]
	protected static void DirtyChildrenHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	[Address(RVA = "0x1B76340", Offset = "0x1B75540", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_flags", ReturnType = typeof(VisualElementFlags))]
	[Calls(Type = typeof(VisualElement), Member = "set_flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Token(Token = "0x600256A")]
	private static void DirtyParentHierarchy(VisualElement ve, VisualElementFlags flags) { }

	[Address(RVA = "0x1B76700", Offset = "0x1B75900", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002565")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x1B763B0", Offset = "0x1B755B0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002567")]
	protected static VisualElementFlags GetChildrenMustDirtyFlags(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1B763F0", Offset = "0x1B755F0", Length = "0x1AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyChildrenHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_flags", ReturnType = typeof(VisualElementFlags))]
	[Calls(Type = typeof(VisualElement), Member = "set_flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002566")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1B765A0", Offset = "0x1B757A0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "UpdateElementUnderPointers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600256B")]
	public virtual void Update() { }

}

