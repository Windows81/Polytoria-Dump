namespace System.Resources;

[Token(Token = "0x20004AD")]
internal class FileBasedResourceGroveler : IResourceGroveler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012B6")]
	private ResourceManagerMediator _mediator; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020FB")]
	public FileBasedResourceGroveler(ResourceManagerMediator mediator) { }

}

