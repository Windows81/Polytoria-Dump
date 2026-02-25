namespace System;

[Token(Token = "0x20000D5")]
internal static class IOSelector
{

	[Address(RVA = "0x17564C0", Offset = "0x17556C0", Length = "0x5")]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass355_0", Member = "<QueueIOSelectorJob>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendToCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180221E60")]
	[Token(Token = "0x600045A")]
	public static void Add(IntPtr handle, IOSelectorJob job) { }

}

