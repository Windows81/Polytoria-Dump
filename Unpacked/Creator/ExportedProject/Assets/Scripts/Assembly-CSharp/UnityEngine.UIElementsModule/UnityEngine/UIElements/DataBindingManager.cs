namespace UnityEngine.UIElements;

[Token(Token = "0x200002F")]
internal sealed class DataBindingManager : IDisposable
{
	[Token(Token = "0x2000032")]
	public class BindingData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000111")]
		public long version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000112")]
		public BindingTarget target; //Field offset: 0x18
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000113")]
		public Binding binding; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000114")]
		private DataSourceContext m_LastContext; //Field offset: 0xC0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x158")]
		[Token(Token = "0x4000115")]
		private object <localDataSource>k__BackingField; //Field offset: 0x158
		[FieldOffset(Offset = "0x160")]
		[Token(Token = "0x4000116")]
		public Nullable<BindingResult> m_SourceToUILastUpdate; //Field offset: 0x160
		[FieldOffset(Offset = "0x178")]
		[Token(Token = "0x4000117")]
		public Nullable<BindingResult> m_UIToSourceLastUpdate; //Field offset: 0x178

		[Token(Token = "0x17000034")]
		public DataSourceContext context
		{
			[Address(RVA = "0x1A93ED0", Offset = "0x1A930D0", Length = "0x35D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
			[Calls(Type = typeof(DataSourceContextChanged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(DataSourceContext&), typeof(DataSourceContext&)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x60001B3")]
			 set { } //Length: 861
		}

		[Token(Token = "0x17000033")]
		public object localDataSource
		{
			[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001B0")]
			 get { } //Length: 8
			[Address(RVA = "0x1A94230", Offset = "0x1A93430", Length = "0x13")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001B1")]
			 set { } //Length: 19
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B4")]
		public BindingData() { }

		[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B0")]
		public object get_localDataSource() { }

		[Address(RVA = "0x1A93E10", Offset = "0x1A93010", Length = "0xBD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001B2")]
		public void Reset() { }

		[Address(RVA = "0x1A93ED0", Offset = "0x1A930D0", Length = "0x35D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(DataSourceContextChanged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(DataSourceContext&), typeof(DataSourceContext&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B3")]
		public void set_context(DataSourceContext value) { }

		[Address(RVA = "0x1A94230", Offset = "0x1A93430", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B1")]
		public void set_localDataSource(object value) { }

	}

	[Token(Token = "0x2000031")]
	private struct BindingDataCollection : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010F")]
		private Dictionary<BindingId, BindingData> m_BindingPerId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000110")]
		private List<BindingData> m_Bindings; //Field offset: 0x8

		[Address(RVA = "0x1A93770", Offset = "0x1A92970", Length = "0x20A")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "StartTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60001AA")]
		public void AddBindingData(BindingData bindingData) { }

		[Address(RVA = "0x1A93980", Offset = "0x1A92B80", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001A9")]
		public static BindingDataCollection Create() { }

		[Address(RVA = "0x1A93A50", Offset = "0x1A92C50", Length = "0xD8")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "StopTrackingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001AF")]
		public override void Dispose() { }

		[Address(RVA = "0x1A93B30", Offset = "0x1A92D30", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001AE")]
		public int GetBindingCount() { }

		[Address(RVA = "0x150E210", Offset = "0x150D410", Length = "0x7")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AD")]
		public List<BindingData> GetBindings() { }

		[Address(RVA = "0x1A93B70", Offset = "0x1A92D70", Length = "0x1B2")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "StopTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001AC")]
		public bool RemoveBindingData(BindingData bindingData) { }

		[Address(RVA = "0x1A93D30", Offset = "0x1A92F30", Length = "0xDE")]
		[CalledBy(Type = typeof(DataBindingManager), Member = "TryGetBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingData&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001AB")]
		public bool TryGetBindingData(in BindingId bindingId, out BindingData data) { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000030")]
	private struct BindingRequest
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010C")]
		public readonly BindingId bindingId; //Field offset: 0x0
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400010D")]
		public readonly Binding binding; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400010E")]
		public readonly bool shouldProcess; //Field offset: 0xA0

		[Address(RVA = "0x1A94780", Offset = "0x1A93980", Length = "0xDD")]
		[CalledBy(Type = typeof(BindingRequest), Member = "CancelRequest", ReturnType = typeof(BindingRequest))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001A7")]
		public BindingRequest(in BindingId bindingId, Binding binding, bool shouldProcess = true) { }

		[Address(RVA = "0x1A946A0", Offset = "0x1A938A0", Length = "0xD3")]
		[CalledBy(Type = typeof(DataBindingManager), Member = "CreateBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(BindingRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001A8")]
		public BindingRequest CancelRequest() { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000033")]
	public struct ChangesFromUI
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000118")]
		public readonly long version; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000119")]
		public readonly Binding binding; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011A")]
		public readonly BindingData bindingData; //Field offset: 0x10

		[Token(Token = "0x17000035")]
		public bool IsValid
		{
			[Address(RVA = "0x1A974E0", Offset = "0x1A966E0", Length = "0x3C")]
			[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60001B6")]
			 get { } //Length: 60
		}

		[Address(RVA = "0x1A97490", Offset = "0x1A96690", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001B5")]
		public ChangesFromUI(BindingData bindingData) { }

		[Address(RVA = "0x1A974E0", Offset = "0x1A966E0", Length = "0x3C")]
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001B6")]
		public bool get_IsValid() { }

	}

	[Token(Token = "0x2000034")]
	private class HierarchyBindingTracker : IDisposable
	{
		[Token(Token = "0x2000035")]
		private class HierarchicalBindingsSorter : HierarchyTraversal
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000122")]
			private HashSet<VisualElement> <boundElements>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000123")]
			private List<VisualElement> <results>k__BackingField; //Field offset: 0x18

			[Token(Token = "0x17000036")]
			public HashSet<VisualElement> boundElements
			{
				[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
				[CallerCount(Count = 50)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60001C3")]
				 get { } //Length: 5
				[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
				[CallerCount(Count = 1)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60001C4")]
				 set { } //Length: 13
			}

			[Token(Token = "0x17000037")]
			public List<VisualElement> results
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60001C5")]
				 get { } //Length: 5
				[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
				[CallerCount(Count = 9)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60001C6")]
				 set { } //Length: 13
			}

			[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
			[CallerCount(Count = 83)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001C8")]
			public HierarchicalBindingsSorter() { }

			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001C3")]
			public HashSet<VisualElement> get_boundElements() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001C5")]
			public List<VisualElement> get_results() { }

			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001C4")]
			public void set_boundElements(HashSet<VisualElement> value) { }

			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001C6")]
			public void set_results(List<VisualElement> value) { }

			[Address(RVA = "0x1AB1340", Offset = "0x1AB0540", Length = "0xC3")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
			[Calls(Type = typeof(HierarchyTraversal), Member = "Recurse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x60001C7")]
			public virtual void TraverseRecursive(VisualElement element, int depth) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011B")]
		private readonly BaseVisualElementPanel m_Panel; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400011C")]
		private readonly HierarchicalBindingsSorter m_BindingSorter; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400011D")]
		private readonly Dictionary<VisualElement, BindingDataCollection> m_BindingDataPerElement; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400011E")]
		private readonly HashSet<VisualElement> m_BoundElements; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400011F")]
		private readonly List<VisualElement> m_OrderedBindings; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000120")]
		private bool m_IsDirty; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000121")]
		private EventCallback<PropertyChangedEvent, Dictionary`2<VisualElement, BindingDataCollection>> m_OnPropertyChanged; //Field offset: 0x40

		[Address(RVA = "0x1AB2370", Offset = "0x1AB1570", Length = "0x19B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60001B9")]
		public HierarchyBindingTracker(BaseVisualElementPanel panel) { }

		[Address(RVA = "0x1AB1410", Offset = "0x1AB0610", Length = "0x1B3")]
		[CalledBy(Type = typeof(DataBindingManager), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60001C1")]
		public override void Dispose() { }

		[Address(RVA = "0x1AB15D0", Offset = "0x1AB07D0", Length = "0xEF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60001B8")]
		public List<VisualElement> GetBoundElements() { }

		[Address(RVA = "0x1AB16C0", Offset = "0x1AB08C0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001B7")]
		public int GetTrackedElementsCount() { }

		[Address(RVA = "0x1AB1700", Offset = "0x1AB0900", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001BC")]
		public bool IsTrackingElement(VisualElement element) { }

		[Address(RVA = "0x1AB1760", Offset = "0x1AB0960", Length = "0x5E7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BindingId), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Binding&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60001BE")]
		private void OnPropertyChanged(PropertyChangedEvent evt, Dictionary<VisualElement, BindingDataCollection> bindingCollection) { }

		[Address(RVA = "0x1AB1D50", Offset = "0x1AB0F50", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001C2")]
		private void OrderBindings(VisualElement root) { }

		[Address(RVA = "0x17658B0", Offset = "0x1764AB0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BA")]
		public void SetDirty() { }

		[Address(RVA = "0x1AB1E20", Offset = "0x1AB1020", Length = "0x272")]
		[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.UIElements.DataBindingManager+BindingDataCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.UIElements.DataBindingManager+BindingDataCollection"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "AddBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TUserArgsType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TUserArgsType>", "TUserArgsType", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001BD")]
		public void StartTrackingBinding(VisualElement element, BindingData binding) { }

		[Address(RVA = "0x1AB20A0", Offset = "0x1AB12A0", Length = "0x19E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "RemoveBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.UIElements.DataBindingManager+BindingDataCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyBindingTracker), Member = "StopTrackingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001BF")]
		public void StopTrackingBinding(VisualElement element, BindingData binding) { }

		[Address(RVA = "0x1AB2240", Offset = "0x1AB1440", Length = "0xBD")]
		[CalledBy(Type = typeof(HierarchyBindingTracker), Member = "StopTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001C0")]
		public void StopTrackingElement(VisualElement element) { }

		[Address(RVA = "0x1AB2300", Offset = "0x1AB1500", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001BB")]
		public bool TryGetBindingCollection(VisualElement element, out BindingDataCollection collection) { }

	}

	[Token(Token = "0x2000036")]
	private class HierarchyDataSourceTracker : IDisposable
	{
		[Token(Token = "0x2000038")]
		private class InvalidateDataSourcesTraversal : HierarchyTraversal
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000130")]
			private readonly HierarchyDataSourceTracker m_DataSourceTracker; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000131")]
			private readonly HashSet<VisualElement> m_VisitedElements; //Field offset: 0x18

			[Address(RVA = "0x1AB54A0", Offset = "0x1AB46A0", Length = "0x8A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60001E5")]
			public InvalidateDataSourcesTraversal(HierarchyDataSourceTracker dataSourceTracker) { }

			[Address(RVA = "0x1AB51B0", Offset = "0x1AB43B0", Length = "0x1E7")]
			[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "InvalidateCachedDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 2)]
			[Token(Token = "0x60001E6")]
			public void Invalidate(List<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements) { }

			[Address(RVA = "0x1AB53A0", Offset = "0x1AB45A0", Length = "0xFC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataSourceContext>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(HierarchyTraversal), Member = "Recurse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60001E7")]
			public virtual void TraverseRecursive(VisualElement element, int depth) { }

		}

		[Token(Token = "0x2000039")]
		private class ObjectComparer : IEqualityComparer<Object>
		{

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001EA")]
			public ObjectComparer() { }

			[Address(RVA = "0x1AB55A0", Offset = "0x1AB47A0", Length = "0x180")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
			[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60001E8")]
			private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

			[Address(RVA = "0x1AB5730", Offset = "0x1AB4930", Length = "0xA")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60001E9")]
			private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

		}

		[Token(Token = "0x2000037")]
		private class SourceInfo
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400012D")]
			private HashSet<PropertyPath> m_DetectedChanges; //Field offset: 0x10
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400012E")]
			private long <lastVersion>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400012F")]
			private int <refCount>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700003A")]
			public HashSet<PropertyPath> detectedChanges
			{
				[Address(RVA = "0x1AB5E70", Offset = "0x1AB5070", Length = "0x7B")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
				[Calls(Type = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>), Member = ".ctor", ReturnType = typeof(void))]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
				[Token(Token = "0x60001E2")]
				 get { } //Length: 123
			}

			[Token(Token = "0x1700003B")]
			public HashSet<PropertyPath> detectedChangesNoAlloc
			{
				[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
				[CallerCount(Count = 50)]
				[DeduplicatedMethod]
				[Token(Token = "0x60001E3")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000038")]
			public long lastVersion
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60001DE")]
				 get { } //Length: 5
				[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60001DF")]
				 set { } //Length: 5
			}

			[Token(Token = "0x17000039")]
			public int refCount
			{
				[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
				[CallerCount(Count = 3)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60001E0")]
				 get { } //Length: 4
				[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
				[CallerCount(Count = 2)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60001E1")]
				 set { } //Length: 4
			}

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001E4")]
			public SourceInfo() { }

			[Address(RVA = "0x1AB5E70", Offset = "0x1AB5070", Length = "0x7B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>), Member = ".ctor", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Token(Token = "0x60001E2")]
			public HashSet<PropertyPath> get_detectedChanges() { }

			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001E3")]
			public HashSet<PropertyPath> get_detectedChangesNoAlloc() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001DE")]
			public long get_lastVersion() { }

			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001E0")]
			public int get_refCount() { }

			[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001DF")]
			public void set_lastVersion(long value) { }

			[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60001E1")]
			public void set_refCount(int value) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000124")]
		private readonly List<SourceInfo> m_SourceInfosPool; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000125")]
		private readonly DataBindingManager m_DataBindingManager; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000126")]
		private readonly Dictionary<VisualElement, DataSourceContext> m_ResolvedHierarchicalDataSourceContext; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000127")]
		private readonly Dictionary<Binding, Int32> m_BindingRefCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000128")]
		private readonly Dictionary<Object, SourceInfo> m_SourceInfos; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000129")]
		private readonly HashSet<Object> m_SourcesToRemove; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400012A")]
		private readonly InvalidateDataSourcesTraversal m_InvalidateResolvedDataSources; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400012B")]
		private readonly EventHandler<BindablePropertyChangedEventArgs> m_Handler; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400012C")]
		private readonly EventCallback<PropertyChangedEvent, VisualElement> m_VisualElementHandler; //Field offset: 0x50

		[Address(RVA = "0x1AB49D0", Offset = "0x1AB3BD0", Length = "0x30E")]
		[CalledBy(Type = typeof(DataBindingManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(EventHandler`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x60001CB")]
		public HierarchyDataSourceTracker(DataBindingManager manager) { }

		[Address(RVA = "0x1AB2510", Offset = "0x1AB1710", Length = "0x91")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001D3")]
		public void ClearChangesFromSource(object dataSource) { }

		[Address(RVA = "0x1AB25B0", Offset = "0x1AB17B0", Length = "0x2F0")]
		[CalledBy(Type = typeof(DataBindingManager), Member = "ClearSourceCache", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60001DD")]
		public void ClearSourceCache() { }

		[Address(RVA = "0x1AB28B0", Offset = "0x1AB1AB0", Length = "0x159")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60001CD")]
		internal void DecreaseBindingRefCount(ref BindingData bindingData) { }

		[Address(RVA = "0x1AB2A10", Offset = "0x1AB1C10", Length = "0x1AC")]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseBindingRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "TrackDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60001D0")]
		internal void DecreaseRefCount(object dataSource) { }

		[Address(RVA = "0x1AB2BC0", Offset = "0x1AB1DC0", Length = "0xDD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001DC")]
		public override void Dispose() { }

		[Address(RVA = "0x1AB2CA0", Offset = "0x1AB1EA0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001D2")]
		public HashSet<PropertyPath> GetChangesFromSource(object dataSource) { }

		[Address(RVA = "0x1AB2D20", Offset = "0x1AB1F20", Length = "0x69F")]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataSourceContext>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DataSourceContext&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_isDataSourcePathEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_dataSourcePath", ReturnType = typeof(PropertyPath))]
		[Calls(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(DataSourceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataSourceContext>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DataSourceContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801CE800")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001DA")]
		internal DataSourceContext GetHierarchicalDataSourceContext(VisualElement element) { }

		[Address(RVA = "0x1AB33C0", Offset = "0x1AB25C0", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60001C9")]
		private SourceInfo GetPooledSourceInfo() { }

		[Address(RVA = "0x1AB34A0", Offset = "0x1AB26A0", Length = "0x7A7")]
		[CalledBy(Type = typeof(DataBindingManager), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B63A0")]
		[Calls(Type = typeof(DataSourceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
		[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(DataSourceContext))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181A91DD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001D5")]
		public DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData) { }

		[Address(RVA = "0x1AB3C50", Offset = "0x1AB2E50", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001D1")]
		public int GetTrackedDataSourcesCount() { }

		[Address(RVA = "0x1AB3CA0", Offset = "0x1AB2EA0", Length = "0x138")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001CC")]
		internal void IncreaseBindingRefCount(ref BindingData bindingData) { }

		[Address(RVA = "0x1AB3DE0", Offset = "0x1AB2FE0", Length = "0x242")]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseBindingRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "TrackDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TUserArgsType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TUserArgsType>", "TUserArgsType", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60001CE")]
		internal void IncreaseRefCount(object dataSource) { }

		[Address(RVA = "0x1AB4030", Offset = "0x1AB3230", Length = "0x283")]
		[CalledBy(Type = typeof(DataBindingManager), Member = "InvalidateCachedDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker+InvalidateDataSourcesTraversal", Member = "Invalidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181A91D90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60001D4")]
		public void InvalidateCachedDataSource(HashSet<VisualElement> elements, HashSet<VisualElement> removedElements) { }

		[Address(RVA = "0x1AB42C0", Offset = "0x1AB34C0", Length = "0x18F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "TrackPropertyChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001CF")]
		private void OnVisualElementPropertyChanged(PropertyChangedEvent evt, VisualElement element) { }

		[Address(RVA = "0x1AB4450", Offset = "0x1AB3650", Length = "0xE8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60001CA")]
		private void ReleasePooledSourceInfo(SourceInfo info) { }

		[Address(RVA = "0x1AB4540", Offset = "0x1AB3740", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataSourceContext>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001DB")]
		internal void RemoveHierarchyDataSourceContextFromElement(VisualElement element) { }

		[Address(RVA = "0x1AB45A0", Offset = "0x1AB37A0", Length = "0x167")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "TrackPropertyChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001D6")]
		private void TrackPropertyChanges(object sender, BindablePropertyChangedEventArgs args) { }

		[Address(RVA = "0x1AB4710", Offset = "0x1AB3910", Length = "0x17E")]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "OnVisualElementPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyChangedEvent), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "TrackPropertyChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindablePropertyChangedEventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001D7")]
		private void TrackPropertyChanges(object sender, PropertyPath propertyPath) { }

		[Address(RVA = "0x1AB4890", Offset = "0x1AB3A90", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001D8")]
		public bool TryGetLastVersion(object source, out long version) { }

		[Address(RVA = "0x1AB4930", Offset = "0x1AB3B30", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001D9")]
		public void UpdateVersion(object source, long version) { }

	}

	[Token(Token = "0x200003A")]
	private struct IgnoreUIChangesData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000132")]
		public VisualElement element; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000133")]
		public Binding binding; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000134")]
		public BindingId bindingId; //Field offset: 0x10

		[Address(RVA = "0x1AB4CE0", Offset = "0x1AB3EE0", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BindingId), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60001EB")]
		public bool ShouldIgnoreChange(VisualElement ve, Binding b, BindingId id) { }

	}

	[Token(Token = "0x200003B")]
	internal struct IgnoreUIChangesScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000135")]
		private IgnoreUIChangesData m_ScopeData; //Field offset: 0x0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000136")]
		private DataBindingManager manager; //Field offset: 0xA8

		[Address(RVA = "0x1AB4E90", Offset = "0x1AB4090", Length = "0x313")]
		[CalledBy(Type = typeof(DataBindingManager), Member = "IgnoreChangesScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId), typeof(Binding)}, ReturnType = typeof(IgnoreUIChangesScope))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001EC")]
		internal IgnoreUIChangesScope(DataBindingManager manager, VisualElement target, BindingId bindingId, Binding binding) { }

		[Address(RVA = "0x1AB4D70", Offset = "0x1AB3F70", Length = "0x11F")]
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001ED")]
		public override void Dispose() { }

	}

	[Token(Token = "0x4000102")]
	private static readonly PropertyName k_RequestBindingPropertyName; //Field offset: 0x0
	[Token(Token = "0x4000103")]
	private static readonly BindingId k_ClearBindingsToken; //Field offset: 0x8
	[Token(Token = "0x4000104")]
	internal static BindingLogLevel globalLogLevel; //Field offset: 0xA0
	[Token(Token = "0x4000106")]
	private static readonly List<BindingData> s_Empty; //Field offset: 0xA8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000101")]
	private readonly List<BindingData> m_BindingDataLocalPool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000105")]
	private Nullable<BindingLogLevel> m_LogLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000107")]
	private readonly BaseVisualElementPanel m_Panel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000108")]
	private readonly HierarchyDataSourceTracker m_DataSourceTracker; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000109")]
	private readonly HierarchyBindingTracker m_BindingsTracker; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400010A")]
	private readonly List<ChangesFromUI> m_DetectedChangesFromUI; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400010B")]
	private IgnoreUIChangesData m_IgnoreUIChangesData; //Field offset: 0x40

	[Token(Token = "0x17000032")]
	internal BindingLogLevel logLevel
	{
		[Address(RVA = "0x1AAEFD0", Offset = "0x1AAE1D0", Length = "0x81")]
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000183")]
		internal get { } //Length: 129
		[Address(RVA = "0x1AAF060", Offset = "0x1AAE260", Length = "0x5B")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Token(Token = "0x6000184")]
		internal set { } //Length: 91
	}

	[Address(RVA = "0x1AAEB30", Offset = "0x1AADD30", Length = "0x1CC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001A6")]
	private static DataBindingManager() { }

	[Address(RVA = "0x1AAED00", Offset = "0x1AADF00", Length = "0x2CE")]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBindingManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000186")]
	internal DataBindingManager(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1AAAD50", Offset = "0x1AA9F50", Length = "0xCA")]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ProcessBindingRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600019F")]
	internal static bool AnyPendingBindingRequests(VisualElement element) { }

	[Address(RVA = "0x1AAAE20", Offset = "0x1AAA020", Length = "0x96")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018C")]
	internal void CacheSourceBindingResult(BindingData bindingData, BindingResult result) { }

	[Address(RVA = "0x1AAAEC0", Offset = "0x1AAA0C0", Length = "0x96")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018A")]
	internal void CacheUIBindingResult(BindingData bindingData, BindingResult result) { }

	[Address(RVA = "0x1AAAF60", Offset = "0x1AAA160", Length = "0x307")]
	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181A92370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600019E")]
	private void ClearAllBindings(VisualElement element) { }

	[Address(RVA = "0x1AAB270", Offset = "0x1AAA470", Length = "0x9D")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000194")]
	internal void ClearChangesFromSource(object dataSource) { }

	[Address(RVA = "0x1AAB310", Offset = "0x1AAA510", Length = "0x1D")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "ClearSourceCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001A3")]
	public void ClearSourceCache() { }

	[Address(RVA = "0x1AAB330", Offset = "0x1AAA530", Length = "0x53E")]
	[CalledBy(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingRequest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D5AC0")]
	[Calls(Type = typeof(BindingRequest), Member = "CancelRequest", ReturnType = typeof(BindingRequest))]
	[Calls(Type = typeof(BindingId), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BindingRequest))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600019C")]
	private static void CreateBindingRequest(VisualElement target, in BindingId bindingId, Binding binding, bool isTransferring) { }

	[Address(RVA = "0x1AAB870", Offset = "0x1AAAA70", Length = "0x1B")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001A1")]
	public void DirtyBindingOrder() { }

	[Address(RVA = "0x1AAB890", Offset = "0x1AAAA90", Length = "0x15B")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HierarchyBindingTracker), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019B")]
	public override void Dispose() { }

	[Address(RVA = "0x1AAEFD0", Offset = "0x1AAE1D0", Length = "0x81")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000183")]
	internal BindingLogLevel get_logLevel() { }

	[Address(RVA = "0x1AAB9F0", Offset = "0x1AAABF0", Length = "0xE4")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000195")]
	internal List<BindingData> GetBindingData(VisualElement element) { }

	[Address(RVA = "0x1AABB30", Offset = "0x1AAAD30", Length = "0xFA")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000190")]
	internal IEnumerable<VisualElement> GetBoundElements() { }

	[Address(RVA = "0x1AABAE0", Offset = "0x1AAACE0", Length = "0x42")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018F")]
	internal int GetBoundElementsCount() { }

	[Address(RVA = "0x1AABC30", Offset = "0x1AAAE30", Length = "0x8B")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000193")]
	internal HashSet<PropertyPath> GetChangedDetectedFromSource(object dataSource) { }

	[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000192")]
	internal List<ChangesFromUI> GetChangedDetectedFromUI() { }

	[Address(RVA = "0x1AABCC0", Offset = "0x1AAAEC0", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001A4")]
	public BindingData GetPooledBindingData(BindingTarget target, Binding binding) { }

	[Address(RVA = "0x1AABE40", Offset = "0x1AAB040", Length = "0x16D")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018E")]
	internal DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData) { }

	[Address(RVA = "0x1AABFB0", Offset = "0x1AAB1B0", Length = "0x4A")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000187")]
	internal int GetTrackedDataSourcesCount() { }

	[Address(RVA = "0x1AAC000", Offset = "0x1AAB200", Length = "0x170")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(IgnoreUIChangesScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBindingManager), typeof(VisualElement), typeof(BindingId), typeof(Binding)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000191")]
	public IgnoreUIChangesScope IgnoreChangesScope(VisualElement target, BindingId bindingId, Binding binding) { }

	[Address(RVA = "0x1AAC170", Offset = "0x1AAB370", Length = "0x1E")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessDataSourceChangedRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "InvalidateCachedDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019A")]
	public void InvalidateCachedDataSource(HashSet<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements) { }

	[Address(RVA = "0x1AAC190", Offset = "0x1AAB390", Length = "0x59D")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "ClearAllBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingId), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BindingRequest))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600019D")]
	public void ProcessBindingRequests(VisualElement element) { }

	[Address(RVA = "0x1AAC730", Offset = "0x1AAB930", Length = "0xE1E")]
	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DataSourceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSourceContextChanged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(DataSourceContext&), typeof(DataSourceContext&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyBindingTracker), Member = "StartTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B63A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000197")]
	internal void RegisterBinding(VisualElement element, in BindingId bindingId, Binding binding) { }

	[Address(RVA = "0x1AAD550", Offset = "0x1AAC750", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A5")]
	public void ReleasePoolBindingData(BindingData data) { }

	[Address(RVA = "0x1AAD6C0", Offset = "0x1AAC8C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000185")]
	internal void ResetLogLevel() { }

	[Address(RVA = "0x1AAF060", Offset = "0x1AAE260", Length = "0x5B")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000184")]
	internal void set_logLevel(BindingLogLevel value) { }

	[Address(RVA = "0x1AAD6D0", Offset = "0x1AAC8D0", Length = "0x44")]
	[CalledBy(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001A2")]
	public void TrackDataSource(object previous, object current) { }

	[Address(RVA = "0x1AAD720", Offset = "0x1AAC920", Length = "0x1B3")]
	[CalledBy(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "CreateBindingRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DataBindingManager), Member = "CreateBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyBindingTracker), Member = "StopTrackingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000199")]
	internal void TransferBindingRequests(VisualElement element) { }

	[Address(RVA = "0x1AAD8E0", Offset = "0x1AACAE0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingDataCollection), Member = "TryGetBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000196")]
	internal bool TryGetBindingData(VisualElement element, in BindingId bindingId, out BindingData bindingData) { }

	[Address(RVA = "0x1AAD9C0", Offset = "0x1AACBC0", Length = "0x224")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BindingRequest))]
	[Calls(Type = typeof(BindingId), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60001A0")]
	internal static bool TryGetBindingRequest(VisualElement element, in BindingId bindingId, out Binding binding) { }

	[Address(RVA = "0x1AADBF0", Offset = "0x1AACDF0", Length = "0x96")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018D")]
	internal bool TryGetLastSourceBindingResult(BindingData bindingData, out BindingResult result) { }

	[Address(RVA = "0x1AADC90", Offset = "0x1AACE90", Length = "0x96")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018B")]
	internal bool TryGetLastUIBindingResult(BindingData bindingData, out BindingResult result) { }

	[Address(RVA = "0x1AADD30", Offset = "0x1AACF30", Length = "0xA5")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "GetDataSourceVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Int64>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000188")]
	internal bool TryGetLastVersion(object source, out long version) { }

	[Address(RVA = "0x1AADDE0", Offset = "0x1AACFE0", Length = "0xCA0")]
	[CalledBy(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "ClearAllBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingDataCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyBindingTracker), Member = "StopTrackingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSourceContextChanged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(DataSourceContext&), typeof(DataSourceContext&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(DataSourceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B63A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000198")]
	internal void UnregisterBinding(VisualElement element, in BindingId bindingId) { }

	[Address(RVA = "0x1AAEA90", Offset = "0x1AADC90", Length = "0x96")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000189")]
	internal void UpdateVersion(object source, long version) { }

}

