namespace Unity.Hierarchy;

[DefaultMember("Item")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyViewModel.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyViewModelBindings.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000028")]
public sealed class HierarchyViewModel : IDisposable
{
	[Token(Token = "0x2000029")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000116")]
		public static IntPtr ConvertToNative(HierarchyViewModel viewModel) { }

	}

	[Token(Token = "0x200002A")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007D")]
		private readonly HierarchyViewModel m_ViewModel; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400007E")]
		private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400007F")]
		private readonly Int32* m_NodesPtr; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000080")]
		private readonly int m_NodesCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000081")]
		private readonly int m_Version; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000082")]
		private int m_Index; //Field offset: 0x20

		[IsReadOnly]
		[Token(Token = "0x17000034")]
		public HierarchyNode Current
		{
			[Address(RVA = "0x1996210", Offset = "0x1995410", Length = "0x8F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000118")]
			 get { } //Length: 143
		}

		[Address(RVA = "0x1995F70", Offset = "0x1995170", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000117")]
		internal Enumerator(HierarchyViewModel hierarchyViewModel) { }

		[Address(RVA = "0x1996210", Offset = "0x1995410", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000118")]
		public HierarchyNode get_Current() { }

		[Address(RVA = "0x1995B10", Offset = "0x1994D10", Length = "0xF")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000119")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000075")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000076")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000077")]
	private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000078")]
	private IntPtr m_NodesPtr; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000079")]
	private int m_NodesCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400007A")]
	private int m_Version; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400007B")]
	private readonly bool m_IsOwner; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400007C")]
	private IHierarchySearchQueryParser <QueryParser>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x1700002D")]
	public int Count
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EB")]
		 get { } //Length: 174
	}

	[Token(Token = "0x1700002F")]
	public HierarchyFlattened HierarchyFlattened
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000ED")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002C")]
	public bool IsCreated
	{
		[Address(RVA = "0x19974B0", Offset = "0x19966B0", Length = "0x9")]
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 9
	}

	[IsReadOnly]
	[Token(Token = "0x17000033")]
	public HierarchyNode Item
	{
		[Address(RVA = "0x199B150", Offset = "0x199A350", Length = "0x91")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetHierarchyNodeByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetIdForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "HasChildrenByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ReusableCollectionItem", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F6")]
		 get { } //Length: 145
	}

	[Token(Token = "0x17000032")]
	internal HierarchySearchQueryDescriptor Query
	{
		[Address(RVA = "0x199B230", Offset = "0x199A430", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod(IsThreadSafe = True)]
		[Token(Token = "0x60000F0")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
		internal get { } //Length: 81
	}

	[Token(Token = "0x17000031")]
	internal IHierarchySearchQueryParser QueryParser
	{
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EF")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.HierarchyModule"})]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700002E")]
	public bool UpdateNeeded
	{
		[Address(RVA = "0x199B2D0", Offset = "0x199A4D0", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
		[Token(Token = "0x60000EC")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000030")]
	internal int Version
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EE")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x199B080", Offset = "0x199A280", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000F2")]
	private HierarchyViewModel(IntPtr nativePtr, HierarchyFlattened hierarchyFlattened, IntPtr nodesPtr, int nodesCount, int version) { }

	[Address(RVA = "0x199AF40", Offset = "0x199A140", Length = "0x139")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "set_hierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F1")]
	public HierarchyViewModel(HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags = 0) { }

	[Address(RVA = "0x199A020", Offset = "0x1999220", Length = "0x7B")]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FD")]
	public void ClearFlags(in HierarchyNode node, HierarchyNodeFlags flags, bool recurse = false) { }

	[Address(RVA = "0x199A020", Offset = "0x1999220", Length = "0x7B")]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("HierarchyViewModelBindings::ClearFlagsNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000107")]
	private void ClearFlagsNode(in HierarchyNode node, HierarchyNodeFlags flags, bool recurse = false) { }

	[Address(RVA = "0x1999FB0", Offset = "0x19991B0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000115")]
	private static void ClearFlagsNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags, bool recurse) { }

	[Address(RVA = "0x199A0F0", Offset = "0x19992F0", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList", Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x60000F8")]
	public bool Contains(in HierarchyNode node) { }

	[Address(RVA = "0x199A0A0", Offset = "0x19992A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010E")]
	private static bool Contains_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x199A2F0", Offset = "0x19994F0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyViewModelBindings::Create", IsThreadSafe = True)]
	[Token(Token = "0x6000102")]
	private static IntPtr Create(IntPtr handlePtr, HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags, out IntPtr nodesPtr, out int nodesCount, out int version) { }

	[Address(RVA = "0x199A280", Offset = "0x1999480", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000111")]
	private static IntPtr Create_Injected(IntPtr handlePtr, IntPtr hierarchyFlattened, HierarchyNodeFlags defaultFlags, out IntPtr nodesPtr, out int nodesCount, out int version) { }

	[Address(RVA = "0x199A150", Offset = "0x1999350", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995130")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000108")]
	private static IntPtr CreateHierarchyViewModel(IntPtr nativePtr, IntPtr flattenedPtr, IntPtr nodesPtr, int nodesCount, int version) { }

	[Address(RVA = "0x199A360", Offset = "0x1999560", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyViewModelBindings::Destroy", IsThreadSafe = True)]
	[Token(Token = "0x6000103")]
	private static void Destroy(IntPtr nativePtr) { }

	[Address(RVA = "0x199A3A0", Offset = "0x19995A0", Length = "0x90")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F4")]
	public override void Dispose() { }

	[Address(RVA = "0x199A430", Offset = "0x1999630", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F5")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x199A490", Offset = "0x1999690", Length = "0x185")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Token(Token = "0x60000FE")]
	public HierarchyViewNodesEnumerable EnumerateNodesWithAllFlags(HierarchyNodeFlags flags) { }

	[Address(RVA = "0x199A620", Offset = "0x1999820", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F3")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x199A6C0", Offset = "0x19998C0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000101")]
	internal static HierarchyViewModel FromIntPtr(IntPtr handlePtr) { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EB")]
	public int get_Count() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000ED")]
	public HierarchyFlattened get_HierarchyFlattened() { }

	[Address(RVA = "0x19974B0", Offset = "0x19966B0", Length = "0x9")]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EA")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x199B150", Offset = "0x199A350", Length = "0x91")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ReusableCollectionItem", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "HasChildrenByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetIdForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetHierarchyNodeByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<Boolean>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000F6")]
	public HierarchyNode get_Item(int index) { }

	[Address(RVA = "0x199B230", Offset = "0x199A430", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x60000F0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal HierarchySearchQueryDescriptor get_Query() { }

	[Address(RVA = "0x199B1F0", Offset = "0x199A3F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010C")]
	private static HierarchySearchQueryDescriptor get_Query_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x199B2D0", Offset = "0x199A4D0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
	[Token(Token = "0x60000EC")]
	public bool get_UpdateNeeded() { }

	[Address(RVA = "0x199B290", Offset = "0x199A490", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010B")]
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal int get_Version() { }

	[Address(RVA = "0x199A7E0", Offset = "0x19999E0", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ReusableCollectionItem", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<Boolean>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "HasChildrenByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x60000F9")]
	public int GetChildrenCount(in HierarchyNode node) { }

	[Address(RVA = "0x199A790", Offset = "0x1999990", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010F")]
	private static int GetChildrenCount_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x199A840", Offset = "0x1999A40", Length = "0x75")]
	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList+Enumerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyViewModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList+Enumerator", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList", Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000100")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x199A920", Offset = "0x1999B20", Length = "0x69")]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	public bool HasAllFlags(in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x199A920", Offset = "0x1999B20", Length = "0x69")]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("HierarchyViewModelBindings::HasAllFlagsNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000106")]
	private bool HasAllFlagsNode(in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x199A8C0", Offset = "0x1999AC0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000114")]
	private static bool HasAllFlagsNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x199A9E0", Offset = "0x1999BE0", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x60000F7")]
	public int IndexOf(in HierarchyNode node) { }

	[Address(RVA = "0x199A990", Offset = "0x1999B90", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010D")]
	private static int IndexOf_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x199AA40", Offset = "0x1999C40", Length = "0x273")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Memory`1<System.IntPtr>), Member = "get_Span", ReturnType = typeof(System.Span`1<System.IntPtr>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819953F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	[Token(Token = "0x600010A")]
	private static void SearchBegin(IntPtr handlePtr) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.HierarchyModule"})]
	internal void set_QueryParser(IHierarchySearchQueryParser value) { }

	[Address(RVA = "0x199ADD0", Offset = "0x1999FD0", Length = "0x7B")]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FB")]
	public void SetFlags(in HierarchyNode node, HierarchyNodeFlags flags, bool recurse = false) { }

	[Address(RVA = "0x199AD00", Offset = "0x1999F00", Length = "0x58")]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FA")]
	public void SetFlags(HierarchyNodeFlags flags) { }

	[Address(RVA = "0x199AD00", Offset = "0x1999F00", Length = "0x58")]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("HierarchyViewModelBindings::SetFlagsAll", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000104")]
	private void SetFlagsAll(HierarchyNodeFlags flags) { }

	[Address(RVA = "0x199ACC0", Offset = "0x1999EC0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000112")]
	private static void SetFlagsAll_Injected(IntPtr _unity_self, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x199ADD0", Offset = "0x1999FD0", Length = "0x7B")]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("HierarchyViewModelBindings::SetFlagsNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000105")]
	private void SetFlagsNode(in HierarchyNode node, HierarchyNodeFlags flags, bool recurse = false) { }

	[Address(RVA = "0x199AD60", Offset = "0x1999F60", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000113")]
	private static void SetFlagsNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags, bool recurse) { }

	[Address(RVA = "0x199AEE0", Offset = "0x199A0E0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x60000FF")]
	public void Update() { }

	[Address(RVA = "0x199AEA0", Offset = "0x199A0A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000110")]
	private static void Update_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x199AE50", Offset = "0x199A050", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819953F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000109")]
	private static void UpdateHierarchyViewModel(IntPtr handlePtr, IntPtr nodesPtr, int nodesCount, int version) { }

}

