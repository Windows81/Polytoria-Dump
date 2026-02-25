namespace UnityEngine.Pool;

[Token(Token = "0x2000282")]
public class ObjectPool : IDisposable, IPool, IObjectPool<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006A3")]
	internal readonly List<T> m_List; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006A4")]
	private readonly Func<T> m_CreateFunc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006A5")]
	private readonly Action<T> m_ActionOnGet; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006A6")]
	private readonly Action<T> m_ActionOnRelease; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006A7")]
	private readonly Action<T> m_ActionOnDestroy; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006A8")]
	private readonly int m_MaxSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006A9")]
	internal bool m_CollectionCheck; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006AA")]
	private T m_FreshlyReleased; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006AB")]
	private int <CountAll>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700020C")]
	public private int CountAll
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CE2")]
		 get { } //Length: 4
		[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CE3")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700020D")]
	public override int CountInactive
	{
		[Address(RVA = "0xE5B8C0", Offset = "0xE5AAC0", Length = "0x23")]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+ManagedJobData", Member = "Release", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Awaitable), Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.SpringJoint", Member = "set_tolerance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CE4")]
		 get { } //Length: 35
	}

	[Address(RVA = "0xE5B3C0", Offset = "0xE5A5C0", Length = "0x1E0")]
	[CalledBy(Type = "Unity.Properties.PropertyContainer+GetPropertyVisitor", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.PropertyContainer+GetValueVisitor`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CollectionPool`2), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable+<>c", Member = "<.cctor>b__76_0", ReturnType = typeof(UnityEngine.Pool.ObjectPool`1<UnityEngine.Awaitable>))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.SetValueVisitor`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VerticalVirtualizationController`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVerticalCollectionView"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PoolManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CE5")]
	public ObjectPool`1(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000) { }

	[Address(RVA = "0xE5A780", Offset = "0xE59980", Length = "0x1B1")]
	[CalledBy(Type = "UnityEngine.UIElements.VerticalVirtualizationController`1", Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectPool`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CE9")]
	public override void Clear() { }

	[Address(RVA = "0xE5A940", Offset = "0xE59B40", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Clear", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CEA")]
	public override void Dispose() { }

	[Address(RVA = "0x689170", Offset = "0x688370", Length = "0x20E")]
	[CalledBy(Type = "Unity.Properties.PropertyContainer", Member = "TryGetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", "Unity.Properties.PropertyPath&", "Unity.Properties.IProperty&", "Unity.Properties.VisitReturnCode&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.PropertyContainer", Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", "Unity.Properties.PropertyPath&", "TValue&", "Unity.Properties.VisitReturnCode&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "GetPooledRenderTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeManager", "UnityEngine.UIElements.UIR.RenderData"}, ReturnType = "UnityEngine.UIElements.UIR.RenderTree")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderEvents", Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeManager", "UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.VisualElement", typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.MeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Material>&", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>&", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>&", "System.Collections.Generic.List`1<GlyphRenderMode>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "GetPooledRenderData", ReturnType = "UnityEngine.UIElements.UIR.RenderData")]
	[CalledBy(Type = "UnityEngine.UIElements.TextJobSystem", Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", "UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroup", Member = "TrySetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", "Unity.Properties.PropertyPath&", "TValue", "Unity.Properties.VisitReturnCode&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", "UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CE6")]
	public override T Get() { }

	[Address(RVA = "0xE5A9C0", Offset = "0xE59BC0", Length = "0x134")]
	[CalledBy(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CE7")]
	public override PooledObject<T> Get(out T v) { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CE2")]
	public int get_CountAll() { }

	[Address(RVA = "0xE5B8C0", Offset = "0xE5AAC0", Length = "0x23")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+ManagedJobData", Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Awaitable), Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.SpringJoint", Member = "set_tolerance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CE4")]
	public override int get_CountInactive() { }

	[Address(RVA = "0xE5ADB0", Offset = "0xE59FB0", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CE8")]
	public override void Release(T element) { }

	[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CE3")]
	private void set_CountAll(int value) { }

}

