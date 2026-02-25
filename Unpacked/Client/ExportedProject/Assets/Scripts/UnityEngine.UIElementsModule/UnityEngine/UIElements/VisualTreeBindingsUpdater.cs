namespace UnityEngine.UIElements;

[Token(Token = "0x2000047")]
internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
{
	[Token(Token = "0x4000147")]
	private static readonly PropertyName s_BindingRequestObjectVEPropertyName; //Field offset: 0x0
	[Token(Token = "0x4000148")]
	private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName; //Field offset: 0x4
	[Token(Token = "0x4000149")]
	private static readonly string s_Description; //Field offset: 0x8
	[Token(Token = "0x400014A")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x10
	[Token(Token = "0x400014B")]
	private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker; //Field offset: 0x18
	[Token(Token = "0x400014C")]
	private static ProfilerMarker s_MarkerUpdate; //Field offset: 0x20
	[Token(Token = "0x400014D")]
	private static ProfilerMarker s_MarkerPoll; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400014E")]
	private static bool <disableBindingsThrottling>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400014F")]
	private readonly HashSet<VisualElement> m_ElementsWithBindings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000150")]
	private readonly HashSet<VisualElement> m_ElementsToAdd; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000151")]
	private readonly HashSet<VisualElement> m_ElementsToRemove; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000152")]
	private long m_LastUpdateTime; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000153")]
	private HashSet<VisualElement> m_ElementsToBind; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000154")]
	private Dictionary<Object, Object> <temporaryObjectCache>k__BackingField; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000155")]
	private List<IBinding> updatedBindings; //Field offset: 0x70

	[Token(Token = "0x17000043")]
	public static bool disableBindingsThrottling
	{
		[Address(RVA = "0x1ACF1E0", Offset = "0x1ACE3E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000209")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000042")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x1ACF230", Offset = "0x1ACE430", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000208")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000044")]
	public Dictionary<Object, Object> temporaryObjectCache
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600020D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1ACEE80", Offset = "0x1ACE080", Length = "0x1BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600021A")]
	private static VisualTreeBindingsUpdater() { }

	[Address(RVA = "0x1ACF040", Offset = "0x1ACE240", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualTreeHierarchyTrackerUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000219")]
	public VisualTreeBindingsUpdater() { }

	[Address(RVA = "0x1ACD9A0", Offset = "0x1ACCBA0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Token(Token = "0x6000213")]
	private static long CurrentTime() { }

	[Address(RVA = "0x1ACD9E0", Offset = "0x1ACCBE0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "PerformTrackingOperations", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000218")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1ACF1E0", Offset = "0x1ACE3E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000209")]
	public static bool get_disableBindingsThrottling() { }

	[Address(RVA = "0x1ACF230", Offset = "0x1ACE430", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000208")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600020D")]
	public Dictionary<Object, Object> get_temporaryObjectCache() { }

	[Address(RVA = "0x1ACDA00", Offset = "0x1ACCC00", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600020E")]
	public static IBinding GetAdditionalBinding(VisualElement ve) { }

	[Address(RVA = "0x1ACDA90", Offset = "0x1ACCC90", Length = "0x10F")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "PerformTrackingOperations", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "UpdateBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600020A")]
	private IBinding GetBindingObjectFromElement(VisualElement ve) { }

	[Address(RVA = "0x1ACDBA0", Offset = "0x1ACCDA0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000212")]
	protected virtual void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	[Address(RVA = "0x1ACDBD0", Offset = "0x1ACCDD0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVisualTreeHierarchyTrackerUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "GetBindingObjectFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(IBinding))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000211")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1ACDCC0", Offset = "0x1ACCEC0", Length = "0x270")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "GetBindingObjectFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(IBinding))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000215")]
	public void PerformTrackingOperations() { }

	[Address(RVA = "0x1ACDF40", Offset = "0x1ACD140", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000214")]
	public static bool ShouldProcessBindings(long startTime) { }

	[Address(RVA = "0x1ACE160", Offset = "0x1ACD360", Length = "0x77")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600020B")]
	private void StartTracking(VisualElement ve) { }

	[Address(RVA = "0x1ACE030", Offset = "0x1ACD230", Length = "0x129")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "GetBindingObjectFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(IBinding))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600020F")]
	private void StartTrackingRecursive(VisualElement ve) { }

	[Address(RVA = "0x1ACE300", Offset = "0x1ACD500", Length = "0x77")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "UpdateBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600020C")]
	private void StopTracking(VisualElement ve) { }

	[Address(RVA = "0x1ACE1E0", Offset = "0x1ACD3E0", Length = "0x119")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000210")]
	private void StopTrackingRecursive(VisualElement ve) { }

	[Address(RVA = "0x1ACE850", Offset = "0x1ACDA50", Length = "0x629")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "PerformTrackingOperations", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectListPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "UpdateBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVisualTreeHierarchyTrackerUpdater), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000216")]
	public virtual void Update() { }

	[Address(RVA = "0x1ACE380", Offset = "0x1ACD580", Length = "0x4C4")]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "GetBindingObjectFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(IBinding))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000217")]
	private void UpdateBindings() { }

}

