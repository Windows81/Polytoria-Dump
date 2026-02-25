namespace System.Threading.Tasks;

[Extension]
[Token(Token = "0x2000255")]
internal static class TaskAwaiters
{

	[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600134C")]
	public static ForceAsyncAwaiter ForceAsync(Task task) { }

}

