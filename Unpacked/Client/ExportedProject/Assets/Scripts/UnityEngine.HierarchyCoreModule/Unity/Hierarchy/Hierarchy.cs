namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/Hierarchy.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeTypeHandlerBase.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000016")]
public sealed class Hierarchy : IDisposable
{
	[Token(Token = "0x2000017")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600007D")]
		public static IntPtr ConvertToNative(Hierarchy hierarchy) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002F")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000030")]
	private readonly IntPtr m_RootPtr; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000031")]
	private readonly IntPtr m_VersionPtr; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000032")]
	private readonly bool m_IsOwner; //Field offset: 0x28

	[Token(Token = "0x17000008")]
	public bool IsCreated
	{
		[Address(RVA = "0x19974B0", Offset = "0x19966B0", Length = "0x9")]
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600004D")]
		 get { } //Length: 9
	}

	[IsReadOnly]
	[Token(Token = "0x17000009")]
	public HierarchyNode Root
	{
		[Address(RVA = "0x199C810", Offset = "0x199BA10", Length = "0xD")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004E")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700000A")]
	public bool UpdateNeeded
	{
		[Address(RVA = "0x199C860", Offset = "0x199BA60", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
		[Token(Token = "0x600004F")]
		 get { } //Length: 81
	}

	[Token(Token = "0x1700000B")]
	internal int Version
	{
		[Address(RVA = "0x199C8C0", Offset = "0x199BAC0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000050")]
		internal get { } //Length: 22
	}

	[Address(RVA = "0x199C730", Offset = "0x199B930", Length = "0x8A")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultMultiColumnTreeViewController`1", Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultTreeViewController`1", Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000051")]
	public Hierarchy() { }

	[Address(RVA = "0x199C7C0", Offset = "0x199B9C0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000052")]
	private Hierarchy(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr) { }

	[Address(RVA = "0x199B520", Offset = "0x199A720", Length = "0x6D")]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000058")]
	public HierarchyNode Add(in HierarchyNode parent) { }

	[Address(RVA = "0x199B520", Offset = "0x199A720", Length = "0x6D")]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("HierarchyBindings::AddNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000067")]
	private HierarchyNode AddNode(in HierarchyNode parent) { }

	[Address(RVA = "0x199B4C0", Offset = "0x199A6C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000078")]
	private static void AddNode_Injected(IntPtr _unity_self, in HierarchyNode parent, out HierarchyNode ret) { }

	[Address(RVA = "0x199B620", Offset = "0x199A820", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyBindings::Create", IsThreadSafe = True)]
	[Token(Token = "0x6000063")]
	private static IntPtr Create(IntPtr handlePtr, out IntPtr rootPtr, out IntPtr versionPtr) { }

	[Address(RVA = "0x199B590", Offset = "0x199A790", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x600006C")]
	private static IntPtr CreateHierarchy(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr) { }

	[Address(RVA = "0x199B680", Offset = "0x199A880", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyBindings::Destroy", IsThreadSafe = True)]
	[Token(Token = "0x6000064")]
	private static void Destroy(IntPtr nativePtr) { }

	[Address(RVA = "0x199B6C0", Offset = "0x199A8C0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000055")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x199B720", Offset = "0x199A920", Length = "0x90")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	public override void Dispose() { }

	[Address(RVA = "0x199B860", Offset = "0x199AA60", Length = "0x96")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(HierarchyNodeChildren), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005C")]
	public HierarchyNodeChildren EnumerateChildren(in HierarchyNode node) { }

	[Address(RVA = "0x199B800", Offset = "0x199AA00", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyBindings::EnumerateChildrenPtr", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000068")]
	private IntPtr EnumerateChildrenPtr(in HierarchyNode node) { }

	[Address(RVA = "0x199B7B0", Offset = "0x199A9B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000079")]
	private static IntPtr EnumerateChildrenPtr_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public HierarchyNodeTypeHandlerBaseEnumerable EnumerateNodeTypeHandlersBase() { }

	[Address(RVA = "0x199B950", Offset = "0x199AB50", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetParentId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "HasChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000057")]
	public bool Exists(in HierarchyNode node) { }

	[Address(RVA = "0x199B900", Offset = "0x199AB00", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006E")]
	private static bool Exists_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x199B9B0", Offset = "0x199ABB0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x199BA50", Offset = "0x199AC50", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000062")]
	internal static Hierarchy FromIntPtr(IntPtr handlePtr) { }

	[Address(RVA = "0x19974B0", Offset = "0x19966B0", Length = "0x9")]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600004D")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x199C810", Offset = "0x199BA10", Length = "0xD")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	public HierarchyNode get_Root() { }

	[Address(RVA = "0x199C860", Offset = "0x199BA60", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
	[Token(Token = "0x600004F")]
	public bool get_UpdateNeeded() { }

	[Address(RVA = "0x199C820", Offset = "0x199BA20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006D")]
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x199C8C0", Offset = "0x199BAC0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000050")]
	internal int get_Version() { }

	[Address(RVA = "0x199BC30", Offset = "0x199AE30", Length = "0x100")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181994C90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600005B")]
	public HierarchyNode[] GetChildren(in HierarchyNode node) { }

	[Address(RVA = "0x199BBD0", Offset = "0x199ADD0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000071")]
	private static void GetChildren_Injected(IntPtr _unity_self, in HierarchyNode node, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x199BB70", Offset = "0x199AD70", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "HasChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600005D")]
	public int GetChildrenCount(in HierarchyNode node) { }

	[Address(RVA = "0x199BB20", Offset = "0x199AD20", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000072")]
	private static int GetChildrenCount_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x199BD80", Offset = "0x199AF80", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyBindings::GetNodeTypeHandlersBaseCount", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000065")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal int GetNodeTypeHandlersBaseCount() { }

	[Address(RVA = "0x199BD40", Offset = "0x199AF40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000076")]
	private static int GetNodeTypeHandlersBaseCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x199BE30", Offset = "0x199B030", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyBindings::GetNodeTypeHandlersBaseSpan", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000066")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal int GetNodeTypeHandlersBaseSpan(Span<IntPtr> outHandlers) { }

	[Address(RVA = "0x199BDE0", Offset = "0x199AFE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000077")]
	private static int GetNodeTypeHandlersBaseSpan_Injected(IntPtr _unity_self, ref ManagedSpanWrapper outHandlers) { }

	[Address(RVA = "0x199BF80", Offset = "0x199B180", Length = "0x1E8")]
	[CalledBy(Type = typeof(Hierarchy), Member = "GetOrCreatePropertyUnmanaged", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyStorageType)}, ReturnType = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyBindings::GetOrCreateProperty", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000069")]
	private HierarchyPropertyId GetOrCreateProperty(string name, in HierarchyPropertyDescriptor descriptor) { }

	[Address(RVA = "0x199BF10", Offset = "0x199B110", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007A")]
	private static void GetOrCreateProperty_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, in HierarchyPropertyDescriptor descriptor, out HierarchyPropertyId ret) { }

	[Address(RVA = "0x6D70E0", Offset = "0x6D62E0", Length = "0x9B")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "set_hierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Hierarchy), Member = "GetOrCreateProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyDescriptor&)}, ReturnType = typeof(HierarchyPropertyId))]
	[Calls(Type = typeof(HierarchyPropertyUnmanaged`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy), typeof(HierarchyPropertyId&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000060")]
	public HierarchyPropertyUnmanaged<T> GetOrCreatePropertyUnmanaged(string name, HierarchyPropertyStorageType type = 1) { }

	[Address(RVA = "0x199C1D0", Offset = "0x199B3D0", Length = "0x6D")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetParentId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600005A")]
	public HierarchyNode GetParent(in HierarchyNode node) { }

	[Address(RVA = "0x199C170", Offset = "0x199B370", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	private static void GetParent_Injected(IntPtr _unity_self, in HierarchyNode node, out HierarchyNode ret) { }

	[Address(RVA = "0x199C2B0", Offset = "0x199B4B0", Length = "0x79")]
	[CalledBy(Type = typeof(HierarchyPropertyUnmanaged`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyBindings::GetPropertyRaw", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600006B")]
	internal Void* GetPropertyRaw(in HierarchyPropertyId property, in HierarchyNode node, out int size) { }

	[Address(RVA = "0x199C240", Offset = "0x199B440", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007C")]
	private static Void* GetPropertyRaw_Injected(IntPtr _unity_self, in HierarchyPropertyId property, in HierarchyNode node, out int size) { }

	[Address(RVA = "0x199C390", Offset = "0x199B590", Length = "0x69")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000059")]
	public bool SetParent(in HierarchyNode node, in HierarchyNode parent) { }

	[Address(RVA = "0x199C330", Offset = "0x199B530", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006F")]
	private static bool SetParent_Injected(IntPtr _unity_self, in HierarchyNode node, in HierarchyNode parent) { }

	[Address(RVA = "0x199C470", Offset = "0x199B670", Length = "0x79")]
	[CalledBy(Type = typeof(HierarchyPropertyUnmanaged`1), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyBindings::SetPropertyRaw", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600006A")]
	internal void SetPropertyRaw(in HierarchyPropertyId property, in HierarchyNode node, Void* ptr, int size) { }

	[Address(RVA = "0x199C400", Offset = "0x199B600", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007B")]
	private static void SetPropertyRaw_Injected(IntPtr _unity_self, in HierarchyPropertyId property, in HierarchyNode node, Void* ptr, int size) { }

	[Address(RVA = "0x199C550", Offset = "0x199B750", Length = "0x69")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600005E")]
	public void SetSortIndex(in HierarchyNode node, int sortIndex) { }

	[Address(RVA = "0x199C4F0", Offset = "0x199B6F0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000073")]
	private static void SetSortIndex_Injected(IntPtr _unity_self, in HierarchyNode node, int sortIndex) { }

	[Address(RVA = "0x199C620", Offset = "0x199B820", Length = "0x6B")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600005F")]
	public void SortChildren(in HierarchyNode node, bool recurse = false) { }

	[Address(RVA = "0x199C5C0", Offset = "0x199B7C0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000074")]
	private static void SortChildren_Injected(IntPtr _unity_self, in HierarchyNode node, bool recurse) { }

	[Address(RVA = "0x199C6D0", Offset = "0x199B8D0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000061")]
	public void Update() { }

	[Address(RVA = "0x199C690", Offset = "0x199B890", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000075")]
	private static void Update_Injected(IntPtr _unity_self) { }

}

