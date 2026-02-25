namespace System.Buffers;

[Token(Token = "0x2000614")]
internal static class Utilities
{

	[Address(RVA = "0x144F530", Offset = "0x144E730", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002C69")]
	internal static int GetMaxSizeForBucket(int binIndex) { }

	[Address(RVA = "0xFEA1C0", Offset = "0xFE93C0", Length = "0x71")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Rent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6002C68")]
	internal static int SelectBucketIndex(int bufferSize) { }

}

