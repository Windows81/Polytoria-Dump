namespace System;

[Token(Token = "0x2000141")]
public static class Tuple
{

	[Address(RVA = "0xE08BA0", Offset = "0xE07DA0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A40")]
	internal static int CombineHashCodes(int h1, int h2) { }

	[Address(RVA = "0x14C58C0", Offset = "0x14C4AC0", Length = "0xC")]
	[CalledBy(Type = typeof(Tuple`3), Member = "System.Collections.IStructuralEquatable.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000A41")]
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	[Address(RVA = "0x14C58A0", Offset = "0x14C4AA0", Length = "0x12")]
	[CalledBy(Type = typeof(Tuple`4), Member = "System.Collections.IStructuralEquatable.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000A42")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	[Address(RVA = "0x76DBD0", Offset = "0x76CDD0", Length = "0x7E")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "InvokeCoreAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "InvokeContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A3E")]
	public static Tuple<T1, T2> Create(T1 item1, T2 item2) { }

	[Address(RVA = "0x76DA90", Offset = "0x76CC90", Length = "0xA0")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Tuple`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A3F")]
	public static Tuple<T1, T2, T3> Create(T1 item1, T2 item2, T3 item3) { }

}

