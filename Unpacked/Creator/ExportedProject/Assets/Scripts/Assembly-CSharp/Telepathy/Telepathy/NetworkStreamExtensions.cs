namespace Telepathy;

[Extension]
[Token(Token = "0x2000011")]
public static class NetworkStreamExtensions
{

	[Address(RVA = "0x18040E0", Offset = "0x18032E0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkStreamExtensions), Member = "ReadSafely", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Extension]
	[Token(Token = "0x600002A")]
	public static bool ReadExactly(NetworkStream stream, Byte[] buffer, int amount) { }

	[Address(RVA = "0x1804160", Offset = "0x1803360", Length = "0x32")]
	[CalledBy(Type = typeof(NetworkStreamExtensions), Member = "ReadExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadFunctions), Member = "ReadMessageBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(int), typeof(Byte[]), typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000029")]
	public static int ReadSafely(NetworkStream stream, Byte[] buffer, int offset, int size) { }

}

