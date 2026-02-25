namespace MoonSharp.Interpreter.Execution.VM;

[Token(Token = "0x2000148")]
internal class CallStackItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004EF")]
	public int Debug_EntryPoint; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F0")]
	public SymbolRef[] Debug_Symbols; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004F1")]
	public SourceRef CallingSourceRef; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004F2")]
	public CallbackFunction ClrFunction; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004F3")]
	public CallbackFunction Continuation; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004F4")]
	public CallbackFunction ErrorHandler; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004F5")]
	public DynValue ErrorHandlerBeforeUnwind; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004F6")]
	public int BasePointer; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40004F7")]
	public int ReturnAddress; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004F8")]
	public DynValue[] LocalScope; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004F9")]
	public ClosureContext ClosureScope; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004FA")]
	public CallStackItemFlags Flags; //Field offset: 0x60

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2C")]
	public CallStackItem() { }

}

