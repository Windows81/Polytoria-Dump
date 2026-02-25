namespace UnityEngine.Pool;

[Token(Token = "0x2000283")]
public struct PooledObject : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006AC")]
	private readonly T m_ToReturn; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006AD")]
	private readonly IObjectPool<T> m_Pool; //Field offset: 0x0

	[Address(RVA = "0x310490", Offset = "0x30F690", Length = "0x32")]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CEB")]
	public PooledObject`1(T value, IObjectPool<T> pool) { }

	[Address(RVA = "0xE6D930", Offset = "0xE6CB30", Length = "0xC9")]
	[CallerCount(Count = 59)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CEC")]
	private override void System.IDisposable.Dispose() { }

}

