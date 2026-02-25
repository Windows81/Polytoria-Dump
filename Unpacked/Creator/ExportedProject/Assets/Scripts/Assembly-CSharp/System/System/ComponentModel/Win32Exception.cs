namespace System.ComponentModel;

[Token(Token = "0x2000196")]
public class Win32Exception : ExternalException, ISerializable
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000660")]
	private readonly int nativeErrorCode; //Field offset: 0x90

	[Token(Token = "0x170001CE")]
	public int NativeErrorCode
	{
		[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C4")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x17B0EA0", Offset = "0x17B00A0", Length = "0x6F")]
	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Exception), Member = "GetErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009C0")]
	public Win32Exception() { }

	[Address(RVA = "0x17B0FD0", Offset = "0x17B01D0", Length = "0x37")]
	[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_14", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "CompleteAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), "System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1<Socket>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Win32Exception), Member = "GetErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009C1")]
	public Win32Exception(int error) { }

	[Address(RVA = "0x17B0FA0", Offset = "0x17B01A0", Length = "0x2E")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009C2")]
	public Win32Exception(int error, string message) { }

	[Address(RVA = "0x17B0F10", Offset = "0x17B0110", Length = "0x81")]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009C3")]
	protected Win32Exception(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C4")]
	public int get_NativeErrorCode() { }

	[Address(RVA = "0x17B0300", Offset = "0x17AF500", Length = "0x434")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60009C6")]
	internal static string GetErrorMessage(int error) { }

	[Address(RVA = "0x17B0DD0", Offset = "0x17AFFD0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60009C5")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

