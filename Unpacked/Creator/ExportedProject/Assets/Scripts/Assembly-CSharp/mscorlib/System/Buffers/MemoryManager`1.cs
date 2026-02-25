namespace System.Buffers;

[Token(Token = "0x200060F")]
public abstract class MemoryManager
{

	[Token(Token = "0x6002C53")]
	public abstract Span<T> GetSpan() { }

	[Token(Token = "0x6002C54")]
	public abstract MemoryHandle Pin(int elementIndex = 0) { }

	[Address(RVA = "0xE08820", Offset = "0xE07A20", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C55")]
	protected private override bool TryGetArray(out ArraySegment<T>& segment) { }

}

