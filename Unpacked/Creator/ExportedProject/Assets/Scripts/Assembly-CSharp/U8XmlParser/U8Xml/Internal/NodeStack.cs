namespace U8Xml.Internal;

[DebuggerDisplay("NodeStack[{Count}]")]
[DebuggerTypeProxy(typeof(NodeStackDebuggerTypeProxy))]
[Token(Token = "0x2000024")]
internal struct NodeStack : IDisposable
{
	[Token(Token = "0x2000025")]
	private class NodeStackDebuggerTypeProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000041")]
	private XmlNode_** _ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000042")]
	private int _capacity; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000043")]
	private int _count; //Field offset: 0xC

	[Token(Token = "0x17000029")]
	public int Count
	{
		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BF")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1807D10", Offset = "0x1806F10", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000C0")]
	public NodeStack(int capacity) { }

	[Address(RVA = "0x1807990", Offset = "0x1806B90", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000C5")]
	public override void Dispose() { }

	[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BF")]
	public int get_Count() { }

	[Address(RVA = "0x1807A00", Offset = "0x1806C00", Length = "0x1E2")]
	[CalledBy(Type = typeof(XmlParser), Member = "StartStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(NodeStore&), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NodeStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode_*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60000C6")]
	private void GrowUp() { }

	[Address(RVA = "0x1807BF0", Offset = "0x1806DF0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000C3")]
	public XmlNode_* Peek() { }

	[Address(RVA = "0x1807C40", Offset = "0x1806E40", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000C2")]
	public XmlNode_* Pop() { }

	[Address(RVA = "0x1807CA0", Offset = "0x1806EA0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeStack), Member = "GrowUp", ReturnType = typeof(void))]
	[Token(Token = "0x60000C1")]
	public void Push(XmlNode_* value) { }

	[Address(RVA = "0x1807CE0", Offset = "0x1806EE0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000C4")]
	public bool TryPeek(out XmlNode_* item) { }

}

