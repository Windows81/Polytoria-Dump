namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B7")]
public class PlayersProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001001")]
	private readonly Players players; //Field offset: 0x18

	[Token(Token = "0x17000C30")]
	public Player LocalPlayer
	{
		[Address(RVA = "0x4A8290", Offset = "0x4A7490", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002898")]
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Player), "player", False)]
	[Token(Token = "0x17000C2D")]
	public LuaEvent PlayerAdded
	{
		[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002894")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C2F")]
	public bool PlayerCollisionEnabled
	{
		[Address(RVA = "0x4A82B0", Offset = "0x4A74B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002896")]
		 get { } //Length: 30
		[Address(RVA = "0x4A82D0", Offset = "0x4A74D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Players), Member = "set_PlayerCollisionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002897")]
		 set { } //Length: 30
	}

	[LuaEventParameter(typeof(Player), "player", False)]
	[Token(Token = "0x17000C2E")]
	public LuaEvent PlayerRemoved
	{
		[Address(RVA = "0x4A4080", Offset = "0x4A3280", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002895")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002893")]
	public PlayersProxy(Players target) { }

	[Address(RVA = "0x4A8290", Offset = "0x4A7490", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002898")]
	public Player get_LocalPlayer() { }

	[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002894")]
	public LuaEvent get_PlayerAdded() { }

	[Address(RVA = "0x4A82B0", Offset = "0x4A74B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002896")]
	public bool get_PlayerCollisionEnabled() { }

	[Address(RVA = "0x4A4080", Offset = "0x4A3280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002895")]
	public LuaEvent get_PlayerRemoved() { }

	[Address(RVA = "0x4A8250", Offset = "0x4A7450", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Players), Member = "GetPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Player))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600289A")]
	public Player GetPlayer(string username) { }

	[Address(RVA = "0x4A8230", Offset = "0x4A7430", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Players), Member = "GetPlayerByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Player))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600289B")]
	public Player GetPlayerByID(int id) { }

	[Address(RVA = "0x4A8270", Offset = "0x4A7470", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Players), Member = "GetPlayers", ReturnType = typeof(Player[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002899")]
	public Player[] GetPlayers() { }

	[Address(RVA = "0x4A82D0", Offset = "0x4A74D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Players), Member = "set_PlayerCollisionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002897")]
	public void set_PlayerCollisionEnabled(bool value) { }

}

