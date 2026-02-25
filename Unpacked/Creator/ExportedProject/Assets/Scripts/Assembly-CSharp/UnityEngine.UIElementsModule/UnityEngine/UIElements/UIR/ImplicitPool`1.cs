namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200056C")]
internal class ImplicitPool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012A2")]
	private readonly int m_StartCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012A3")]
	private readonly int m_MaxCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012A4")]
	private Func<T> m_CreateAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012A5")]
	private Action<T> m_ResetAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012A6")]
	private List<T> m_List; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012A7")]
	private int m_UsedCount; //Field offset: 0x0

	[Address(RVA = "0xC88480", Offset = "0xC87680", Length = "0x13B")]
	[CalledBy(Type = typeof(EntryPool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshWriteDataPool), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60026E9")]
	public ImplicitPool`1(Func<T> createAction, Action<T> resetAction, int startCapacity, int maxCapacity) { }

	[Address(RVA = "0xC881B0", Offset = "0xC873B0", Length = "0x1D9")]
	[CalledBy(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026EA")]
	public T Get() { }

	[Address(RVA = "0xC88390", Offset = "0xC87590", Length = "0xE2")]
	[CalledBy(Type = typeof(EntryPool), Member = "ReturnAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60026EB")]
	public void ReturnAll() { }

}

