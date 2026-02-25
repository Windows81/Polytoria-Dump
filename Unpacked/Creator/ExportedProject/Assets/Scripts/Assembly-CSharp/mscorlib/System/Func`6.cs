namespace System;

[Token(Token = "0x20000AB")]
public sealed class Func : MulticastDelegate
{

	[Address(RVA = "0xC49340", Offset = "0xC48540", Length = "0x125")]
	[CalledBy(Type = "System.Net.Sockets.UdpClient", Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), "System.Net.IPEndPoint"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D8")]
	public Func`6(object object, IntPtr method) { }

	[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D9")]
	public override TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

}

