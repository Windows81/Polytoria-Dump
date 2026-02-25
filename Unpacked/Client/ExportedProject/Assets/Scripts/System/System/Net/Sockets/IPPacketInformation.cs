namespace System.Net.Sockets;

[Token(Token = "0x20002EE")]
public struct IPPacketInformation
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D2B")]
	private IPAddress address; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D2C")]
	private int networkInterface; //Field offset: 0x8

	[Address(RVA = "0x1718B50", Offset = "0x1717D50", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001332")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x1718C10", Offset = "0x1717E10", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001333")]
	public virtual int GetHashCode() { }

}

