namespace Edgegap;

[Token(Token = "0x2000026")]
public class LobbyApi
{
	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000119")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400011A")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400011B")]
		public Action onResponse; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A0")]
		public <>c__DisplayClass10_0() { }

		[Address(RVA = "0x1284C50", Offset = "0x1283E50", Length = "0xE8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A1")]
		internal void <LeaveLobby>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002A")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011C")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400011D")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400011E")]
		public Action onResponse; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A2")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x1284D40", Offset = "0x1283F40", Length = "0xE8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A3")]
		internal void <StartLobby>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002B")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011F")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000120")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000121")]
		public Action onResponse; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A4")]
		public <>c__DisplayClass12_0() { }

		[Address(RVA = "0x1284E30", Offset = "0x1284030", Length = "0xE8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A5")]
		internal void <DeleteLobby>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002C")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000122")]
		public string apiKey; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000123")]
		public string name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000124")]
		public Action<LobbyServiceResponse> onResponse; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000125")]
		public Action<String> onError; //Field offset: 0x28

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A6")]
		public <>c__DisplayClass16_0() { }

		[Address(RVA = "0x1284F20", Offset = "0x1284120", Length = "0x12C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LobbyApi), Member = "DeployLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Action`1<Edgegap.LobbyApi+LobbyServiceResponse>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LobbyApi), Member = "CreateLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Action`1<Edgegap.LobbyApi+LobbyServiceResponse>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001A7")]
		internal void <CreateAndDeployLobbyService>b__0(Nullable<LobbyServiceResponse> response) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002D")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000126")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000127")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000128")]
		public string apiKey; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000129")]
		public string name; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400012A")]
		public Action<LobbyServiceResponse> onResponse; //Field offset: 0x30

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A8")]
		public <>c__DisplayClass17_0() { }

		[Address(RVA = "0x12857C0", Offset = "0x12849C0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LobbyApi), Member = "DeployLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Action`1<Edgegap.LobbyApi+LobbyServiceResponse>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x60001A9")]
		internal void <CreateLobbyService>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002E")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012B")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400012C")]
		public Action<Nullable`1<LobbyServiceResponse>> onResponse; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400012D")]
		public Action<String> onError; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AA")]
		public <>c__DisplayClass18_0() { }

		[Address(RVA = "0x12858A0", Offset = "0x1284AA0", Length = "0x218")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_responseCode", ReturnType = typeof(long))]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyServiceResponse)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LobbyServiceResponse))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60001AB")]
		internal void <GetLobbyService>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002F")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012E")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400012F")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000130")]
		public Action<LobbyServiceResponse> onResponse; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AC")]
		public <>c__DisplayClass19_0() { }

		[Address(RVA = "0x1285AC0", Offset = "0x1284CC0", Length = "0x16C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyServiceResponse)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LobbyServiceResponse))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001AD")]
		internal void <TerminateLobbyService>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000030")]
	private sealed class <>c__DisplayClass20_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000131")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000132")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000133")]
		public Action<LobbyServiceResponse> onResponse; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AE")]
		public <>c__DisplayClass20_0() { }

		[Address(RVA = "0x1285C30", Offset = "0x1284E30", Length = "0x16C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyServiceResponse)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LobbyServiceResponse))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001AF")]
		internal void <DeployLobbyService>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000031")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000134")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000135")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000136")]
		public LobbyApi <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000137")]
		public Action<LobbyBrief[]> onLoaded; //Field offset: 0x28

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B0")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x1286200", Offset = "0x1285400", Length = "0x172")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B1")]
		internal void <RefreshLobbies>b__0(AsyncOperation operation) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000032")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000138")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000139")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400013A")]
		public Action<Lobby> onResponse; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B2")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x1286380", Offset = "0x1285580", Length = "0x1A0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lobby)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Lobby))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B3")]
		internal void <CreateLobby>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000033")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013B")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400013C")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400013D")]
		public Action<LobbyBrief> onResponse; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B4")]
		public <>c__DisplayClass7_0() { }

		[Address(RVA = "0x1286530", Offset = "0x1285730", Length = "0x17F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyBrief)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LobbyBrief))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B5")]
		internal void <UpdateLobby>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000034")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013E")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400013F")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000140")]
		public Action<Lobby> onResponse; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B6")]
		public <>c__DisplayClass8_0() { }

		[Address(RVA = "0x12866B0", Offset = "0x12858B0", Length = "0x1A0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lobby)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Lobby))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B7")]
		internal void <GetLobby>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000035")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000141")]
		public UnityWebRequest request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000142")]
		public Action<String> onError; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000143")]
		public Action onResponse; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B8")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x1286860", Offset = "0x1285A60", Length = "0xE8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LobbyApi), Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B9")]
		internal void <JoinLobby>b__0(AsyncOperation op) { }

	}

	[Token(Token = "0x2000027")]
	private struct CreateLobbyServiceRequest
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000115")]
		public string name; //Field offset: 0x0

	}

	[Token(Token = "0x2000028")]
	internal struct LobbyServiceResponse
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000116")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000117")]
		public string url; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000118")]
		public string status; //Field offset: 0x10

	}

	[FieldOffset(Offset = "0x10")]
	[Header("Lobby Config")]
	[Token(Token = "0x4000113")]
	public string LobbyUrl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000114")]
	public LobbyBrief[] Lobbies; //Field offset: 0x18

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018F")]
	public LobbyApi(string url) { }

	[Address(RVA = "0x127C1B0", Offset = "0x127B3B0", Length = "0x13A")]
	[CalledBy(Type = typeof(<>c__DisplayClass7_0), Member = "<UpdateLobby>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass9_0), Member = "<JoinLobby>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass8_0), Member = "<GetLobby>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass5_0), Member = "<RefreshLobbies>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass20_0), Member = "<DeployLobbyService>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass19_0), Member = "<TerminateLobbyService>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass6_0), Member = "<CreateLobby>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass17_0), Member = "<CreateLobbyService>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass12_0), Member = "<DeleteLobby>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass11_0), Member = "<StartLobby>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass10_0), Member = "<LeaveLobby>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass18_0), Member = "<GetLobbyService>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_responseCode", ReturnType = typeof(long))]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000191")]
	private static bool CheckErrorResponse(UnityWebRequest request, Action<String> onError) { }

	[Address(RVA = "0x127C2F0", Offset = "0x127B4F0", Length = "0x260")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LobbyApi), Member = "TrimApiKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600019B")]
	public static void CreateAndDeployLobbyService(string apiKey, string name, Action<LobbyServiceResponse> onResponse, Action<String> onError) { }

	[Address(RVA = "0x127C730", Offset = "0x127B930", Length = "0x1BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000193")]
	public void CreateLobby(LobbyCreateRequest createData, Action<Lobby> onResponse, Action<String> onError) { }

	[Address(RVA = "0x127C560", Offset = "0x127B760", Length = "0x1C5")]
	[CalledBy(Type = typeof(<>c__DisplayClass16_0), Member = "<CreateAndDeployLobbyService>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<Edgegap.LobbyApi+LobbyServiceResponse>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600019C")]
	private static void CreateLobbyService(string apiKey, string name, Action<LobbyServiceResponse> onResponse, Action<String> onError) { }

	[Address(RVA = "0x127C8F0", Offset = "0x127BAF0", Length = "0x1AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000199")]
	public void DeleteLobby(string lobbyId, Action onResponse, Action<String> onError) { }

	[Address(RVA = "0x127CAA0", Offset = "0x127BCA0", Length = "0x1A3")]
	[CalledBy(Type = typeof(<>c__DisplayClass16_0), Member = "<CreateAndDeployLobbyService>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<Edgegap.LobbyApi+LobbyServiceResponse>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass17_0), Member = "<CreateLobbyService>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600019F")]
	private static void DeployLobbyService(string apiKey, string name, Action<LobbyServiceResponse> onResponse, Action<String> onError) { }

	[Address(RVA = "0x127CDE0", Offset = "0x127BFE0", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000195")]
	public void GetLobby(string lobbyId, Action<Lobby> onResponse, Action<String> onError) { }

	[Address(RVA = "0x127CC50", Offset = "0x127BE50", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LobbyApi), Member = "TrimApiKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600019D")]
	public static void GetLobbyService(string apiKey, string name, Action<Nullable`1<LobbyServiceResponse>> onResponse, Action<String> onError) { }

	[Address(RVA = "0x127CF30", Offset = "0x127C130", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000196")]
	public void JoinLobby(LobbyJoinOrLeaveRequest data, Action onResponse, Action<String> onError) { }

	[Address(RVA = "0x127D0B0", Offset = "0x127C2B0", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000197")]
	public void LeaveLobby(LobbyJoinOrLeaveRequest data, Action onResponse, Action<String> onError) { }

	[Address(RVA = "0x127D230", Offset = "0x127C430", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000192")]
	public void RefreshLobbies(Action<LobbyBrief[]> onLoaded, Action<String> onError) { }

	[Address(RVA = "0x6FC3A0", Offset = "0x6FB5A0", Length = "0x1AB")]
	[CalledBy(Type = typeof(LobbyApi), Member = "DeployLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Action`1<Edgegap.LobbyApi+LobbyServiceResponse>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyApi), Member = "CreateLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Action`1<Edgegap.LobbyApi+LobbyServiceResponse>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyApi), Member = "StartLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyIdRequest), typeof(Action), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyApi), Member = "LeaveLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyJoinOrLeaveRequest), typeof(Action), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyApi), Member = "JoinLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyJoinOrLeaveRequest), typeof(Action), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyApi), Member = "UpdateLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LobbyUpdateRequest), typeof(System.Action`1<Edgegap.LobbyBrief>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyApi), Member = "TerminateLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Action`1<Edgegap.LobbyApi+LobbyServiceResponse>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdgegapLobbyKcpTransport), Member = "<ServerStart>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lobby)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdgegapLobbyKcpTransport), Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdgegapLobbyKcpTransport), Member = "ClientDisconnect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdgegapLobbyKcpTransport), Member = "ServerStart", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyApi), Member = "CreateLobby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyCreateRequest), typeof(System.Action`1<Edgegap.Lobby>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DownloadHandlerBuffer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000190")]
	private static UnityWebRequest SendJson(string url, T data, string method = "POST") { }

	[Address(RVA = "0x127D370", Offset = "0x127C570", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000198")]
	public void StartLobby(LobbyIdRequest data, Action onResponse, Action<String> onError) { }

	[Address(RVA = "0x127D4E0", Offset = "0x127C6E0", Length = "0x1A7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LobbyApi), Member = "TrimApiKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600019E")]
	public static void TerminateLobbyService(string apiKey, string name, Action<LobbyServiceResponse> onResponse, Action<String> onError) { }

	[Address(RVA = "0x127D690", Offset = "0x127C890", Length = "0x9B")]
	[CalledBy(Type = typeof(LobbyApi), Member = "CreateAndDeployLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Action`1<Edgegap.LobbyApi+LobbyServiceResponse>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyApi), Member = "GetLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Action`1<System.Nullable`1<Edgegap.LobbyApi+LobbyServiceResponse>>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyApi), Member = "TerminateLobbyService", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Action`1<Edgegap.LobbyApi+LobbyServiceResponse>), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019A")]
	public static void TrimApiKey(ref string apiKey) { }

	[Address(RVA = "0x127D730", Offset = "0x127C930", Length = "0x1AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000194")]
	public void UpdateLobby(string lobbyId, LobbyUpdateRequest updateData, Action<LobbyBrief> onResponse, Action<String> onError) { }

}

