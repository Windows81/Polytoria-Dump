namespace UnityEngine.UIElements;

[Token(Token = "0x200052B")]
internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x200052C")]
	private enum State
	{
		Waiting = 0,
		TrackingAddOrMove = 1,
		TrackingRemove = 2,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001115")]
	private State m_State; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001116")]
	private VisualElement m_CurrentChangeElement; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001117")]
	private VisualElement m_CurrentChangeParent; //Field offset: 0x38

	[Address(RVA = "0x1B5F0D0", Offset = "0x1B5E2D0", Length = "0xE")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600257A")]
	protected BaseVisualTreeHierarchyTrackerUpdater() { }

	[Token(Token = "0x6002574")]
	protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	[Address(RVA = "0x1B5EBE0", Offset = "0x1B5DDE0", Length = "0x21B")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(BaseVisualTreeHierarchyTrackerUpdater), Member = "ProcessNewChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002575")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1B5EE00", Offset = "0x1B5E000", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002578")]
	private void ProcessAddOrMove(VisualElement ve) { }

	[Address(RVA = "0x1B5EEC0", Offset = "0x1B5E0C0", Length = "0xA3")]
	[CalledBy(Type = typeof(BaseVisualTreeHierarchyTrackerUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002577")]
	private void ProcessNewChange(VisualElement ve) { }

	[Address(RVA = "0x1B5EF70", Offset = "0x1B5E170", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002579")]
	private void ProcessRemove(VisualElement ve) { }

	[Address(RVA = "0x1B5F010", Offset = "0x1B5E210", Length = "0xBC")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002576")]
	public virtual void Update() { }

}

