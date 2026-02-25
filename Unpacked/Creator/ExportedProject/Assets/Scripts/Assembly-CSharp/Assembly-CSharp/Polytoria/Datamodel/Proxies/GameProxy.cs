namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003A2")]
public class GameProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FEC")]
	private readonly Game game; //Field offset: 0x18

	[Token(Token = "0x17000B8B")]
	public int GameID
	{
		[Address(RVA = "0x4A4000", Offset = "0x4A3200", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002727")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000B8D")]
	public int InstanceCount
	{
		[Address(RVA = "0x4A4020", Offset = "0x4A3220", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002729")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000B8E")]
	public int LocalInstanceCount
	{
		[Address(RVA = "0x4A4040", Offset = "0x4A3240", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600272A")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000B8C")]
	public int PlayersConnected
	{
		[Address(RVA = "0x4A4060", Offset = "0x4A3260", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002728")]
		 get { } //Length: 29
	}

	[LuaEventParameter(typeof(float), "deltaTime", False)]
	[Token(Token = "0x17000B8A")]
	public LuaEvent Rendered
	{
		[Address(RVA = "0x4A4080", Offset = "0x4A3280", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002726")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002725")]
	public GameProxy(Game target) { }

	[Address(RVA = "0x4A4000", Offset = "0x4A3200", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002727")]
	public int get_GameID() { }

	[Address(RVA = "0x4A4020", Offset = "0x4A3220", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002729")]
	public int get_InstanceCount() { }

	[Address(RVA = "0x4A4040", Offset = "0x4A3240", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600272A")]
	public int get_LocalInstanceCount() { }

	[Address(RVA = "0x4A4060", Offset = "0x4A3260", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002728")]
	public int get_PlayersConnected() { }

	[Address(RVA = "0x4A4080", Offset = "0x4A3280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002726")]
	public LuaEvent get_Rendered() { }

}

