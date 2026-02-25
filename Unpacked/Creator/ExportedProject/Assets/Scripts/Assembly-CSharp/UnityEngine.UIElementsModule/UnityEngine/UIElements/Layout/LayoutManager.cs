namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005BE")]
internal class LayoutManager : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20005C0")]
	private sealed class <>c
	{
		[Token(Token = "0x40014E1")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40014E2")]
		public static EventHandler <>9__9_0; //Field offset: 0x8

		[Address(RVA = "0x1BB8940", Offset = "0x1BB7B40", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60028E9")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60028EA")]
		public <>c() { }

		[Address(RVA = "0x1BB8670", Offset = "0x1BB7870", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LayoutManager), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028EB")]
		internal void <Initialize>b__9_0(object _, EventArgs __) { }

	}

	[Token(Token = "0x20005BF")]
	private enum SharedManagerState
	{
		Uninitialized = 0,
		Initialized = 1,
		Shutdown = 2,
	}

	[Token(Token = "0x40014CF")]
	private static SharedManagerState s_Initialized; //Field offset: 0x0
	[Token(Token = "0x40014D0")]
	private static bool s_AppDomainUnloadRegistered; //Field offset: 0x4
	[Token(Token = "0x40014D1")]
	private static LayoutManager s_SharedInstance; //Field offset: 0x8
	[Token(Token = "0x40014D2")]
	private static readonly List<LayoutManager> s_Managers; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014D3")]
	private readonly int m_Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40014D4")]
	private LayoutDataStore m_Nodes; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014D5")]
	private LayoutDataStore m_Configs; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014D6")]
	private readonly ConcurrentQueue<LayoutHandle> m_NodesToFree; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014D7")]
	private readonly LayoutHandle m_DefaultConfig; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40014D8")]
	private readonly ManagedObjectStore<LayoutMeasureFunction> m_ManagedMeasureFunctions; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40014D9")]
	private readonly ManagedObjectStore<LayoutBaselineFunction> m_ManagedBaselineFunctions; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40014DA")]
	private readonly ManagedObjectStore<GCHandle> m_ManagedOwners; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40014DB")]
	private readonly ProfilerMarker m_CollectMarker; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40014DC")]
	private int m_HighMark; //Field offset: 0x68

	[Token(Token = "0x17000A36")]
	private static int DefaultCapacity
	{
		[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60028D3")]
		private get { } //Length: 6
	}

	[Token(Token = "0x17000A34")]
	public static bool IsSharedManagerCreated
	{
		[Address(RVA = "0x1BABED0", Offset = "0x1BAB0D0", Length = "0x51")]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60028CF")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000A35")]
	public static LayoutManager SharedManager
	{
		[Address(RVA = "0x1BABF30", Offset = "0x1BAB130", Length = "0x53")]
		[CalledBy(Type = typeof(BaseVisualElementPanel), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "Finalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LayoutManager), Member = "Initialize", ReturnType = typeof(void))]
		[Token(Token = "0x60028D0")]
		 get { } //Length: 83
	}

	[Address(RVA = "0x1BAB980", Offset = "0x1BAAB80", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028E8")]
	private static LayoutManager() { }

	[Address(RVA = "0x1BABA10", Offset = "0x1BAAC10", Length = "0x456")]
	[CalledBy(Type = typeof(LayoutManager), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutDataStore), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComponentType[]), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComponentType), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutConfigData)}, ReturnType = typeof(ComponentType))]
	[Calls(Type = typeof(ComponentType), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(ComponentType))]
	[Calls(Type = typeof(ComponentType), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutComputedData)}, ReturnType = typeof(ComponentType))]
	[Calls(Type = typeof(ComponentType), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutStyleData)}, ReturnType = typeof(ComponentType))]
	[Calls(Type = typeof(ComponentType), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNodeData)}, ReturnType = typeof(ComponentType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&"}, ReturnType = typeof(LayoutHandle))]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.Layout.ManagedObjectStore`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<UnityEngine.UIElements.Layout.LayoutHandle>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028D6")]
	public LayoutManager(Allocator allocator, int initialNodeCapacity) { }

	[Address(RVA = "0x1BABE70", Offset = "0x1BAB070", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60028D5")]
	public LayoutManager(Allocator allocator) { }

	[Address(RVA = "0x1BAA220", Offset = "0x1BA9420", Length = "0x81")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "TryRecycleNodes", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60028E2")]
	public void Collect() { }

	[Address(RVA = "0x1BAA2B0", Offset = "0x1BA94B0", Length = "0xFE")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&"}, ReturnType = typeof(LayoutHandle))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028DA")]
	public LayoutConfig CreateConfig() { }

	[Address(RVA = "0x1BAA830", Offset = "0x1BA9A30", Length = "0x47")]
	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutManager), Member = "CreateNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutNode))]
	[Token(Token = "0x60028DC")]
	public LayoutNode CreateNode() { }

	[Address(RVA = "0x1BAA3B0", Offset = "0x1BA95B0", Length = "0x472")]
	[CalledBy(Type = typeof(LayoutManager), Member = "CreateNode", ReturnType = typeof(LayoutNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<UnityEngine.UIElements.Layout.LayoutHandle>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(LayoutHandle))]
	[Calls(Type = typeof(LayoutList`1), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028DD")]
	private LayoutNode CreateNodeInternal(LayoutHandle configHandle) { }

	[Address(RVA = "0x1BAA880", Offset = "0x1BA9A80", Length = "0x52")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutDataStore), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60028DB")]
	public void DestroyConfig(ref LayoutConfig config) { }

	[Address(RVA = "0x1BAA8E0", Offset = "0x1BA9AE0", Length = "0x1B0")]
	[CalledBy(Type = typeof(<>c), Member = "<Initialize>b__9_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028D7")]
	public override void Dispose() { }

	[Address(RVA = "0x1BAAAA0", Offset = "0x1BA9CA0", Length = "0x8A")]
	[CalledBy(Type = typeof(VisualElement), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<UnityEngine.UIElements.Layout.LayoutHandle>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028E0")]
	public void EnqueueNodeForRecycling(ref LayoutNode node) { }

	[Address(RVA = "0x1BAAB30", Offset = "0x1BA9D30", Length = "0x18F")]
	[CalledBy(Type = typeof(LayoutManager), Member = "CreateNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutNode))]
	[CalledBy(Type = typeof(LayoutManager), Member = "TryRecycleSingleNode", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutList`1), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "UpdateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028E1")]
	private void FreeNode(LayoutHandle handle) { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028D3")]
	private static int get_DefaultCapacity() { }

	[Address(RVA = "0x1BABED0", Offset = "0x1BAB0D0", Length = "0x51")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028CF")]
	public static bool get_IsSharedManagerCreated() { }

	[Address(RVA = "0x1BABF30", Offset = "0x1BAB130", Length = "0x53")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "Initialize", ReturnType = typeof(void))]
	[Token(Token = "0x60028D0")]
	public static LayoutManager get_SharedManager() { }

	[Address(RVA = "0x1BAACC0", Offset = "0x1BA9EC0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028D8")]
	private LayoutDataAccess GetAccess() { }

	[Address(RVA = "0x1BAAD10", Offset = "0x1BA9F10", Length = "0xBC")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutConfig), Member = "get_Baseline", ReturnType = typeof(LayoutBaselineFunction))]
	[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028E7")]
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle) { }

	[Address(RVA = "0x1BAADD0", Offset = "0x1BA9FD0", Length = "0x5A")]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028D9")]
	public LayoutConfig GetDefaultConfig() { }

	[Address(RVA = "0x1BAAE30", Offset = "0x1BAA030", Length = "0xB6")]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutConfig), Member = "get_Measure", ReturnType = typeof(LayoutMeasureFunction))]
	[CalledBy(Type = typeof(LayoutConfig), Member = "get_Baseline", ReturnType = typeof(LayoutBaselineFunction))]
	[CalledBy(Type = typeof(LayoutNode), Member = "GetOwner", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(IntPtr&), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "SetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028D4")]
	internal static LayoutManager GetManager(int index) { }

	[Address(RVA = "0x1BAAEF0", Offset = "0x1BAA0F0", Length = "0xBC")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutConfig), Member = "get_Measure", ReturnType = typeof(LayoutMeasureFunction))]
	[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(IntPtr&), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028E5")]
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle) { }

	[Address(RVA = "0x1BAAFB0", Offset = "0x1BAA1B0", Length = "0x225")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "GetOwner", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028E3")]
	public VisualElement GetOwner(LayoutHandle handle) { }

	[Address(RVA = "0x1BAB1E0", Offset = "0x1BAA3E0", Length = "0x257")]
	[CalledBy(Type = typeof(LayoutManager), Member = "get_SharedManager", ReturnType = typeof(LayoutManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AppDomain), Member = "add_DomainUnload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60028D1")]
	private static void Initialize() { }

	[Address(RVA = "0x1BAB440", Offset = "0x1BAA640", Length = "0xCE")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "SetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.Layout.ManagedObjectStore`1<System.Object>), Member = "UpdateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028E6")]
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value) { }

	[Address(RVA = "0x1BAB510", Offset = "0x1BAA710", Length = "0x129")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "UpdateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028E4")]
	public void SetOwner(LayoutHandle handle, VisualElement value) { }

	[Address(RVA = "0x1BAB640", Offset = "0x1BAA840", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D2")]
	private static void Shutdown() { }

	[Address(RVA = "0x1BAB6E0", Offset = "0x1BAA8E0", Length = "0x22B")]
	[CalledBy(Type = typeof(LayoutManager), Member = "Collect", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<UnityEngine.UIElements.Layout.LayoutHandle>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutList`1), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "UpdateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028DF")]
	private void TryRecycleNodes() { }

	[Address(RVA = "0x1BAB910", Offset = "0x1BAAB10", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<UnityEngine.UIElements.Layout.LayoutHandle>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028DE")]
	private void TryRecycleSingleNode() { }

}

