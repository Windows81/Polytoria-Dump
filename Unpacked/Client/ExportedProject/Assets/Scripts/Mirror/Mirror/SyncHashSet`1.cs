namespace Mirror;

[Token(Token = "0x2000086")]
public class SyncHashSet : SyncSet<T>
{

	[Address(RVA = "0xC7DC80", Offset = "0xC7CE80", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046C")]
	public SyncHashSet`1() { }

	[Address(RVA = "0xF6E1C0", Offset = "0xF6D3C0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046D")]
	public SyncHashSet`1(IEqualityComparer<T> comparer) { }

	[Address(RVA = "0xF6E060", Offset = "0xF6D260", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046E")]
	public Enumerator<T> GetEnumerator() { }

}

