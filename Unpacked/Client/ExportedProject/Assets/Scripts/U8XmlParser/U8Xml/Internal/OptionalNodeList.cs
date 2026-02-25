namespace U8Xml.Internal;

[IsReadOnly]
[Token(Token = "0x2000026")]
internal struct OptionalNodeList : IDisposable, IReference
{
	[Token(Token = "0x2000027")]
	private struct OptionalNodeList_
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000045")]
		public XmlDeclaration_ Declaration; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000046")]
		public XmlDocumentType_ DocumentType; //Field offset: 0x20

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000044")]
	private readonly IntPtr _list; //Field offset: 0x0

	[Token(Token = "0x1700002B")]
	public XmlDeclaration_* Declaration
	{
		[Address(RVA = "0x18084F0", Offset = "0x18076F0", Length = "0x1D")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700002C")]
	public XmlDocumentType_* DocumentType
	{
		[Address(RVA = "0x1808510", Offset = "0x1807710", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000C9")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700002A")]
	public override bool IsNull
	{
		[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C7")]
		 get { } //Length: 8
	}

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CA")]
	private OptionalNodeList(IntPtr list) { }

	[Address(RVA = "0x1808410", Offset = "0x1807610", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000CB")]
	public static OptionalNodeList Create() { }

	[Address(RVA = "0x1808480", Offset = "0x1807680", Length = "0x69")]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedBuffer&), typeof(int)}, ReturnType = typeof(XmlObjectCore))]
	[CalledBy(Type = typeof(XmlObjectCore), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000CC")]
	public override void Dispose() { }

	[Address(RVA = "0x18084F0", Offset = "0x18076F0", Length = "0x1D")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C8")]
	public XmlDeclaration_* get_Declaration() { }

	[Address(RVA = "0x1808510", Offset = "0x1807710", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000C9")]
	public XmlDocumentType_* get_DocumentType() { }

	[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C7")]
	public override bool get_IsNull() { }

}

