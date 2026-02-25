namespace Mirror;

[Extension]
[Token(Token = "0x2000075")]
public static class SortedListExtensions
{

	[Address(RVA = "0x75C680", Offset = "0x75B880", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(SortedList`2), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60003EC")]
	public static void RemoveRange(SortedList<T, U> list, int amount) { }

}

