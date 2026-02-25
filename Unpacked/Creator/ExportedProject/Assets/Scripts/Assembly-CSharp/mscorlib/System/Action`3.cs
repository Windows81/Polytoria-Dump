namespace System;

[Token(Token = "0x20000A0")]
public sealed class Action : MulticastDelegate
{

	[Address(RVA = "0xA33AB0", Offset = "0xA32CB0", Length = "0xA6")]
	[CalledBy(Type = "Mirror.NetworkClient", Member = "RegisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkMessages", Member = "WrapHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "C"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<C, T>", typeof(bool), typeof(bool)}, ReturnType = "Mirror.NetworkMessageDelegate")]
	[CalledBy(Type = "Mirror.NetworkServer", Member = "RegisterMessageHandlers", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkServer", Member = "RegisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<NetworkConnectionToClient, T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C2")]
	public Action`3(object object, IntPtr method) { }

	[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C3")]
	public override void Invoke(T1 arg1, T2 arg2, T3 arg3) { }

}

