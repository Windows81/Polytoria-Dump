namespace System.Threading;

[Token(Token = "0x200020F")]
public class Lock
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009D9")]
	private object _lock; //Field offset: 0x10

	[Address(RVA = "0x1513540", Offset = "0x1512740", Length = "0x66")]
	[CalledBy(Type = typeof(TaskScheduler), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001192")]
	public Lock() { }

	[Address(RVA = "0x1513520", Offset = "0x1512720", Length = "0x9")]
	[CalledBy(Type = typeof(TaskScheduler), Member = "PublishUnobservedTaskException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(UnobservedTaskExceptionEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D640")]
	[Token(Token = "0x6001190")]
	public void Acquire() { }

	[Address(RVA = "0x1513530", Offset = "0x1512730", Length = "0x9")]
	[CalledBy(Type = typeof(TaskScheduler), Member = "PublishUnobservedTaskException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(UnobservedTaskExceptionEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D670")]
	[Token(Token = "0x6001191")]
	public void Release() { }

}

