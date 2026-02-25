namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005BD")]
internal class ManagedObjectStore
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014CB")]
	private readonly int m_ChunkSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014CC")]
	private int m_Length; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014CD")]
	private readonly List<T[]> m_Chunks; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014CE")]
	private readonly Queue<Int32> m_Free; //Field offset: 0x0

	[Address(RVA = "0xE08360", Offset = "0xE07560", Length = "0x194")]
	[CalledBy(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028CC")]
	public ManagedObjectStore`1(int chunkSize = 2048) { }

	[Address(RVA = "0xE07950", Offset = "0xE06B50", Length = "0x5A")]
	[CalledBy(Type = typeof(LayoutManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "TryRecycleNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(LayoutManager), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[CalledBy(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60028CD")]
	public T GetValue(int index) { }

	[Address(RVA = "0xE081D0", Offset = "0xE073D0", Length = "0x18F")]
	[CalledBy(Type = typeof(LayoutManager), Member = "TryRecycleNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Int32>), Member = "Dequeue", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60028CE")]
	public void UpdateValue(ref int index, T value) { }

}

