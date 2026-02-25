namespace UnityEngine;

[Token(Token = "0x2000159")]
internal class ScriptingUtility
{
	[Token(Token = "0x200015A")]
	private struct TestClass
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000579")]
		public int value; //Field offset: 0x0

	}


	[Address(RVA = "0x8D41C0", Offset = "0x8D33C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x60009F0")]
	private static bool IsManagedCodeWorking() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x60009F1")]
	private static void SetupCallbacks(IntPtr p) { }

}

