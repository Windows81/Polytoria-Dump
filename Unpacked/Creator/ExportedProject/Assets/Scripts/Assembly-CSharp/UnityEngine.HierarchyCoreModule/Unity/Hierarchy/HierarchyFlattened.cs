namespace Unity.Hierarchy;

[DefaultMember("Item")]
[NativeHeader("Modules/HierarchyCore/HierarchyFlattenedBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyFlattened.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200001A")]
public sealed class HierarchyFlattened : IDisposable
{
	[Token(Token = "0x200001B")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A3")]
		public static IntPtr ConvertToNative(HierarchyFlattened hierarchyFlattened) { }

	}

	[Token(Token = "0x200001C")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400003C")]
		private readonly HierarchyFlattenedNode* m_NodesPtr; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400003D")]
		private readonly int m_NodesCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400003E")]
		private readonly int m_Version; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400003F")]
		private int m_Index; //Field offset: 0x18

		[IsReadOnly]
		[Token(Token = "0x17000013")]
		public HierarchyFlattenedNode Current
		{
			[Address(RVA = "0x1996060", Offset = "0x1995260", Length = "0x7D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x60000A5")]
			 get { } //Length: 125
		}

		[Address(RVA = "0x1996010", Offset = "0x1995210", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000A4")]
		internal Enumerator(HierarchyFlattened hierarchyFlattened) { }

		[Address(RVA = "0x1996060", Offset = "0x1995260", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60000A5")]
		public HierarchyFlattenedNode get_Current() { }

		[Address(RVA = "0x1995B20", Offset = "0x1994D20", Length = "0xF")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000A6")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000035")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000036")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000037")]
	private IntPtr m_NodesPtr; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000038")]
	private int m_NodesCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000039")]
	private int m_Version; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003A")]
	private readonly bool m_IsOwner; //Field offset: 0x30

	[Token(Token = "0x1700000D")]
	public int Count
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000087")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000F")]
	public Hierarchy Hierarchy
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000089")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000C")]
	public bool IsCreated
	{
		[Address(RVA = "0x19974B0", Offset = "0x19966B0", Length = "0x9")]
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000086")]
		 get { } //Length: 9
	}

	[IsReadOnly]
	[Token(Token = "0x17000012")]
	public HierarchyFlattenedNode Item
	{
		[Address(RVA = "0x1995200", Offset = "0x1994400", Length = "0x72")]
		[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList+Enumerator", Member = "get_Current", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[CalledBy(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000091")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000010")]
	internal HierarchyFlattenedNode* NodesPtr
	{
		[Address(RVA = "0x19974C0", Offset = "0x19966C0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600008A")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x1700000E")]
	public bool UpdateNeeded
	{
		[Address(RVA = "0x1997510", Offset = "0x1996710", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
		[Token(Token = "0x6000088")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000011")]
	internal int Version
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008B")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x19973F0", Offset = "0x19965F0", Length = "0xBF")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "set_hierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008C")]
	public HierarchyFlattened(Hierarchy hierarchy) { }

	[Address(RVA = "0x1997380", Offset = "0x1996580", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008D")]
	private HierarchyFlattened(IntPtr nativePtr, Hierarchy hierarchy, IntPtr nodesPtr, int nodesCount, int version) { }

	[Address(RVA = "0x1996BF0", Offset = "0x1995DF0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000093")]
	public bool Contains(in HierarchyNode node) { }

	[Address(RVA = "0x1996BA0", Offset = "0x1995DA0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009F")]
	private static bool Contains_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x1996D80", Offset = "0x1995F80", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyFlattenedBindings::Create", IsThreadSafe = True)]
	[Token(Token = "0x6000099")]
	private static IntPtr Create(IntPtr handlePtr, Hierarchy hierarchy, out IntPtr nodesPtr, out int nodesCount, out int version) { }

	[Address(RVA = "0x1996D10", Offset = "0x1995F10", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A2")]
	private static IntPtr Create_Injected(IntPtr handlePtr, IntPtr hierarchy, out IntPtr nodesPtr, out int nodesCount, out int version) { }

	[Address(RVA = "0x1996C50", Offset = "0x1995E50", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819954C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x600009B")]
	private static IntPtr CreateHierarchyFlattened(IntPtr nativePtr, IntPtr hierarchyPtr, IntPtr nodesPtr, int nodesCount, int version) { }

	[Address(RVA = "0x1996DF0", Offset = "0x1995FF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyFlattenedBindings::Destroy", IsThreadSafe = True)]
	[Token(Token = "0x600009A")]
	private static void Destroy(IntPtr nativePtr) { }

	[Address(RVA = "0x1996EC0", Offset = "0x19960C0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000090")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x1996E30", Offset = "0x1996030", Length = "0x90")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008F")]
	public override void Dispose() { }

	[Address(RVA = "0x1996F20", Offset = "0x1996120", Length = "0x26")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyFlattened), typeof(HierarchyNode&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000094")]
	public HierarchyFlattenedNodeChildren EnumerateChildren(in HierarchyNode node) { }

	[Address(RVA = "0x1996F50", Offset = "0x1996150", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008E")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1996FF0", Offset = "0x19961F0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000098")]
	internal static HierarchyFlattened FromIntPtr(IntPtr handlePtr) { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000087")]
	public int get_Count() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000089")]
	public Hierarchy get_Hierarchy() { }

	[Address(RVA = "0x19974B0", Offset = "0x19966B0", Length = "0x9")]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000086")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x1995200", Offset = "0x1994400", Length = "0x72")]
	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList+Enumerator", Member = "get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
	[CalledBy(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000091")]
	public HierarchyFlattenedNode get_Item(int index) { }

	[Address(RVA = "0x19974C0", Offset = "0x19966C0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	internal HierarchyFlattenedNode* get_NodesPtr() { }

	[Address(RVA = "0x1997510", Offset = "0x1996710", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
	[Token(Token = "0x6000088")]
	public bool get_UpdateNeeded() { }

	[Address(RVA = "0x19974D0", Offset = "0x19966D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009D")]
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008B")]
	internal int get_Version() { }

	[Address(RVA = "0x1997110", Offset = "0x1996310", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000095")]
	public int GetChildrenCount(in HierarchyNode node) { }

	[Address(RVA = "0x19970C0", Offset = "0x19962C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A0")]
	private static int GetChildrenCount_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x1997170", Offset = "0x1996370", Length = "0x60")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000097")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x1997230", Offset = "0x1996430", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000092")]
	public int IndexOf(in HierarchyNode node) { }

	[Address(RVA = "0x19971E0", Offset = "0x19963E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009E")]
	private static int IndexOf_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x1997320", Offset = "0x1996520", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000096")]
	public void Update() { }

	[Address(RVA = "0x19972E0", Offset = "0x19964E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A1")]
	private static void Update_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1997290", Offset = "0x1996490", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995130")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x600009C")]
	private static void UpdateHierarchyFlattened(IntPtr handlePtr, IntPtr nodesPtr, int nodesCount, int version) { }

}

