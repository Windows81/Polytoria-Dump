namespace U8Xml.Internal;

[Token(Token = "0x2000037")]
internal static class XXHash32
{
	[Token(Token = "0x400005E")]
	private static readonly uint _seed; //Field offset: 0x0

	[Address(RVA = "0x180BC30", Offset = "0x180AE30", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Token(Token = "0x600010D")]
	private static XXHash32() { }

	[Address(RVA = "0x180B4F0", Offset = "0x180A6F0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000108")]
	private static uint AccumBlockLane(uint hash, uint lane) { }

	[Address(RVA = "0x180B510", Offset = "0x180A710", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600010A")]
	private static uint AccumByte(uint hash, byte b) { }

	[Address(RVA = "0x180B530", Offset = "0x180A730", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000109")]
	private static uint AccumRemainingLane(uint hash, uint lane) { }

	[Address(RVA = "0x7D2F50", Offset = "0x7D2150", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XXHash32), Member = "ComputeHashShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000103")]
	public static int ComputeHash(in T data) { }

	[Address(RVA = "0x180BA60", Offset = "0x180AC60", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XXHash32), Member = "ComputeHashFull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(XXHash32), Member = "ComputeHashShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000104")]
	public static int ComputeHash(Byte* data, int byteLength) { }

	[Address(RVA = "0x180B550", Offset = "0x180A750", Length = "0x252")]
	[CalledBy(Type = typeof(Vector`1), Member = "ScalarEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XXHash32), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "DivRem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XXHash32), Member = "ComputeHashShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000106")]
	private static uint ComputeHashFull(Byte* data, int byteLength) { }

	[Address(RVA = "0x180B7B0", Offset = "0x180A9B0", Length = "0x2A2")]
	[CalledBy(Type = typeof(Vector`1), Member = "ScalarEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataLinePosition), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XXHash32), Member = "ComputeHash", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XXHash32), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XXHash32), Member = "ComputeHashFull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "DivRem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000105")]
	private static uint ComputeHashShort(Byte* data, int byteLength, uint acc) { }

	[Address(RVA = "0x180BB20", Offset = "0x180AD20", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000107")]
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	[Address(RVA = "0x149E560", Offset = "0x149D760", Length = "0x22")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010C")]
	private static uint MixFinal(uint hash) { }

	[Address(RVA = "0x180BBF0", Offset = "0x180ADF0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600010B")]
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

}

