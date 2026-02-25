namespace System.Runtime.Serialization;

[Token(Token = "0x20003DF")]
internal class ObjectHolderListEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F57")]
	private bool m_isFixupEnumerator; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F58")]
	private ObjectHolderList m_list; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F59")]
	private int m_startingVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000F5A")]
	private int m_currPos; //Field offset: 0x24

	[Token(Token = "0x170003C1")]
	internal ObjectHolder Current
	{
		[Address(RVA = "0x138ABC0", Offset = "0x1389DC0", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001D81")]
		internal get { } //Length: 52
	}

	[Address(RVA = "0x138AB60", Offset = "0x1389D60", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D7F")]
	internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator) { }

	[Address(RVA = "0x138ABC0", Offset = "0x1389DC0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001D81")]
	internal ObjectHolder get_Current() { }

	[Address(RVA = "0x138AAB0", Offset = "0x1389CB0", Length = "0xA8")]
	[CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D80")]
	internal bool MoveNext() { }

}

