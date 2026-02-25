namespace MoonSharp.Interpreter.DataStructs;

[Token(Token = "0x200016D")]
internal class ReferenceEqualityComparer : IEqualityComparer<Object>
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D76")]
	public ReferenceEqualityComparer() { }

	[Address(RVA = "0x388280", Offset = "0x387480", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D74")]
	private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	[Address(RVA = "0x388290", Offset = "0x387490", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D75")]
	private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

}

