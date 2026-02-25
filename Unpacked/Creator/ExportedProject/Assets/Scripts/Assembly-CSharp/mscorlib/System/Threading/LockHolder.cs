namespace System.Threading;

[ReflectionBlocked]
[Token(Token = "0x200020E")]
public struct LockHolder : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D8")]
	private Lock _lock; //Field offset: 0x0

	[Address(RVA = "0x1513390", Offset = "0x1512590", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D670")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600118F")]
	public override void Dispose() { }

	[Address(RVA = "0x15133B0", Offset = "0x15125B0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D640")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600118E")]
	public static LockHolder Hold(Lock l) { }

}

