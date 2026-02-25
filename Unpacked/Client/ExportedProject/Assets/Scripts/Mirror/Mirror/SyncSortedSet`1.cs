namespace Mirror;

[Token(Token = "0x2000087")]
public class SyncSortedSet : SyncSet<T>
{

	[Address(RVA = "0xC7DC80", Offset = "0xC7CE80", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046F")]
	public SyncSortedSet`1() { }

	[Address(RVA = "0xF6E1C0", Offset = "0xF6D3C0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000470")]
	public SyncSortedSet`1(IComparer<T> comparer) { }

	[Address(RVA = "0xF7C2C0", Offset = "0xF7B4C0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000471")]
	public Enumerator<T> GetEnumerator() { }

}

