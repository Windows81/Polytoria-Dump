namespace UnityEngine.UIElements;

[Token(Token = "0x20002A1")]
internal class ObjectPool
{
	[CompilerGenerated]
	[Token(Token = "0x20002A2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000A7A")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x4000A7B")]
		public static Func<T> <>9__6_0; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001221")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001222")]
		public <>c() { }

		[Address(RVA = "0x7F9CD0", Offset = "0x7F8ED0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001223")]
		internal T <.ctor>b__6_0() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A77")]
	private readonly Stack<T> m_Stack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A78")]
	private int m_MaxSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A79")]
	internal Func<T> CreateFunc; //Field offset: 0x0

	[Token(Token = "0x17000369")]
	public int maxSize
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x600121B")]
		 get { } //Length: 6
		[Address(RVA = "0xE5B8F0", Offset = "0xE5AAF0", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600121C")]
		 set { } //Length: 219
	}

	[Address(RVA = "0xE5B5B0", Offset = "0xE5A7B0", Length = "0x302")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectListPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementListPool), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropagationPaths), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatcher), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+Row", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600121D")]
	public ObjectPool`1(Func<T> CreateFunc, int maxSize = 100) { }

	[Address(RVA = "0xE5A960", Offset = "0xE59B60", Length = "0x55")]
	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryPartitionArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "BuildDrawOperationTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetFocusChangeDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(FocusChangeDirection))]
	[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(VisualElementFocusChangeTarget))]
	[CalledBy(Type = typeof(VisualElementListPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
	[CalledBy(Type = typeof(VisualElementListPool), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = "UnityEngine.UIElements.UIRAtlasAllocator+AreaNode")]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+Row", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = "UnityEngine.UIElements.UIRAtlasAllocator+Row")]
	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = "T")]
	[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[CalledBy(Type = typeof(EventDispatcher), Member = "ProcessEventQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatcher), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatcher), Member = "CreateDefault", ReturnType = typeof(EventDispatcher))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600121F")]
	public T Get() { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x600121B")]
	public int get_maxSize() { }

	[Address(RVA = "0xE5ACD0", Offset = "0xE59ED0", Length = "0xD3")]
	[CalledBy(Type = typeof(VisualElementListPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Recycle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "CleanupOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropagationPaths), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TabView+ViewState", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+Row", Member = "Release", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001220")]
	public void Release(T element) { }

	[Address(RVA = "0xE5B8F0", Offset = "0xE5AAF0", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600121C")]
	public void set_maxSize(int value) { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600121E")]
	public int Size() { }

}

