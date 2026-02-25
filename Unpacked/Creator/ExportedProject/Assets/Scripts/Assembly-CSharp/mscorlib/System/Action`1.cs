namespace System;

[Token(Token = "0x200009E")]
public sealed class Action : MulticastDelegate
{

	[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", Length = "0xA6")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.TweenService", Member = "TweenVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3", "UnityEngine.Vector3", typeof(float), "MoonSharp.Interpreter.DynValue", "LeanTweenType", "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.NetworkClient", Member = "RegisterMessageHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "RegisterClientMessages", ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport+<WaitForLobbyRelay>d__16", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "ServerStart", ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "CreateAndDeployLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<LobbyServiceResponse>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnStartClient", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003BE")]
	public Action`1(object object, IntPtr method) { }

	[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003BF")]
	public override void Invoke(T obj) { }

}

