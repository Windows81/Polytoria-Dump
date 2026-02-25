namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000081")]
internal static class SafeHandleCache
{
	[Token(Token = "0x400025F")]
	private static T s_invalidHandle; //Field offset: 0x0

	[Address(RVA = "0xF0D4C0", Offset = "0xF0C6C0", Length = "0x5E")]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600023C")]
	internal static bool IsCachedInvalidHandle(SafeHandle handle) { }

}

