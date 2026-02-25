namespace UnityEngine.UIElements;

[Token(Token = "0x2000049")]
internal class VisualTreeDataBindingsUpdater : BaseVisualTreeUpdater
{
	[CompilerGenerated]
	[Token(Token = "0x200004B")]
	private sealed class <>c
	{
		[Token(Token = "0x400016B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400016C")]
		public static Predicate<VisualElement> <>9__29_0; //Field offset: 0x8

		[Address(RVA = "0x1ACD8C0", Offset = "0x1ACCAC0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600022D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600022E")]
		public <>c() { }

		[Address(RVA = "0x1ACD7B0", Offset = "0x1ACC9B0", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600022F")]
		internal bool <ProcessDataSourceChangedRequests>b__29_0(VisualElement e) { }

	}

	[IsReadOnly]
	[Token(Token = "0x200004A")]
	private struct VersionInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000169")]
		public readonly object source; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400016A")]
		public readonly long version; //Field offset: 0x8

		[Address(RVA = "0x13BA110", Offset = "0x13B9310", Length = "0x27")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600022C")]
		public VersionInfo(object source, long version) { }

	}

	[Token(Token = "0x4000159")]
	private static readonly ProfilerMarker s_UpdateProfilerMarker; //Field offset: 0x0
	[Token(Token = "0x400015A")]
	private static readonly ProfilerMarker s_ProcessBindingRequestsProfilerMarker; //Field offset: 0x8
	[Token(Token = "0x400015B")]
	private static readonly ProfilerMarker s_ProcessDataSourcesProfilerMarker; //Field offset: 0x10
	[Token(Token = "0x400015C")]
	private static readonly ProfilerMarker s_ShouldUpdateBindingProfilerMarker; //Field offset: 0x18
	[Token(Token = "0x400015D")]
	private static readonly ProfilerMarker s_UpdateBindingProfilerMarker; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400015E")]
	private readonly BindingUpdater m_Updater; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400015F")]
	private readonly List<VisualElement> m_BindingRegistrationRequests; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000160")]
	private readonly HashSet<VisualElement> m_DataSourceChangedRequests; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000161")]
	private readonly HashSet<VisualElement> m_RemovedElements; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000162")]
	private readonly List<VisualElement> m_BoundsElement; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000163")]
	private readonly List<VersionInfo> m_VersionChanges; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000164")]
	private readonly HashSet<Object> m_TrackedObjects; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000165")]
	private readonly HashSet<Binding> m_RanUpdate; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000166")]
	private readonly HashSet<Object> m_KnownSources; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000167")]
	private readonly HashSet<Binding> m_DirtyBindings; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000168")]
	private BaseVisualElementPanel m_AttachedPanel; //Field offset: 0x78

	[Token(Token = "0x17000045")]
	private DataBindingManager bindingManager
	{
		[Address(RVA = "0x1AD20F0", Offset = "0x1AD12F0", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600021B")]
		private get { } //Length: 48
	}

	[Token(Token = "0x17000046")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x1AD2130", Offset = "0x1AD1330", Length = "0x4B7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(TimerEventScheduler), Member = "PrivateUnSchedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x600021C")]
		 get { } //Length: 1207
	}

	[Address(RVA = "0x1AD1CD0", Offset = "0x1AD0ED0", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600022B")]
	private static VisualTreeDataBindingsUpdater() { }

	[Address(RVA = "0x1AD1E20", Offset = "0x1AD1020", Length = "0x2CA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualTreeUpdater), Member = "add_panelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.BaseVisualElementPanel>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x600021D")]
	public VisualTreeDataBindingsUpdater() { }

	[Address(RVA = "0x1ACF280", Offset = "0x1ACE480", Length = "0x1CE")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataBindingManager), Member = "get_logLevel", ReturnType = typeof(BindingLogLevel))]
	[Calls(Type = typeof(DataBindingManager), Member = "TryGetLastSourceBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData), typeof(BindingResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "TryGetLastUIBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData), typeof(BindingResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "LogResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingResult&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "CacheSourceBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData), typeof(BindingResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "CacheUIBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData), typeof(BindingResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000220")]
	private void CacheAndLogBindingResult(bool appliedOnUiCache, in BindingData bindingData, in BindingResult result) { }

	[Address(RVA = "0x1ACF450", Offset = "0x1ACE650", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessAllBindingRequests", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessDataSourceChangedRequests", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000227")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1AD20F0", Offset = "0x1AD12F0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021B")]
	private DataBindingManager get_bindingManager() { }

	[Address(RVA = "0x1AD2130", Offset = "0x1AD1330", Length = "0x4B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimerEventScheduler), Member = "PrivateUnSchedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600021C")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x1ACF4D0", Offset = "0x1ACE6D0", Length = "0x16F")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DataBindingManager), Member = "TryGetLastVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(System.ValueTuple`2<System.Boolean, System.Int64>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000223")]
	private ValueTuple<Boolean, Int64> GetDataSourceVersion(object source) { }

	[Address(RVA = "0x1ACF640", Offset = "0x1ACE840", Length = "0x18A")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Key", ReturnType = typeof(object))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Index", ReturnType = typeof(int))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000224")]
	private bool IsPrefix(in PropertyPath prefix, in PropertyPath path) { }

	[Address(RVA = "0x1ACF7D0", Offset = "0x1ACE9D0", Length = "0x137")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Panel), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000221")]
	private void LogResult(in BindingResult result) { }

	[Address(RVA = "0x1ACF910", Offset = "0x1ACEB10", Length = "0x380")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DataBindingManager), Member = "GetBoundElementsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetTrackedDataSourcesCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "DirtyBindingOrder", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600021E")]
	protected void OnHierarchyChange(VisualElement ve, HierarchyChangeType type, IReadOnlyList<VisualElement> additionalContext = null) { }

	[Address(RVA = "0x1ACFCA0", Offset = "0x1ACEEA0", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "remove_hierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "add_hierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyEvent)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000226")]
	private void OnPanelChanged(BaseVisualElementPanel p) { }

	[Address(RVA = "0x1ACFD90", Offset = "0x1ACEF90", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021F")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1ACFE80", Offset = "0x1ACF080", Length = "0x185")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000228")]
	private void ProcessAllBindingRequests() { }

	[Address(RVA = "0x1AD0010", Offset = "0x1ACF210", Length = "0x49")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessAllBindingRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000229")]
	private void ProcessBindingRequests(VisualElement element) { }

	[Address(RVA = "0x1AD0060", Offset = "0x1ACF260", Length = "0x295")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "RemoveWhere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataBindingManager), Member = "InvalidateCachedDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000225")]
	private void ProcessDataSourceChangedRequests() { }

	[Address(RVA = "0x1AD0300", Offset = "0x1ACF500", Length = "0x8AD")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataBindingManager), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[Calls(Type = typeof(IgnoreUIChangesScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(DataBindingManager), Member = "IgnoreChangesScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId), typeof(Binding)}, ReturnType = typeof(IgnoreUIChangesScope))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(BindingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(PropertyPath&), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingUpdater), Member = "ShouldProcessBindingAtStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binding), typeof(BindingUpdateStage), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChangesFromUI), Member = "get_IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600022A")]
	private void ProcessPropertyChangedEvents(HashSet<Binding> ranUpdate) { }

	[Address(RVA = "0x1AD0BB0", Offset = "0x1ACFDB0", Length = "0x1119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingUpdater), Member = "ShouldProcessBindingAtStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binding), typeof(BindingUpdateStage), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<Unity.Properties.PropertyPath>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<Unity.Properties.PropertyPath>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(PropertyPath&), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetChangedDetectedFromSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>))]
	[Calls(Type = typeof(DataBindingManager), Member = "UpdateVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "ClearChangesFromSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessAllBindingRequests", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessDataSourceChangedRequests", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetBoundElements", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualElement>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingData>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "GetDataSourceVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Int64>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
	[Calls(Type = typeof(DataBindingManager), Member = "ClearSourceCache", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000222")]
	public virtual void Update() { }

}

