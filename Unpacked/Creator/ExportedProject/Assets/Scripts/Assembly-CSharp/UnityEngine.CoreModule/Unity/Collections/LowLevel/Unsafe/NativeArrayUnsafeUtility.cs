namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[Token(Token = "0x200005A")]
public static class NativeArrayUnsafeUtility
{

	[Address(RVA = "0x706580", Offset = "0x705780", Length = "0x21")]
	[CallerCount(Count = 77)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D1")]
	public static NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, Allocator allocator) { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60000D2")]
	public static Void* GetUnsafePtr(NativeArray<T> nativeArray) { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60000D3")]
	public static Void* GetUnsafeReadOnlyPtr(NativeArray<T> nativeArray) { }

}

