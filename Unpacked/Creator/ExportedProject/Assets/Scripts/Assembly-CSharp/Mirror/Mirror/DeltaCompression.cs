namespace Mirror;

[Token(Token = "0x2000092")]
public static class DeltaCompression
{

	[Address(RVA = "0x1288E90", Offset = "0x1288090", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004A8")]
	public static void Compress(NetworkWriter writer, long last, long current) { }

	[Address(RVA = "0x1288E00", Offset = "0x1288000", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004AA")]
	public static void Compress(NetworkWriter writer, Vector3Long last, Vector3Long current) { }

	[Address(RVA = "0x1288D50", Offset = "0x1287F50", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004AB")]
	public static void Compress(NetworkWriter writer, Vector4Long last, Vector4Long current) { }

	[Address(RVA = "0x1288F80", Offset = "0x1288180", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x60004A9")]
	public static long Decompress(NetworkReader reader, long last) { }

	[Address(RVA = "0x1288FB0", Offset = "0x12881B0", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x60004AC")]
	public static Vector3Long Decompress(NetworkReader reader, Vector3Long last) { }

	[Address(RVA = "0x1288EB0", Offset = "0x12880B0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x60004AD")]
	public static Vector4Long Decompress(NetworkReader reader, Vector4Long last) { }

}

