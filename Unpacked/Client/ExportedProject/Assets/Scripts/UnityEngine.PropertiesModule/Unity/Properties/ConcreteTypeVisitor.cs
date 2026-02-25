namespace Unity.Properties;

[Token(Token = "0x2000048")]
public abstract class ConcreteTypeVisitor : IPropertyBagVisitor
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012D")]
	protected ConcreteTypeVisitor() { }

	[Address(RVA = "0x689D40", Offset = "0x688F40", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012C")]
	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	[Token(Token = "0x600012B")]
	protected abstract void VisitContainer(ref TContainer container) { }

}

