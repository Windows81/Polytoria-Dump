namespace Edgegap;

[Token(Token = "0x200003F")]
public struct LobbyIdRequest
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016A")]
	public string lobby_id; //Field offset: 0x0

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BC")]
	public LobbyIdRequest(string lobbyId) { }

}

