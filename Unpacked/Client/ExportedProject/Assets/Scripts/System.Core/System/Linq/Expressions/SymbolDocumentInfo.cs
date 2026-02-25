namespace System.Linq.Expressions;

[Token(Token = "0x20000AD")]
public class SymbolDocumentInfo
{
	[Token(Token = "0x4000175")]
	internal static readonly Guid DocumentType_Text; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000174")]
	private readonly string <FileName>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000F7")]
	public string FileName
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15AA3F0", Offset = "0x15A95F0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(short), typeof(short), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Token(Token = "0x600047D")]
	private static SymbolDocumentInfo() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047C")]
	public string get_FileName() { }

}

