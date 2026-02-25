namespace System.Runtime.Serialization;

[Token(Token = "0x20003E0")]
internal class TypeLoadExceptionHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F5B")]
	private string m_typeName; //Field offset: 0x10

	[Token(Token = "0x170003C2")]
	internal string TypeName
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D83")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D82")]
	internal TypeLoadExceptionHolder(string typeName) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D83")]
	internal string get_TypeName() { }

}

