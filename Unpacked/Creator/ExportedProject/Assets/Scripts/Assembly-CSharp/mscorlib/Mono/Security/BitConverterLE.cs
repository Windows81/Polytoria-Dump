namespace Mono.Security;

[Token(Token = "0x200005F")]
internal sealed class BitConverterLE
{

	[Address(RVA = "0x12D7350", Offset = "0x12D6550", Length = "0x8A")]
	[CalledBy(Type = typeof(BinaryWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000126")]
	internal static Byte[] GetBytes(float value) { }

	[Address(RVA = "0x12D73E0", Offset = "0x12D65E0", Length = "0xC2")]
	[CalledBy(Type = typeof(BinaryWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000127")]
	internal static Byte[] GetBytes(double value) { }

	[Address(RVA = "0x12D74B0", Offset = "0x12D66B0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000124")]
	private static Byte[] GetUIntBytes(Byte* bytes) { }

	[Address(RVA = "0x12D7530", Offset = "0x12D6730", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000125")]
	private static Byte[] GetULongBytes(Byte* bytes) { }

	[Address(RVA = "0x12D75F0", Offset = "0x12D67F0", Length = "0x51")]
	[CalledBy(Type = typeof(BinaryReader), Member = "ReadDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600012B")]
	internal static double ToDouble(Byte[] value, int startIndex) { }

	[Address(RVA = "0x12D7650", Offset = "0x12D6850", Length = "0x70")]
	[CalledBy(Type = typeof(BinaryReader), Member = "ReadSingle", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600012A")]
	internal static float ToSingle(Byte[] value, int startIndex) { }

	[Address(RVA = "0x12A9CF0", Offset = "0x12A8EF0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000128")]
	private static void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	[Address(RVA = "0x12D76D0", Offset = "0x12D68D0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000129")]
	private static void ULongFromBytes(Byte* dst, Byte[] src, int startIndex) { }

}

