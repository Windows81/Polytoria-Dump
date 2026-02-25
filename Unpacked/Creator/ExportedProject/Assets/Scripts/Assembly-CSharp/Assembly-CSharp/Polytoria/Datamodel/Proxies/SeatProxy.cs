namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003BC")]
public class SeatProxy : PartProxy
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001006")]
	private readonly Seat seat; //Field offset: 0x28

	[Token(Token = "0x17000C3C")]
	public Player Occupant
	{
		[Address(RVA = "0x4AC800", Offset = "0x4ABA00", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60028BD")]
		 get { } //Length: 29
	}

	[LuaEventParameter(typeof(Player), "occupant", False)]
	[Token(Token = "0x17000C3D")]
	public LuaEvent Sat
	{
		[Address(RVA = "0x4AC820", Offset = "0x4ABA20", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028BE")]
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Player), "occupant", False)]
	[Token(Token = "0x17000C3E")]
	public LuaEvent Vacated
	{
		[Address(RVA = "0x4AC840", Offset = "0x4ABA40", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028BF")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x4A17F0", Offset = "0x4A09F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028BC")]
	public SeatProxy(Seat target) { }

	[Address(RVA = "0x4AC800", Offset = "0x4ABA00", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028BD")]
	public Player get_Occupant() { }

	[Address(RVA = "0x4AC820", Offset = "0x4ABA20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028BE")]
	public LuaEvent get_Sat() { }

	[Address(RVA = "0x4AC840", Offset = "0x4ABA40", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028BF")]
	public LuaEvent get_Vacated() { }

}

