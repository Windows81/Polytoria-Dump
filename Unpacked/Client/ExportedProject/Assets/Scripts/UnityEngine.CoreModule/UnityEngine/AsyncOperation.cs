namespace UnityEngine;

[NativeHeader("Runtime/Misc/AsyncOperation.h")]
[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x200011F")]
public class AsyncOperation : YieldInstruction
{
	[Token(Token = "0x2000120")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x195D9F0", Offset = "0x195CBF0", Length = "0x80")]
		[CalledBy(Type = "UnityEngine.UnitySynchronizationContext+WorkRequest", Member = "Invoke", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.AI.NavMeshBuilder", Member = "UpdateNavMeshDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AI.NavMeshData", "UnityEngine.AI.NavMeshBuildSettings", "System.Collections.Generic.List`1<NavMeshBuildSource>", typeof(Bounds)}, ReturnType = typeof(AsyncOperation))]
		[CalledBy(Type = "UnityEngine.AI.NavMeshBuilder", Member = "UpdateNavMeshDataAsyncListInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AI.NavMeshData", "UnityEngine.AI.NavMeshBuildSettings", typeof(object), typeof(Bounds)}, ReturnType = typeof(AsyncOperation))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60008CB")]
		public static AsyncOperation ConvertToManaged(IntPtr ptr) { }

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60008CC")]
		public static IntPtr ConvertToNative(AsyncOperation asyncOperation) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400050D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AssetBundleModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400050E")]
	private Action<AsyncOperation> m_completeCallback; //Field offset: 0x18

	[Token(Token = "0x14000006")]
	public event Action<AsyncOperation> completed
	{
		[Address(RVA = "0x195B430", Offset = "0x195A630", Length = "0x123")]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "DeleteLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Action), "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "DeployLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<LobbyServiceResponse>", "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "TerminateLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<LobbyServiceResponse>", "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "GetLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<Nullable`1<LobbyServiceResponse>>", "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "CreateLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<LobbyServiceResponse>", "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "CreateAndDeployLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<LobbyServiceResponse>", "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "LeaveLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.LobbyJoinOrLeaveRequest", typeof(Action), "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "JoinLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.LobbyJoinOrLeaveRequest", typeof(Action), "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "GetLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Action`1<Lobby>", "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "StartLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.LobbyIdRequest", typeof(Action), "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "CreateLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.LobbyCreateRequest", "System.Action`1<Lobby>", "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport+<WaitForLobbyRelay>d__16", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "UpdateLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Edgegap.LobbyUpdateRequest", "System.Action`1<LobbyBrief>", "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "ServerStop", ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "ClientDisconnect", ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "ServerStart", ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "<ServerStart>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.Lobby"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "RefreshLobbies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<LobbyBrief[]>", "System.Action`1<String>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60008C7")]
		 add { } //Length: 291
		[Address(RVA = "0x195B600", Offset = "0x195A800", Length = "0xAF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60008C8")]
		 remove { } //Length: 175
	}

	[Token(Token = "0x17000175")]
	public bool allowSceneActivation
	{
		[Address(RVA = "0x195B700", Offset = "0x195A900", Length = "0x5B")]
		[CalledBy(Type = "Mirror.Discovery.NetworkDiscovery", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("SetAllowSceneActivation")]
		[Token(Token = "0x60008C4")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000174")]
	public bool isDone
	{
		[Address(RVA = "0x195B5A0", Offset = "0x195A7A0", Length = "0x51")]
		[CalledBy(Type = "Mirror.NetworkManager", Member = "UpdateScene", ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.Loading.AwaitableDownload+<WaitAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("IsDone")]
		[Token(Token = "0x60008C3")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C1")]
	public AsyncOperation() { }

	[Address(RVA = "0x195B3D0", Offset = "0x195A5D0", Length = "0x52")]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestAsyncOperation+BindingsMarshaller", Member = "ConvertToManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "UnityEngine.Networking.UnityWebRequestAsyncOperation")]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestAsyncOperation", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequest", Member = "BeginWebRequest", ReturnType = "UnityEngine.Networking.UnityWebRequestAsyncOperation")]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequest", Member = "SendWebRequest", ReturnType = "UnityEngine.Networking.UnityWebRequestAsyncOperation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008C2")]
	protected AsyncOperation(IntPtr ptr) { }

	[Address(RVA = "0x195B430", Offset = "0x195A630", Length = "0x123")]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "RefreshLobbies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<LobbyBrief[]>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "<ServerStart>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.Lobby"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "ServerStart", ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "ServerStop", ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "UpdateLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Edgegap.LobbyUpdateRequest", "System.Action`1<LobbyBrief>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport+<WaitForLobbyRelay>d__16", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "CreateLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.LobbyCreateRequest", "System.Action`1<Lobby>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "StartLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.LobbyIdRequest", typeof(Action), "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "ClientDisconnect", ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "JoinLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.LobbyJoinOrLeaveRequest", typeof(Action), "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "LeaveLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.LobbyJoinOrLeaveRequest", typeof(Action), "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "CreateAndDeployLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<LobbyServiceResponse>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "CreateLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<LobbyServiceResponse>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "GetLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Action`1<Lobby>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "GetLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<Nullable`1<LobbyServiceResponse>>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "TerminateLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<LobbyServiceResponse>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "DeployLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Action`1<LobbyServiceResponse>", "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "DeleteLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Action), "System.Action`1<String>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60008C7")]
	public void add_completed(Action<AsyncOperation> value) { }

	[Address(RVA = "0x195B270", Offset = "0x195A470", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008C5")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x195B5A0", Offset = "0x195A7A0", Length = "0x51")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "UpdateScene", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Loading.AwaitableDownload+<WaitAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("IsDone")]
	[Token(Token = "0x60008C3")]
	public bool get_isDone() { }

	[Address(RVA = "0x195B560", Offset = "0x195A760", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008C9")]
	private static bool get_isDone_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x195B2F0", Offset = "0x195A4F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[StaticAccessor("AsyncOperationBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x60008BF")]
	private static void InternalDestroy(IntPtr ptr) { }

	[Address(RVA = "0x195B330", Offset = "0x195A530", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[StaticAccessor("AsyncOperationBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x60008C0")]
	private static void InternalSetManagedObject(IntPtr ptr, AsyncOperation self) { }

	[Address(RVA = "0x195B380", Offset = "0x195A580", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60008C6")]
	internal void InvokeCompletionEvent() { }

	[Address(RVA = "0x195B600", Offset = "0x195A800", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60008C8")]
	public void remove_completed(Action<AsyncOperation> value) { }

	[Address(RVA = "0x195B700", Offset = "0x195A900", Length = "0x5B")]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscovery", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("SetAllowSceneActivation")]
	[Token(Token = "0x60008C4")]
	public void set_allowSceneActivation(bool value) { }

	[Address(RVA = "0x195B6B0", Offset = "0x195A8B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008CA")]
	private static void set_allowSceneActivation_Injected(IntPtr _unity_self, bool value) { }

}

