namespace Telepathy;

[Token(Token = "0x2000012")]
public class Pool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002B")]
	private readonly Stack<T> objects; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002C")]
	private readonly Func<T> objectGenerator; //Field offset: 0x0

	[Address(RVA = "0xE6D580", Offset = "0xE6C780", Length = "0x9C")]
	[CalledBy(Type = typeof(ConnectionState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MagnificentReceivePipe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MagnificentSendPipe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002B")]
	public Pool`1(Func<T> objectGenerator) { }

	[Address(RVA = "0xE6CA20", Offset = "0xE6BC20", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public void Clear() { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	public int Count() { }

	[Address(RVA = "0xE6CDA0", Offset = "0xE6BFA0", Length = "0x2A")]
	[CalledBy(Type = typeof(MagnificentReceivePipe), Member = "TryDequeue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MagnificentReceivePipe), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MagnificentSendPipe), Member = "DequeueAndSerializeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MagnificentSendPipe), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public void Return(T item) { }

	[Address(RVA = "0xE6D320", Offset = "0xE6C520", Length = "0x50")]
	[CalledBy(Type = typeof(MagnificentReceivePipe), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EventType), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MagnificentSendPipe), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002C")]
	public T Take() { }

}

